namespace NCR_Packout_Camera
{
	partial class ConfigureTARS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigureTARS));
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txCustomer = new System.Windows.Forms.TextBox();
            this.txtResource = new System.Windows.Forms.TextBox();
            this.txtStepName = new System.Windows.Forms.TextBox();
            this.txAssembly = new System.Windows.Forms.TextBox();
            this.txOutputPath = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOutputXML = new System.Windows.Forms.TextBox();
            this.btnReadIniFile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnVideoValidation1 = new System.Windows.Forms.RadioButton();
            this.rbtnVideoValidation2 = new System.Windows.Forms.RadioButton();
            this.rbtnVideoValidation3 = new System.Windows.Forms.RadioButton();
            this.rbtnKitVideo = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(308, 246);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 48);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(11, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(11, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Process:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(11, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Resource:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(10, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Assembly:";
            // 
            // txCustomer
            // 
            this.txCustomer.Location = new System.Drawing.Point(121, 57);
            this.txCustomer.Name = "txCustomer";
            this.txCustomer.Size = new System.Drawing.Size(307, 20);
            this.txCustomer.TabIndex = 8;
            // 
            // txtResource
            // 
            this.txtResource.Location = new System.Drawing.Point(121, 87);
            this.txtResource.Name = "txtResource";
            this.txtResource.Size = new System.Drawing.Size(307, 20);
            this.txtResource.TabIndex = 10;
            // 
            // txtStepName
            // 
            this.txtStepName.Location = new System.Drawing.Point(121, 117);
            this.txtStepName.Name = "txtStepName";
            this.txtStepName.Size = new System.Drawing.Size(307, 20);
            this.txtStepName.TabIndex = 11;
            // 
            // txAssembly
            // 
            this.txAssembly.Location = new System.Drawing.Point(121, 146);
            this.txAssembly.Name = "txAssembly";
            this.txAssembly.Size = new System.Drawing.Size(307, 20);
            this.txAssembly.TabIndex = 12;
            // 
            // txOutputPath
            // 
            this.txOutputPath.Location = new System.Drawing.Point(121, 176);
            this.txOutputPath.Name = "txOutputPath";
            this.txOutputPath.Size = new System.Drawing.Size(307, 20);
            this.txOutputPath.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(6, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Output Path TARS:";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.IndianRed;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(584, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(33, 32);
            this.btnExit.TabIndex = 30;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(5, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "CONFIGURE TARS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(6, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Output Path XML:";
            // 
            // txtOutputXML
            // 
            this.txtOutputXML.Location = new System.Drawing.Point(121, 211);
            this.txtOutputXML.Name = "txtOutputXML";
            this.txtOutputXML.Size = new System.Drawing.Size(307, 20);
            this.txtOutputXML.TabIndex = 35;
            // 
            // btnReadIniFile
            // 
            this.btnReadIniFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReadIniFile.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnReadIniFile.FlatAppearance.BorderSize = 0;
            this.btnReadIniFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadIniFile.ForeColor = System.Drawing.Color.Black;
            this.btnReadIniFile.Location = new System.Drawing.Point(444, 183);
            this.btnReadIniFile.Name = "btnReadIniFile";
            this.btnReadIniFile.Size = new System.Drawing.Size(167, 48);
            this.btnReadIniFile.TabIndex = 37;
            this.btnReadIniFile.Text = "LOAD SETTINGS";
            this.btnReadIniFile.UseVisualStyleBackColor = false;
            this.btnReadIniFile.Click += new System.EventHandler(this.btnReadIniFile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnKitVideo);
            this.groupBox1.Controls.Add(this.rbtnVideoValidation3);
            this.groupBox1.Controls.Add(this.rbtnVideoValidation2);
            this.groupBox1.Controls.Add(this.rbtnVideoValidation1);
            this.groupBox1.Location = new System.Drawing.Point(444, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 119);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "STATIONS";
            // 
            // rbtnVideoValidation1
            // 
            this.rbtnVideoValidation1.AutoSize = true;
            this.rbtnVideoValidation1.Location = new System.Drawing.Point(6, 28);
            this.rbtnVideoValidation1.Name = "rbtnVideoValidation1";
            this.rbtnVideoValidation1.Size = new System.Drawing.Size(134, 17);
            this.rbtnVideoValidation1.TabIndex = 0;
            this.rbtnVideoValidation1.TabStop = true;
            this.rbtnVideoValidation1.Text = "VIDEO VALIDATION 1";
            this.rbtnVideoValidation1.UseVisualStyleBackColor = true;
            // 
            // rbtnVideoValidation2
            // 
            this.rbtnVideoValidation2.AutoSize = true;
            this.rbtnVideoValidation2.Location = new System.Drawing.Point(6, 51);
            this.rbtnVideoValidation2.Name = "rbtnVideoValidation2";
            this.rbtnVideoValidation2.Size = new System.Drawing.Size(134, 17);
            this.rbtnVideoValidation2.TabIndex = 1;
            this.rbtnVideoValidation2.TabStop = true;
            this.rbtnVideoValidation2.Text = "VIDEO VALIDATION 2";
            this.rbtnVideoValidation2.UseVisualStyleBackColor = true;
            // 
            // rbtnVideoValidation3
            // 
            this.rbtnVideoValidation3.AutoSize = true;
            this.rbtnVideoValidation3.Location = new System.Drawing.Point(6, 74);
            this.rbtnVideoValidation3.Name = "rbtnVideoValidation3";
            this.rbtnVideoValidation3.Size = new System.Drawing.Size(134, 17);
            this.rbtnVideoValidation3.TabIndex = 2;
            this.rbtnVideoValidation3.TabStop = true;
            this.rbtnVideoValidation3.Text = "VIDEO VALIDATION 3";
            this.rbtnVideoValidation3.UseVisualStyleBackColor = true;
            // 
            // rbtnKitVideo
            // 
            this.rbtnKitVideo.AutoSize = true;
            this.rbtnKitVideo.Location = new System.Drawing.Point(6, 97);
            this.rbtnKitVideo.Name = "rbtnKitVideo";
            this.rbtnKitVideo.Size = new System.Drawing.Size(78, 17);
            this.rbtnKitVideo.TabIndex = 3;
            this.rbtnKitVideo.TabStop = true;
            this.rbtnKitVideo.Text = "KIT VIDEO";
            this.rbtnKitVideo.UseVisualStyleBackColor = true;
            // 
            // ConfigureTARS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(623, 306);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReadIniFile);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtOutputXML);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txOutputPath);
            this.Controls.Add(this.txAssembly);
            this.Controls.Add(this.txtStepName);
            this.Controls.Add(this.txtResource);
            this.Controls.Add(this.txCustomer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigureTARS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configure TARS File";
            this.Load += new System.EventHandler(this.ConfigureTARS_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ConfigureTARS_MouseDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txCustomer;
		private System.Windows.Forms.TextBox txtResource;
		private System.Windows.Forms.TextBox txtStepName;
		private System.Windows.Forms.TextBox txAssembly;
		private System.Windows.Forms.TextBox txOutputPath;
		private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOutputXML;
        private System.Windows.Forms.Button btnReadIniFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnKitVideo;
        private System.Windows.Forms.RadioButton rbtnVideoValidation3;
        private System.Windows.Forms.RadioButton rbtnVideoValidation2;
        private System.Windows.Forms.RadioButton rbtnVideoValidation1;
    }
}