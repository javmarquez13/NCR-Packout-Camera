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
using Ozeki.Camera;
using Ozeki.Media;

namespace NCR_Packout_Camera
{
	public partial class CameraSetting : Form
	{
		private CameraURLBuilderWF _myCameraUrlBuilder_1;
		private OzekiCamera _camera_1;
		private MediaConnector _connector_1;
		private DrawingImageProvider _imageProvider_1;
		private CameraURLBuilderWF _myCameraUrlBuilder_2;
		private OzekiCamera _camera_2;
		private MediaConnector _connector_2;
		private DrawingImageProvider _imageProvider_2;
		private CameraURLBuilderWF _myCameraUrlBuilder_3;
		private OzekiCamera _camera_3;
		private MediaConnector _connector_3;
		private DrawingImageProvider _imageProvider_3;
		private CameraURLBuilderWF _myCameraUrlBuilder_4;
		private OzekiCamera _camera_4;
		private MediaConnector _connector_4;
		private DrawingImageProvider _imageProvider_4;
		private CameraURLBuilderWF _myCameraUrlBuilder_5;
		private OzekiCamera _camera_5;
		private MediaConnector _connector_5;
		private DrawingImageProvider _imageProvider_5;
		public static string cameraURL_1;
		public static string cameraURL_2;
		public static string cameraURL_3;
		public static string cameraURL_4;
		public static string cameraURL_5;


