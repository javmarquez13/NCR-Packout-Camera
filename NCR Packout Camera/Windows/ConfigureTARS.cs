using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCR_Packout_Camera
{
	public partial class ConfigureTARS : Form
	{
		public ConfigureTARS()
		{
			InitializeComponent();
		}

		private void ConfigureTARS_Load(object sender, EventArgs e)
		{
            //this.DesktopLocation = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Height);

            // Load current parameter values into text boxes
            txCustomer.Text = Properties.Settings.Default.Tars_Customer;
			txtResource.Text = Properties.Settings.Default.Tars_Equipment;
			txOutputPath.Text = Properties.Settings.Default.Tars_Path;
			txtStepName.Text = Properties.Settings.Default.Tars_Process;
			txAssembly.Text = Properties.Settings.Default.Tars_Assembly;
            txtOutputXML.Text = Properties.Settings.Default.XML_Path;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			// This executes when Save button has been pressed
			// This will save parameter values from text boxes and close form

			Properties.Settings.Default.Tars_Customer = txCustomer.Text;
			Properties.Settings.Default.Tars_Equipment = txtResource.Text;
			Properties.Settings.Default.Tars_Path = txOutputPath.Text;
			Properties.Settings.Default.Tars_Process = txtStepName.Text;
            Properties.Settings.Default.XML_Path = txtOutputXML.Text;
			//Properties.Settings.Default.Tars_Assembly = txAssembly.Text;
			Properties.Settings.Default.Save();
			this.Close();
		}

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void ConfigureTARS_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnReadIniFile_Click(object sender, EventArgs e)
        {
            string pathConfig = @"\\mxchim0pangea01\AUTOMATION_SSCO\NCR PACKOUT CAMERAS\Configuration.ini";


            if (rbtnVideoValidation1.Checked)
            {
                txtResource.Text = INIConfig.reader(rbtnVideoValidation1.Text, "RESOURCE", pathConfig);
                txtStepName.Text = INIConfig.reader(rbtnVideoValidation1.Text, "STEPNAME", pathConfig);
                txtOutputXML.Text = INIConfig.reader(rbtnVideoValidation1.Text, "OUTPUTXML", pathConfig);
            }

            if (rbtnVideoValidation2.Checked)
            {
                txtResource.Text = INIConfig.reader(rbtnVideoValidation2.Text, "RESOURCE", pathConfig);
                txtStepName.Text = INIConfig.reader(rbtnVideoValidation2.Text, "STEPNAME", pathConfig);
                txtOutputXML.Text = INIConfig.reader(rbtnVideoValidation2.Text, "OUTPUTXML", pathConfig);
            }

            if (rbtnVideoValidation3.Checked)
            {
                txtResource.Text = INIConfig.reader(rbtnVideoValidation3.Text, "RESOURCE", pathConfig);
                txtStepName.Text = INIConfig.reader(rbtnVideoValidation3.Text, "STEPNAME", pathConfig);
                txtOutputXML.Text = INIConfig.reader(rbtnVideoValidation3.Text, "OUTPUTXML", pathConfig);
            }

            if (rbtnKitVideo.Checked)
            {
                txtResource.Text = INIConfig.reader(rbtnKitVideo.Text, "RESOURCE", pathConfig);
                txtStepName.Text = INIConfig.reader(rbtnKitVideo.Text, "STEPNAME", pathConfig);
                txtOutputXML.Text = INIConfig.reader(rbtnKitVideo.Text, "OUTPUTXML", pathConfig);
            }

            this.Refresh();
        }
    }
}
