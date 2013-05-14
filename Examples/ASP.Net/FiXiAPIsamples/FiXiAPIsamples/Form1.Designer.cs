namespace FiXiAPIsamples
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGetMatchesByDateRange = new System.Windows.Forms.TextBox();
            this.btnMatchbyDate = new System.Windows.Forms.Button();
            this.dtMatchByDate = new System.Windows.Forms.DateTimePicker();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGetTeamDetailsParam = new System.Windows.Forms.TextBox();
            this.txtGetTeamDetails = new System.Windows.Forms.TextBox();
            this.btnGetTeamDetails = new System.Windows.Forms.Button();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TabPage1.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.GroupBox1);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(457, 434);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Match";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtGetMatchesByDateRange);
            this.GroupBox1.Controls.Add(this.btnMatchbyDate);
            this.GroupBox1.Controls.Add(this.dtMatchByDate);
            this.GroupBox1.Location = new System.Drawing.Point(8, 6);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(426, 396);
            this.GroupBox1.TabIndex = 2;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "GetMatchesByDateRange";
            // 
            // txtGetMatchesByDateRange
            // 
            this.txtGetMatchesByDateRange.Location = new System.Drawing.Point(7, 75);
            this.txtGetMatchesByDateRange.Multiline = true;
            this.txtGetMatchesByDateRange.Name = "txtGetMatchesByDateRange";
            this.txtGetMatchesByDateRange.Size = new System.Drawing.Size(413, 315);
            this.txtGetMatchesByDateRange.TabIndex = 2;
            // 
            // btnMatchbyDate
            // 
            this.btnMatchbyDate.Location = new System.Drawing.Point(247, 19);
            this.btnMatchbyDate.Name = "btnMatchbyDate";
            this.btnMatchbyDate.Size = new System.Drawing.Size(158, 38);
            this.btnMatchbyDate.TabIndex = 0;
            this.btnMatchbyDate.Text = "GetMatchesByDateRange";
            this.btnMatchbyDate.UseVisualStyleBackColor = true;
            this.btnMatchbyDate.Click += new System.EventHandler(this.btnMatchbyDate_Click);
            // 
            // dtMatchByDate
            // 
            this.dtMatchByDate.Location = new System.Drawing.Point(23, 26);
            this.dtMatchByDate.Name = "dtMatchByDate";
            this.dtMatchByDate.Size = new System.Drawing.Size(200, 20);
            this.dtMatchByDate.TabIndex = 1;
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.tabPage3);
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.tabPage5);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.Location = new System.Drawing.Point(0, 0);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(465, 460);
            this.TabControl1.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox2);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(457, 434);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Team";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtGetTeamDetailsParam);
            this.groupBox2.Controls.Add(this.txtGetTeamDetails);
            this.groupBox2.Controls.Add(this.btnGetTeamDetails);
            this.groupBox2.Location = new System.Drawing.Point(8, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 396);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GetTeamDetails";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Team ID";
            // 
            // txtGetTeamDetailsParam
            // 
            this.txtGetTeamDetailsParam.Location = new System.Drawing.Point(68, 29);
            this.txtGetTeamDetailsParam.Name = "txtGetTeamDetailsParam";
            this.txtGetTeamDetailsParam.Size = new System.Drawing.Size(59, 20);
            this.txtGetTeamDetailsParam.TabIndex = 3;
            this.txtGetTeamDetailsParam.Text = "6281";
            // 
            // txtGetTeamDetails
            // 
            this.txtGetTeamDetails.Location = new System.Drawing.Point(7, 75);
            this.txtGetTeamDetails.Multiline = true;
            this.txtGetTeamDetails.Name = "txtGetTeamDetails";
            this.txtGetTeamDetails.Size = new System.Drawing.Size(413, 315);
            this.txtGetTeamDetails.TabIndex = 2;
            // 
            // btnGetTeamDetails
            // 
            this.btnGetTeamDetails.Location = new System.Drawing.Point(146, 22);
            this.btnGetTeamDetails.Name = "btnGetTeamDetails";
            this.btnGetTeamDetails.Size = new System.Drawing.Size(103, 32);
            this.btnGetTeamDetails.TabIndex = 0;
            this.btnGetTeamDetails.Text = "GetTeamDetails";
            this.btnGetTeamDetails.UseVisualStyleBackColor = true;
            this.btnGetTeamDetails.Click += new System.EventHandler(this.btnGetTeamDetails_Click);
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.button4);
            this.TabPage2.Controls.Add(this.button3);
            this.TabPage2.Controls.Add(this.button2);
            this.TabPage2.Controls.Add(this.button1);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(457, 434);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Other Calls";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(238, 63);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Get Team Transactions";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(35, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Get Resources";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save Customer Attendance";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(238, 24);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(184, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Get Centre Details";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Controls.Add(this.linkLabel3);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.linkLabel2);
            this.tabPage3.Controls.Add(this.linkLabel1);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(457, 434);
            this.tabPage3.TabIndex = 5;
            this.tabPage3.Text = "Overview";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "API Documentation:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sample Code:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(134, 35);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(118, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://api.fixionline.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(134, 66);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(172, 13);
            this.linkLabel2.TabIndex = 3;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "https://github.com/tallday/FiXi-API";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email Support: ";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(134, 99);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(116, 13);
            this.linkLabel3.TabIndex = 5;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "support@fixionline.com";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(300, 341);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 85);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 460);
            this.Controls.Add(this.TabControl1);
            this.Name = "Form1";
            this.Text = "FiXi Samples";
            this.TabPage1.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox txtGetMatchesByDateRange;
        internal System.Windows.Forms.Button btnMatchbyDate;
        internal System.Windows.Forms.DateTimePicker dtMatchByDate;
        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.TabPage tabPage5;
        internal System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.TextBox txtGetTeamDetails;
        internal System.Windows.Forms.Button btnGetTeamDetails;
        private System.Windows.Forms.TextBox txtGetTeamDetailsParam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

