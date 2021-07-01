
namespace KeywordDriven.Desktop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_checkproject = new System.Windows.Forms.Button();
            this.btn_selectlocation = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_projectname = new System.Windows.Forms.TextBox();
            this.txt_generallocation = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_apkpath = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_platformversion = new System.Windows.Forms.TextBox();
            this.txt_udid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_devicename = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.num_navtimeout = new System.Windows.Forms.NumericUpDown();
            this.num_timeout = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.combo_headless = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.combo_drivertype = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_setup = new System.Windows.Forms.Button();
            this.btn_Execute = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_navtimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_timeout)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_checkproject);
            this.groupBox5.Controls.Add(this.btn_selectlocation);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.txt_projectname);
            this.groupBox5.Controls.Add(this.txt_generallocation);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(503, 88);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Location setting";
            // 
            // btn_checkproject
            // 
            this.btn_checkproject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_checkproject.Location = new System.Drawing.Point(299, 52);
            this.btn_checkproject.Name = "btn_checkproject";
            this.btn_checkproject.Size = new System.Drawing.Size(69, 29);
            this.btn_checkproject.TabIndex = 5;
            this.btn_checkproject.Text = "Check";
            this.btn_checkproject.UseVisualStyleBackColor = true;
            this.btn_checkproject.Click += new System.EventHandler(this.btn_checkproject_Click);
            // 
            // btn_selectlocation
            // 
            this.btn_selectlocation.Location = new System.Drawing.Point(413, 18);
            this.btn_selectlocation.Name = "btn_selectlocation";
            this.btn_selectlocation.Size = new System.Drawing.Size(78, 29);
            this.btn_selectlocation.TabIndex = 4;
            this.btn_selectlocation.Text = "Select";
            this.btn_selectlocation.UseVisualStyleBackColor = true;
            this.btn_selectlocation.Click += new System.EventHandler(this.btn_selectlocation_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "Project name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "General Location";
            // 
            // txt_projectname
            // 
            this.txt_projectname.Location = new System.Drawing.Point(130, 53);
            this.txt_projectname.Name = "txt_projectname";
            this.txt_projectname.Size = new System.Drawing.Size(163, 27);
            this.txt_projectname.TabIndex = 1;
            // 
            // txt_generallocation
            // 
            this.txt_generallocation.Enabled = false;
            this.txt_generallocation.Location = new System.Drawing.Point(130, 20);
            this.txt_generallocation.Name = "txt_generallocation";
            this.txt_generallocation.Size = new System.Drawing.Size(277, 27);
            this.txt_generallocation.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txt_apkpath);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txt_platformversion);
            this.groupBox4.Controls.Add(this.txt_udid);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txt_devicename);
            this.groupBox4.Location = new System.Drawing.Point(12, 213);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(503, 103);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "MobieDriver setting";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(269, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Apk";
            // 
            // txt_apkpath
            // 
            this.txt_apkpath.Location = new System.Drawing.Point(310, 59);
            this.txt_apkpath.Name = "txt_apkpath";
            this.txt_apkpath.Size = new System.Drawing.Size(181, 27);
            this.txt_apkpath.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Platform version";
            // 
            // txt_platformversion
            // 
            this.txt_platformversion.Location = new System.Drawing.Point(129, 59);
            this.txt_platformversion.Name = "txt_platformversion";
            this.txt_platformversion.Size = new System.Drawing.Size(101, 27);
            this.txt_platformversion.TabIndex = 4;
            // 
            // txt_udid
            // 
            this.txt_udid.Location = new System.Drawing.Point(335, 26);
            this.txt_udid.Name = "txt_udid";
            this.txt_udid.Size = new System.Drawing.Size(156, 27);
            this.txt_udid.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(288, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Udid";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Device name";
            // 
            // txt_devicename
            // 
            this.txt_devicename.Location = new System.Drawing.Point(102, 26);
            this.txt_devicename.Name = "txt_devicename";
            this.txt_devicename.Size = new System.Drawing.Size(169, 27);
            this.txt_devicename.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.num_navtimeout);
            this.groupBox3.Controls.Add(this.num_timeout);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.combo_headless);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.combo_drivertype);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 106);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(503, 101);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "WebDriver setting";
            // 
            // num_navtimeout
            // 
            this.num_navtimeout.Location = new System.Drawing.Point(366, 58);
            this.num_navtimeout.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.num_navtimeout.Name = "num_navtimeout";
            this.num_navtimeout.Size = new System.Drawing.Size(125, 27);
            this.num_navtimeout.TabIndex = 13;
            this.num_navtimeout.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // num_timeout
            // 
            this.num_timeout.Location = new System.Drawing.Point(105, 58);
            this.num_timeout.Name = "num_timeout";
            this.num_timeout.Size = new System.Drawing.Size(125, 27);
            this.num_timeout.TabIndex = 12;
            this.num_timeout.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Headless";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "NavTimeout";
            // 
            // combo_headless
            // 
            this.combo_headless.FormattingEnabled = true;
            this.combo_headless.Items.AddRange(new object[] {
            "true",
            "false"});
            this.combo_headless.Location = new System.Drawing.Point(366, 24);
            this.combo_headless.Name = "combo_headless";
            this.combo_headless.Size = new System.Drawing.Size(125, 28);
            this.combo_headless.TabIndex = 11;
            this.combo_headless.Text = "false";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Timeout";
            // 
            // combo_drivertype
            // 
            this.combo_drivertype.Enabled = false;
            this.combo_drivertype.FormattingEnabled = true;
            this.combo_drivertype.Items.AddRange(new object[] {
            "local",
            "remote"});
            this.combo_drivertype.Location = new System.Drawing.Point(105, 24);
            this.combo_drivertype.Name = "combo_drivertype";
            this.combo_drivertype.Size = new System.Drawing.Size(125, 28);
            this.combo_drivertype.TabIndex = 7;
            this.combo_drivertype.Text = "local";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Driver type";
            // 
            // btn_setup
            // 
            this.btn_setup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_setup.Enabled = false;
            this.btn_setup.Location = new System.Drawing.Point(101, 323);
            this.btn_setup.Name = "btn_setup";
            this.btn_setup.Size = new System.Drawing.Size(141, 29);
            this.btn_setup.TabIndex = 5;
            this.btn_setup.Text = "SetUp";
            this.btn_setup.UseVisualStyleBackColor = true;
            this.btn_setup.Click += new System.EventHandler(this.btn_setup_Click);
            // 
            // btn_Execute
            // 
            this.btn_Execute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Execute.Enabled = false;
            this.btn_Execute.Location = new System.Drawing.Point(262, 323);
            this.btn_Execute.Name = "btn_Execute";
            this.btn_Execute.Size = new System.Drawing.Size(157, 29);
            this.btn_Execute.TabIndex = 13;
            this.btn_Execute.Text = "Execute tests";
            this.btn_Execute.UseVisualStyleBackColor = true;
            this.btn_Execute.Click += new System.EventHandler(this.btn_Execute_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 364);
            this.Controls.Add(this.btn_Execute);
            this.Controls.Add(this.btn_setup);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Automation";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_navtimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_timeout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combo_drivertype;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combo_headless;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_devicename;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_udid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_apkpath;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_platformversion;
        private System.Windows.Forms.NumericUpDown num_navtimeout;
        private System.Windows.Forms.NumericUpDown num_timeout;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_projectname;
        private System.Windows.Forms.TextBox txt_generallocation;
        private System.Windows.Forms.Button btn_selectlocation;
        private System.Windows.Forms.Button btn_setup;
        private System.Windows.Forms.Button btn_Execute;
        private System.Windows.Forms.Button btn_checkproject;
    }
}

