using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReOrganize
{
    public partial class ReOrganizeWindow : Form
    {
        private FolderBrowserDialog folderBrowserDialog;
        private static Regex r = new Regex(":");
        CancellationTokenSource cts;

        public ReOrganizeWindow()
        {
            InitializeComponent();
        }

        private void selectInputLocationBtn_Click(object sender, EventArgs e)
        {
            folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                inputLocationTxt.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void selectOutputLocationBtn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                outputLocationTxt.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private async void startBtn_Click(object sender, EventArgs e)
        {
            cts = new CancellationTokenSource();
            CancellationToken ct = cts.Token;
            WarningLabel.Text = "";
            stopBtn.Enabled = true;
            startBtn.Enabled = false;
            optionsGroupBox.Enabled = false;
            string inputPath = inputLocationTxt.Text;
            string outputPath = outputLocationTxt.Text;

            if (!string.IsNullOrEmpty(inputPath) && !string.IsNullOrEmpty(outputPath))
            {
                if (inputPath != outputPath)
                {
                    try
                    {
                        int fileCount = Directory.GetFiles(inputPath, "*", SearchOption.AllDirectories).Length;
                        mainProgressBar.Minimum = 0;
                        mainProgressBar.Maximum = fileCount;
                        mainProgressBar.Step = 1;

                        string[] fileTypes = { ".jpg", ".jpeg", ".png", ".bmp", ".cr2", ".arw", ".mov", ".mp4", ".mkv" };
                        bool ignoreCase = true;
                        CultureInfo culture = new CultureInfo("en-US");
                        var files = Directory.EnumerateFiles(inputPath, "*.*", SearchOption.AllDirectories).Where(s => fileTypes.Any(x => s.EndsWith(x, ignoreCase, culture)));
                        foreach (string currentFile in files)
                        {
                            if (ct.IsCancellationRequested) throw new TaskCanceledException();
                            currentFileLabel.Text = currentFile.ToString();
                            currentFileLabel.Update();

                            DateTime currentFileDateTime = GetDateTakenFromImage(currentFile);
                            string yearString = currentFileDateTime.ToString("yyyy");
                            string monthString = currentFileDateTime.ToString("MMMM");
                            string newOutputPath = outputPath;

                            if (yearCheckBox.Checked) newOutputPath += "\\" + yearString;
                            if (monthCheckBox.Checked) newOutputPath += "\\" + monthString;
                            if (monthYearCheckBox.Checked) newOutputPath += "\\" + monthString + " " + yearString;

                            Directory.CreateDirectory(newOutputPath);
                            try
                            {
                                await Task.Run(() =>
                                    File.Copy(currentFile, Path.Combine(newOutputPath, currentFileDateTime.ToString("yyyy_MM_dd HH_mm_ss") + Path.GetExtension(currentFile))), cts.Token);
                            }
                            catch (Exception copyException)
                            {
                                if (copyException.InnerException is IOException)
                                {
                                    try
                                    {
                                        await Task.Run(() => File.Copy(currentFile, Path.Combine(newOutputPath, MakeUnique(currentFileDateTime.ToString("yyyy_MM_dd HH_mm_ss") + Path.GetExtension(currentFile)).FullName)), cts.Token);
                                    }
                                    catch (Exception exception)
                                    {
                                        Console.WriteLine(exception.Message);
                                    }
                                }
                            }

                            progressLabel.Text = "File " + mainProgressBar.Value.ToString() + " of " + mainProgressBar.Maximum.ToString();
                            progressLabel.Update();
                            mainProgressBar.Value++;
                        }
                        mainProgressBar.Value = mainProgressBar.Maximum;
                    }
                    catch (DirectoryNotFoundException dirEx)
                    {
                        WarningLabel.Text = "Invalid Input/Output locations provided!";
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception.Message);
                    }
                }
                else
                {
                    WarningLabel.Text = "Input and Output locations cannot be the same!";
                }
            }
            else
            {
                WarningLabel.Text = "Input/Output locations are not valid!";
            }

            currentFileLabel.Text = "";
            progressLabel.Text = "";
            mainProgressBar.Value = mainProgressBar.Minimum;
            stopBtn.Enabled = false;
            startBtn.Enabled = true;
            optionsGroupBox.Enabled = true;
            cts.Dispose();
        }

        public static DateTime GetDateTakenFromImage(string path)
        {
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                using (Image myImage = Image.FromStream(fs, false, false))
                {
                    PropertyItem propItem = myImage.GetPropertyItem(36867); // Date Taken
                    string dateTaken = r.Replace(Encoding.UTF8.GetString(propItem.Value), "-", 2);
                    return DateTime.Parse(dateTaken);
                }
            }
            catch
            {
                DateTime creationTime = File.GetCreationTime(path);
                DateTime lastWriteTime = File.GetLastWriteTime(path);
                int result = DateTime.Compare(creationTime, lastWriteTime);
                if (result < 0) { return creationTime; } else return lastWriteTime;
            }
        }

        public FileInfo MakeUnique(string path)
        {
            string dir = Path.GetDirectoryName(path);
            string fileName = Path.GetFileNameWithoutExtension(path);
            string fileExt = Path.GetExtension(path);

            for (int i = 1; ; ++i)
            {
                if (!File.Exists(path))
                    return new FileInfo(path);

                path = Path.Combine(dir, fileName + " " + i + fileExt);
            }
        }

        private void yearCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!yearCheckBox.Checked)
            {
                monthCheckBox.Enabled = false;
                monthCheckBox.Checked = false;
                monthYearCheckBox.Checked = true;
            }
            else
            {
                monthCheckBox.Enabled = true;
            }
        }

        private void monthCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (monthCheckBox.Checked)
            {
                monthYearCheckBox.Checked = false;
            }
        }

        private void monthYearCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (monthYearCheckBox.Checked)
            {
                monthCheckBox.Checked = false;
            }
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            if (cts != null) cts.Cancel();
            stopBtn.Enabled = false;
            progressLabel.Text = "Cancelling process, please wait...";
            progressLabel.Update();
        }
    }
}
