using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TechLab_IDE
{
    public partial class Terminal : Form
    {
        SerialPort _serialPort;
        bool _connected = false;
        private delegate void RecvDeleg(string text);
        string port = "COM1";

        public Terminal()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _serialPort.Write(InputBox.Text);
            InputBox.Text = "";
        }

        void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = _serialPort.ReadLine();
            this.BeginInvoke(new RecvDeleg(si_DataReceived),
                             new object[] { data });
        }

        private void si_DataReceived(string input)
        {
            try
            {
                if (input.Length > 0)
                {
                    OutputBox.Text += input;
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (_serialPort.IsOpen)
                    _serialPort.Close();

                _serialPort = new SerialPort(port,
                                            int.Parse(comboBox1.SelectedItem.ToString()),
                                            Parity.None,
                                            8,
                                            StopBits.One);
                _serialPort.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
                _serialPort.Open();
            }
            catch(Exception ex)
            {

            }
        }

        public void setport(string _port)
        {
            port = _port;
            _serialPort = new SerialPort(port,
                                        int.Parse(comboBox1.SelectedItem.ToString()),
                                        Parity.None,
                                        8,
                                        StopBits.One);
            _serialPort.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
            _serialPort.Open();
        }

        private void Terminal_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_serialPort.IsOpen)
            {
                _serialPort.Close();
            }
        }

        private void InputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)ConsoleKey.Enter)
            {
                _serialPort.Write(InputBox.Text);
                InputBox.Text = "";
            }
        }
    }
}
