﻿namespace WindowsSystemDiffTool
{
    partial class Form1
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkListScans = new System.Windows.Forms.CheckedListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnStartScan = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCompare = new System.Windows.Forms.Button();
            this.lblAfterCompare = new System.Windows.Forms.Label();
            this.lblBeforeCompare = new System.Windows.Forms.Label();
            this.btnCompareAfter = new System.Windows.Forms.Button();
            this.txtCompareBefore = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.chkToggle = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(13, 13);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(672, 602);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.chkToggle);
            this.tabPage1.Controls.Add(this.chkListScans);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.btnStartScan);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(664, 576);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Scan";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // chkListScans
            // 
            this.chkListScans.CheckOnClick = true;
            this.chkListScans.FormattingEnabled = true;
            this.chkListScans.Location = new System.Drawing.Point(12, 26);
            this.chkListScans.Name = "chkListScans";
            this.chkListScans.Size = new System.Drawing.Size(646, 259);
            this.chkListScans.TabIndex = 5;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 390);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(646, 142);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // btnStartScan
            // 
            this.btnStartScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartScan.Location = new System.Drawing.Point(15, 307);
            this.btnStartScan.Name = "btnStartScan";
            this.btnStartScan.Size = new System.Drawing.Size(643, 64);
            this.btnStartScan.TabIndex = 1;
            this.btnStartScan.Text = "Start Scan";
            this.btnStartScan.UseVisualStyleBackColor = true;
            this.btnStartScan.Click += new System.EventHandler(this.btnStartScan_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnCompare);
            this.tabPage2.Controls.Add(this.lblAfterCompare);
            this.tabPage2.Controls.Add(this.lblBeforeCompare);
            this.tabPage2.Controls.Add(this.btnCompareAfter);
            this.tabPage2.Controls.Add(this.txtCompareBefore);
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(664, 576);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Compare";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(216, 481);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(168, 62);
            this.btnCompare.TabIndex = 5;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // lblAfterCompare
            // 
            this.lblAfterCompare.AutoSize = true;
            this.lblAfterCompare.Location = new System.Drawing.Point(271, 192);
            this.lblAfterCompare.Name = "lblAfterCompare";
            this.lblAfterCompare.Size = new System.Drawing.Size(10, 13);
            this.lblAfterCompare.TabIndex = 4;
            this.lblAfterCompare.Text = "-";
            // 
            // lblBeforeCompare
            // 
            this.lblBeforeCompare.AutoSize = true;
            this.lblBeforeCompare.Location = new System.Drawing.Point(271, 92);
            this.lblBeforeCompare.Name = "lblBeforeCompare";
            this.lblBeforeCompare.Size = new System.Drawing.Size(10, 13);
            this.lblBeforeCompare.TabIndex = 3;
            this.lblBeforeCompare.Text = "-";
            // 
            // btnCompareAfter
            // 
            this.btnCompareAfter.Location = new System.Drawing.Point(253, 166);
            this.btnCompareAfter.Name = "btnCompareAfter";
            this.btnCompareAfter.Size = new System.Drawing.Size(75, 23);
            this.btnCompareAfter.TabIndex = 2;
            this.btnCompareAfter.Text = "After";
            this.btnCompareAfter.UseVisualStyleBackColor = true;
            this.btnCompareAfter.Click += new System.EventHandler(this.btnCompareAfter_Click);
            // 
            // txtCompareBefore
            // 
            this.txtCompareBefore.Location = new System.Drawing.Point(253, 66);
            this.txtCompareBefore.Name = "txtCompareBefore";
            this.txtCompareBefore.Size = new System.Drawing.Size(75, 23);
            this.txtCompareBefore.TabIndex = 1;
            this.txtCompareBefore.Text = "Before";
            this.txtCompareBefore.UseVisualStyleBackColor = true;
            this.txtCompareBefore.Click += new System.EventHandler(this.txtCompareBefore_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(25, 34);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(195, 394);
            this.listBox1.TabIndex = 0;
            // 
            // chkToggle
            // 
            this.chkToggle.AutoSize = true;
            this.chkToggle.Location = new System.Drawing.Point(15, 6);
            this.chkToggle.Name = "chkToggle";
            this.chkToggle.Size = new System.Drawing.Size(73, 17);
            this.chkToggle.TabIndex = 6;
            this.chkToggle.Text = "Toggle All";
            this.chkToggle.UseVisualStyleBackColor = true;
            this.chkToggle.Click += new System.EventHandler(this.chkToggle_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 538);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(646, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 627);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "WindowsDiffTool";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnStartScan;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckedListBox chkListScans;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblAfterCompare;
        private System.Windows.Forms.Label lblBeforeCompare;
        private System.Windows.Forms.Button btnCompareAfter;
        private System.Windows.Forms.Button txtCompareBefore;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.CheckBox chkToggle;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

