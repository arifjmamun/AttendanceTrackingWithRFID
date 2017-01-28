using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Attendance.BLL;

namespace Attendance
{
    public partial class EmployeeAttendanceForm : Form
    {
        AttendanceManager _attendanceManager = new AttendanceManager();
        SerialPort sp = new SerialPort("COM4",9600,Parity.None,8,StopBits.One);
        public EmployeeAttendanceForm()
        {
            InitializeComponent();
        }

        private void EmployeeAttendanceForm_Load(object sender, EventArgs e)
        {
            //statusLabel.Text = _attendanceManager.GetTotalEntry();

        }


        private void InitiateSerialConnection()
        {
            //Set the datareceived event handler
            sp.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
            //Open the serial port
            sp.Open();
            //Read from the console, to stop it from closing.
            Console.Read();
        }


        private void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //Write the serial port data to the console.
            Console.Write(sp.ReadExisting());
        }
    }
}
