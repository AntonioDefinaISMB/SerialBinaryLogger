using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Reflection;

namespace SerialBinaryLogger
{
    public partial class MainForm : Form
    {
        public delegate void TOnWrite(string Write);
        
        private BinaryWriter    logFile;
        private event TOnWrite  onWrite;
        private int             counterBytesRead    = 0;
        private int             SEGMENT_SYNC_FILE   = 0;
        private int             bytesNextFileSync   = 0;

        public MainForm()
        {
            InitializeComponent();
            UpdateCOMList();

            onWrite += new TOnWrite(RealUpdateStatusWrite);

            Version version = Assembly.GetEntryAssembly().GetName().Version;

            this.Text = "Serial Binary Logger v" + version.ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                SEGMENT_SYNC_FILE = int.Parse(tbRefreshFileBytes.Text);
                bytesNextFileSync = SEGMENT_SYNC_FILE;

                if (InitializeBinaryLog(tbFileLog.Text) == false)
                {
                    NotifyStatus("UNABLE TO CREATE FILE! STOPPED");
                    return;
                }

                if (OpenSerialPort(cbbComPorts.Text, int.Parse(tbCOMSpeed.Text)) == true)
                {
                    NotifyStatus("OPEN SERIAL SUCCESS. START LOGGER");
                    SetFormApplicationRunning(true);
                }
            }
            catch (Exception ex)
            {
                NotifyStatus("FAILED OPEN SERIAL PORT");
                MessageBox.Show(ex.Message);
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                byte[] buffer = new byte[serialPort1.BytesToRead];
                serialPort1.Read(buffer, 0, buffer.Length);

                if (logFile != null)
                {
                    logFile.Write(buffer);
                }

                counterBytesRead += buffer.Length;

                if(counterBytesRead> bytesNextFileSync)
                {
                    logFile.Flush();
                    bytesNextFileSync += SEGMENT_SYNC_FILE;
                    UpdateStatusWriting("WRITTEN " + counterBytesRead + " BYTES ON FILE");
                }

            }
            catch (Exception ex)
            {
                UpdateStatusWriting(ex.Message);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
                logFile.Close();
                SetFormApplicationRunning(false);
                NotifyStatus("STOP LOGGER");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void SetFormApplicationRunning(bool flagIsRunning)
        {
            btnStart.Enabled    = !flagIsRunning;
            cbbComPorts.Enabled = !flagIsRunning;
            tbCOMSpeed.Enabled  = !flagIsRunning;
            tbFileLog.Enabled   = !flagIsRunning;
        }

        private void btnFilePath_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            tbFileLog.Text = saveFileDialog1.FileName;
        }

        private void btnUpdateCOMList_Click(object sender, EventArgs e)
        {
            UpdateCOMList();
        }

        private void NotifyStatus(string message)
        {
            this.Text = message;
        }

        private bool OpenSerialPort(string COMPort,int COMSpeed)
        {
            try
            {
                serialPort1.BaudRate    = COMSpeed;
                serialPort1.Parity      = Parity.None;
                serialPort1.DataBits    = 8;
                serialPort1.StopBits    = StopBits.One;

                serialPort1.PortName = COMPort;
                serialPort1.Open();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool InitializeBinaryLog(string pathFile)
        {
            try
            {
                if (pathFile.Length > 0)
                {
                    logFile = new BinaryWriter(new FileStream(pathFile, FileMode.Create));

                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void UpdateStatusWriting(string message)
        {
            if(onWrite!=null)
                this.Invoke(onWrite, new object[] { message });
        }  

        private void RealUpdateStatusWrite(string message)
        {
            this.tbStatusWriting.Text   = message;
            this.tbStatus.ForeColor     = this.tbStatus.ForeColor == Color.Red ? Color.Green : Color.Red;
            this.tbStatus.BackColor     = this.tbStatus.BackColor== Color.Red ? Color.Green : Color.Red;
        }

        private void UpdateCOMList()
        {
            string[] strListPort = SerialPort.GetPortNames();

            if (strListPort != null)
            {
                cbbComPorts.Items.AddRange(strListPort);
            }
        }
    }
}
