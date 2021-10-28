using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ozeki.Camera;
using Ozeki.Media;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using iFactoryInfo;

/// <summary>
/// 5130988
/// 
/// NCR PACKOUT CAMERAS APPLICATION
/// 
/// 01 AGOSTO 2019 FIX SE AGREGA MainForm_FormClosing PARA ELIMIANR DEJAR LAS CAMARAS ABIERTAS CUADNO LA APLICACION SEA CERRADA.................1.0.0.3
/// 
/// 08 AGOSTO 2019 SE AGREGA FUNCION PARA VALIDAR PROCESOS EN IFACTORY  iFactoryValidation
/// SE AGREGA A LOS SETTING DE LA APLICACION EL "STEP VALIDATION, BUTTON UP, ACCESSORIES INSPECTION FOR SSCOS AND ATM.............................1.0.0.4
/// SE AGREGA BOTON PARA CANCELAR WIP ESCANEADO...................................................................................................1.0.0.5
/// 
/// 13 AGOSTO 2019
/// SE AGREGA FUNCION PARA ESCANEAR TRACER O WIP Y OBTENER LA UNIT INFO DESDE IFACTORY bool GetUnitInfo(string TRACER_WIP)........................1.0.0.6
/// SE AGREGA OPCION PARA HABILITAR Y DESHABILITAR LA CONSULTA UNIT INFO DESDE IFACTORY...........................................................1.0.0.7
/// SE MODIFICA LA CREACION DE TARS PARA QUE EL ENSAMBLE LO TOME DE IFACTORY Y NO DE LOS SETTINGS DE LA APP.......................................1.0.0.8
/// 
/// 14 AGOSTO 2019
/// CAMBIO DE SKIN................................................................................................................................1.0.0.9
/// CAMBIO DE SKIN................................................................................................................................1.0.0.10
/// CAMBIO DE SKIN................................................................................................................................1.0.0.11
/// 
/// 16 AGOSTO 2019
/// SE AGREGA FUNCION PARA GENERAR LOG EN FORMATO XML.............................................................................................1.0.0.12
/// 
/// 02 SEPTIEMBRE
/// SE CORRIGE ERROR DE RESOURCENAME Y STEPNAME INTERCAMBIADOS EN LOG XML.........................................................................1.0.0.13
/// 
/// 04 SEPTIEMBRE 
/// SE QUITA REPORTEO DE LOGBK A MXCHIM0PANGEA POR FALTA DE PERMISOS EN LA CUENTA GENERICA........................................................1.0.0.14
/// FIX PROBLEMA DE REPORTEO DE LOG XML POR SETTINGS INCORRECTO...................................................................................1.0.0.15
/// 
/// 10 SEPTIEMBRE 2019
/// SE AGREGA CANDADO PARA LOS SETTINGS PASSWORD CONTROL+P PARA DESBLOQUEAR Y BLOQUEAR SETTINGS...................................................1.0.0.16
/// SE AGREGA POKA-YOKE PARA VERIFICAR LA EJECUCION DE NCR PREPARSER IMAGE........................................................................1.0.0.17
/// 
/// 11 SEPTIEMBRE 2019
/// ICONO DE APLICACION...........................................................................................................................1.0.0.18
/// FIX POKA-YOKE PREPARSER.......................................................................................................................1.0.0.19
/// 
/// 12 SEPTIEMBRE 2019
/// SE AGREGA BOTON PARA CANCELAR LA VIDEO GRABACION "ABORT VIDEO RECORDING"......................................................................1.0.0.20
/// SE AGREGA FUNCION PARA ELIMINAR VIDEOS GRABADOS ABORTADOS.....................................................................................1.0.0.20
/// 
/// 
/// 25 NOVIEMBRE 2019
/// SE AGREGA POKA-YOKE PARA EVITAR MAS DE 1 INSTANCIA ABIERTA....................................................................................1.0.0.21
/// FIX BUG 1.0.0.21..............................................................................................................................1.0.0.22
/// 
/// 18 MARZO 2020
/// DARK MODE.....................................................................................................................................1.0.0.23
/// 
/// 14 ABRIL 2020
/// SE AGREGA FUNCION PARA MANDAR A LLAMAR EXTERNAL PROCESS ALERTA DE CALIDAD PEDIDA POR BERENICE PRIETO..........................................1.0.0.24
/// 
/// 01 JULIO 2020
/// SE AGREGA CONDICION VERIFICACION DE COPIADO DE VIDEOS GRABADOS..................................... ..........................................1.0.0.25
/// SE AGREGA CONDICION VERIFICACION DE COPIADO DE VIDEOS GRABADOS..................................... ..........................................1.0.0.26
/// SE EXEPTION THE UNDERLYING PARA EVITAR FALLO DE IFACTORY........................................... ..........................................1.0.0.27
/// 
/// 
/// 
/// 11 MAYO 2021
/// VIDEO SHIPPING 2 
/// SE REDISENA APLICACION PARA PODER ABRIR DOS INSTANCIAS AL MISMO TIEMPO EN UN SOLO MONITOR.......... ..........................................1.0.0.28
/// SE REDISENA APLICACION PARA PODER ABRIR DOS INSTANCIAS AL MISMO TIEMPO EN UN SOLO MONITOR.......... ..........................................1.0.0.29
/// 
/// 
/// 17 MAYO 2021
/// SE REDISENAN PAGINAS DE CONFIGURACION, Y SE CREA UN NUEVO REPOSITORIO PARA EJECTUAR 2 APP CON DIFERENTES SETTINGS.............................1.0.0.30
/// FIX SHARE SETTINGS............................................................................................................................1.0.0.31
/// SE AGREGA CARGA AUTOMATICA DE STEPS RESOURCES.................................................................................................1.0.0.32
///
///
/// /// 21 JUNIO 2021
/// SE ACTUALIZA LIVBRERIA IFACTORY INFO POR LA MIGRACION DE IT A NUEVOS SERVIDORES...............................................................1.0.0.33
/// 
/// 22 JUNIO 2021
/// SE REMUEVE CANDADO PARA PODER ABRIR 2 INSTANCIAS DE LA MISMA APLICACION.......................................................................1.0.0.34
/// 
/// 
/// 
/// 15 SEPTIEMBRE 2021
/// SE AMPLIA MAXIMA LONGUITUD DE CARACTERES AL ESCANEO A 30......................................................................................1.0.0.35
///
/// 
/// 17 SEPTIEMBRE 2021
/// FIX SOME ISSUES
/// 1.0.0.41
/// 
/// 
/// 17 SEPTIEMBRE 2021
/// FIX SOME ISSUES
/// 1.0.0.42
/// 1.0.0.44
/// 1.0.0.45



