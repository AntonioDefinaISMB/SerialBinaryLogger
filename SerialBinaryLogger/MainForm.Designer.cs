namespace SerialBinaryLogger
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.cbbComPorts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tbFileLog = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFilePath = new System.Windows.Forms.Button();
            this.btnUpdateCOMList = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCOMSpeed = new System.Windows.Forms.TextBox();
            this.tbStatusWriting = new System.Windows.Forms.TextBox();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.tbRefreshFileBytes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.PortName = "COM13";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(103, 150);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(230, 150);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // cbbComPorts
            // 
            this.cbbComPorts.FormattingEnabled = true;
            this.cbbComPorts.Location = new System.Drawing.Point(103, 10);
            this.cbbComPorts.Name = "cbbComPorts";
            this.cbbComPorts.Size = new System.Drawing.Size(121, 21);
            this.cbbComPorts.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Comport";
            // 
            // tbFileLog
            // 
            this.tbFileLog.Location = new System.Drawing.Point(103, 108);
            this.tbFileLog.Name = "tbFileLog";
            this.tbFileLog.Size = new System.Drawing.Size(226, 20);
            this.tbFileLog.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Log File Path";
            // 
            // btnFilePath
            // 
            this.btnFilePath.Location = new System.Drawing.Point(335, 108);
            this.btnFilePath.Name = "btnFilePath";
            this.btnFilePath.Size = new System.Drawing.Size(47, 23);
            this.btnFilePath.TabIndex = 6;
            this.btnFilePath.Text = "...";
            this.btnFilePath.UseVisualStyleBackColor = true;
            this.btnFilePath.Click += new System.EventHandler(this.btnFilePath_Click);
            // 
            // btnUpdateCOMList
            // 
            this.btnUpdateCOMList.Location = new System.Drawing.Point(235, 10);
            this.btnUpdateCOMList.Name = "btnUpdateCOMList";
            this.btnUpdateCOMList.Size = new System.Drawing.Size(99, 23);
            this.btnUpdateCOMList.TabIndex = 7;
            this.btnUpdateCOMList.Text = "Update COM List";
            this.btnUpdateCOMList.UseVisualStyleBackColor = true;
            this.btnUpdateCOMList.Click += new System.EventHandler(this.btnUpdateCOMList_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Speed";
            // 
            // tbCOMSpeed
            // 
            this.tbCOMSpeed.Location = new System.Drawing.Point(103, 46);
            this.tbCOMSpeed.Name = "tbCOMSpeed";
            this.tbCOMSpeed.Size = new System.Drawing.Size(121, 20);
            this.tbCOMSpeed.TabIndex = 9;
            this.tbCOMSpeed.Text = "115200";
            // 
            // tbStatusWriting
            // 
            this.tbStatusWriting.Location = new System.Drawing.Point(-1, 178);
            this.tbStatusWriting.Name = "tbStatusWriting";
            this.tbStatusWriting.Size = new System.Drawing.Size(459, 20);
            this.tbStatusWriting.TabIndex = 10;
            // 
            // tbStatus
            // 
            this.tbStatus.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tbStatus.Location = new System.Drawing.Point(335, 152);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(100, 20);
            this.tbStatus.TabIndex = 11;
            // 
            // tbRefreshFileBytes
            // 
            this.tbRefreshFileBytes.Location = new System.Drawing.Point(103, 82);
            this.tbRefreshFileBytes.Name = "tbRefreshFileBytes";
            this.tbRefreshFileBytes.Size = new System.Drawing.Size(121, 20);
            this.tbRefreshFileBytes.TabIndex = 13;
            this.tbRefreshFileBytes.Text = "10000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Refresh File Bytes";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 197);
            this.Controls.Add(this.tbRefreshFileBytes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.tbStatusWriting);
            this.Controls.Add(this.tbCOMSpeed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUpdateCOMList);
            this.Controls.Add(this.btnFilePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFileLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbComPorts);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Serial Logger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ComboBox cbbComPorts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox tbFileLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFilePath;
        private System.Windows.Forms.Button btnUpdateCOMList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCOMSpeed;
        private System.Windows.Forms.TextBox tbStatusWriting;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.TextBox tbRefreshFileBytes;
        private System.Windows.Forms.Label label4;
    }
}

