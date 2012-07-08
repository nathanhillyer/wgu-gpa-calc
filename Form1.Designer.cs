﻿namespace wgu_gpa_calc
{
    partial class wgugpacalc
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
            this.components = new System.ComponentModel.Container();
            this.ClassDescription = new System.Windows.Forms.ToolTip(this.components);
            this.txtGPA = new System.Windows.Forms.TextBox();
            this.btnGPA = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblVal = new System.Windows.Forms.Label();
            this.cmbInput = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtGPA
            // 
            this.txtGPA.Location = new System.Drawing.Point(589, 31);
            this.txtGPA.Name = "txtGPA";
            this.txtGPA.ReadOnly = true;
            this.txtGPA.Size = new System.Drawing.Size(100, 20);
            this.txtGPA.TabIndex = 4;
            this.txtGPA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGPA
            // 
            this.btnGPA.Location = new System.Drawing.Point(695, 29);
            this.btnGPA.Name = "btnGPA";
            this.btnGPA.Size = new System.Drawing.Size(100, 23);
            this.btnGPA.TabIndex = 5;
            this.btnGPA.Text = "Calculate GPA";
            this.btnGPA.UseVisualStyleBackColor = true;
            this.btnGPA.Click += new System.EventHandler(this.btnGPA_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(815, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // cmbClass
            // 
            this.cmbClass.DropDownHeight = 600;
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.IntegralHeight = false;
            this.cmbClass.Items.AddRange(new object[] {
            "WFV1",
            "AGC1",
            "BBC1",
            "CLC1",
            "LAE1",
            "LUT1",
            "QBT1",
            "AXV1",
            "CPV1",
            "INC1",
            "INT1",
            "DFV1",
            "CUV1",
            "BVC1",
            "GAC1",
            "HHT1",
            "DHV1",
            "DIV1",
            "CWV1",
            "CRV1",
            "QLT1",
            "DEV1",
            "CTV1",
            "DJV1",
            "BOV1",
            "BNC1",
            "IWC1",
            "IWT1",
            "KET1",
            "CVV1",
            "MGC1",
            "RIT1",
            "CJV1",
            "KFT1",
            "TPV1",
            "SBT1",
            "QZT1"});
            this.cmbClass.Location = new System.Drawing.Point(13, 28);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(121, 21);
            this.cmbClass.TabIndex = 24;
            this.cmbClass.SelectedIndexChanged += new System.EventHandler(this.cmbClass_SelectedIndexChanged);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(141, 29);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 25;
            this.txtInput.Visible = false;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // lblVal
            // 
            this.lblVal.AutoSize = true;
            this.lblVal.Location = new System.Drawing.Point(248, 32);
            this.lblVal.Name = "lblVal";
            this.lblVal.Size = new System.Drawing.Size(0, 13);
            this.lblVal.TabIndex = 26;
            // 
            // cmbInput
            // 
            this.cmbInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInput.FormattingEnabled = true;
            this.cmbInput.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4+"});
            this.cmbInput.Location = new System.Drawing.Point(142, 28);
            this.cmbInput.Name = "cmbInput";
            this.cmbInput.Size = new System.Drawing.Size(100, 21);
            this.cmbInput.TabIndex = 27;
            this.cmbInput.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(508, 29);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Add Score";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 85);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(815, 22);
            this.statusStrip1.TabIndex = 29;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // wgugpacalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 107);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbInput);
            this.Controls.Add(this.lblVal);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnGPA);
            this.Controls.Add(this.txtGPA);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "wgugpacalc";
            this.Text = "WGU GPA Calculator";
            this.Load += new System.EventHandler(this.wgugpacalc_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip ClassDescription;
        private System.Windows.Forms.TextBox txtGPA;
        private System.Windows.Forms.Button btnGPA;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblVal;
        private System.Windows.Forms.ComboBox cmbInput;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}

