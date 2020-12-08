using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCUD
{
    public partial class Create : Form
    {
        string ConnString = "Data Source=.;Initial Catalog=AMS;Integrated Security=True";
        private SerialPort RFID;
        private string DispString;
        public Create()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void RFID_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
                DispString = RFID.ReadExisting();
                this.Invoke(new EventHandler(DisplayText));
        }
        private void DisplayText(object sender, EventArgs e)
        {
            string DispString1 = new string(DispString.Where(c => char.IsLetter(c) || char.IsDigit(c)).ToArray()); //Оставляем только нужное
            tbCardNumber.AppendText(DispString1);
        }
        private void btn_ReadCard_Click(object sender, EventArgs e)
        {
            RFID = new SerialPort();
            RFID.PortName = "COM6";
            RFID.BaudRate = 9600;
            RFID.DataBits = 8;
            RFID.Parity = Parity.None;
            RFID.StopBits = StopBits.One;
            RFID.Open();
            RFID.ReadTimeout = 200;
            if (RFID.IsOpen)
            {
                DispString = "";
                tbCardNumber.Text = "";
            }
            else
            {
                RFID.Close();
            }
            RFID.DataReceived += new SerialDataReceivedEventHandler(RFID_DataReceived);
        }
    }
}
