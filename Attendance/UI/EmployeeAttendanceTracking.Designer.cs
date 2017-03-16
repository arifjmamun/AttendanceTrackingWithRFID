namespace Attendance.UI
{
    partial class EmployeeAttendanceTracking
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
            this.employeeAttendanceTabControl = new System.Windows.Forms.TabControl();
            this.authenticationTab = new System.Windows.Forms.TabPage();
            this.authenticationGroupBox = new System.Windows.Forms.GroupBox();
            this.loginStatusLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.passowordTextBox = new System.Windows.Forms.TextBox();
            this.userIdTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.attendanceTab = new System.Windows.Forms.TabPage();
            this.attendanceGroupBox = new System.Windows.Forms.GroupBox();
            this.timeAndDateLabel = new System.Windows.Forms.Label();
            this.employeeIdLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.attendanceLabelStatus = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.profileImageBox = new System.Windows.Forms.PictureBox();
            this.providerNameTextBox = new System.Windows.Forms.TabPage();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.defaultRadioButton = new System.Windows.Forms.RadioButton();
            this.configureManuallyradioButton = new System.Windows.Forms.RadioButton();
            this.dbConnectionConfigGroupBox = new System.Windows.Forms.GroupBox();
            this.applyDbConfigButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dbNameTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dbPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dbUserIdTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.serverNameTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.serialPortConfigGroupBox = new System.Windows.Forms.GroupBox();
            this.applySerialConfigButton = new System.Windows.Forms.Button();
            this.baudRateComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comPortComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.employeeAttendancemenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authenticationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label16 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.employeeAttendanceTabControl.SuspendLayout();
            this.authenticationTab.SuspendLayout();
            this.authenticationGroupBox.SuspendLayout();
            this.attendanceTab.SuspendLayout();
            this.attendanceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileImageBox)).BeginInit();
            this.providerNameTextBox.SuspendLayout();
            this.dbConnectionConfigGroupBox.SuspendLayout();
            this.serialPortConfigGroupBox.SuspendLayout();
            this.employeeAttendancemenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeAttendanceTabControl
            // 
            this.employeeAttendanceTabControl.Controls.Add(this.authenticationTab);
            this.employeeAttendanceTabControl.Controls.Add(this.attendanceTab);
            this.employeeAttendanceTabControl.Controls.Add(this.providerNameTextBox);
            this.employeeAttendanceTabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.employeeAttendanceTabControl.Location = new System.Drawing.Point(0, 27);
            this.employeeAttendanceTabControl.Name = "employeeAttendanceTabControl";
            this.employeeAttendanceTabControl.SelectedIndex = 0;
            this.employeeAttendanceTabControl.Size = new System.Drawing.Size(733, 371);
            this.employeeAttendanceTabControl.TabIndex = 0;
            // 
            // authenticationTab
            // 
            this.authenticationTab.Controls.Add(this.authenticationGroupBox);
            this.authenticationTab.Controls.Add(this.label2);
            this.authenticationTab.Controls.Add(this.label1);
            this.authenticationTab.Location = new System.Drawing.Point(4, 22);
            this.authenticationTab.Name = "authenticationTab";
            this.authenticationTab.Padding = new System.Windows.Forms.Padding(3);
            this.authenticationTab.Size = new System.Drawing.Size(725, 345);
            this.authenticationTab.TabIndex = 2;
            this.authenticationTab.Text = "Authentication";
            this.authenticationTab.UseVisualStyleBackColor = true;
            // 
            // authenticationGroupBox
            // 
            this.authenticationGroupBox.Controls.Add(this.loginStatusLabel);
            this.authenticationGroupBox.Controls.Add(this.loginButton);
            this.authenticationGroupBox.Controls.Add(this.label3);
            this.authenticationGroupBox.Controls.Add(this.passowordTextBox);
            this.authenticationGroupBox.Controls.Add(this.userIdTextBox);
            this.authenticationGroupBox.Controls.Add(this.label4);
            this.authenticationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authenticationGroupBox.Location = new System.Drawing.Point(163, 99);
            this.authenticationGroupBox.Name = "authenticationGroupBox";
            this.authenticationGroupBox.Size = new System.Drawing.Size(389, 179);
            this.authenticationGroupBox.TabIndex = 0;
            this.authenticationGroupBox.TabStop = false;
            this.authenticationGroupBox.Text = "Authentication";
            // 
            // loginStatusLabel
            // 
            this.loginStatusLabel.AutoSize = true;
            this.loginStatusLabel.Location = new System.Drawing.Point(16, 26);
            this.loginStatusLabel.Name = "loginStatusLabel";
            this.loginStatusLabel.Size = new System.Drawing.Size(0, 17);
            this.loginStatusLabel.TabIndex = 3;
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(242, 118);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(84, 32);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "User Id";
            // 
            // passowordTextBox
            // 
            this.passowordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passowordTextBox.Location = new System.Drawing.Point(157, 89);
            this.passowordTextBox.Name = "passowordTextBox";
            this.passowordTextBox.PasswordChar = '*';
            this.passowordTextBox.Size = new System.Drawing.Size(169, 23);
            this.passowordTextBox.TabIndex = 1;
            // 
            // userIdTextBox
            // 
            this.userIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdTextBox.Location = new System.Drawing.Point(157, 58);
            this.userIdTextBox.Name = "userIdTextBox";
            this.userIdTextBox.Size = new System.Drawing.Size(169, 23);
            this.userIdTextBox.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(288, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Authentication";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Attendace Tracking";
            // 
            // attendanceTab
            // 
            this.attendanceTab.Controls.Add(this.attendanceGroupBox);
            this.attendanceTab.Location = new System.Drawing.Point(4, 22);
            this.attendanceTab.Name = "attendanceTab";
            this.attendanceTab.Padding = new System.Windows.Forms.Padding(3);
            this.attendanceTab.Size = new System.Drawing.Size(725, 345);
            this.attendanceTab.TabIndex = 1;
            this.attendanceTab.Text = "Attendance";
            this.attendanceTab.UseVisualStyleBackColor = true;
            // 
            // attendanceGroupBox
            // 
            this.attendanceGroupBox.Controls.Add(this.statusLabel);
            this.attendanceGroupBox.Controls.Add(this.timeAndDateLabel);
            this.attendanceGroupBox.Controls.Add(this.employeeIdLabel);
            this.attendanceGroupBox.Controls.Add(this.label16);
            this.attendanceGroupBox.Controls.Add(this.label8);
            this.attendanceGroupBox.Controls.Add(this.attendanceLabelStatus);
            this.attendanceGroupBox.Controls.Add(this.label7);
            this.attendanceGroupBox.Controls.Add(this.employeeNameLabel);
            this.attendanceGroupBox.Controls.Add(this.label6);
            this.attendanceGroupBox.Controls.Add(this.label5);
            this.attendanceGroupBox.Controls.Add(this.profileImageBox);
            this.attendanceGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendanceGroupBox.Location = new System.Drawing.Point(8, 6);
            this.attendanceGroupBox.Name = "attendanceGroupBox";
            this.attendanceGroupBox.Size = new System.Drawing.Size(709, 336);
            this.attendanceGroupBox.TabIndex = 1;
            this.attendanceGroupBox.TabStop = false;
            this.attendanceGroupBox.Text = "Attendance";
            // 
            // timeAndDateLabel
            // 
            this.timeAndDateLabel.AutoSize = true;
            this.timeAndDateLabel.Location = new System.Drawing.Point(366, 141);
            this.timeAndDateLabel.Name = "timeAndDateLabel";
            this.timeAndDateLabel.Size = new System.Drawing.Size(0, 22);
            this.timeAndDateLabel.TabIndex = 4;
            // 
            // employeeIdLabel
            // 
            this.employeeIdLabel.AutoSize = true;
            this.employeeIdLabel.Location = new System.Drawing.Point(366, 71);
            this.employeeIdLabel.Name = "employeeIdLabel";
            this.employeeIdLabel.Size = new System.Drawing.Size(0, 22);
            this.employeeIdLabel.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(219, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 22);
            this.label8.TabIndex = 4;
            this.label8.Text = "Time and Date";
            // 
            // attendanceLabelStatus
            // 
            this.attendanceLabelStatus.AutoSize = true;
            this.attendanceLabelStatus.Location = new System.Drawing.Point(366, 106);
            this.attendanceLabelStatus.Name = "attendanceLabelStatus";
            this.attendanceLabelStatus.Size = new System.Drawing.Size(0, 22);
            this.attendanceLabelStatus.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(236, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 22);
            this.label7.TabIndex = 3;
            this.label7.Text = "Employee ID";
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.AutoSize = true;
            this.employeeNameLabel.Location = new System.Drawing.Point(366, 36);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(0, 22);
            this.employeeNameLabel.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Attendance Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Employee Name";
            // 
            // profileImageBox
            // 
            this.profileImageBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.profileImageBox.Location = new System.Drawing.Point(24, 36);
            this.profileImageBox.Name = "profileImageBox";
            this.profileImageBox.Size = new System.Drawing.Size(160, 160);
            this.profileImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profileImageBox.TabIndex = 0;
            this.profileImageBox.TabStop = false;
            // 
            // providerNameTextBox
            // 
            this.providerNameTextBox.Controls.Add(this.disconnectButton);
            this.providerNameTextBox.Controls.Add(this.connectButton);
            this.providerNameTextBox.Controls.Add(this.defaultRadioButton);
            this.providerNameTextBox.Controls.Add(this.configureManuallyradioButton);
            this.providerNameTextBox.Controls.Add(this.dbConnectionConfigGroupBox);
            this.providerNameTextBox.Controls.Add(this.serialPortConfigGroupBox);
            this.providerNameTextBox.Location = new System.Drawing.Point(4, 22);
            this.providerNameTextBox.Name = "providerNameTextBox";
            this.providerNameTextBox.Padding = new System.Windows.Forms.Padding(3);
            this.providerNameTextBox.Size = new System.Drawing.Size(725, 345);
            this.providerNameTextBox.TabIndex = 0;
            this.providerNameTextBox.Text = "Connection";
            this.providerNameTextBox.UseVisualStyleBackColor = true;
            // 
            // disconnectButton
            // 
            this.disconnectButton.BackColor = System.Drawing.Color.Maroon;
            this.disconnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disconnectButton.ForeColor = System.Drawing.SystemColors.Menu;
            this.disconnectButton.Location = new System.Drawing.Point(515, 6);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(98, 43);
            this.disconnectButton.TabIndex = 3;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = false;
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.Color.Green;
            this.connectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectButton.ForeColor = System.Drawing.Color.White;
            this.connectButton.Location = new System.Drawing.Point(619, 6);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(98, 43);
            this.connectButton.TabIndex = 3;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // defaultRadioButton
            // 
            this.defaultRadioButton.AutoSize = true;
            this.defaultRadioButton.Checked = true;
            this.defaultRadioButton.Location = new System.Drawing.Point(13, 26);
            this.defaultRadioButton.Name = "defaultRadioButton";
            this.defaultRadioButton.Size = new System.Drawing.Size(138, 17);
            this.defaultRadioButton.TabIndex = 0;
            this.defaultRadioButton.TabStop = true;
            this.defaultRadioButton.Text = "Use Default Connection";
            this.defaultRadioButton.UseVisualStyleBackColor = true;
            // 
            // configureManuallyradioButton
            // 
            this.configureManuallyradioButton.AutoSize = true;
            this.configureManuallyradioButton.Location = new System.Drawing.Point(157, 26);
            this.configureManuallyradioButton.Name = "configureManuallyradioButton";
            this.configureManuallyradioButton.Size = new System.Drawing.Size(115, 17);
            this.configureManuallyradioButton.TabIndex = 1;
            this.configureManuallyradioButton.TabStop = true;
            this.configureManuallyradioButton.Text = "Configure Manually";
            this.configureManuallyradioButton.UseVisualStyleBackColor = true;
            // 
            // dbConnectionConfigGroupBox
            // 
            this.dbConnectionConfigGroupBox.Controls.Add(this.applyDbConfigButton);
            this.dbConnectionConfigGroupBox.Controls.Add(this.textBox1);
            this.dbConnectionConfigGroupBox.Controls.Add(this.label15);
            this.dbConnectionConfigGroupBox.Controls.Add(this.dbNameTextBox);
            this.dbConnectionConfigGroupBox.Controls.Add(this.label14);
            this.dbConnectionConfigGroupBox.Controls.Add(this.dbPasswordTextBox);
            this.dbConnectionConfigGroupBox.Controls.Add(this.label13);
            this.dbConnectionConfigGroupBox.Controls.Add(this.dbUserIdTextBox);
            this.dbConnectionConfigGroupBox.Controls.Add(this.label12);
            this.dbConnectionConfigGroupBox.Controls.Add(this.serverNameTextBox);
            this.dbConnectionConfigGroupBox.Controls.Add(this.label11);
            this.dbConnectionConfigGroupBox.Location = new System.Drawing.Point(364, 56);
            this.dbConnectionConfigGroupBox.Name = "dbConnectionConfigGroupBox";
            this.dbConnectionConfigGroupBox.Size = new System.Drawing.Size(353, 243);
            this.dbConnectionConfigGroupBox.TabIndex = 2;
            this.dbConnectionConfigGroupBox.TabStop = false;
            this.dbConnectionConfigGroupBox.Text = "Database Connection Configuration";
            // 
            // applyDbConfigButton
            // 
            this.applyDbConfigButton.Location = new System.Drawing.Point(230, 173);
            this.applyDbConfigButton.Name = "applyDbConfigButton";
            this.applyDbConfigButton.Size = new System.Drawing.Size(75, 23);
            this.applyDbConfigButton.TabIndex = 2;
            this.applyDbConfigButton.Text = "Apply";
            this.applyDbConfigButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 147);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "MySql.Data.MySqlClient";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(40, 150);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Provider Name";
            // 
            // dbNameTextBox
            // 
            this.dbNameTextBox.Location = new System.Drawing.Point(125, 121);
            this.dbNameTextBox.Name = "dbNameTextBox";
            this.dbNameTextBox.Size = new System.Drawing.Size(180, 20);
            this.dbNameTextBox.TabIndex = 1;
            this.dbNameTextBox.Text = "employee_db";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(40, 124);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Database Name";
            // 
            // dbPasswordTextBox
            // 
            this.dbPasswordTextBox.Location = new System.Drawing.Point(125, 93);
            this.dbPasswordTextBox.Name = "dbPasswordTextBox";
            this.dbPasswordTextBox.PasswordChar = '*';
            this.dbPasswordTextBox.Size = new System.Drawing.Size(180, 20);
            this.dbPasswordTextBox.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(71, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Password";
            // 
            // dbUserIdTextBox
            // 
            this.dbUserIdTextBox.Location = new System.Drawing.Point(125, 65);
            this.dbUserIdTextBox.Name = "dbUserIdTextBox";
            this.dbUserIdTextBox.Size = new System.Drawing.Size(180, 20);
            this.dbUserIdTextBox.TabIndex = 1;
            this.dbUserIdTextBox.Text = "root";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(83, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "User Id";
            // 
            // serverNameTextBox
            // 
            this.serverNameTextBox.Location = new System.Drawing.Point(125, 37);
            this.serverNameTextBox.Name = "serverNameTextBox";
            this.serverNameTextBox.Size = new System.Drawing.Size(180, 20);
            this.serverNameTextBox.TabIndex = 1;
            this.serverNameTextBox.Text = "127.0.0.1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(86, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Server";
            // 
            // serialPortConfigGroupBox
            // 
            this.serialPortConfigGroupBox.Controls.Add(this.applySerialConfigButton);
            this.serialPortConfigGroupBox.Controls.Add(this.baudRateComboBox);
            this.serialPortConfigGroupBox.Controls.Add(this.label10);
            this.serialPortConfigGroupBox.Controls.Add(this.comPortComboBox);
            this.serialPortConfigGroupBox.Controls.Add(this.label9);
            this.serialPortConfigGroupBox.Location = new System.Drawing.Point(8, 56);
            this.serialPortConfigGroupBox.Name = "serialPortConfigGroupBox";
            this.serialPortConfigGroupBox.Size = new System.Drawing.Size(350, 243);
            this.serialPortConfigGroupBox.TabIndex = 2;
            this.serialPortConfigGroupBox.TabStop = false;
            this.serialPortConfigGroupBox.Text = "Serial Port Connection Configuration";
            // 
            // applySerialConfigButton
            // 
            this.applySerialConfigButton.Location = new System.Drawing.Point(177, 91);
            this.applySerialConfigButton.Name = "applySerialConfigButton";
            this.applySerialConfigButton.Size = new System.Drawing.Size(75, 23);
            this.applySerialConfigButton.TabIndex = 2;
            this.applySerialConfigButton.Text = "Apply";
            this.applySerialConfigButton.UseVisualStyleBackColor = true;
            // 
            // baudRateComboBox
            // 
            this.baudRateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudRateComboBox.FormattingEnabled = true;
            this.baudRateComboBox.Location = new System.Drawing.Point(98, 64);
            this.baudRateComboBox.Name = "baudRateComboBox";
            this.baudRateComboBox.Size = new System.Drawing.Size(154, 21);
            this.baudRateComboBox.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Baud Rate";
            // 
            // comPortComboBox
            // 
            this.comPortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comPortComboBox.FormattingEnabled = true;
            this.comPortComboBox.Location = new System.Drawing.Point(98, 37);
            this.comPortComboBox.Name = "comPortComboBox";
            this.comPortComboBox.Size = new System.Drawing.Size(154, 21);
            this.comPortComboBox.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "COM Port";
            // 
            // employeeAttendancemenuStrip
            // 
            this.employeeAttendancemenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.otherToolStripMenuItem});
            this.employeeAttendancemenuStrip.Location = new System.Drawing.Point(0, 0);
            this.employeeAttendancemenuStrip.Name = "employeeAttendancemenuStrip";
            this.employeeAttendancemenuStrip.Size = new System.Drawing.Size(733, 24);
            this.employeeAttendancemenuStrip.TabIndex = 1;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem,
            this.attendanceToolStripMenuItem,
            this.authenticationToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.connectionToolStripMenuItem.Text = "Connection";
            // 
            // attendanceToolStripMenuItem
            // 
            this.attendanceToolStripMenuItem.Name = "attendanceToolStripMenuItem";
            this.attendanceToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.attendanceToolStripMenuItem.Text = "Attendance";
            // 
            // authenticationToolStripMenuItem
            // 
            this.authenticationToolStripMenuItem.Name = "authenticationToolStripMenuItem";
            this.authenticationToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.authenticationToolStripMenuItem.Text = "Authentication";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // otherToolStripMenuItem
            // 
            this.otherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.otherToolStripMenuItem.Text = "Others";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(34, 228);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 22);
            this.label16.TabIndex = 4;
            this.label16.Text = "Status";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(110, 228);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 22);
            this.statusLabel.TabIndex = 4;
            // 
            // EmployeeAttendanceTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 398);
            this.Controls.Add(this.employeeAttendanceTabControl);
            this.Controls.Add(this.employeeAttendancemenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.employeeAttendancemenuStrip;
            this.MaximizeBox = false;
            this.Name = "EmployeeAttendanceTracking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Attendance Tracking";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeeAttendanceTracking_FormClosing);
            this.Load += new System.EventHandler(this.EmployeeAttendanceTracking_Load);
            this.employeeAttendanceTabControl.ResumeLayout(false);
            this.authenticationTab.ResumeLayout(false);
            this.authenticationTab.PerformLayout();
            this.authenticationGroupBox.ResumeLayout(false);
            this.authenticationGroupBox.PerformLayout();
            this.attendanceTab.ResumeLayout(false);
            this.attendanceGroupBox.ResumeLayout(false);
            this.attendanceGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileImageBox)).EndInit();
            this.providerNameTextBox.ResumeLayout(false);
            this.providerNameTextBox.PerformLayout();
            this.dbConnectionConfigGroupBox.ResumeLayout(false);
            this.dbConnectionConfigGroupBox.PerformLayout();
            this.serialPortConfigGroupBox.ResumeLayout(false);
            this.serialPortConfigGroupBox.PerformLayout();
            this.employeeAttendancemenuStrip.ResumeLayout(false);
            this.employeeAttendancemenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl employeeAttendanceTabControl;
        private System.Windows.Forms.TabPage providerNameTextBox;
        private System.Windows.Forms.TabPage attendanceTab;
        private System.Windows.Forms.RadioButton defaultRadioButton;
        private System.Windows.Forms.TabPage authenticationTab;
        private System.Windows.Forms.GroupBox authenticationGroupBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passowordTextBox;
        private System.Windows.Forms.TextBox userIdTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip employeeAttendancemenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authenticationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Label loginStatusLabel;
        private System.Windows.Forms.RadioButton configureManuallyradioButton;
        private System.Windows.Forms.GroupBox dbConnectionConfigGroupBox;
        private System.Windows.Forms.GroupBox serialPortConfigGroupBox;
        private System.Windows.Forms.GroupBox attendanceGroupBox;
        private System.Windows.Forms.Label timeAndDateLabel;
        private System.Windows.Forms.Label employeeIdLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label attendanceLabelStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label employeeNameLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox profileImageBox;
        private System.Windows.Forms.ComboBox comPortComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox baudRateComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button applySerialConfigButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.TextBox dbUserIdTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox serverNameTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox dbPasswordTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox dbNameTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button applyDbConfigButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label label16;
    }
}