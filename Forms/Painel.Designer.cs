﻿using System.Windows.Forms;

namespace CopyBackupToolUI
{
    partial class Painel
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Painel));
            this.trayMenuContextStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonSchedules = new System.Windows.Forms.Button();
            this.buttonSaveConsole = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonConfigs = new System.Windows.Forms.Button();
            this.buttonRun = new System.Windows.Forms.Button();
            progressBarPercentLabel = new System.Windows.Forms.Label();
            progressBar = new System.Windows.Forms.ProgressBar();
            consoleTextBox = new System.Windows.Forms.TextBox();
            this.trayMenuContextStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trayMenuContextStrip
            // 
            this.trayMenuContextStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem});
            this.trayMenuContextStrip.Name = "trayMenuContextStrip";
            this.trayMenuContextStrip.Size = new System.Drawing.Size(61, 10);
            this.trayMenuContextStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Tray_Options_ItemClicked);
            // 
            // toolStripMenuItem
            // 
            this.toolStripMenuItem.Name = "toolStripMenuItem";
            this.toolStripMenuItem.Size = new System.Drawing.Size(57, 6);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.trayMenuContextStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "CopyBackup Tool";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.NotifyIcon_DoubleClick);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonSchedules);
            this.splitContainer1.Panel1.Controls.Add(this.buttonSaveConsole);
            this.splitContainer1.Panel1.Controls.Add(this.buttonClear);
            this.splitContainer1.Panel1.Controls.Add(this.buttonConfigs);
            this.splitContainer1.Panel1.Controls.Add(this.buttonRun);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(progressBarPercentLabel);
            this.splitContainer1.Panel2.Controls.Add(progressBar);
            this.splitContainer1.Panel2.Controls.Add(consoleTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(823, 340);
            this.splitContainer1.SplitterDistance = 127;
            this.splitContainer1.TabIndex = 1;
            this.splitContainer1.TabStop = false;
            // 
            // buttonSchedules
            // 
            this.buttonSchedules.Image = ((System.Drawing.Image)(resources.GetObject("buttonSchedules.Image")));
            this.buttonSchedules.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSchedules.Location = new System.Drawing.Point(6, 73);
            this.buttonSchedules.Name = "buttonSchedules";
            this.buttonSchedules.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.buttonSchedules.Size = new System.Drawing.Size(114, 60);
            this.buttonSchedules.TabIndex = 1;
            this.buttonSchedules.Text = "Schedules";
            this.buttonSchedules.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSchedules.UseVisualStyleBackColor = true;
            this.buttonSchedules.Click += new System.EventHandler(this.Schedules_Click);
            // 
            // buttonSaveConsole
            // 
            this.buttonSaveConsole.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveConsole.Image")));
            this.buttonSaveConsole.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSaveConsole.Location = new System.Drawing.Point(6, 205);
            this.buttonSaveConsole.Name = "buttonSaveConsole";
            this.buttonSaveConsole.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.buttonSaveConsole.Size = new System.Drawing.Size(114, 60);
            this.buttonSaveConsole.TabIndex = 3;
            this.buttonSaveConsole.Text = "Save Log";
            this.buttonSaveConsole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSaveConsole.UseVisualStyleBackColor = true;
            this.buttonSaveConsole.Click += new System.EventHandler(this.ConsoleSave_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Image = ((System.Drawing.Image)(resources.GetObject("buttonClear.Image")));
            this.buttonClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClear.Location = new System.Drawing.Point(6, 271);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Padding = new System.Windows.Forms.Padding(5, 0, 25, 0);
            this.buttonClear.Size = new System.Drawing.Size(114, 60);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Clear";
            this.buttonClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // buttonConfigs
            // 
            this.buttonConfigs.Image = ((System.Drawing.Image)(resources.GetObject("buttonConfigs.Image")));
            this.buttonConfigs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConfigs.Location = new System.Drawing.Point(6, 139);
            this.buttonConfigs.Name = "buttonConfigs";
            this.buttonConfigs.Padding = new System.Windows.Forms.Padding(5, 0, 15, 0);
            this.buttonConfigs.Size = new System.Drawing.Size(114, 60);
            this.buttonConfigs.TabIndex = 2;
            this.buttonConfigs.Text = "Configs";
            this.buttonConfigs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonConfigs.UseVisualStyleBackColor = true;
            this.buttonConfigs.Click += new System.EventHandler(this.Configs_Click);
            // 
            // buttonRun
            // 
            this.buttonRun.Image = ((System.Drawing.Image)(resources.GetObject("buttonRun.Image")));
            this.buttonRun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRun.Location = new System.Drawing.Point(7, 7);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Padding = new System.Windows.Forms.Padding(5, 0, 25, 0);
            this.buttonRun.Size = new System.Drawing.Size(114, 60);
            this.buttonRun.TabIndex = 0;
            this.buttonRun.Text = "Run";
            this.buttonRun.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.Run_Click);
            // 
            // progressBarPercentLabel
            // 
            progressBarPercentLabel.AutoSize = true;
            progressBarPercentLabel.BackColor = System.Drawing.Color.Transparent;
            progressBarPercentLabel.Location = new System.Drawing.Point(325, 313);
            progressBarPercentLabel.Name = "progressBarPercentLabel";
            progressBarPercentLabel.Size = new System.Drawing.Size(21, 13);
            progressBarPercentLabel.TabIndex = 0;
            progressBarPercentLabel.Text = "0%";
            // 
            // progressBar
            // 
            progressBar.Location = new System.Drawing.Point(10, 308);
            progressBar.Name = "progressBar";
            progressBar.Size = new System.Drawing.Size(670, 23);
            progressBar.TabIndex = 1;
            // 
            // consoleTextBox
            // 
            consoleTextBox.Font = new System.Drawing.Font("Arial", 8F);
            consoleTextBox.Location = new System.Drawing.Point(10, 7);
            consoleTextBox.MaxLength = 230;
            consoleTextBox.Multiline = true;
            consoleTextBox.Name = "consoleTextBox";
            consoleTextBox.ReadOnly = true;
            consoleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            consoleTextBox.Size = new System.Drawing.Size(670, 295);
            consoleTextBox.TabIndex = 2;
            consoleTextBox.TabStop = false;
            // 
            // Painel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 340);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(839, 313);
            this.Name = "Painel";
            this.Text = "CopyBackup Tool - GUI";
            this.Load += new System.EventHandler(this.Form_Load_Tray);
            this.Resize += new System.EventHandler(this.Form_Resize);
            this.trayMenuContextStrip.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

            // KeyDown event - Minimize on press "Esc" or Escape
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(MinimizeFormEscape);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button buttonConfigs;
        private Button buttonRun;

        private ContextMenuStrip trayMenuContextStrip;
        private ToolStripSeparator toolStripMenuItem;
        private Timer timer;
        private Button buttonClear;
        private Button buttonSaveConsole;
        private Button buttonSchedules;
        public static TextBox consoleTextBox;
        private NotifyIcon notifyIcon;
        public static ProgressBar progressBar;
        public static Label progressBarPercentLabel;
    }
}