namespace NCR_Packout_Camera
{
    public partial class MainForm : Form
    {
		private OzekiCamera _camera;
		private MediaConnector _connectorViewer;
		private MediaConnector _connectorRecorder;
		private DrawingImageProvider _imageProvider;
		private MPEG4Recorder _recorder;
        private VideoConcat _videoConcat;
		private int video_number;
		private int Seconds;
		private string VideoString;

        //dll return the dataset with the process info by ifactory wip 
        iFactoryInfo.iFactoryInfo _iFactoryInfo = new iFactoryInfo.iFactoryInfo();
        DataSet ds;
        DataTable dt;
        DataRow dr;

        string TRACER, WIP, CLASS, MC;

        public MainForm()
        {
            InitializeComponent();
            //this.Text = "NCR Packout cameras " + "v1.0.0.8";
             lblVersion.Text = "v1.0.0.45";
            _imageProvider = new DrawingImageProvider();
			_connectorViewer = new MediaConnector();
			_connectorRecorder = new MediaConnector();
			videoViewerWF1.SetImageProvider(_imageProvider);
		}

		private void Form1_Load(object sender, EventArgs e)
        {
			//Load config parameter values
			lblCamera1.Enabled = Properties.Settings.Default.CamActive_1;
			lblCamera2.Enabled = Properties.Settings.Default.CamActive_2;
			lblCamera3.Enabled = Properties.Settings.Default.CamActive_3;
			lblCamera4.Enabled = Properties.Settings.Default.CamActive_4;
			lblCamera5.Enabled = Properties.Settings.Default.CamActive_5;
			txBoxSN.MaxLength = Properties.Settings.Default.SNLength;

			// Set default controls state
			btnStart.Enabled = false;
			picErrorCam_1.Visible = false;
			picErrorCam_2.Visible = false;
			picErrorCam_3.Visible = false;
			picErrorCam_4.Visible = false;
			picErrorCam_5.Visible = false;
			picShot_1.Visible = false;
			picShot_2.Visible = false;
			picShot_3.Visible = false;
			picShot_4.Visible = false;
            picShot_5.Visible = false;
			videoViewerWF1.Visible = false;
			video_number = 0;
			lblInvalidSN.Visible = false;				
			btnStop.Enabled = false;
			picRecording.Visible = false;
			txBoxSN.Focus();
			Seconds = 0;
			timerAutoSec.Enabled = false;
            btnConfig.Enabled = false;
            picLock.Visible = true;
            picLock.Image = Properties.Resources.lockpng;
		}

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Show resource active 
            lblRecursoActivo.Text = Properties.Settings.Default.Tars_Process;

            //Shown us the quality alert before to start the video recording
            if (Properties.Settings.Default.QualityAlert) OpenExe(@"C:\QualityAlert\QualityAlertBere.exe", "");


            // This function starts recording a new video, either by manual click or automatic.
            string cameraURL = "";
			string cameraString = "";

			if (_camera != null) //Stop video and camera if there is a camera running.
			{
				videoViewerWF1.Stop();
				_camera.Stop();
				_connectorViewer.Disconnect(_camera.VideoChannel, _imageProvider);
				_connectorRecorder.Disconnect(_camera.VideoChannel, _recorder.VideoRecorder);
			}

			btnStart.Enabled = false; 
			picRecording.Visible = true;
			NextVideo:
			videoViewerWF1.Visible = true;