		public CameraSetting()
		{
			InitializeComponent();
			_imageProvider_1 = new DrawingImageProvider();
			_connector_1 = new MediaConnector();
			videoViewerWF_1.SetImageProvider(_imageProvider_1);
			_imageProvider_2 = new DrawingImageProvider();
			_connector_2 = new MediaConnector();
			videoViewerWF_2.SetImageProvider(_imageProvider_2);
			_imageProvider_3 = new DrawingImageProvider();
			_connector_3 = new MediaConnector();
			videoViewerWF_3.SetImageProvider(_imageProvider_3);
			_imageProvider_4 = new DrawingImageProvider();
			_connector_4 = new MediaConnector();
			videoViewerWF_4.SetImageProvider(_imageProvider_4);
			_imageProvider_5 = new DrawingImageProvider();
			_connector_5 = new MediaConnector();
			videoViewerWF_5.SetImageProvider(_imageProvider_5);         
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			// This executes when Save button is pressed
			// This will stop all camera preview and dispose objects
			// This will also save all configuration parameters and close form

			if (_camera_1 != null) // If camera 1 is running, then stop it
			{
				videoViewerWF_1.Stop();
				videoViewerWF_1.Dispose();
				_camera_1.Stop();				
				_connector_1.Disconnect(_camera_1.VideoChannel, _imageProvider_1);
				_connector_1.Dispose();
			}
			if (_camera_2 != null) // If camera 2 is running, then stop it
			{
				videoViewerWF_2.Stop();
				videoViewerWF_2.Dispose();
				_camera_2.Stop();
				_connector_2.Disconnect(_camera_2.VideoChannel, _imageProvider_2);
				_connector_2.Dispose();
			}
			if (_camera_3 != null) // If camera 3 is running, then stop it
			{
				videoViewerWF_3.Stop();
				videoViewerWF_3.Dispose();
				_camera_3.Stop();
				_connector_3.Disconnect(_camera_3.VideoChannel, _imageProvider_3);
				_connector_3.Dispose();
			}
			if (_camera_4 != null) // If camera 4 is running, then stop it
			{
				videoViewerWF_4.Stop();
				videoViewerWF_4.Dispose();
				_camera_4.Stop();
				_connector_4.Disconnect(_camera_4.VideoChannel, _imageProvider_4);
				_connector_4.Dispose();
			}
			if (_camera_5 != null) // If camera 5 is running, then stop it
			{
				videoViewerWF_5.Stop();
				videoViewerWF_5.Dispose();
				_camera_5.Stop();
				_connector_5.Disconnect(_camera_5.VideoChannel, _imageProvider_5);
				_connector_5.Dispose();
			}

			// Save all configuration parameters
			Properties.Settings.Default.CameraID_1 = lblCamera_1.Text;
			Properties.Settings.Default.CameraID_2 = lblCamera_2.Text;
			Properties.Settings.Default.CameraID_3 = lblCamera_3.Text;
			Properties.Settings.Default.CameraID_4 = lblCamera_4.Text;
			Properties.Settings.Default.CameraID_5 = lblCamera_5.Text;
			Properties.Settings.Default.SNLength_item = Convert.ToInt32(cboxSerialLength.SelectedIndex);
			Properties.Settings.Default.SNLength = Convert.ToInt32(cboxSerialLength.SelectedIndex) + 5;
			Properties.Settings.Default.LockSN = chBoxLockLength.Checked;
			Properties.Settings.Default.ValidatePrefix = chBoxPrefix.Checked;
			Properties.Settings.Default.Prefix = txBoxPrefix.Text;
			Properties.Settings.Default.OutputPath = txBoxOutput.Text;
			Properties.Settings.Default.VideoTime_1 = Convert.ToInt32(numVideoTime1.Value);
			Properties.Settings.Default.VideoTime_2 = Convert.ToInt32(numVideoTime2.Value);
			Properties.Settings.Default.VideoTime_3 = Convert.ToInt32(numVideoTime3.Value);
			Properties.Settings.Default.VideoTime_4 = Convert.ToInt32(numVideoTime4.Value);
			Properties.Settings.Default.VideoTime_5 = Convert.ToInt32(numVideoTime5.Value);
			Properties.Settings.Default.CamActive_1 = chBoxCamActive1.Checked;
			Properties.Settings.Default.CamActive_2 = chBoxCamActive2.Checked;
			Properties.Settings.Default.CamActive_3 = chBoxCamActive3.Checked;
			Properties.Settings.Default.CamActive_4 = chBoxCamActive4.Checked;
			Properties.Settings.Default.CamActive_5 = chBoxCamActive5.Checked;
			Properties.Settings.Default.CamAuto_1 = rbAuto1.Checked;
			Properties.Settings.Default.CamAuto_2 = rbAuto2.Checked;
			Properties.Settings.Default.CamAuto_3 = rbAuto3.Checked;
			Properties.Settings.Default.CamAuto_4 = rbAuto4.Checked;
			Properties.Settings.Default.CamAuto_5 = rbAuto5.Checked;
			Properties.Settings.Default.AutoStart = chkAutoStart.Checked;
			Properties.Settings.Default.EnableTars = chkReportFile.Checked;
            Properties.Settings.Default.EnableXML = chkXMLFile.Checked;
            Properties.Settings.Default.CheckParser = chBoxParser.Checked;
            Properties.Settings.Default.ParserName = txtParserName.Text;
            Properties.Settings.Default.QualityAlert = chBoxAlert.Checked;
            
      
            Properties.Settings.Default.Step_validation = chBoxStepValidation.Checked;
            Properties.Settings.Default.Step_Buttonup = rBtnButtonUp.Checked;
            Properties.Settings.Default.Step_AccessoriesInp = rBtnAccessoriesInp.Checked;
            Properties.Settings.Default.iFactoryInfo = chBoxIfactoryInfo.Checked;

			Properties.Settings.Default.Save();
			this.Close();
		}

		private void btnSelect1_Click(object sender, EventArgs e)
		{
			//This function will prompt user to select a camera device for camera 1

			lblErrorCam1.Visible = false;
			if (_camera_1 != null) // If camera 1 is running, then stop it
			{
				videoViewerWF_1.Stop();
				_camera_1.Stop();
				_connector_1.Disconnect(_camera_1.VideoChannel, _imageProvider_1);
			}
			try
			{
				_myCameraUrlBuilder_1 = new CameraURLBuilderWF();
				var result = _myCameraUrlBuilder_1.ShowDialog(); // Prompt list with camera devices
				if (result != DialogResult.OK) return;
				cameraURL_1 = _myCameraUrlBuilder_1.CameraURL.ToString();
				_camera_1 = new OzekiCamera(cameraURL_1);
				_connector_1.Connect(_camera_1.VideoChannel, _imageProvider_1);
				_camera_1.Start();
				videoViewerWF_1.Start(); // Start camera preview viewer
				lblCamera_1.Text = cameraURL_1;

                MessageBox.Show(cameraURL_1);
			}
			catch  // If an error ocurred when attempting to open camera 1 selected
			{
				lblCamera_1.Text = "Not configured";
				lblErrorCam1.Visible = true;
			}
		}

