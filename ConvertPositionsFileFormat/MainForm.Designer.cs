namespace ConvertPositionsFileFormat
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
            this.cmdFindPath2Convert = new System.Windows.Forms.Button();
            this.cmdSelectFolder = new System.Windows.Forms.Button();
            this.tbPathFile2Convert = new System.Windows.Forms.TextBox();
            this.tbPathFileResult = new System.Windows.Forms.TextBox();
            this.cmdConvert = new System.Windows.Forms.Button();
            this.cmdUndo = new System.Windows.Forms.Button();
            this.labelPathFile2Convert = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.tbWeekNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTimeOfWeekStart = new System.Windows.Forms.TextBox();
            this.lbDeltaTime = new System.Windows.Forms.Label();
            this.tbDeltaTime = new System.Windows.Forms.TextBox();
            this.tbApplicationInfo = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // cmdFindPath2Convert
            // 
            this.cmdFindPath2Convert.Location = new System.Drawing.Point(571, 12);
            this.cmdFindPath2Convert.Name = "cmdFindPath2Convert";
            this.cmdFindPath2Convert.Size = new System.Drawing.Size(34, 23);
            this.cmdFindPath2Convert.TabIndex = 0;
            this.cmdFindPath2Convert.Text = "...";
            this.cmdFindPath2Convert.UseVisualStyleBackColor = true;
            this.cmdFindPath2Convert.Click += new System.EventHandler(this.cmdFindPath2Convert_Click);
            // 
            // cmdSelectFolder
            // 
            this.cmdSelectFolder.Location = new System.Drawing.Point(571, 41);
            this.cmdSelectFolder.Name = "cmdSelectFolder";
            this.cmdSelectFolder.Size = new System.Drawing.Size(34, 23);
            this.cmdSelectFolder.TabIndex = 1;
            this.cmdSelectFolder.Text = "...";
            this.cmdSelectFolder.UseVisualStyleBackColor = true;
            this.cmdSelectFolder.Click += new System.EventHandler(this.cmdSelectFolder_Click);
            // 
            // tbPathFile2Convert
            // 
            this.tbPathFile2Convert.Location = new System.Drawing.Point(118, 15);
            this.tbPathFile2Convert.Name = "tbPathFile2Convert";
            this.tbPathFile2Convert.Size = new System.Drawing.Size(447, 20);
            this.tbPathFile2Convert.TabIndex = 2;
            // 
            // tbPathFileResult
            // 
            this.tbPathFileResult.Location = new System.Drawing.Point(118, 44);
            this.tbPathFileResult.Name = "tbPathFileResult";
            this.tbPathFileResult.Size = new System.Drawing.Size(447, 20);
            this.tbPathFileResult.TabIndex = 3;
            // 
            // cmdConvert
            // 
            this.cmdConvert.Location = new System.Drawing.Point(118, 165);
            this.cmdConvert.Name = "cmdConvert";
            this.cmdConvert.Size = new System.Drawing.Size(75, 23);
            this.cmdConvert.TabIndex = 4;
            this.cmdConvert.Text = "Convert";
            this.cmdConvert.UseVisualStyleBackColor = true;
            this.cmdConvert.Click += new System.EventHandler(this.cmdConvert_Click);
            // 
            // cmdUndo
            // 
            this.cmdUndo.Location = new System.Drawing.Point(490, 165);
            this.cmdUndo.Name = "cmdUndo";
            this.cmdUndo.Size = new System.Drawing.Size(75, 23);
            this.cmdUndo.TabIndex = 5;
            this.cmdUndo.Text = "Undo";
            this.cmdUndo.UseVisualStyleBackColor = true;
            // 
            // labelPathFile2Convert
            // 
            this.labelPathFile2Convert.AutoSize = true;
            this.labelPathFile2Convert.Location = new System.Drawing.Point(12, 18);
            this.labelPathFile2Convert.Name = "labelPathFile2Convert";
            this.labelPathFile2Convert.Size = new System.Drawing.Size(100, 13);
            this.labelPathFile2Convert.TabIndex = 6;
            this.labelPathFile2Convert.Text = "Path File to Convert";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Path Result";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.onSelectFile2Convert);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Week Number";
            // 
            // tbWeekNumber
            // 
            this.tbWeekNumber.Location = new System.Drawing.Point(118, 70);
            this.tbWeekNumber.Name = "tbWeekNumber";
            this.tbWeekNumber.Size = new System.Drawing.Size(75, 20);
            this.tbWeekNumber.TabIndex = 8;
            this.tbWeekNumber.Text = "1910";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Time Of Week Start";
            // 
            // tbTimeOfWeekStart
            // 
            this.tbTimeOfWeekStart.Location = new System.Drawing.Point(118, 96);
            this.tbTimeOfWeekStart.Name = "tbTimeOfWeekStart";
            this.tbTimeOfWeekStart.Size = new System.Drawing.Size(75, 20);
            this.tbTimeOfWeekStart.TabIndex = 10;
            this.tbTimeOfWeekStart.Text = "20000";
            // 
            // lbDeltaTime
            // 
            this.lbDeltaTime.AutoSize = true;
            this.lbDeltaTime.Location = new System.Drawing.Point(12, 125);
            this.lbDeltaTime.Name = "lbDeltaTime";
            this.lbDeltaTime.Size = new System.Drawing.Size(72, 13);
            this.lbDeltaTime.TabIndex = 13;
            this.lbDeltaTime.Text = "Delta Time (s)";
            // 
            // tbDeltaTime
            // 
            this.tbDeltaTime.Location = new System.Drawing.Point(118, 122);
            this.tbDeltaTime.Name = "tbDeltaTime";
            this.tbDeltaTime.Size = new System.Drawing.Size(75, 20);
            this.tbDeltaTime.TabIndex = 12;
            this.tbDeltaTime.Text = "1";
            // 
            // tbApplicationInfo
            // 
            this.tbApplicationInfo.Location = new System.Drawing.Point(-1, 218);
            this.tbApplicationInfo.Name = "tbApplicationInfo";
            this.tbApplicationInfo.Size = new System.Drawing.Size(606, 20);
            this.tbApplicationInfo.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 235);
            this.Controls.Add(this.tbApplicationInfo);
            this.Controls.Add(this.lbDeltaTime);
            this.Controls.Add(this.tbDeltaTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTimeOfWeekStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbWeekNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPathFile2Convert);
            this.Controls.Add(this.cmdUndo);
            this.Controls.Add(this.cmdConvert);
            this.Controls.Add(this.tbPathFileResult);
            this.Controls.Add(this.tbPathFile2Convert);
            this.Controls.Add(this.cmdSelectFolder);
            this.Controls.Add(this.cmdFindPath2Convert);
            this.Name = "MainForm";
            this.Text = "Converter File Formats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdFindPath2Convert;
        private System.Windows.Forms.Button cmdSelectFolder;
        private System.Windows.Forms.TextBox tbPathFile2Convert;
        private System.Windows.Forms.TextBox tbPathFileResult;
        private System.Windows.Forms.Button cmdConvert;
        private System.Windows.Forms.Button cmdUndo;
        private System.Windows.Forms.Label labelPathFile2Convert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbWeekNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTimeOfWeekStart;
        private System.Windows.Forms.Label lbDeltaTime;
        private System.Windows.Forms.TextBox tbDeltaTime;
        private System.Windows.Forms.TextBox tbApplicationInfo;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}