			// Select camera URL depending on case number
			switch (video_number)  // Depending the video number will open a different camera
			{
				case 1:  // Set camera 1 URL
					if (!Properties.Settings.Default.CamActive_1) //If camera is disabled then skip to next camera
					{
						video_number += 1;
						goto NextVideo;
					}
					if (Properties.Settings.Default.CamAuto_1) //If camera mode is set to automatic, enable timer
					{
						timerRecording.Enabled = true;
						timerRecording.Interval = Properties.Settings.Default.VideoTime_1 * 1000;
						Seconds = Properties.Settings.Default.VideoTime_1;
						timerAutoSec.Enabled = true;
						VideoString = "GRABANDO VIDEO CAM01";
						txBoxIndications.Text = VideoString + "\nAUTO: " + Seconds + " segundos restantes";
						Seconds -= 1;
					}
					if (!Properties.Settings.Default.CamAuto_1) //If camera mode is set to manual, enable Stop button
					{
						btnStop.Enabled = true;
						btnStop.Focus();
						txBoxIndications.Text = "GRABANDO VIDEO CAM01" + "\n" + "MANUAL: PRESIONE STOP O ENTER PARA FINALIZAR VIDEO";
					}
					cameraString = "CAM01";
					cameraURL = Properties.Settings.Default.CameraID_1;
					break;
				case 2: // Set camera 2 URL
					if (!Properties.Settings.Default.CamActive_2) //If camera is disabled then skip to next camera
					{
						video_number += 1;
						goto NextVideo;
					}
					if (Properties.Settings.Default.CamAuto_2) //If camera mode is set to automatic, enable timer
					{
						timerRecording.Enabled = true;
						timerRecording.Interval = Properties.Settings.Default.VideoTime_2 * 1000;
						Seconds = Properties.Settings.Default.VideoTime_2;
						timerAutoSec.Enabled = true;
						VideoString = "GRABANDO VIDEO CAM02";
						txBoxIndications.Text = VideoString + "\nAUTO: " + Seconds + " segundos restantes";
						Seconds -= 1;
					}
					if (!Properties.Settings.Default.CamAuto_2) //If camera mode is set to manual, enable Stop button
					{
						btnStop.Enabled = true;
						btnStop.Focus();
						txBoxIndications.Text = "GRABANDO VIDEO CAM02" + "\n" + "MANUAL: PRESIONE STOP O ENTER PARA FINALIZAR VIDEO";
					}
					cameraString = "CAM02";
					cameraURL = Properties.Settings.Default.CameraID_2;
					break;
				case 3: // Set camera 3 URL
					if (!Properties.Settings.Default.CamActive_3) //If camera is disabled then skip to next camera
					{
						video_number += 1;
						goto NextVideo;
					}
					if (Properties.Settings.Default.CamAuto_3) //If camera mode is set to automatic, enable timer
					{
						timerRecording.Enabled = true;
						timerRecording.Interval = Properties.Settings.Default.VideoTime_3 * 1000;
						Seconds = Properties.Settings.Default.VideoTime_3;
						timerAutoSec.Enabled = true;
						VideoString = "GRABANDO VIDEO CAM03";
						txBoxIndications.Text = VideoString + "\nAUTO: " + Seconds + " segundos restantes";
						Seconds -= 1;
					}
					if (!Properties.Settings.Default.CamAuto_3) //If camera mode is set to manual, enable Stop button
					{
						btnStop.Enabled = true;
						btnStop.Focus();
						txBoxIndications.Text = "GRABANDO VIDEO CAM03" + "\n" + "MANUAL: PRESIONE STOP O ENTER PARA FINALIZAR VIDEO";
					}
					cameraString = "CAM03";
					cameraURL = Properties.Settings.Default.CameraID_3;
					break;
				case 4: // Set camera 4 URL
					if (!Properties.Settings.Default.CamActive_4) //If camera is disabled then skip to next camera
					{
						video_number += 1;
						goto NextVideo;
					}
					if (Properties.Settings.Default.CamAuto_4) //If camera mode is set to automatic, enable timer
					{
						timerRecording.Enabled = true;
						timerRecording.Interval = Properties.Settings.Default.VideoTime_4 * 1000;
						Seconds = Properties.Settings.Default.VideoTime_4;
						timerAutoSec.Enabled = true;
						VideoString = "GRABANDO VIDEO CAM04";
						txBoxIndications.Text = VideoString + "\nAUTO: " + Seconds + " segundos restantes";
						Seconds -= 1;
					}
					if (!Properties.Settings.Default.CamAuto_4) //If camera mode is set to manual, enable Stop button
					{
						btnStop.Enabled = true;
						btnStop.Focus();
						txBoxIndications.Text = "GRABANDO VIDEO CAM04" + "\n" + "MANUAL: PRESIONE STOP O ENTER PARA FINALIZAR VIDEO";
					}
					cameraString = "CAM04";
					cameraURL = Properties.Settings.Default.CameraID_4;
					break;
				case 5: // Set camera 5 URL
					if (!Properties.Settings.Default.CamActive_5) //If camera is disabled then skip to next camera
					{
						video_number += 1;
						goto NextVideo;
					}
					if (Properties.Settings.Default.CamAuto_5) //If camera mode is set to automatic, enable timer
					{
						timerRecording.Enabled = true;
						timerRecording.Interval = Properties.Settings.Default.VideoTime_5 * 1000;
						Seconds = Properties.Settings.Default.VideoTime_5;
						timerAutoSec.Enabled = true;
						VideoString = "GRABANDO VIDEO CAM05";
						txBoxIndications.Text = VideoString + "\nAUTO: " + Seconds + " segundos restantes";
						Seconds -= 1;
					}
					if (!Properties.Settings.Default.CamAuto_5) //If camera mode is set to manual, enable Stop button
					{
						btnStop.Enabled = true;
						btnStop.Focus();
						txBoxIndications.Text = "GRABANDO VIDEO CAM05" + "\n" + "MANUAL: PRESIONE STOP O ENTER PARA FINALIZAR VIDEO";
					}
					cameraString = "CAM05";
					cameraURL = Properties.Settings.Default.CameraID_5;
					break;
			}

			var date = DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" +
						DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second;

			string SerialNumber = txBoxSN.Text.ToString().TrimEnd().TrimStart();

			var currentpath = AppDomain.CurrentDomain.BaseDirectory + SerialNumber + "_" + cameraString + "_" + date + ".mpeg4";

			//// Create Camera and recorder objects
			_recorder = new MPEG4Recorder(currentpath);
			_camera = new OzekiCamera(cameraURL);
			_connectorViewer.Connect(_camera.VideoChannel, _imageProvider);
			_connectorRecorder.Connect(_camera.VideoChannel, _recorder.VideoRecorder);
			_camera.Start();  // Starts camera
			videoViewerWF1.Start();  // Starts camera viewer

			_recorder.MultiplexFinished += _recorder_MultiplexFinished;
			_connectorRecorder.Connect(_camera.VideoChannel, _recorder.VideoRecorder);  // Starts recording
			video_number += 1;
		}

		void _recorder_MultiplexFinished(object sender, VoIPEventArgs<bool> e)
		{
			// This will execute when recorder has finished
			_connectorRecorder.Disconnect(_camera.VideoChannel, _recorder.VideoRecorder);
			_recorder.Dispose();
		}


		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        { 
			// This executes when Form is closed
			if (_camera != null) //Stop video and camera if there is a camera running.
			{
				videoViewerWF1.Stop();
				_camera.Stop();
				_connectorViewer.Disconnect(_camera.VideoChannel, _imageProvider);
				_connectorRecorder.Disconnect(_camera.VideoChannel, _recorder.VideoRecorder);
			}
		}