		private void btnSelect2_Click(object sender, EventArgs e)
		{
			//This function will prompt user to select a camera device for camera 2

			lblErrorCam2.Visible = false;
			if (_camera_2 != null) // If camera 2 is running, then stop it
			{
				videoViewerWF_2.Stop();
				_camera_2.Stop();
				_connector_2.Disconnect(_camera_2.VideoChannel, _imageProvider_2);
			}
			try
			{
				_myCameraUrlBuilder_2 = new CameraURLBuilderWF();
				var result = _myCameraUrlBuilder_2.ShowDialog(); // Prompt list with camera devices
				if (result != DialogResult.OK) return;
				cameraURL_2 = _myCameraUrlBuilder_2.CameraURL.ToString();
				_camera_2 = new OzekiCamera(cameraURL_2);
				_connector_2.Connect(_camera_2.VideoChannel, _imageProvider_2);
				_camera_2.Start();
				videoViewerWF_2.Start(); // Start camera preview viewer
				lblCamera_2.Text = cameraURL_2;
			}
			catch // If an error ocurred when attempting to open camera 2 selected
			{
				lblCamera_2.Text = "Not configured";
				lblErrorCam2.Visible = true;
			}

		}

		private void btnSelect3_Click(object sender, EventArgs e)
		{
			//This function will prompt user to select a camera device for camera 3

			lblErrorCam3.Visible = false;
			if (_camera_3 != null) // If camera 3 is running, then stop it
			{
				videoViewerWF_3.Stop();
				_camera_3.Stop();
				_connector_3.Disconnect(_camera_3.VideoChannel, _imageProvider_3);
			}
			try
			{
				_myCameraUrlBuilder_3 = new CameraURLBuilderWF();
				var result = _myCameraUrlBuilder_3.ShowDialog(); // Prompt list with camera devices
				if (result != DialogResult.OK) return;
				cameraURL_3 = _myCameraUrlBuilder_3.CameraURL.ToString();
				_camera_3 = new OzekiCamera(cameraURL_3);
				_connector_3.Connect(_camera_3.VideoChannel, _imageProvider_3);
				_camera_3.Start();
				videoViewerWF_3.Start(); // Start camera preview viewer
				lblCamera_3.Text = cameraURL_3;
			}
			catch // If an error ocurred when attempting to open camera 3 selected
			{
				lblCamera_3.Text = "Not configured";
				lblErrorCam3.Visible = true;
			}
		}

		private void btnSelect4_Click(object sender, EventArgs e)
		{
			//This function will prompt user to select a camera device for camera 4

			lblErrorCam4.Visible = false;
			if (_camera_4 != null) // If camera 4 is running, then stop it
			{
				videoViewerWF_4.Stop();
				_camera_4.Stop();
				_connector_4.Disconnect(_camera_4.VideoChannel, _imageProvider_4);
			}
			try
			{
				_myCameraUrlBuilder_4 = new CameraURLBuilderWF();
				var result = _myCameraUrlBuilder_4.ShowDialog(); // Prompt list with camera devices
				if (result != DialogResult.OK) return;
				cameraURL_4 = _myCameraUrlBuilder_4.CameraURL.ToString();
				_camera_4 = new OzekiCamera(cameraURL_4);
				_connector_4.Connect(_camera_4.VideoChannel, _imageProvider_4);
				_camera_4.Start();
				videoViewerWF_4.Start(); // Start camera preview viewer
				lblCamera_4.Text = cameraURL_4;
			}
			catch // If an error ocurred when attempting to open camera 4 selected
			{
				lblCamera_4.Text = "Not configured";
				lblErrorCam4.Visible = true;
			}
		}

