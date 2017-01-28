using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Attendance.BLL;
using Attendance.Model;

namespace Attendance.UI
{
    public partial class EmployeeAttendanceTracking : Form
    {
        AdminManager _adminManager = new AdminManager();
        AttendanceManager _attendanceManager = new AttendanceManager();

        public EmployeeAttendanceTracking()
        {
            InitializeComponent();
        }

        private void EmployeeAttendanceTracking_Load(object sender, EventArgs e)
        {
            logoutToolStripMenuItem.Enabled = false;
            DisableTabPage();
            LoadComPorts();
            BaudRate();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            TryToLogin();
        }

        private void EmployeeAttendanceTracking_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginStatusLabel.Text = String.Empty;
            LogOut();
        }

        private void TryToLogin()
        {
            var admin = new Admin
            {
                UserId = userIdTextBox.Text.Trim(),
                Password = passowordTextBox.Text.Trim()
            };
            ArrayList statusList = _adminManager.Login(admin);
            if ((bool) statusList[0])
            {
                ClearAuthenticationFields();
                authenticationGroupBox.Enabled = false;
                logoutToolStripMenuItem.Enabled = true;
                EnableTabPage();
            }
            loginStatusLabel.Text = statusList[1].ToString();
        }

        private void LogOut()
        {
            authenticationGroupBox.Enabled = true;
            logoutToolStripMenuItem.Enabled = false;
            ClearAuthenticationFields();
            DisableTabPage();
            loginStatusLabel.Text = @"Logged Out.";
        }

        private void DisableTabPage()
        {
            providerNameTextBox.Enabled = false;
            attendanceTab.Enabled = false;
        }

        private void EnableTabPage()
        {
            providerNameTextBox.Enabled = true;
            attendanceTab.Enabled = true;
        }

        private void ClearAuthenticationFields()
        {
            userIdTextBox.Clear();
            passowordTextBox.Clear();
        }

        private void LoadComPorts()
        {
            foreach (string portName in SerialPort.GetPortNames())
            {
                comPortComboBox.Items.Add(portName);
                if (portName == "COM4")
                {
                    comPortComboBox.SelectedItem = portName;
                }
            }
        }

        private void BaudRate()
        {
            List<string> baudRates = new List<string>
            {
                "2400", "4800", "9600", "14400", "19200", "28800", "38400", "57600", "115200"
            };
            baudRateComboBox.DataSource = baudRates;
            baudRateComboBox.SelectedItem = baudRates[2];
        }
    }
}