		private void timerRecording_Tick(object sender, EventArgs e)
		{
			// This will execute when the recording timer has finished, or when Stop button has been pressed
			// This will stop video recorder and camera viewer

			string filePath = "";
			string folderPath = "";
			if (_camera.VideoChannel == null) return;

			_recorder.Multiplex(); // Stop video recorder
			System.Threading.Thread.Sleep(500);			
			videoViewerWF1.Stop();   // Stop camera viewer
			videoViewerWF1.Visible = false;
			System.Threading.Thread.Sleep(200);
			_connectorViewer.Disconnect(_camera.VideoChannel, _imageProvider);
			_connectorRecorder.Disconnect(_camera.VideoChannel, _recorder.VideoRecorder);
			System.Threading.Thread.Sleep(200);
			_camera = null;
			timerRecording.Enabled = false;
			btnStop.Enabled = false;
			picRecording.Visible = false;
			timerAutoSec.Enabled = false;
			Seconds = 0;

			switch (video_number) //Depending on the video number, will set green ok sign next to camera label
			{
				case 2: // Will set camera 1 as completed, activates start button
					picShot_1.Visible = true;
					lblCamera1.Font = new Font(lblCamera1.Font.Name, 12, FontStyle.Bold);
					if ((!Properties.Settings.Default.CamActive_2) && (!Properties.Settings.Default.CamActive_3) && (!Properties.Settings.Default.CamActive_4) && (!Properties.Settings.Default.CamActive_5)) goto case 7;
					txBoxIndications.Text = "PRESIONE BOTON START O PRESIONE ENTER PARA COMENZAR A GRABAR SIGUIENTE VIDEO";
					btnStart.Enabled = true;
					btnStart.Focus();
					break;
				case 3: // Will set camera 2 as completed, activates start button
					picShot_2.Visible = true;
					lblCamera2.Font = new Font(lblCamera2.Font.Name, 12, FontStyle.Bold);
					if ((!Properties.Settings.Default.CamActive_3) && (!Properties.Settings.Default.CamActive_4) && (!Properties.Settings.Default.CamActive_5)) goto case 7;
					txBoxIndications.Text = "PRESIONE BOTON START O PRESIONE ENTER PARA COMENZAR A GRABAR SIGUIENTE VIDEO";
					btnStart.Enabled = true;
					btnStart.Focus();
					break;
				case 4: // Will set camera 3 as completed, activates start button
					picShot_3.Visible = true;
					lblCamera3.Font = new Font(lblCamera3.Font.Name, 12, FontStyle.Bold);
					if ((!Properties.Settings.Default.CamActive_4) && (!Properties.Settings.Default.CamActive_5)) goto case 7;
					txBoxIndications.Text = "PRESIONE BOTON START O PRESIONE ENTER PARA COMENZAR A GRABAR SIGUIENTE VIDEO";
					btnStart.Enabled = true;
					btnStart.Focus();
					break;
				case 5: // Will set camera 4 as completed, activates start button
					picShot_4.Visible = true;
					lblCamera4.Font = new Font(lblCamera4.Font.Name, 12, FontStyle.Bold);
					if (!Properties.Settings.Default.CamActive_5) goto case 7;
					txBoxIndications.Text = "PRESIONE BOTON START O PRESIONE ENTER PARA COMENZAR A GRABAR SIGUIENTE VIDEO";
					btnStart.Enabled = true;
					btnStart.Focus();
					break;
				case 6: // Will set camera 5 as completed, activates start button		 		
					picErrorCam_5.Visible = true;
					lblCamera5.Font = new Font(lblCamera5.Font.Name, 12, FontStyle.Bold);
					goto case 7;
				case 7: // End of the recording sequence, here the videos are moved to final location and TARS file is generated
					txBoxIndications.Text = "GUARDANDO VIDEOS. ESPERE";					
					System.Threading.Thread.Sleep(100);
					txBoxIndications.Refresh();
					picErrorCam_5.Refresh();
					lblCamera5.Refresh();

					string[] files = System.IO.Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*.mpeg4");

					if (files.Length == 0)
					{                       
						txBoxIndications.Text = "ERROR. ARCHIVOS DE VIDEO INVALIDOS. FAVOR DE REINICAR LAS CAMARAS E INTENTAR DE NUEVO.";
						if (Properties.Settings.Default.CamActive_1) picErrorCam_1.Visible = true;
						if (Properties.Settings.Default.CamActive_2) picErrorCam_2.Visible = true;
						if (Properties.Settings.Default.CamActive_3) picErrorCam_3.Visible = true;
						if (Properties.Settings.Default.CamActive_4) picErrorCam_4.Visible = true;
						if (Properties.Settings.Default.CamActive_5) picErrorCam_5.Visible = true;
                        if (Properties.Settings.Default.EnableXML) CreateLogXML("FAIL");
                        // Set controls to default
                        //btnConfig.Enabled = true;
						video_number = 0;
						txBoxSN.Enabled = true;
						txBoxSN.Text = null;
						txBoxSN.Focus();
						btnStart.Enabled = false;
						videoViewerWF1.Enabled = false;
						return;
					}

                    string status = "PASS";
                    string OutputPath = Properties.Settings.Default.OutputPath + DateTime.Now.ToString("MM_yyyy_dd") + @"\" + DateTime.Now.ToString("HH") + @"\";

                    DirectoryInfo DirInfo = new DirectoryInfo(OutputPath);
                    if (!DirInfo.Exists)
                    {
                        DirInfo.Create();
                    }

                    folderPath = OutputPath + txBoxSN.Text.TrimStart().TrimEnd();
                    if (!System.IO.Directory.Exists(folderPath)) //Checks if a folder of that SN already exists
					{
						System.IO.Directory.CreateDirectory(folderPath); //Creates new folder for that SN
					}
					
					filePath = folderPath + "\\" + DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" +
						DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second;
					System.IO.Directory.CreateDirectory(filePath); //Creates new folder inside, with the date on the name


                    

					//This will move all MPEG4 videos from working directory to final directory
					for (int i = 0; i < files.Length; i++) 
					{
						string[] words = files[i].Split('\\');
						int lastIndex = words.Length - 1;
						string destFile = filePath + "\\" + words[lastIndex];
						System.IO.File.Copy(files[i], destFile, true);

                        if (!File.Exists(destFile)) status = "FAIL";
					}
					//This will delete all MPEG4 videos from working directory
					for (int i = 0; i < files.Length; i++) 
					{
						string[] words = files[i].Split('\\');
						int lastIndex = words.Length - 1;
						string destFile = filePath + "\\" + words[lastIndex];
						System.IO.File.Delete(files[i]);
					}


                    if (status == "FAIL")
                    {
                        txBoxIndications.Text = "ERROR. ARCHIVOS DE VIDEO INVALIDOS. FAVOR DE REINICAR LAS CAMARAS E INTENTAR DE NUEVO.";
                        if (Properties.Settings.Default.CamActive_1) picErrorCam_1.Visible = true;
                        if (Properties.Settings.Default.CamActive_2) picErrorCam_2.Visible = true;
                        if (Properties.Settings.Default.CamActive_3) picErrorCam_3.Visible = true;
                        if (Properties.Settings.Default.CamActive_4) picErrorCam_4.Visible = true;
                        if (Properties.Settings.Default.CamActive_5) picErrorCam_5.Visible = true;
                        if (Properties.Settings.Default.EnableXML) CreateLogXML("FAIL");
                        // Set controls to default
                        //btnConfig.Enabled = true;
                        video_number = 0;
                        txBoxSN.Enabled = true;
                        txBoxSN.Text = null;
                        txBoxSN.Focus();
                        btnStart.Enabled = false;
                        videoViewerWF1.Enabled = false;
                        return;
                    }


                    if (Properties.Settings.Default.EnableTars)	CreateTarsFile();  //Execute Create TARS file function if option is enabled
                    if (Properties.Settings.Default.EnableXML)  CreateLogXML(status);  //Execute Create XML file function if option is enabled

            
					txBoxIndications.Text = txBoxSN.Text.ToString() + ". DONE";		
					// Set controls to default
					//btnConfig.Enabled = true;
					video_number = 0;
					txBoxSN.Enabled = true;
					txBoxSN.Text = null;
					txBoxSN.Focus();
					btnStart.Enabled = false;
					videoViewerWF1.Enabled = false;
					break;
			}
			
			// If Automatic start option is enabled, this will start a new video automatically
			if ((Properties.Settings.Default.AutoStart)&&(video_number < 7)&&(video_number > 0)) btnStart_Click(sender, e);

		}