		private void btnSelect5_Click(object sender, EventArgs e)
		{
			//This function will prompt user to select a camera device for camera 5

			lblErrorCam5.Visible = false;
			if (_camera_5 != null) // If camera 5 is running, then stop it
			{
				videoViewerWF_5.Stop();
				_camera_5.Stop();
				_connector_5.Disconnect(_camera_5.VideoChannel, _imageProvider_5);
			}
			try
			{
				_myCameraUrlBuilder_5 = new CameraURLBuilderWF();
				var result = _myCameraUrlBuilder_5.ShowDialog(); // Prompt list with camera devices
				if (result != DialogResult.OK) return;
				cameraURL_5 = _myCameraUrlBuilder_5.CameraURL.ToString();
				_camera_5 = new OzekiCamera(cameraURL_5);
				_connector_5.Connect(_camera_5.VideoChannel, _imageProvider_5);
				_camera_5.Start(); 
				videoViewerWF_5.Start(); // Start camera preview viewer
				lblCamera_5.Text = cameraURL_5;
			}
			catch // If an error ocurred when attempting to open camera 5 selected
			{
				lblCamera_5.Text = "Not configured";
				lblErrorCam5.Visible = true;
			}
		}

		private void CameraSetting_Load(object sender, EventArgs e)
		{
			// Set all the controls with the current saved configuration parameters

			timer1.Enabled = true;
			btnSave.Enabled = false;
			txBoxPrefix.Enabled = false;
			lblErrorCam1.Visible = false;
			lblErrorCam2.Visible = false;
			lblErrorCam3.Visible = false;
			lblErrorCam4.Visible = false;
			lblErrorCam5.Visible = false;
			lblCamera_1.Text = Properties.Settings.Default.CameraID_1;
			lblCamera_2.Text = Properties.Settings.Default.CameraID_2;
			lblCamera_3.Text = Properties.Settings.Default.CameraID_3;
			lblCamera_4.Text = Properties.Settings.Default.CameraID_4;
			lblCamera_5.Text = Properties.Settings.Default.CameraID_5;
			cboxSerialLength.SelectedIndex = Properties.Settings.Default.SNLength_item;
			chBoxLockLength.Checked = Properties.Settings.Default.LockSN;
			chBoxPrefix.Checked = Properties.Settings.Default.ValidatePrefix;
			numVideoTime1.Value = Properties.Settings.Default.VideoTime_1;
			numVideoTime2.Value = Properties.Settings.Default.VideoTime_2;
			numVideoTime3.Value = Properties.Settings.Default.VideoTime_3;
			numVideoTime4.Value = Properties.Settings.Default.VideoTime_4;
			numVideoTime5.Value = Properties.Settings.Default.VideoTime_5;
			chBoxCamActive1.Checked = Properties.Settings.Default.CamActive_1;
			chBoxCamActive2.Checked = Properties.Settings.Default.CamActive_2;
			chBoxCamActive3.Checked = Properties.Settings.Default.CamActive_3;
			chBoxCamActive4.Checked = Properties.Settings.Default.CamActive_4;
			chBoxCamActive5.Checked = Properties.Settings.Default.CamActive_5;
			chkAutoStart.Checked = Properties.Settings.Default.AutoStart;
			chkReportFile.Checked = Properties.Settings.Default.EnableTars;
            chBoxStepValidation.Checked = Properties.Settings.Default.Step_validation;
            rBtnButtonUp.Checked = Properties.Settings.Default.Step_Buttonup;
            rBtnAccessoriesInp.Checked = Properties.Settings.Default.Step_AccessoriesInp;
            chBoxIfactoryInfo.Checked = Properties.Settings.Default.iFactoryInfo;
            chkXMLFile.Checked = Properties.Settings.Default.EnableXML;
            chBoxParser.Checked = Properties.Settings.Default.CheckParser;
            txtParserName.Text = Properties.Settings.Default.ParserName;
            chBoxAlert.Checked = Properties.Settings.Default.QualityAlert;

			if (Properties.Settings.Default.CamActive_1)
			{
				grpCam1.Enabled = true;
				rbAuto1.Enabled = true;
				rbManual1.Enabled = true;
				numVideoTime1.Enabled = true;
				lblTime1.Enabled = true;
			}
			if (!Properties.Settings.Default.CamActive_1)
			{
				grpCam1.Enabled = false;
				rbAuto1.Enabled = false;
				rbManual1.Enabled = false;
				numVideoTime1.Enabled = false;
				lblTime1.Enabled = false;
			}
			if (Properties.Settings.Default.CamActive_2)
			{
				grpCam2.Enabled = true;
				rbAuto2.Enabled = true;
				rbManual2.Enabled = true;
				numVideoTime2.Enabled = true;
				lblTime2.Enabled = true;
			}
			if (!Properties.Settings.Default.CamActive_2)
			{
				grpCam2.Enabled = false;
				rbAuto2.Enabled = false;
				rbManual2.Enabled = false;
				numVideoTime2.Enabled = false;
				lblTime2.Enabled = false;
			}
			if (Properties.Settings.Default.CamActive_3)
			{
				grpCam3.Enabled = true;
				rbAuto3.Enabled = true;
				rbManual3.Enabled = true;
				numVideoTime3.Enabled = true;
				lblTime3.Enabled = true;
			}
			if (!Properties.Settings.Default.CamActive_3)
			{
				grpCam3.Enabled = false;
				rbAuto3.Enabled = false;
				rbManual3.Enabled = false;
				numVideoTime3.Enabled = false;
				lblTime3.Enabled = false;
			}
			if (Properties.Settings.Default.CamActive_4)
			{
				grpCam4.Enabled = true;
				rbAuto4.Enabled = true;
				rbManual4.Enabled = true;
				numVideoTime4.Enabled = true;
				lblTime4.Enabled = true;
			}
			if (!Properties.Settings.Default.CamActive_4)
			{
				grpCam4.Enabled = false;
				rbAuto4.Enabled = false;
				rbManual4.Enabled = false;
				numVideoTime4.Enabled = false;
				lblTime4.Enabled = false;
			}
			if (Properties.Settings.Default.CamActive_5)
			{
				grpCam5.Enabled = true;
				rbAuto5.Enabled = true;
				rbManual5.Enabled = true;
				numVideoTime5.Enabled = true;
				lblTime5.Enabled = true;
			}
			if (!Properties.Settings.Default.CamActive_5)
			{
				grpCam5.Enabled = false;
				rbAuto5.Enabled = false;
				rbManual5.Enabled = false;
				numVideoTime5.Enabled = false;
				lblTime5.Enabled = false;
			}
			if (Properties.Settings.Default.EnableTars) btnConfigureFile.Enabled = true;
			if (!Properties.Settings.Default.EnableTars) btnConfigureFile.Enabled = false;
			if (Properties.Settings.Default.CamAuto_1) rbAuto1.Checked = true;
			if (!Properties.Settings.Default.CamAuto_1) rbManual1.Checked = true;
			if (Properties.Settings.Default.CamAuto_2) rbAuto2.Checked = true;
			if (!Properties.Settings.Default.CamAuto_2) rbManual2.Checked = true;
			if (Properties.Settings.Default.CamAuto_3) rbAuto3.Checked = true;
			if (!Properties.Settings.Default.CamAuto_3) rbManual3.Checked = true;
			if (Properties.Settings.Default.CamAuto_4) rbAuto4.Checked = true;
			if (!Properties.Settings.Default.CamAuto_4) rbManual4.Checked = true;
			if (Properties.Settings.Default.CamAuto_5) rbAuto5.Checked = true;
			if (!Properties.Settings.Default.CamAuto_5) rbManual5.Checked = true;
			txBoxOutput.Text = Properties.Settings.Default.OutputPath;
			if (Properties.Settings.Default.ValidatePrefix)
			{
				txBoxPrefix.Enabled = true;
				txBoxPrefix.Text = Properties.Settings.Default.Prefix;
			}

			if (lblCamera_1.Text != "Not configured") //If there is a camera 1 previously configured, attempt to open and display
			{
				try
				{
					_camera_1 = new OzekiCamera(Properties.Settings.Default.CameraID_1);
					_connector_1.Connect(_camera_1.VideoChannel, _imageProvider_1);
					_camera_1.Start();
					videoViewerWF_1.Start();
				}
				catch
				{
					lblCamera_1.Text = "Not configured";
					lblErrorCam1.Visible = true;
				}
			}
			if (lblCamera_2.Text != "Not configured") //If there is a camera 2 previously configured, attempt to open and display
			{
				try
				{
					_camera_2 = new OzekiCamera(Properties.Settings.Default.CameraID_2);
					_connector_2.Connect(_camera_2.VideoChannel, _imageProvider_2);
					_camera_2.Start();
					videoViewerWF_2.Start();
				}
				catch
				{
					lblCamera_2.Text = "Not configured";
					lblErrorCam2.Visible = true;
				}
			}
			if (lblCamera_3.Text != "Not configured") //If there is a camera 3 previously configured, attempt to open and display
			{
				try
				{
					_camera_3 = new OzekiCamera(Properties.Settings.Default.CameraID_3);
					_connector_3.Connect(_camera_3.VideoChannel, _imageProvider_3);
					_camera_3.Start();
					videoViewerWF_3.Start();
				}
				catch
				{
					lblCamera_3.Text = "Not configured";
					lblErrorCam3.Visible = true;
				}
			}
			if (lblCamera_4.Text != "Not configured") //If there is a camera 4 previously configured, attempt to open and display
			{
				try
				{
					_camera_4 = new OzekiCamera(Properties.Settings.Default.CameraID_4);
					_connector_4.Connect(_camera_4.VideoChannel, _imageProvider_4);
					_camera_4.Start();
					videoViewerWF_4.Start();
				}
				catch
				{
					lblCamera_4.Text = "Not configured";
					lblErrorCam4.Visible = true;
				}
			}
			if (lblCamera_5.Text != "Not configured") //If there is a camera 5 previously configured, attempt to open and display
			{
				try
				{
					_camera_5 = new OzekiCamera(Properties.Settings.Default.CameraID_5);
					_connector_5.Connect(_camera_5.VideoChannel, _imageProvider_5);
					_camera_5.Start();
					videoViewerWF_5.Start();
				}
				catch
				{
					lblCamera_5.Text = "Not configured";
					lblErrorCam5.Visible = true;
				}
			}
		}

