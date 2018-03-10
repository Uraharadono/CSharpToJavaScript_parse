﻿namespace CsFilesUploadRuntimeConverter
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SelectFileButton = new System.Windows.Forms.Button();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.codeTextEditor = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // SelectFileButton
            // 
            this.SelectFileButton.Location = new System.Drawing.Point(28, 30);
            this.SelectFileButton.Name = "SelectFileButton";
            this.SelectFileButton.Size = new System.Drawing.Size(100, 36);
            this.SelectFileButton.TabIndex = 0;
            this.SelectFileButton.Text = "Select File";
            this.SelectFileButton.UseVisualStyleBackColor = true;
            this.SelectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(25, 69);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(0, 17);
            this.fileNameLabel.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(28, 115);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(181, 39);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // codeTextEditor
            // 
            this.codeTextEditor.Dock = System.Windows.Forms.DockStyle.Right;
            this.codeTextEditor.Location = new System.Drawing.Point(385, 0);
            this.codeTextEditor.Name = "codeTextEditor";
            this.codeTextEditor.Size = new System.Drawing.Size(693, 472);
            this.codeTextEditor.TabIndex = 3;
            this.codeTextEditor.Text = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 472);
            this.Controls.Add(this.codeTextEditor);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.SelectFileButton);
            this.Name = "Main";
            this.Text = "C# class runtime generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SelectFileButton;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.RichTextBox codeTextEditor;
    }
}