        private void btnAbortVideoRecording_Click(object sender, EventArgs e)
        {
            try
            {
                if (_camera.VideoChannel == null) return;
            }
            catch (Exception ex)
            {
                return;
            }

            _recorder.Multiplex(); // Stop video recorder
            System.Threading.Thread.Sleep(500);
            videoViewerWF1.Stop();   // Stop camera viewer
            videoViewerWF1.Visible = false;
            System.Threading.Thread.Sleep(200);
            _connectorViewer.Disconnect(_camera.VideoChannel, _imageProvider);
            _connectorRecorder.Disconnect(_camera.VideoChannel, _recorder.VideoRecorder);
            System.Threading.Thread.Sleep(200);
            _camera = null;
            timerRecording.Enabled = false;
            btnStop.Enabled = false;
            picRecording.Visible = false;
            timerAutoSec.Enabled = false;
            Seconds = 0;

            switch (video_number) //Depending on the video number, will set green ok sign next to camera label
            {
                case 2: // Will set camera 1 as completed, activates start button
                    picErrorCam_1.Visible = true;
                    lblCamera1.Font = new Font(lblCamera1.Font.Name, 12, FontStyle.Bold);
                    if ((!Properties.Settings.Default.CamActive_2) && (!Properties.Settings.Default.CamActive_3) && (!Properties.Settings.Default.CamActive_4) && (!Properties.Settings.Default.CamActive_5)) goto case 7;
                    txBoxIndications.Text = "PRESIONE BOTON START O PRESIONE ENTER PARA COMENZAR A GRABAR SIGUIENTE VIDEO";
                    btnStart.Enabled = true;
                    btnStart.Focus();
                    break;
                case 3: // Will set camera 2 as completed, activates start button
                    picErrorCam_2.Visible = true;
                    lblCamera2.Font = new Font(lblCamera2.Font.Name, 12, FontStyle.Bold);
                    if ((!Properties.Settings.Default.CamActive_3) && (!Properties.Settings.Default.CamActive_4) && (!Properties.Settings.Default.CamActive_5)) goto case 7;
                    txBoxIndications.Text = "PRESIONE BOTON START O PRESIONE ENTER PARA COMENZAR A GRABAR SIGUIENTE VIDEO";
                    btnStart.Enabled = true;
                    btnStart.Focus();
                    break;
                case 4: // Will set camera 3 as completed, activates start button
                    picErrorCam_3.Visible = true;
                    lblCamera3.Font = new Font(lblCamera3.Font.Name, 12, FontStyle.Bold);
                    if ((!Properties.Settings.Default.CamActive_4) && (!Properties.Settings.Default.CamActive_5)) goto case 7;
                    txBoxIndications.Text = "PRESIONE BOTON START O PRESIONE ENTER PARA COMENZAR A GRABAR SIGUIENTE VIDEO";
                    btnStart.Enabled = true;
                    btnStart.Focus();
                    break;
                case 5: // Will set camera 4 as completed, activates start button
                    picErrorCam_4.Visible = true;
                    lblCamera4.Font = new Font(lblCamera4.Font.Name, 12, FontStyle.Bold);
                    if (!Properties.Settings.Default.CamActive_5) goto case 7;
                    txBoxIndications.Text = "PRESIONE BOTON START O PRESIONE ENTER PARA COMENZAR A GRABAR SIGUIENTE VIDEO";
                    btnStart.Enabled = true;
                    btnStart.Focus();
                    break;
                case 6: // Will set camera 5 as completed, activates start button		 		
                    picErrorCam_5.Visible = true;
                    lblCamera5.Font = new Font(lblCamera5.Font.Name, 12, FontStyle.Bold);
                    goto case 7;
                case 7: // End of the recording sequence, here the videos are moved to final location and TARS file is generated
                    txBoxIndications.Text = "ELIMINANDO VIDEOS. ESPERE...";
                    System.Threading.Thread.Sleep(100);
                    txBoxIndications.Refresh();
                    picErrorCam_5.Refresh();
                    lblCamera5.Refresh();
                    

                    DirectoryInfo directoryInfo = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
                    FileInfo[] filesVideos = directoryInfo.GetFiles("*.mpeg4");

                    if (filesVideos.Length == 0)
                    {
                        txBoxIndications.Text = "ERROR. ARCHIVOS DE VIDEO INVALIDOS. FAVOR DE REINICAR LAS CAMARAS E INTENTAR DE NUEVO.";
                        if (Properties.Settings.Default.CamActive_1) picErrorCam_1.Visible = true;
                        if (Properties.Settings.Default.CamActive_2) picErrorCam_2.Visible = true;
                        if (Properties.Settings.Default.CamActive_3) picErrorCam_3.Visible = true;
                        if (Properties.Settings.Default.CamActive_4) picErrorCam_4.Visible = true;
                        if (Properties.Settings.Default.CamActive_5) picErrorCam_5.Visible = true;
                        if (Properties.Settings.Default.EnableXML) CreateLogXML("FAIL");
                        // Set controls to default
                        //btnConfig.Enabled = true;
                        video_number = 0;
                        txBoxSN.Enabled = true;
                        txBoxSN.Text = null;
                        txBoxSN.Focus();
                        btnStart.Enabled = false;
                        videoViewerWF1.Enabled = false;
                        return;
                    }

                    //This will delete all MPEG4 videos from working directory
                    string _videoDeleted = string.Empty;
                    foreach(FileInfo video in filesVideos)
                    {
                        _videoDeleted = _videoDeleted + "\n" + video.Name;
                        video.Delete();
                    }

          
                    txBoxIndications.Text = txBoxSN.Text.ToString() + ". VIDEO GRABACION ABORTADA" + "\n" + _videoDeleted + " " + "ELIMINADO";
                    // Set controls to default
                    //btnConfig.Enabled = true;
                    video_number = 0;
                    txBoxSN.Enabled = true;
                    txBoxSN.Text = null;
                    txBoxSN.Focus();
                    btnStart.Enabled = false;
                    videoViewerWF1.Enabled = false;
                    break;
            }

            // If Automatic start option is enabled, this will start a new video automatically
            if ((Properties.Settings.Default.AutoStart) && (video_number < 7) && (video_number > 0)) btnStart_Click(sender, e);


        }

