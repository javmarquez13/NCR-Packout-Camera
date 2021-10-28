namespace NCR_Packout_Camera
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
            this.txBoxSN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCamera1 = new System.Windows.Forms.Label();
            this.lblCamera2 = new System.Windows.Forms.Label();
            this.lblCamera3 = new System.Windows.Forms.Label();
            this.lblCamera4 = new System.Windows.Forms.Label();
            this.timerRecording = new System.Windows.Forms.Timer(this.components);
            this.lblInvalidSN = new System.Windows.Forms.Label();
            this.lblCamera5 = new System.Windows.Forms.Label();
            this.picErrorCam_5 = new System.Windows.Forms.PictureBox();
            this.picErrorCam_1 = new System.Windows.Forms.PictureBox();
            this.picErrorCam_2 = new System.Windows.Forms.PictureBox();
            this.picShot_2 = new System.Windows.Forms.PictureBox();
            this.picShot_1 = new System.Windows.Forms.PictureBox();
            this.picErrorCam_3 = new System.Windows.Forms.PictureBox();
            this.picShot_3 = new System.Windows.Forms.PictureBox();
            this.picErrorCam_4 = new System.Windows.Forms.PictureBox();
            this.picShot_4 = new System.Windows.Forms.PictureBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblWip = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTracer = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.txBoxIndications = new System.Windows.Forms.RichTextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnAbortVideoRecording = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerAutoSec = new System.Windows.Forms.Timer(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.lblRecursoActivo = new System.Windows.Forms.Label();
            this.picLock = new System.Windows.Forms.PictureBox();
            this.picRecording = new System.Windows.Forms.PictureBox();
            this.picShot_5 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.videoViewerWF1 = new Ozeki.Media.VideoViewerWF();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorCam_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorCam_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorCam_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShot_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShot_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorCam_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShot_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorCam_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShot_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRecording)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShot_5)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txBoxSN
            // 
            this.txBoxSN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txBoxSN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(54)))));
            this.txBoxSN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txBoxSN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel2.SetColumnSpan(this.txBoxSN, 3);
            this.txBoxSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBoxSN.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txBoxSN.Location = new System.Drawing.Point(3, 32);
            this.txBoxSN.Multiline = true;
            this.txBoxSN.Name = "txBoxSN";
            this.txBoxSN.Size = new System.Drawing.Size(174, 23);
            this.txBoxSN.TabIndex = 1;
            this.txBoxSN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label1, 3);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(32, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Numero de serie:";
            // 
            // lblCamera1
            // 
            this.lblCamera1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCamera1.AutoSize = true;
            this.lblCamera1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCamera1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblCamera1.Location = new System.Drawing.Point(94, 217);
            this.lblCamera1.Name = "lblCamera1";
            this.lblCamera1.Size = new System.Drawing.Size(78, 20);
            this.lblCamera1.TabIndex = 6;
            this.lblCamera1.Text = "Camara 1";
            // 
            // lblCamera2
            // 
            this.lblCamera2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCamera2.AutoSize = true;
            this.lblCamera2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCamera2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblCamera2.Location = new System.Drawing.Point(94, 270);
            this.lblCamera2.Name = "lblCamera2";
            this.lblCamera2.Size = new System.Drawing.Size(78, 20);
            this.lblCamera2.TabIndex = 7;
            this.lblCamera2.Text = "Camara 2";
            // 
            // lblCamera3
            // 
            this.lblCamera3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCamera3.AutoSize = true;
            this.lblCamera3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCamera3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblCamera3.Location = new System.Drawing.Point(94, 323);
            this.lblCamera3.Name = "lblCamera3";
            this.lblCamera3.Size = new System.Drawing.Size(78, 20);
            this.lblCamera3.TabIndex = 8;
            this.lblCamera3.Text = "Camara 3";
            // 
            // lblCamera4
            // 
            this.lblCamera4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCamera4.AutoSize = true;
            this.lblCamera4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCamera4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblCamera4.Location = new System.Drawing.Point(94, 376);
            this.lblCamera4.Name = "lblCamera4";
            this.lblCamera4.Size = new System.Drawing.Size(78, 20);
            this.lblCamera4.TabIndex = 9;
            this.lblCamera4.Text = "Camara 4";
            // 
            // timerRecording
            // 
            this.timerRecording.Interval = 10000;
            this.timerRecording.Tick += new System.EventHandler(this.timerRecording_Tick);
            // 
            // lblInvalidSN
            // 
            this.lblInvalidSN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblInvalidSN.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.lblInvalidSN, 3);
            this.lblInvalidSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidSN.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidSN.Location = new System.Drawing.Point(14, 58);
            this.lblInvalidSN.Name = "lblInvalidSN";
            this.lblInvalidSN.Size = new System.Drawing.Size(152, 18);
            this.lblInvalidSN.TabIndex = 16;
            this.lblInvalidSN.Text = "Invalid Serial Number!!";
            // 
            // lblCamera5
            // 
            this.lblCamera5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCamera5.AutoSize = true;
            this.lblCamera5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCamera5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblCamera5.Location = new System.Drawing.Point(94, 429);
            this.lblCamera5.Name = "lblCamera5";
            this.lblCamera5.Size = new System.Drawing.Size(78, 20);
            this.lblCamera5.TabIndex = 17;
            this.lblCamera5.Text = "Camara 5";
            // 
            // picErrorCam_5
            // 
            this.picErrorCam_5.Image = global::NCR_Packout_Camera.Properties.Resources.bad;
            this.picErrorCam_5.Location = new System.Drawing.Point(3, 416);
            this.picErrorCam_5.Name = "picErrorCam_5";
            this.picErrorCam_5.Size = new System.Drawing.Size(39, 43);
            this.picErrorCam_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picErrorCam_5.TabIndex = 18;
            this.picErrorCam_5.TabStop = false;
            // 
            // picErrorCam_1
            // 
            this.picErrorCam_1.Image = global::NCR_Packout_Camera.Properties.Resources.bad;
            this.picErrorCam_1.Location = new System.Drawing.Point(3, 204);
            this.picErrorCam_1.Name = "picErrorCam_1";
            this.picErrorCam_1.Size = new System.Drawing.Size(39, 43);
            this.picErrorCam_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picErrorCam_1.TabIndex = 8;
            this.picErrorCam_1.TabStop = false;
            // 
            // picErrorCam_2
            // 
            this.picErrorCam_2.Image = global::NCR_Packout_Camera.Properties.Resources.bad;
            this.picErrorCam_2.Location = new System.Drawing.Point(3, 257);
            this.picErrorCam_2.Name = "picErrorCam_2";
            this.picErrorCam_2.Size = new System.Drawing.Size(39, 43);
            this.picErrorCam_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picErrorCam_2.TabIndex = 19;
            this.picErrorCam_2.TabStop = false;
            this.picErrorCam_2.Click += new System.EventHandler(this.picErrorCam_2_Click);
            // 
            // picShot_2
            // 
            this.picShot_2.Image = global::NCR_Packout_Camera.Properties.Resources.good1;
            this.picShot_2.Location = new System.Drawing.Point(48, 257);
            this.picShot_2.Name = "picShot_2";
            this.picShot_2.Size = new System.Drawing.Size(35, 43);
            this.picShot_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShot_2.TabIndex = 11;
            this.picShot_2.TabStop = false;
            // 
            // picShot_1
            // 
            this.picShot_1.Image = global::NCR_Packout_Camera.Properties.Resources.good1;
            this.picShot_1.Location = new System.Drawing.Point(48, 204);
            this.picShot_1.Name = "picShot_1";
            this.picShot_1.Size = new System.Drawing.Size(35, 43);
            this.picShot_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShot_1.TabIndex = 10;
            this.picShot_1.TabStop = false;
            // 
            // picErrorCam_3
            // 
            this.picErrorCam_3.Image = global::NCR_Packout_Camera.Properties.Resources.bad;
            this.picErrorCam_3.Location = new System.Drawing.Point(3, 310);
            this.picErrorCam_3.Name = "picErrorCam_3";
            this.picErrorCam_3.Size = new System.Drawing.Size(39, 43);
            this.picErrorCam_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picErrorCam_3.TabIndex = 20;
            this.picErrorCam_3.TabStop = false;
            // 
            // picShot_3
            // 
            this.picShot_3.Image = global::NCR_Packout_Camera.Properties.Resources.good1;
            this.picShot_3.Location = new System.Drawing.Point(48, 310);
            this.picShot_3.Name = "picShot_3";
            this.picShot_3.Size = new System.Drawing.Size(35, 43);
            this.picShot_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShot_3.TabIndex = 12;
            this.picShot_3.TabStop = false;
            // 
            // picErrorCam_4
            // 
            this.picErrorCam_4.Image = global::NCR_Packout_Camera.Properties.Resources.bad;
            this.picErrorCam_4.Location = new System.Drawing.Point(3, 363);
            this.picErrorCam_4.Name = "picErrorCam_4";
            this.picErrorCam_4.Size = new System.Drawing.Size(39, 43);
            this.picErrorCam_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picErrorCam_4.TabIndex = 21;
            this.picErrorCam_4.TabStop = false;
            // 
            // picShot_4
            // 
            this.picShot_4.Image = global::NCR_Packout_Camera.Properties.Resources.good1;
            this.picShot_4.Location = new System.Drawing.Point(48, 363);
            this.picShot_4.Name = "picShot_4";
            this.picShot_4.Size = new System.Drawing.Size(35, 43);
            this.picShot_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShot_4.TabIndex = 13;
            this.picShot_4.TabStop = false;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.lblClass, 3);
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblClass.Location = new System.Drawing.Point(3, 132);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(46, 17);
            this.lblClass.TabIndex = 19;
            this.lblClass.Text = "Class:";
            // 
            // lblWip
            // 
            this.lblWip.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.lblWip, 3);
            this.lblWip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWip.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblWip.Location = new System.Drawing.Point(3, 110);
            this.lblWip.Name = "lblWip";
            this.lblWip.Size = new System.Drawing.Size(36, 17);
            this.lblWip.TabIndex = 18;
            this.lblWip.Text = "Wip:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(54)))));
            this.tableLayoutPanel2.SetColumnSpan(this.btnCancel, 3);
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancel.Location = new System.Drawing.Point(3, 157);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(175, 41);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTracer
            // 
            this.lblTracer.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.lblTracer, 3);
            this.lblTracer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTracer.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTracer.Location = new System.Drawing.Point(3, 83);
            this.lblTracer.Name = "lblTracer";
            this.lblTracer.Size = new System.Drawing.Size(54, 17);
            this.lblTracer.TabIndex = 17;
            this.lblTracer.Text = "Tracer:";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(54)))));
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnStart.Location = new System.Drawing.Point(3, 531);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(181, 42);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txBoxIndications
            // 
            this.txBoxIndications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.tableLayoutPanel1.SetColumnSpan(this.txBoxIndications, 3);
            this.txBoxIndications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txBoxIndications.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBoxIndications.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txBoxIndications.Location = new System.Drawing.Point(3, 3);
            this.txBoxIndications.Name = "txBoxIndications";
            this.txBoxIndications.ReadOnly = true;
            this.txBoxIndications.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txBoxIndications.Size = new System.Drawing.Size(557, 118);
            this.txBoxIndications.TabIndex = 5;
            this.txBoxIndications.Text = "";
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(54)))));
            this.btnStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnStop.Location = new System.Drawing.Point(190, 531);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(181, 42);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnAbortVideoRecording
            // 
            this.btnAbortVideoRecording.BackColor = System.Drawing.Color.IndianRed;
            this.btnAbortVideoRecording.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAbortVideoRecording.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnAbortVideoRecording.FlatAppearance.BorderSize = 0;
            this.btnAbortVideoRecording.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbortVideoRecording.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAbortVideoRecording.Location = new System.Drawing.Point(377, 531);
            this.btnAbortVideoRecording.Name = "btnAbortVideoRecording";
            this.btnAbortVideoRecording.Size = new System.Drawing.Size(183, 42);
            this.btnAbortVideoRecording.TabIndex = 8;
            this.btnAbortVideoRecording.Text = "ABORT VIDEO RECORDING";
            this.btnAbortVideoRecording.UseVisualStyleBackColor = false;
            this.btnAbortVideoRecording.Click += new System.EventHandler(this.btnAbortVideoRecording_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerAutoSec
            // 
            this.timerAutoSec.Interval = 1000;
            this.timerAutoSec.Tick += new System.EventHandler(this.timerAutoSec_Tick);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.IndianRed;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(743, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(24, 32);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(93)))), ((int)(((byte)(0)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMinimize.Location = new System.Drawing.Point(709, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(28, 32);
            this.btnMinimize.TabIndex = 26;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(21, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "NCR PACKOUT CAMERAS";
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblVersion.Location = new System.Drawing.Point(328, 17);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(53, 13);
            this.lblVersion.TabIndex = 20;
            this.lblVersion.Text = "VERSION";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(54)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(93)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(1013, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 32);
            this.button1.TabIndex = 27;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnConfig
            // 
            this.btnConfig.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(54)))));
            this.btnConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanel2.SetColumnSpan(this.btnConfig, 2);
            this.btnConfig.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnConfig.Location = new System.Drawing.Point(3, 507);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(80, 45);
            this.btnConfig.TabIndex = 21;
            this.btnConfig.Text = "SETTINGS";
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // lblRecursoActivo
            // 
            this.lblRecursoActivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRecursoActivo.AutoSize = true;
            this.lblRecursoActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecursoActivo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblRecursoActivo.Location = new System.Drawing.Point(478, 15);
            this.lblRecursoActivo.Name = "lblRecursoActivo";
            this.lblRecursoActivo.Size = new System.Drawing.Size(88, 17);
            this.lblRecursoActivo.TabIndex = 29;
            this.lblRecursoActivo.Text = "RECURSO:";
            // 
            // picLock
            // 
            this.picLock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picLock.Image = global::NCR_Packout_Camera.Properties.Resources.lockOpen;
            this.picLock.Location = new System.Drawing.Point(95, 502);
            this.picLock.Name = "picLock";
            this.picLock.Size = new System.Drawing.Size(77, 54);
            this.picLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLock.TabIndex = 28;
            this.picLock.TabStop = false;
            // 
            // picRecording
            // 
            this.picRecording.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picRecording.Image = global::NCR_Packout_Camera.Properties.Resources.recording;
            this.picRecording.Location = new System.Drawing.Point(591, 11);
            this.picRecording.Name = "picRecording";
            this.picRecording.Size = new System.Drawing.Size(102, 25);
            this.picRecording.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRecording.TabIndex = 7;
            this.picRecording.TabStop = false;
            // 
            // picShot_5
            // 
            this.picShot_5.Image = global::NCR_Packout_Camera.Properties.Resources.good1;
            this.picShot_5.Location = new System.Drawing.Point(48, 416);
            this.picShot_5.Name = "picShot_5";
            this.picShot_5.Size = new System.Drawing.Size(35, 43);
            this.picShot_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShot_5.TabIndex = 22;
            this.picShot_5.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnAbortVideoRecording, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.videoViewerWF1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txBoxIndications, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnStop, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnStart, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(199, 59);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.58093F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.22613F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.291457F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(563, 576);
            this.tableLayoutPanel1.TabIndex = 30;
            // 
            // videoViewerWF1
            // 
            this.videoViewerWF1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.tableLayoutPanel1.SetColumnSpan(this.videoViewerWF1, 3);
            this.videoViewerWF1.ContextMenuEnabled = true;
            this.videoViewerWF1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoViewerWF1.FlipMode = Ozeki.Media.FlipMode.None;
            this.videoViewerWF1.FrameStretch = Ozeki.Media.FrameStretch.Uniform;
            this.videoViewerWF1.FullScreenEnabled = true;
            this.videoViewerWF1.Location = new System.Drawing.Point(3, 127);
            this.videoViewerWF1.Name = "videoViewerWF1";
            this.videoViewerWF1.RotateAngle = 0;
            this.videoViewerWF1.Size = new System.Drawing.Size(557, 398);
            this.videoViewerWF1.TabIndex = 2;
            this.videoViewerWF1.Text = "videoViewerWF1";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.16176F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.83824F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txBoxSN, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblClass, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.picLock, 2, 13);
            this.tableLayoutPanel2.Controls.Add(this.lblInvalidSN, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblWip, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnConfig, 0, 13);
            this.tableLayoutPanel2.Controls.Add(this.lblTracer, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblCamera5, 2, 11);
            this.tableLayoutPanel2.Controls.Add(this.picShot_5, 1, 11);
            this.tableLayoutPanel2.Controls.Add(this.picErrorCam_5, 0, 11);
            this.tableLayoutPanel2.Controls.Add(this.lblCamera4, 2, 10);
            this.tableLayoutPanel2.Controls.Add(this.picShot_4, 1, 10);
            this.tableLayoutPanel2.Controls.Add(this.picErrorCam_4, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.picErrorCam_3, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.picShot_3, 1, 9);
            this.tableLayoutPanel2.Controls.Add(this.lblCamera3, 2, 9);
            this.tableLayoutPanel2.Controls.Add(this.lblCamera2, 2, 8);
            this.tableLayoutPanel2.Controls.Add(this.picShot_2, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.picErrorCam_2, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.picErrorCam_1, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.picShot_1, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.lblCamera1, 2, 7);
            this.tableLayoutPanel2.Controls.Add(this.btnCancel, 0, 6);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 62);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 14;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.293844F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.293844F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.528454F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.981299F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.075609F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.075609F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.490851F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.475791F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.475791F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.475791F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.475791F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.475791F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.655914F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.30107F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(181, 573);
            this.tableLayoutPanel2.TabIndex = 31;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.21411F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.36983F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.59854F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.501216F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.37197F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblVersion, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblRecursoActivo, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.picRecording, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnExit, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnMinimize, 4, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(770, 47);
            this.tableLayoutPanel3.TabIndex = 32;
            this.tableLayoutPanel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel3_MouseDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(770, 655);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NCR - Packout Camera System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.picErrorCam_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorCam_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorCam_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShot_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShot_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorCam_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShot_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorCam_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShot_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRecording)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShot_5)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
		private System.Windows.Forms.TextBox txBoxSN;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblCamera1;
		private System.Windows.Forms.Label lblCamera2;
		private System.Windows.Forms.Label lblCamera3;
		private System.Windows.Forms.Label lblCamera4;
		private System.Windows.Forms.Timer timerRecording;
		private System.Windows.Forms.PictureBox picShot_1;
		private System.Windows.Forms.PictureBox picShot_2;
		private System.Windows.Forms.PictureBox picShot_3;
		private System.Windows.Forms.PictureBox picShot_4;
		private System.Windows.Forms.Label lblInvalidSN;
		private System.Windows.Forms.Label lblCamera5;
		private System.Windows.Forms.PictureBox picErrorCam_5;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.RichTextBox txBoxIndications;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.PictureBox picRecording;
		private System.Windows.Forms.Timer timerAutoSec;
		private System.Windows.Forms.Button btnConfig;
		private System.Windows.Forms.PictureBox picErrorCam_1;
		private System.Windows.Forms.PictureBox picErrorCam_4;
		private System.Windows.Forms.PictureBox picErrorCam_3;
		private System.Windows.Forms.PictureBox picErrorCam_2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTracer;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblWip;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picLock;
        private System.Windows.Forms.Button btnAbortVideoRecording;
        private System.Windows.Forms.Label lblRecursoActivo;
        private System.Windows.Forms.PictureBox picShot_5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Ozeki.Media.VideoViewerWF videoViewerWF1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}

