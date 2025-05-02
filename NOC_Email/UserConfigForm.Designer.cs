namespace NOC_Email
{
	partial class UserConfigForm
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBox_EmailDaTelecom;
		private System.Windows.Forms.ComboBox comboBox_ContatoTelecom;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ComboBox comboBox_RazaoSocial;
		private System.Windows.Forms.ComboBox comboBox_ExpedienteDoCliente;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button btnExitApplication;
		private System.Windows.Forms.Button btnSalvarExpedienteDoCliente;
		private System.Windows.Forms.Button btnSalvarRazaoSocial;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnHistórico;
		private System.Windows.Forms.Label label_aviso;
		
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnSalvarExpedienteDoCliente = new System.Windows.Forms.Button();
			this.comboBox_RazaoSocial = new System.Windows.Forms.ComboBox();
			this.button2 = new System.Windows.Forms.Button();
			this.btnSalvarRazaoSocial = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.comboBox_ExpedienteDoCliente = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBox_EmailDaTelecom = new System.Windows.Forms.ComboBox();
			this.comboBox_ContatoTelecom = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.btnExitApplication = new System.Windows.Forms.Button();
			this.btnHistórico = new System.Windows.Forms.Button();
			this.label_aviso = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(97, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "Razão Social";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(17, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 21);
			this.label2.TabIndex = 1;
			this.label2.Text = "Expediente";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.panel1.Controls.Add(this.btnSalvarExpedienteDoCliente);
			this.panel1.Controls.Add(this.comboBox_RazaoSocial);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.btnSalvarRazaoSocial);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.comboBox_ExpedienteDoCliente);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.comboBox_EmailDaTelecom);
			this.panel1.Controls.Add(this.comboBox_ContatoTelecom);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(463, 230);
			this.panel1.TabIndex = 9;
			// 
			// btnSalvarExpedienteDoCliente
			// 
			this.btnSalvarExpedienteDoCliente.Location = new System.Drawing.Point(375, 45);
			this.btnSalvarExpedienteDoCliente.Name = "btnSalvarExpedienteDoCliente";
			this.btnSalvarExpedienteDoCliente.Size = new System.Drawing.Size(75, 23);
			this.btnSalvarExpedienteDoCliente.TabIndex = 13;
			this.btnSalvarExpedienteDoCliente.Text = "Salvar";
			this.btnSalvarExpedienteDoCliente.UseVisualStyleBackColor = true;
			this.btnSalvarExpedienteDoCliente.Click += new System.EventHandler(this.BtnSalvarExpedienteDoClienteClick);
			// 
			// comboBox_RazaoSocial
			// 
			this.comboBox_RazaoSocial.FormattingEnabled = true;
			this.comboBox_RazaoSocial.Location = new System.Drawing.Point(119, 15);
			this.comboBox_RazaoSocial.Name = "comboBox_RazaoSocial";
			this.comboBox_RazaoSocial.Size = new System.Drawing.Size(250, 21);
			this.comboBox_RazaoSocial.TabIndex = 11;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(377, 153);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 8;
			this.button2.Text = "Salvar";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// btnSalvarRazaoSocial
			// 
			this.btnSalvarRazaoSocial.Location = new System.Drawing.Point(375, 15);
			this.btnSalvarRazaoSocial.Name = "btnSalvarRazaoSocial";
			this.btnSalvarRazaoSocial.Size = new System.Drawing.Size(75, 23);
			this.btnSalvarRazaoSocial.TabIndex = 12;
			this.btnSalvarRazaoSocial.Text = "Salvar";
			this.btnSalvarRazaoSocial.UseVisualStyleBackColor = true;
			this.btnSalvarRazaoSocial.Click += new System.EventHandler(this.BtnSalvarRazaoSocialClick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(377, 123);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 7;
			this.button1.Text = "Salvar";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// comboBox_ExpedienteDoCliente
			// 
			this.comboBox_ExpedienteDoCliente.FormattingEnabled = true;
			this.comboBox_ExpedienteDoCliente.Location = new System.Drawing.Point(119, 42);
			this.comboBox_ExpedienteDoCliente.Name = "comboBox_ExpedienteDoCliente";
			this.comboBox_ExpedienteDoCliente.Size = new System.Drawing.Size(250, 21);
			this.comboBox_ExpedienteDoCliente.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(79, 152);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 21);
			this.label5.TabIndex = 6;
			this.label5.Text = "Telefone";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(92, 125);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 21);
			this.label4.TabIndex = 5;
			this.label4.Text = "E-mail";
			// 
			// comboBox_EmailDaTelecom
			// 
			this.comboBox_EmailDaTelecom.FormattingEnabled = true;
			this.comboBox_EmailDaTelecom.Location = new System.Drawing.Point(152, 125);
			this.comboBox_EmailDaTelecom.Name = "comboBox_EmailDaTelecom";
			this.comboBox_EmailDaTelecom.Size = new System.Drawing.Size(217, 21);
			this.comboBox_EmailDaTelecom.TabIndex = 3;
			// 
			// comboBox_ContatoTelecom
			// 
			this.comboBox_ContatoTelecom.FormattingEnabled = true;
			this.comboBox_ContatoTelecom.Location = new System.Drawing.Point(152, 152);
			this.comboBox_ContatoTelecom.Name = "comboBox_ContatoTelecom";
			this.comboBox_ContatoTelecom.Size = new System.Drawing.Size(217, 21);
			this.comboBox_ContatoTelecom.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(16, 89);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(135, 21);
			this.label3.TabIndex = 2;
			this.label3.Text = "Forma de Contato";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.label6.Location = new System.Drawing.Point(2, 61);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(465, 21);
			this.label6.TabIndex = 14;
			this.label6.Text = "_________________________________________________________________";
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Transparent;
			this.button3.Location = new System.Drawing.Point(373, 239);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 10;
			this.button3.Text = "Cancelar";
			this.button3.UseVisualStyleBackColor = false;
			// 
			// btnExitApplication
			// 
			this.btnExitApplication.Location = new System.Drawing.Point(292, 239);
			this.btnExitApplication.Name = "btnExitApplication";
			this.btnExitApplication.Size = new System.Drawing.Size(75, 23);
			this.btnExitApplication.TabIndex = 11;
			this.btnExitApplication.Text = "Ok";
			this.btnExitApplication.UseVisualStyleBackColor = true;
			// 
			// btnHistórico
			// 
			this.btnHistórico.Location = new System.Drawing.Point(211, 239);
			this.btnHistórico.Name = "btnHistórico";
			this.btnHistórico.Size = new System.Drawing.Size(75, 23);
			this.btnHistórico.TabIndex = 12;
			this.btnHistórico.Text = "Histórico ...";
			this.btnHistórico.UseVisualStyleBackColor = true;
			// 
			// label_aviso
			// 
			this.label_aviso.AutoSize = true;
			this.label_aviso.Location = new System.Drawing.Point(2, 238);
			this.label_aviso.Name = "label_aviso";
			this.label_aviso.Size = new System.Drawing.Size(0, 13);
			this.label_aviso.TabIndex = 13;
			// 
			// UserConfigForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(457, 270);
			this.Controls.Add(this.label_aviso);
			this.Controls.Add(this.btnHistórico);
			this.Controls.Add(this.btnExitApplication);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Name = "UserConfigForm";
			this.Text = "UserConfig";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
