using System;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

namespace ConvertPositionsFileFormat
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Version version = Assembly.GetEntryAssembly().GetName().Version;

            this.Text = "Conversion File Format v" + version.ToString();
        }

        private void cmdFindPath2Convert_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void onSelectFile2Convert(object sender, CancelEventArgs e)
        {
            String pathFile = openFileDialog.FileName.ToString();

            tbPathFile2Convert.Text = pathFile;
        }

        private void cmdConvert_Click(object sender, EventArgs e)
        {
            int     WeekNumber;
            double  TimeOfWeekStart;
            double  DeltaTime;
            String  PathFileInput;
            String  PathFileOutput;


            PathFileInput   = tbPathFile2Convert.Text;
            PathFileOutput  = tbPathFileResult.Text;

            WeekNumber      = int.Parse(tbWeekNumber.Text);
            TimeOfWeekStart = double.Parse(tbTimeOfWeekStart.Text);
            DeltaTime       = double.Parse(tbDeltaTime.Text);

            if (FileParser.ConvertTNTFile2ASSISTPos(PathFileInput, PathFileOutput, WeekNumber, TimeOfWeekStart, DeltaTime) == false)
            {
                WriteInfo("FAILED CONVERSION");
            }
            else
            {
                WriteInfo("CONVERSION DONE");
            }
        }

        private void WriteInfo(String info)
        {
            tbApplicationInfo.Text = info;
        }

        private void cmdSelectFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();

            tbPathFileResult.Text = folderBrowserDialog.SelectedPath+"\\";
        }
    }
}