        private void input_KeyDown(object sender, KeyEventArgs e)
		{
            // This function checks if the ENTER key has been pressed on the Serial Number Box to start recording sequence

            if (e.KeyData == Keys.Enter)
			{
				if (txBoxSN.Text == "") return;


                //fuction to verify Parser is running
                if (Properties.Settings.Default.CheckParser)
                {
                    if (!CheckParserIsRunning())
                    {
                        lblInvalidSN.Text = Properties.Settings.Default.ParserName + " " + "sin ejecutarse..." + "\n" + "Contacte a Ingenieraia de pruebas";
                        lblInvalidSN.Visible = true;
                        txBoxSN.Clear();
                        txBoxSN.Focus();
                        return;
                    }
                }
              
                //Function to get UnitInfo from iFactory DB
                if (Properties.Settings.Default.iFactoryInfo)
                {
                    bool info = GetUnitInfo(txBoxSN.Text);
                    if (!info) return;
                }
               

				if (Properties.Settings.Default.ValidatePrefix) // Checks if SN Prefix verification is enabled
				{
					if (Properties.Settings.Default.Prefix != null)
					{
						string prefix = Properties.Settings.Default.Prefix;
						if (txBoxSN.TextLength < Properties.Settings.Default.Prefix.Length) return;
						string SNPrefix = txBoxSN.Text.Substring(0, prefix.Length);
						if (SNPrefix != prefix)  // If SN prefix doesn't match to Prefix configured
						{
							lblInvalidSN.Text = "Prefijo de numero serie invalido";
							lblInvalidSN.Visible = true;
							return;
						}
					}
				}
				if (Properties.Settings.Default.LockSN) // Checks if SN lock to length is enabled
				{
					int SNLength = Properties.Settings.Default.SNLength;
					int SerialLength = txBoxSN.TextLength;
					if (SerialLength != SNLength) // If SN doesn't match to configured length
					{
						lblInvalidSN.Text = "Longitud de numero de serie invalida";
						lblInvalidSN.Visible = true;
                        txBoxSN.Clear();
                        txBoxSN.Focus();
						return;
					}
				}

                //Validate the previous ifactory step
                if (Properties.Settings.Default.Step_validation)
                {
                    bool STEPVAL1 = false;
                    bool STEPVAL2 = false;
                    var result = iFactoryValidation(txBoxSN.Text);
                    STEPVAL1 = result.Item1;
                    STEPVAL2 = result.Item2;
      
                    if (Properties.Settings.Default.Step_Buttonup)
                    {
                        if (!STEPVAL1)
                        {
                           lblInvalidSN.Text = "Proceso faltante:" + "\n" + "*BUTTON UP*";
                           lblInvalidSN.Visible = true;
                           txBoxSN.Clear();
                           txBoxSN.Focus();
                           return;
                        }
                    }
                    if (Properties.Settings.Default.Step_AccessoriesInp)
                    {
                        if (!STEPVAL2)
                        {
                            lblInvalidSN.Text = "Proceso faltante:" + "\n" + "*ACCESSORIES INSPECTION*";
                            lblInvalidSN.Visible = true;
                            txBoxSN.Clear();
                            txBoxSN.Focus();
                            return;
                        }
                    }           
                }
               
                // If none of the cameras is Enabled, then display a message to the user
                if ((!Properties.Settings.Default.CamActive_1)&& (!Properties.Settings.Default.CamActive_2)&& (!Properties.Settings.Default.CamActive_3)&&(!Properties.Settings.Default.CamActive_4)&& (!Properties.Settings.Default.CamActive_5))
				{
					lblInvalidSN.Text = "ERROR: No se a configurado camara";
					lblInvalidSN.Visible = true;
				}

                // Set controls to default, and disable SN box
				btnConfig.Enabled = false;
				lblCamera1.Font = new Font(lblCamera1.Font.Name, 12,FontStyle.Regular);
				lblCamera2.Font = new Font(lblCamera2.Font.Name, 12, FontStyle.Regular);
				lblCamera3.Font = new Font(lblCamera3.Font.Name, 12, FontStyle.Regular);
				lblCamera4.Font = new Font(lblCamera4.Font.Name, 12, FontStyle.Regular);
				lblCamera5.Font = new Font(lblCamera5.Font.Name, 12, FontStyle.Regular);
				lblInvalidSN.Visible = false;
				videoViewerWF1.Enabled = true;
				picErrorCam_1.Visible = false;
				picErrorCam_2.Visible = false;
				picErrorCam_3.Visible = false;
				picErrorCam_4.Visible = false;
				picErrorCam_5.Visible = false;
				picShot_1.Visible = false;
				picShot_2.Visible = false;
				picShot_3.Visible = false;
				picShot_4.Visible = false;
				picErrorCam_5.Visible = false;
				txBoxSN.Enabled = false;
				btnStart.Enabled = true;
				btnStart.Focus();				
				video_number = 1;
				txBoxIndications.Text = "PRESIONE BOTON START O PRESIONE ENTER PARA COMENZAR A GRABAR VIDEO";
			}
		}

