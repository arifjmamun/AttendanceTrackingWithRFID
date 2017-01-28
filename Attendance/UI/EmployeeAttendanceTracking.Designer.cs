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
            this.connectionTab = new System.Windows.Forms.TabPage();
            this.defaultRadioButton = new System.Windows.Forms.RadioButton();
            this.configureManuallyradioButton = new System.Windows.Forms.RadioButton();
            this.dbConnectionConfigGroupBox = new System.Windows.Forms.GroupBox();
            this.serialPortConfigGroupBox = new System.Windows.Forms.GroupBox();
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
            this.employeeAttendanceTabControl.SuspendLayout();
            this.authenticationTab.SuspendLayout();
            this.authenticationGroupBox.SuspendLayout();
            this.connectionTab.SuspendLayout();
            this.employeeAttendancemenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeAttendanceTabControl
            // 
            this.employeeAttendanceTabControl.Controls.Add(this.authenticationTab);
            this.employeeAttendanceTabControl.Controls.Add(this.attendanceTab);
            this.employeeAttendanceTabControl.Controls.Add(this.connectionTab);
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
            this.attendanceTab.Location = new System.Drawing.Point(4, 22);
            this.attendanceTab.Name = "attendanceTab";
            this.attendanceTab.Padding = new System.Windows.Forms.Padding(3);
            this.attendanceTab.Size = new System.Drawing.Size(725, 345);
            this.attendanceTab.TabIndex = 1;
            this.attendanceTab.Text = "Attendance";
            this.attendanceTab.UseVisualStyleBackColor = true;
            // 
            // connectionTab
            // 
            this.connectionTab.Controls.Add(this.defaultRadioButton);
            this.connectionTab.Controls.Add(this.configureManuallyradioButton);
            this.connectionTab.Controls.Add(this.dbConnectionConfigGroupBox);
            this.connectionTab.Controls.Add(this.serialPortConfigGroupBox);
            this.connectionTab.Location = new System.Drawing.Point(4, 22);
            this.connectionTab.Name = "connectionTab";
            this.connectionTab.Padding = new System.Windows.Forms.Padding(3);
            this.connectionTab.Size = new System.Drawing.Size(725, 345);
            this.connectionTab.TabIndex = 0;
            this.connectionTab.Text = "Connection";
            this.connectionTab.UseVisualStyleBackColor = true;
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
            this.dbConnectionConfigGroupBox.Location = new System.Drawing.Point(364, 56);
            this.dbConnectionConfigGroupBox.Name = "dbConnectionConfigGroupBox";
            this.dbConnectionConfigGroupBox.Size = new System.Drawing.Size(353, 243);
            this.dbConnectionConfigGroupBox.TabIndex = 2;
            this.dbConnectionConfigGroupBox.TabStop = false;
            this.dbConnectionConfigGroupBox.Text = "Database Connection Configuration";
            // 
            // serialPortConfigGroupBox
            // 
            this.serialPortConfigGroupBox.Location = new System.Drawing.Point(8, 56);
            this.serialPortConfigGroupBox.Name = "serialPortConfigGroupBox";
            this.serialPortConfigGroupBox.Size = new System.Drawing.Size(350, 243);
            this.serialPortConfigGroupBox.TabIndex = 2;
            this.serialPortConfigGroupBox.TabStop = false;
            this.serialPortConfigGroupBox.Text = "Serial Port Connection Configuration";
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
            this.connectionTab.ResumeLayout(false);
            this.connectionTab.PerformLayout();
            this.employeeAttendancemenuStrip.ResumeLayout(false);
            this.employeeAttendancemenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl employeeAttendanceTabControl;
        private System.Windows.Forms.TabPage connectionTab;
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
    }
}