		private void chBoxPrefix_CheckedChanged(object sender, EventArgs e)
		{
			//This executes when Validate SN prefix box changes

			if (chBoxPrefix.Checked) txBoxPrefix.Enabled = true;
			if (!chBoxPrefix.Checked) txBoxPrefix.Enabled = false;
		}

		private void chBoxCamActive1_CheckedChanged(object sender, EventArgs e)
		{
			//This executes when Camera 1 Enable box changes

			if (chBoxCamActive1.Checked) // Activate all controls related to camera 1
			{
				grpCam1.Enabled = true;
				rbAuto1.Enabled = true;
				rbManual1.Enabled = true;
				numVideoTime1.Enabled = true;
				lblTime1.Enabled = true;
			}
			if (!chBoxCamActive1.Checked) // Deactivate all controls related to camera 1
			{
				grpCam1.Enabled = false;
				rbAuto1.Enabled = false;
				rbManual1.Enabled = false;
				numVideoTime1.Enabled = false;
				lblTime1.Enabled = false;
			}
		}

		private void chBoxCamActive2_CheckedChanged(object sender, EventArgs e)
		{
			//This executes when Camera 2 Enable box changes

			if (chBoxCamActive2.Checked) // Activate all controls related to camera 2
			{
				grpCam2.Enabled = true;
				rbAuto2.Enabled = true;
				rbManual2.Enabled = true;
				numVideoTime2.Enabled = true;
				lblTime2.Enabled = true;
			}
			if (!chBoxCamActive2.Checked) // Deactivate all controls related to camera 2
			{
				grpCam2.Enabled = false;
				rbAuto2.Enabled = false;
				rbManual2.Enabled = false;
				numVideoTime2.Enabled = false;
				lblTime2.Enabled = false;
			}
		}