        //Function to get Unit info by serial number or tracer number from iFactory Data base
        bool GetUnitInfo(string TRACER_WIP)
        {
            string[] info = _iFactoryInfo.GetWIPInfo(TRACER_WIP);
            WIP = info[0];
            TRACER = info[1];
            CLASS = info[2];
            MC = info[3];
            Properties.Settings.Default.Tars_Assembly = CLASS;

            lblTracer.Text =  "Tracer: " + TRACER;
            lblWip.Text = "Wip: " + WIP;
            lblClass.Text = "Class: " + MC;

            if(WIP.Contains("The underlying") || WIP == "Serial Not Found" || CLASS == "Serial Not Found" || MC == "Serial Not Found" || WIP == "There is no row at position 0.")
            {
                lblInvalidSN.Text = "Longitud de numero de serie invalida";
                lblInvalidSN.Visible = true;
                txBoxSN.Clear();
                txBoxSN.Focus();
                return false;
            }

            txBoxSN.Text = WIP;
            return true;
        }

        //Validate the previous ifactory steps
        Tuple<bool, bool> iFactoryValidation(string wip)
        {
            int Loops = 1;
            int numSteps = 0;
            string STEP = "";
            string STATUS = "";
            string DATE = "";
            string OPERATOR = "";
            bool STEPVAL1 = false;
            bool STEPVAL2 = false;

            try
            {      
                ds = _iFactoryInfo.GetHistory(wip);                
                dt = ds.Tables[0];
                numSteps = dt.Rows.Count;
                numSteps = numSteps - 1;

                while (Loops <= numSteps)
                {
                    var varDate = dt.Rows[Loops]["ArrivalTime"];
                    DATE = varDate.ToString();
                    var varStep = dt.Rows[Loops]["ProcessName"];
                    STEP = varStep.ToString();
                    var varOperator = dt.Rows[Loops]["Operator"];
                    OPERATOR = varOperator.ToString();
                    var varStepStatus = dt.Rows[Loops]["ProcessResult"];
                    STATUS = varStepStatus.ToString();

                    if (STEP == "BUTTON UP" && STATUS == "Passed") STEPVAL1 = true;
                    if (STEP == "BUTTON UP AND ACCESSORIES" && STATUS == "Passed") STEPVAL1 = true;
                    if (STEP == "ACCESSORIES INSPECTION" && STATUS == "Passed") STEPVAL2 = true;

                    Loops = Loops + 1;
                    System.Threading.Thread.Sleep(50);                 
                }     
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return Tuple.Create(STEPVAL1, STEPVAL2);
        }


        private void btnStop_Click(object sender, EventArgs e)
		{
			// Manually stop video, this execute finalization function
			timerRecording_Tick(sender,e);
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			// This timer gives focus to SN Box
			txBoxSN.Focus();
			timer1.Enabled = false;
		}

		private void timerAutoSec_Tick(object sender, EventArgs e)
		{
			// This timer sets the seconds count down label
			txBoxIndications.Text = VideoString + "\nAUTO: " + Seconds +" segundos restantes";
			Seconds -= 1;
		}

		private void CreateTarsFile()
		{
			// This function creates TARS file to report to IFactory

			string path = Properties.Settings.Default.Tars_Path;
			string Date = System.DateTime.Now.ToString();
			Date = Date.Replace(':', '_');
			Date = Date.Replace('/', '_');
			path += txBoxSN.Text + "_" + Date + ".tar";
			using (StreamWriter sw = File.CreateText(path))
			{
				sw.WriteLine("S"+ txBoxSN.Text);
				sw.WriteLine("C"+ Properties.Settings.Default.Tars_Customer);
				sw.WriteLine("N"+ Properties.Settings.Default.Tars_Equipment);
				sw.WriteLine("P" + Properties.Settings.Default.Tars_Process);
				sw.WriteLine("TP");
				sw.WriteLine("n" + Properties.Settings.Default.Tars_Assembly);
				sw.WriteLine("O" + Environment.UserName);
				sw.WriteLine("[" + System.DateTime.Now.ToString());
				sw.WriteLine("]" + System.DateTime.Now.ToString());
			}
		}

        void CreateLogXML(string STATUS)
        {
            //Create DataTable 
            DataTable tableLOG;
            tableLOG = new DataTable("NCR_PACKOUT_CAMERAS");
            tableLOG.Columns.Add("DATE");
            tableLOG.Columns.Add("WIP");
            tableLOG.Columns.Add("ASSEMBLY");
            tableLOG.Columns.Add("CUSTOMER");
            tableLOG.Columns.Add("STEPNAME");
            tableLOG.Columns.Add("RESOURCENAME");
            tableLOG.Columns.Add("STATUS");

            DateTime date = DateTime.Now;
            string WIP = txBoxSN.Text.TrimEnd().TrimStart();
            string ASSY = Properties.Settings.Default.Tars_Assembly;
            string Customer = Properties.Settings.Default.Tars_Customer;
            string StepName = Properties.Settings.Default.Tars_Process;      
            string ResourceName = Properties.Settings.Default.Tars_Equipment;  
            string Status = STATUS;
            //string LOGSBK = @"\\mxchim0pangea01\SSCO_IMAGES\LOGS\VIDEOCAM\";

            tableLOG.Rows.Add(date.ToString(), WIP, ASSY, Customer, StepName, ResourceName, Status);

            //string outputPath = "";
            //outputPath = LOGSBK + DateTime.Now.ToString("MM_yyyy_dd") + @"\" + DateTime.Now.ToString("HH") + @"\";
            //DirectoryInfo DirInfo = new DirectoryInfo(outputPath);

            //if (!DirInfo.Exists)
            //{
            //    DirInfo.Create();
            //}
         
            string Date = System.DateTime.Now.ToString();
            Date = Date.Replace(':', '_');
            Date = Date.Replace('/', '_');         

            DataSet setXML = new DataSet("VIDEOCAM");
            setXML.Tables.Add(tableLOG);
            string XML = setXML.GetXml();
            File.WriteAllText(Properties.Settings.Default.XML_Path + WIP + "_" + Date + ".xml", XML);
            //File.WriteAllText(outputPath + WIP + "_" + Date + ".xml", XML);
            setXML.Tables.Remove(tableLOG);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnConfig_Click(object sender, EventArgs e)
		{
			// When Configuration button is pressed, this will open CameraSetting Form

			CameraSetting CamSettings = new CameraSetting();
			CamSettings.ShowDialog();
			// When the CameraSetting form has been closed, will load some configurations
			lblCamera1.Enabled = Properties.Settings.Default.CamActive_1;
			lblCamera2.Enabled = Properties.Settings.Default.CamActive_2;
			lblCamera3.Enabled = Properties.Settings.Default.CamActive_3;
			lblCamera4.Enabled = Properties.Settings.Default.CamActive_4;
			lblCamera5.Enabled = Properties.Settings.Default.CamActive_5;
			txBoxSN.MaxLength = Properties.Settings.Default.SNLength;
			txBoxSN.Focus();


            lblRecursoActivo.Text = Properties.Settings.Default.Tars_Process;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {       
            _camera = null;
            if (Properties.Settings.Default.CamActive_1) //Function only run if the cam1 is active in the settings
            {
                if (_camera == null) //Stop video and camera if there is a camera running.
                {
                    string cameraURL = Properties.Settings.Default.CameraID_1;
                    _camera = new OzekiCamera(cameraURL);
                    videoViewerWF1.Stop();
                    _camera.Stop();
                    _connectorViewer.Disconnect(_camera.VideoChannel, _imageProvider);
                }
            }

            _camera = null;
            if (Properties.Settings.Default.CamActive_2) //Function only run if the cam1 is active in the settings
            {
                if (_camera == null) //Stop video and camera if there is a camera running.
                {
                    string cameraURL = Properties.Settings.Default.CameraID_2;
                    _camera = new OzekiCamera(cameraURL);
                    videoViewerWF1.Stop();
                    _camera.Stop();
                    _connectorViewer.Disconnect(_camera.VideoChannel, _imageProvider);
                }
            }

            _camera = null;
            if (Properties.Settings.Default.CamActive_3) //Function only run if the cam1 is active in the settings
            {
                if (_camera == null) //Stop video and camera if there is a camera running.
                {
                    string cameraURL = Properties.Settings.Default.CameraID_3;
                    _camera = new OzekiCamera(cameraURL);
                    videoViewerWF1.Stop();
                    _camera.Stop();
                    _connectorViewer.Disconnect(_camera.VideoChannel, _imageProvider);
                }
            }

            _camera = null;
            if (Properties.Settings.Default.CamActive_4) //Function only run if the cam1 is active in the settings
            {
                if (_camera == null) //Stop video and camera if there is a camera running.
                {
                    string cameraURL = Properties.Settings.Default.CameraID_4;
                    _camera = new OzekiCamera(cameraURL);
                    videoViewerWF1.Stop();
                    _camera.Stop();
                    _connectorViewer.Disconnect(_camera.VideoChannel, _imageProvider);
                }
            }

            _camera = null;
            if (Properties.Settings.Default.CamActive_5) //Function only run if the cam1 is active in the settings
            {
                if (_camera == null) //Stop video and camera if there is a camera running.
                {
                    string cameraURL = Properties.Settings.Default.CameraID_5;
                    _camera = new OzekiCamera(cameraURL);
                    videoViewerWF1.Stop();
                    _camera.Stop();
                    _connectorViewer.Disconnect(_camera.VideoChannel, _imageProvider);
                }
            }
        }

     
        private void btnCancel_Click(object sender, EventArgs e)
        {
            lblTracer.Text = "Tracer:";
            lblWip.Text = "Wip:";
            lblClass.Text = "Class:";
            txBoxSN.Enabled = true;
            //btnConfig.Enabled = true;
            txBoxIndications.Clear();
            btnStart.Enabled = false;
            txBoxSN.Clear();
            txBoxSN.Focus();
        }


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void tableLayoutPanel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }    
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picErrorCam_2_Click(object sender, EventArgs e)
        {

        }



        bool CheckParserIsRunning()
        {
            bool result = true;
            try
            {
                string processname = Properties.Settings.Default.ParserName;
                Process[] parser = Process.GetProcessesByName(Properties.Settings.Default.ParserName);
                if(parser.Length == 0)
                {
                    result = false;
                }
            }
            catch(Exception ex)
            {

            }
            return result;       
        }

        string OpenExe(string FileName, string Args)
        {
            string _ProgStatus = "";
            Process _process = new Process();
            _process.StartInfo.FileName = FileName;
            _process.Start();
            _process.WaitForExit();
            return _ProgStatus;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (!btnConfig.Enabled)
            {
                if (keyData == (Keys.Control | Keys.P))
                {
                    btnConfig.Enabled = true;
                    picLock.Image = Properties.Resources.lockOpen;
                    return true;
                }
            }

            if (btnConfig.Enabled)
            {
                if (keyData == (Keys.Control | Keys.P))
                {
                    btnConfig.Enabled = false;
                    picLock.Visible = true;
                    picLock.Image = Properties.Resources.lockpng;
                    return true;
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
