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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Attendance.BLL;
using Attendance.Model;
using Attendance.ViewModel;

namespace Attendance.UI
{
    public partial class EmployeeAttendanceTracking : Form
    {
        AdminManager _adminManager = new AdminManager();
        AttendanceManager _attendanceManager = new AttendanceManager();
        public static SerialPort port;
        private BackgroundWorker hardWorker;

        private Thread readThread = null;

        public EmployeeAttendanceTracking()
        {
            InitializeComponent();
            hardWorker = new BackgroundWorker();
        }

        private void EmployeeAttendanceTracking_Load(object sender, EventArgs e)
        {
            logoutToolStripMenuItem.Enabled = false;
            DisableTabPage();
            LoadComPorts();
            BaudRate();
            //TestSomething();
        }

        private void TestSomething()
        {
            MessageBox.Show(DateTime.Now.Month.ToString() +" "+ DateTime.Now.Year.ToString());
            MessageBox.Show(DateTime.Now.ToString("dddd"));
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            TryToLogin();
        }

        private void EmployeeAttendanceTracking_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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

        private void connectButton_Click(object sender, EventArgs e)
        {
            IContainer components = new Container();
            port = new SerialPort(components);
            port.PortName = comPortComboBox.SelectedItem.ToString();
            port.BaudRate = Int32.Parse(baudRateComboBox.SelectedItem.ToString());
            port.DtrEnable = true;
            port.ReadTimeout = 5000;
            port.WriteTimeout = 500;
            port.Open();

            readThread = new Thread(new ThreadStart(this.Read));
            readThread.Start();
            this.hardWorker.RunWorkerAsync();

            connectButton.Enabled = false;
        }

        private void Read()
        {
            while (port.IsOpen)
            {
                try
                {
                    string rfid = port.ReadLine();
                    //MessageBox.Show(rfid);
                    EmployeeProfileRfid employeeProfileRfid = _attendanceManager.AssignAttendanceInfo(rfid);

                    Task.Delay(1000);
                }
                catch (TimeoutException)
                {
                    
                }
            }
        }
    }
}
