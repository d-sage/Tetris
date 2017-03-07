﻿namespace Tetris {
    partial class mainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.mstripTop = new System.Windows.Forms.MenuStrip();
            this.mstripFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mstripNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mstripSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mstripOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mstripExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mstripGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mstripGo = new System.Windows.Forms.ToolStripMenuItem();
            this.mstripPause = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mstripTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstripTop
            // 
            this.mstripTop.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mstripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstripFile,
            this.mstripGame});
            this.mstripTop.Location = new System.Drawing.Point(0, 0);
            this.mstripTop.Name = "mstripTop";
            this.mstripTop.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mstripTop.Size = new System.Drawing.Size(697, 28);
            this.mstripTop.TabIndex = 1;
            this.mstripTop.Text = "menuStrip1";
            // 
            // mstripFile
            // 
            this.mstripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstripNew,
            this.mstripSave,
            this.mstripOpen,
            this.mstripExit});
            this.mstripFile.Name = "mstripFile";
            this.mstripFile.Size = new System.Drawing.Size(44, 24);
            this.mstripFile.Text = "&File";
            // 
            // mstripNew
            // 
            this.mstripNew.Name = "mstripNew";
            this.mstripNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mstripNew.Size = new System.Drawing.Size(173, 26);
            this.mstripNew.Text = "&New";
            this.mstripNew.Click += new System.EventHandler(this.mstripNew_Click);
            // 
            // mstripSave
            // 
            this.mstripSave.Name = "mstripSave";
            this.mstripSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mstripSave.Size = new System.Drawing.Size(173, 26);
            this.mstripSave.Text = "&Save";
            this.mstripSave.Click += new System.EventHandler(this.mstripSave_Click);
            // 
            // mstripOpen
            // 
            this.mstripOpen.Name = "mstripOpen";
            this.mstripOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mstripOpen.Size = new System.Drawing.Size(173, 26);
            this.mstripOpen.Text = "&Open";
            this.mstripOpen.Click += new System.EventHandler(this.mstripLoad_Click);
            // 
            // mstripExit
            // 
            this.mstripExit.Name = "mstripExit";
            this.mstripExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mstripExit.Size = new System.Drawing.Size(173, 26);
            this.mstripExit.Text = "E&xit";
            this.mstripExit.Click += new System.EventHandler(this.mstripExit_Click);
            // 
            // mstripGame
            // 
            this.mstripGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstripGo,
            this.mstripPause});
            this.mstripGame.Name = "mstripGame";
            this.mstripGame.Size = new System.Drawing.Size(60, 24);
            this.mstripGame.Text = "Ga&me";
            // 
            // mstripGo
            // 
            this.mstripGo.Name = "mstripGo";
            this.mstripGo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.mstripGo.Size = new System.Drawing.Size(172, 26);
            this.mstripGo.Text = "&Go";
            this.mstripGo.Click += new System.EventHandler(this.mstripGo_Click);
            // 
            // mstripPause
            // 
            this.mstripPause.Name = "mstripPause";
            this.mstripPause.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.mstripPause.Size = new System.Drawing.Size(172, 26);
            this.mstripPause.Text = "&Pause";
            this.mstripPause.Click += new System.EventHandler(this.mstripPause_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Title = "Save Tetris Game";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Title = "Load Tetris Game";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 473);
            this.Controls.Add(this.mstripTop);
            this.Font = new System.Drawing.Font("Forte", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mstripTop;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "mainForm";
            this.Text = "Tetris";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mainForm_KeyUp);
            this.mstripTop.ResumeLayout(false);
            this.mstripTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mstripTop;
        private System.Windows.Forms.ToolStripMenuItem mstripFile;
        private System.Windows.Forms.ToolStripMenuItem mstripNew;
        private System.Windows.Forms.ToolStripMenuItem mstripGame;
        private System.Windows.Forms.ToolStripMenuItem mstripGo;
        private System.Windows.Forms.ToolStripMenuItem mstripPause;
        private System.Windows.Forms.ToolStripMenuItem mstripSave;
        private System.Windows.Forms.ToolStripMenuItem mstripOpen;
        private System.Windows.Forms.ToolStripMenuItem mstripExit;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