		private void chBoxCamActive3_CheckedChanged(object sender, EventArgs e)
		{
			//This executes when Camera 3 Enable box changes

			if (chBoxCamActive3.Checked) // Activate all controls related to camera 3
			{
				grpCam3.Enabled = true;
				rbAuto3.Enabled = true;
				rbManual3.Enabled = true;
				numVideoTime3.Enabled = true;
				lblTime3.Enabled = true;
			}
			if (!chBoxCamActive3.Checked) // Deactivate all controls related to camera 3
			{
				grpCam3.Enabled = false;
				rbAuto3.Enabled = false;
				rbManual3.Enabled = false;
				numVideoTime3.Enabled = false;
				lblTime3.Enabled = false;
			}
		}

		private void chBoxCamActive4_CheckedChanged(object sender, EventArgs e)
		{
			//This executes when Camera 4 Enable box changes

			if (chBoxCamActive4.Checked) // Activate all controls related to camera 4
			{
				grpCam4.Enabled = true;
				rbAuto4.Enabled = true;
				rbManual4.Enabled = true;
				numVideoTime4.Enabled = true;
				lblTime4.Enabled = true;
			}
			if (!chBoxCamActive4.Checked) // Deactivate all controls related to camera 4
			{
				grpCam4.Enabled = false;
				rbAuto4.Enabled = false;
				rbManual4.Enabled = false;
				numVideoTime4.Enabled = false;
				lblTime4.Enabled = false;
			}
		}

