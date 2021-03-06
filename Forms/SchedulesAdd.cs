﻿using CopyBackupToolUI.Forms;
using CopyBackupToolUI.Helpers;
using CopyBackupToolUI.Models;
using System;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CopyBackupToolUI
{
    public partial class SchedulesAdd : Form
    {
        FileModel _config = new FileModel();
        public SchedulesAdd()
        {
            InitializeComponent();
        }
        public SchedulesAdd(FileModel config)
        {
            InitializeComponent();
            _config = config;
        }
        private void Schedules_Load(object sender, EventArgs e)
        {
            try
            {
                if (_config.Title == null)
                {
                    return;
                }
                // Load by DataGrid
                this.textBoxTitle.Text = _config.Title;
                this.checkBoxStatus.Checked = _config.Status;

                this.checkBoxCopyPasteStatus.Checked = _config.CopyAndPaste.Status;
                this.checkBoxCopyPasteOverwrite.Checked = _config.CopyAndPaste.Overwrite;
                this.textBoxCopyPasteSourcePath.Text = _config.CopyAndPaste.SourcePath;
                this.textBoxCopyPasteDestinationPath.Text = _config.CopyAndPaste.DestinationPath;
                this.textBoxCopyPasteIgnoreFiles.Text = GlobalHelpers.ConvertStringArrayToString(_config.CopyAndPaste.Ignore.Files);
                this.textBoxCopyPasteIgnoreFolders.Text = GlobalHelpers.ConvertStringArrayToString(_config.CopyAndPaste.Ignore.Folders);

                this.checkBoxCompressStatus.Checked = _config.CompressFolder.Status;
                this.textBoxCompressTitle.Text = _config.CompressFolder.ZipFileName;
                this.textBoxCompressSourcePath.Text = _config.CompressFolder.SourcePath;
                this.textBoxCompressDestinationPath.Text = _config.CompressFolder.MoveToPath;
                this.textBoxCompressIgnoreFiles.Text = GlobalHelpers.ConvertStringArrayToString(_config.CompressFolder.Ignore.Files);
                this.textBoxCompressIgnoreFolders.Text = GlobalHelpers.ConvertStringArrayToString(_config.CompressFolder.Ignore.Folders);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public string GetFolderPath()
        {
            var _resultMSG = "";
            using (var dialog = new FolderBrowserDialog())
            {
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                    _resultMSG = dialog.SelectedPath;
            }
            return _resultMSG;
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            this.textBoxTitle.Text = string.Empty;
            this.checkBoxStatus.Checked = false;

            this.checkBoxCopyPasteStatus.Checked = false;
            this.checkBoxCopyPasteOverwrite.Checked = false;
            this.textBoxCopyPasteSourcePath.Text = string.Empty;
            this.textBoxCopyPasteDestinationPath.Text = string.Empty;
            this.textBoxCopyPasteIgnoreFiles.Text = string.Empty;
            this.textBoxCopyPasteIgnoreFolders.Text = string.Empty;

            this.checkBoxCompressStatus.Checked = false;
            this.textBoxCompressTitle.Text = string.Empty;
            this.textBoxCompressSourcePath.Text = string.Empty;
            this.textBoxCompressDestinationPath.Text = string.Empty;
            this.textBoxCompressIgnoreFiles.Text = string.Empty;
            this.textBoxCompressIgnoreFolders.Text = string.Empty;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            Console.Beep();

            // Validate fields
            ValidateTextRequiredField(errorProvider, textBoxTitle);
            if (this.checkBoxCopyPasteStatus.Checked == true)
            {
                ValidateFolderField(errorProvider, textBoxCopyPasteSourcePath);
                ValidateFolderField(errorProvider, textBoxCopyPasteDestinationPath);
            }
            if (this.checkBoxCompressStatus.Checked == true)
            {
                ValidateTextRequiredField(errorProvider, textBoxCompressTitle);
                ValidateFolderField(errorProvider, textBoxCompressSourcePath);
                ValidateFolderField(errorProvider, textBoxCompressDestinationPath);
            }

            // Check if any field has an error message.
            foreach (Control ctrl in Controls)
            {
                if (errorProvider.GetError(ctrl) != "")
                {
                    //MessageBox.Show(errorProvider.GetError(ctrl));
                    return;
                }
            }

            // Get Data
            var _id = _config.Id;
            var _title = this.textBoxTitle.Text;
            var _status = this.checkBoxStatus.Checked;

            var _copyPasteStatus = this.checkBoxCopyPasteStatus.Checked;
            var _copyPasteOverwrite = this.checkBoxCopyPasteOverwrite.Checked;
            var _copyPasteSource = this.textBoxCopyPasteSourcePath.Text;
            var _copyPasteDestination = this.textBoxCopyPasteDestinationPath.Text;
            string[] _copyPasteIgnoreFiles = this.textBoxCopyPasteIgnoreFiles.Text.Split(',').ToArray();
            string[] _copyPasteIgnoreFolders = this.textBoxCopyPasteIgnoreFolders.Text.Split(',').ToArray();

            var _compressStatus = this.checkBoxCompressStatus.Checked;
            var _compressTitle = this.textBoxCompressTitle.Text;
            var _compressSource = this.textBoxCompressSourcePath.Text;
            var _compressDestination = this.textBoxCompressDestinationPath.Text;
            string[] _compressIgnoreFiles = this.textBoxCompressIgnoreFiles.Text.Split(',').ToArray();
            string[] _compressIgnoreFolders = this.textBoxCompressIgnoreFolders.Text.Split(',').ToArray();

            // Create Models
            FileModel _myFileModel = new FileModel
            {
                Id = _id,
                Title = _title.ToString(),
                Status = _status,
                CopyAndPaste = new CopyAndPaste
                {
                    Status = _copyPasteStatus,
                    Overwrite = _copyPasteOverwrite,
                    SourcePath = _copyPasteSource,
                    DestinationPath = _copyPasteDestination,
                    Ignore = new Ignore
                    {
                        Files = _copyPasteIgnoreFiles,
                        Folders = _copyPasteIgnoreFolders
                    }
                },
                CompressFolder = new CompressFolder
                {
                    Status = _compressStatus,
                    ZipFileName = _compressTitle,
                    SourcePath = _compressSource,
                    MoveToPath = _compressDestination,
                    Ignore = new Ignore
                    {
                        Files = _compressIgnoreFiles,
                        Folders = _compressIgnoreFolders
                    }
                }
            };
            ConfigFileHelper.SaveOrUpdate(_myFileModel);

            // Update View
            ConfigFileHelper.Load(false);
            Schedules.dataGridViewSchedulesConfigs.DataSource = ConfigFileHelper.JsonFileConfigs;

            // Close
            this.Close();
        }

        #region SchedulesAdd - Form Validation
        private bool ValidateTextRequiredField(ErrorProvider error, TextBox tBox)
        {
            if (tBox.Text.Length > 0)
            {
                error.SetError(tBox, "");
                return false;
            }
            else
            {
                error.SetError(tBox, "This field must not be blank.");
                return true;
            }
        }
        private void ValidateFolderField(ErrorProvider error, TextBox tBox)
        {
            if (ValidateTextRequiredField(error, tBox)) return;
            Regex _regex = new Regex(@"^(?:[A-Za-z]\:|\\\.\.|\.\.|\\)(\\|\\[a-zA-Z_\-\s0-9\.]+)+(\.\w+)?$");
            if (_regex.IsMatch(tBox.Text))
                errorProvider.SetError(tBox, "");
            else
                errorProvider.SetError(tBox, "This fields must have a folder path.");
        }

        private void RequiredTextField_Validating(object sender, CancelEventArgs e)
        {
            TextBox tBox = sender as TextBox;
            ValidateTextRequiredField(errorProvider, tBox);
        }
        private void RequiredFolderField_Validating(object sender, CancelEventArgs e)
        {
            TextBox tBox = sender as TextBox;
            ValidateFolderField(errorProvider, tBox);
        }
        #endregion

        private void textBoxCopyPaste_SourcePath_Click(object sender, EventArgs e){   this.textBoxCopyPasteSourcePath.Text = GetFolderPath();    }
        private void textBoxCopyPaste_DestinationPath_Click(object sender, EventArgs e){   this.textBoxCopyPasteDestinationPath.Text = GetFolderPath();    }
        private void textBoxCompressSourcePath_Click(object sender, EventArgs e){    this.textBoxCompressSourcePath.Text = GetFolderPath();  }
        private void textBoxCompressDestinationPath_Click(object sender, EventArgs e){  this.textBoxCompressDestinationPath.Text = GetFolderPath(); }

        public void MinimizeFormEscape(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                this.Hide();
        }
    }
}