		private void chBoxCamActive5_CheckedChanged(object sender, EventArgs e)
		{
			//This executes when Camera 5 Enable box changes

			if (chBoxCamActive5.Checked) // Activate all controls related to camera 5
			{
				grpCam5.Enabled = true;
				rbAuto5.Enabled = true;
				rbManual5.Enabled = true;
				numVideoTime5.Enabled = true;
				lblTime5.Enabled = true;
			}
			if (!chBoxCamActive5.Checked) // Deactivate all controls related to camera 5
			{
				grpCam5.Enabled = false;
				rbAuto5.Enabled = false;
				rbManual5.Enabled = false;
				numVideoTime5.Enabled = false;
				lblTime5.Enabled = false;
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			// This timer is checking every 100ms if at least 1 camera is enabled and configured to enable Save button

			if((chBoxCamActive1.Checked)||(chBoxCamActive2.Checked)||(chBoxCamActive3.Checked)||(chBoxCamActive4.Checked)||(chBoxCamActive5.Checked))
			{
				btnSave.Enabled = true;
				if ((lblCamera_1.Text == "Not configured") && (chBoxCamActive1.Checked)) btnSave.Enabled = false;
				if ((lblCamera_2.Text == "Not configured") && (chBoxCamActive2.Checked)) btnSave.Enabled = false;
				if ((lblCamera_3.Text == "Not configured") && (chBoxCamActive3.Checked)) btnSave.Enabled = false;
				if ((lblCamera_4.Text == "Not configured") && (chBoxCamActive4.Checked)) btnSave.Enabled = false;
				if ((lblCamera_5.Text == "Not configured") && (chBoxCamActive5.Checked)) btnSave.Enabled = false;
			}
			else
			{
				btnSave.Enabled = false;
			}
		}

		private void chkReportFile_CheckedChanged(object sender, EventArgs e)
		{
			// This executed when Enable Report TARS box has changed
			
			if (chkReportFile.Checked) btnConfigureFile.Enabled = true;
			if (!chkReportFile.Checked) btnConfigureFile.Enabled = false;
		}

		private void btnConfigureFile_Click(object sender, EventArgs e)
		{
			// When Configure TARS button is pressed, this will open a new ConfigTars Form
			ConfigureTARS TARS = new ConfigureTARS();
			TARS.ShowDialog();
		}

        private void btnExit_Click(object sender, EventArgs e)
        {
            btnSave_Click(sender, e);
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


        private void CameraSetting_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
