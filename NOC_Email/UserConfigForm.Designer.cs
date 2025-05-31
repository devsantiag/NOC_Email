namespace NOC_Email
{
	partial class UserConfigForm
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBox_EmailDaTelecom;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnSalvarEmail;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ComboBox comboBox_RazaoSocial;
		private System.Windows.Forms.ComboBox comboBox_ExpedienteDoCliente;
		private System.Windows.Forms.Button btnSalvarExpedienteDoCliente;
		private System.Windows.Forms.Button btnSalvarRazaoSocial;
		private System.Windows.Forms.Label label6;
//		private System.Windows.Forms.Button btnWindowSair;
		private System.Windows.Forms.Label label_aviso;
		private System.Windows.Forms.ComboBox comboBox_TelefoneDeContato;
		private System.Windows.Forms.Button btnSalvarTelefone;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox comboBox_TipoDeDefeito;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panelConfiguracoes;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label btnCloseWindow;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSalvarTipoDeDefeito;
		private System.Windows.Forms.Button btnDuvida;
		private System.Windows.Forms.Button btnWindowOk;
		
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
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.comboBox_TipoDeDefeito = new System.Windows.Forms.ComboBox();
			this.comboBox_TelefoneDeContato = new System.Windows.Forms.ComboBox();
			this.comboBox_EmailDaTelecom = new System.Windows.Forms.ComboBox();
			this.comboBox_ExpedienteDoCliente = new System.Windows.Forms.ComboBox();
			this.comboBox_RazaoSocial = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.btnSalvarTipoDeDefeito = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.btnSalvarTelefone = new System.Windows.Forms.Button();
			this.btnSalvarExpedienteDoCliente = new System.Windows.Forms.Button();
			this.btnSalvarRazaoSocial = new System.Windows.Forms.Button();
			this.btnSalvarEmail = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label_aviso = new System.Windows.Forms.Label();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.panelConfiguracoes = new System.Windows.Forms.Panel();
			this.btnCloseWindow = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.btnWindowOk = new System.Windows.Forms.Button();
			this.btnDuvida = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panelConfiguracoes.SuspendLayout();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(24, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 21);
			this.label2.TabIndex = 1;
			this.label2.Text = "Expediente";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.panel1.Controls.Add(this.comboBox_TipoDeDefeito);
			this.panel1.Controls.Add(this.comboBox_TelefoneDeContato);
			this.panel1.Controls.Add(this.comboBox_EmailDaTelecom);
			this.panel1.Controls.Add(this.comboBox_ExpedienteDoCliente);
			this.panel1.Controls.Add(this.comboBox_RazaoSocial);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.btnSalvarTipoDeDefeito);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.btnSalvarTelefone);
			this.panel1.Controls.Add(this.btnSalvarExpedienteDoCliente);
			this.panel1.Controls.Add(this.btnSalvarRazaoSocial);
			this.panel1.Controls.Add(this.btnSalvarEmail);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Location = new System.Drawing.Point(12, 36);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(463, 326);
			this.panel1.TabIndex = 9;
			// 
			// comboBox_TipoDeDefeito
			// 
			this.comboBox_TipoDeDefeito.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox_TipoDeDefeito.FormattingEnabled = true;
			this.comboBox_TipoDeDefeito.Location = new System.Drawing.Point(115, 272);
			this.comboBox_TipoDeDefeito.Name = "comboBox_TipoDeDefeito";
			this.comboBox_TipoDeDefeito.Size = new System.Drawing.Size(254, 25);
			this.comboBox_TipoDeDefeito.TabIndex = 19;
			// 
			// comboBox_TelefoneDeContato
			// 
			this.comboBox_TelefoneDeContato.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox_TelefoneDeContato.FormattingEnabled = true;
			this.comboBox_TelefoneDeContato.Location = new System.Drawing.Point(115, 178);
			this.comboBox_TelefoneDeContato.Name = "comboBox_TelefoneDeContato";
			this.comboBox_TelefoneDeContato.Size = new System.Drawing.Size(254, 25);
			this.comboBox_TelefoneDeContato.TabIndex = 15;
			// 
			// comboBox_EmailDaTelecom
			// 
			this.comboBox_EmailDaTelecom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox_EmailDaTelecom.FormattingEnabled = true;
			this.comboBox_EmailDaTelecom.Location = new System.Drawing.Point(115, 151);
			this.comboBox_EmailDaTelecom.Name = "comboBox_EmailDaTelecom";
			this.comboBox_EmailDaTelecom.Size = new System.Drawing.Size(254, 25);
			this.comboBox_EmailDaTelecom.TabIndex = 3;
			// 
			// comboBox_ExpedienteDoCliente
			// 
			this.comboBox_ExpedienteDoCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox_ExpedienteDoCliente.FormattingEnabled = true;
			this.comboBox_ExpedienteDoCliente.Location = new System.Drawing.Point(119, 68);
			this.comboBox_ExpedienteDoCliente.Name = "comboBox_ExpedienteDoCliente";
			this.comboBox_ExpedienteDoCliente.Size = new System.Drawing.Size(250, 25);
			this.comboBox_ExpedienteDoCliente.TabIndex = 10;
			// 
			// comboBox_RazaoSocial
			// 
			this.comboBox_RazaoSocial.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox_RazaoSocial.FormattingEnabled = true;
			this.comboBox_RazaoSocial.Location = new System.Drawing.Point(119, 41);
			this.comboBox_RazaoSocial.Name = "comboBox_RazaoSocial";
			this.comboBox_RazaoSocial.Size = new System.Drawing.Size(250, 25);
			this.comboBox_RazaoSocial.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.label1.Location = new System.Drawing.Point(2, 304);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(458, 21);
			this.label1.TabIndex = 23;
			this.label1.Text = "________________________________________________________________";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.SystemColors.ControlLight;
			this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(11, 238);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(111, 21);
			this.label10.TabIndex = 22;
			this.label10.Text = "Tipo de reparo";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.SystemColors.ControlLight;
			this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(11, 9);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(183, 21);
			this.label9.TabIndex = 21;
			this.label9.Text = "Informações do Contrato";
			// 
			// btnSalvarTipoDeDefeito
			// 
			this.btnSalvarTipoDeDefeito.AutoSize = true;
			this.btnSalvarTipoDeDefeito.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.btnSalvarTipoDeDefeito.Location = new System.Drawing.Point(373, 271);
			this.btnSalvarTipoDeDefeito.Name = "btnSalvarTipoDeDefeito";
			this.btnSalvarTipoDeDefeito.Size = new System.Drawing.Size(75, 27);
			this.btnSalvarTipoDeDefeito.TabIndex = 20;
			this.btnSalvarTipoDeDefeito.Text = "Salvar";
			this.btnSalvarTipoDeDefeito.UseVisualStyleBackColor = true;
			this.btnSalvarTipoDeDefeito.Click += new System.EventHandler(this.BtnSalvarTipoDeDefeitoClick);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.SystemColors.ControlLight;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(42, 273);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(60, 21);
			this.label8.TabIndex = 18;
			this.label8.Text = "Defeito";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.SystemColors.ControlLight;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.label7.Location = new System.Drawing.Point(2, 209);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(458, 21);
			this.label7.TabIndex = 17;
			this.label7.Text = "________________________________________________________________";
			// 
			// btnSalvarTelefone
			// 
			this.btnSalvarTelefone.AutoSize = true;
			this.btnSalvarTelefone.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.btnSalvarTelefone.Location = new System.Drawing.Point(373, 176);
			this.btnSalvarTelefone.Name = "btnSalvarTelefone";
			this.btnSalvarTelefone.Size = new System.Drawing.Size(75, 27);
			this.btnSalvarTelefone.TabIndex = 16;
			this.btnSalvarTelefone.Text = "Salvar";
			this.btnSalvarTelefone.UseVisualStyleBackColor = true;
			this.btnSalvarTelefone.Click += new System.EventHandler(this.BtnSalvarTelefoneClick);
			// 
			// btnSalvarExpedienteDoCliente
			// 
			this.btnSalvarExpedienteDoCliente.AutoSize = true;
			this.btnSalvarExpedienteDoCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.btnSalvarExpedienteDoCliente.Location = new System.Drawing.Point(373, 67);
			this.btnSalvarExpedienteDoCliente.Name = "btnSalvarExpedienteDoCliente";
			this.btnSalvarExpedienteDoCliente.Size = new System.Drawing.Size(75, 27);
			this.btnSalvarExpedienteDoCliente.TabIndex = 13;
			this.btnSalvarExpedienteDoCliente.Text = "Salvar";
			this.btnSalvarExpedienteDoCliente.UseVisualStyleBackColor = true;
			this.btnSalvarExpedienteDoCliente.Click += new System.EventHandler(this.BtnSalvarExpedienteDoClienteClick);
			// 
			// btnSalvarRazaoSocial
			// 
			this.btnSalvarRazaoSocial.AutoSize = true;
			this.btnSalvarRazaoSocial.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.btnSalvarRazaoSocial.Location = new System.Drawing.Point(373, 39);
			this.btnSalvarRazaoSocial.Name = "btnSalvarRazaoSocial";
			this.btnSalvarRazaoSocial.Size = new System.Drawing.Size(75, 27);
			this.btnSalvarRazaoSocial.TabIndex = 12;
			this.btnSalvarRazaoSocial.Text = "Salvar";
			this.btnSalvarRazaoSocial.UseVisualStyleBackColor = true;
			this.btnSalvarRazaoSocial.Click += new System.EventHandler(this.BtnSalvarRazaoSocialClick);
			// 
			// btnSalvarEmail
			// 
			this.btnSalvarEmail.AutoSize = true;
			this.btnSalvarEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.btnSalvarEmail.Location = new System.Drawing.Point(373, 149);
			this.btnSalvarEmail.Name = "btnSalvarEmail";
			this.btnSalvarEmail.Size = new System.Drawing.Size(75, 27);
			this.btnSalvarEmail.TabIndex = 7;
			this.btnSalvarEmail.Text = "Salvar";
			this.btnSalvarEmail.UseVisualStyleBackColor = true;
			this.btnSalvarEmail.Click += new System.EventHandler(this.BtnSalvarEmailClick);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(42, 179);
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
			this.label4.Location = new System.Drawing.Point(55, 151);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 21);
			this.label4.TabIndex = 5;
			this.label4.Text = "E-mail";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(11, 118);
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
			this.label6.Location = new System.Drawing.Point(2, 91);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(458, 21);
			this.label6.TabIndex = 14;
			this.label6.Text = "________________________________________________________________";
			// 
			// label_aviso
			// 
			this.label_aviso.AutoSize = true;
			this.label_aviso.Location = new System.Drawing.Point(2, 238);
			this.label_aviso.Name = "label_aviso";
			this.label_aviso.Size = new System.Drawing.Size(0, 13);
			this.label_aviso.TabIndex = 13;
			// 
			// btnExcluir
			// 
			this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcluir.Location = new System.Drawing.Point(254, 378);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(111, 40);
			this.btnExcluir.TabIndex = 14;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.UseVisualStyleBackColor = true;
			this.btnExcluir.Click += new System.EventHandler(this.BtnExcluirClick);
			// 
			// panelConfiguracoes
			// 
			this.panelConfiguracoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(93)))));
			this.panelConfiguracoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.panelConfiguracoes.Controls.Add(this.btnCloseWindow);
			this.panelConfiguracoes.Controls.Add(this.label11);
			this.panelConfiguracoes.Location = new System.Drawing.Point(0, 0);
			this.panelConfiguracoes.Name = "panelConfiguracoes";
			this.panelConfiguracoes.Size = new System.Drawing.Size(490, 32);
			this.panelConfiguracoes.TabIndex = 23;
			// 
			// btnCloseWindow
			// 
			this.btnCloseWindow.AutoSize = true;
			this.btnCloseWindow.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCloseWindow.Location = new System.Drawing.Point(459, 1);
			this.btnCloseWindow.Name = "btnCloseWindow";
			this.btnCloseWindow.Size = new System.Drawing.Size(25, 30);
			this.btnCloseWindow.TabIndex = 23;
			this.btnCloseWindow.Text = "X";
			this.btnCloseWindow.Click += new System.EventHandler(this.BtnCloseWindowClick);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.White;
			this.label11.Location = new System.Drawing.Point(3, 5);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(134, 25);
			this.label11.TabIndex = 23;
			this.label11.Text = "Configurações";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.BackColor = System.Drawing.SystemColors.ControlLight;
			this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(24, 78);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(97, 21);
			this.label13.TabIndex = 24;
			this.label13.Text = "Razão Social";
			// 
			// btnWindowOk
			// 
			this.btnWindowOk.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnWindowOk.Location = new System.Drawing.Point(371, 378);
			this.btnWindowOk.Name = "btnWindowOk";
			this.btnWindowOk.Size = new System.Drawing.Size(111, 40);
			this.btnWindowOk.TabIndex = 25;
			this.btnWindowOk.Text = "Ok";
			this.btnWindowOk.UseVisualStyleBackColor = true;
			this.btnWindowOk.Click += new System.EventHandler(this.btnWindowOkClick);
			// 
			// btnDuvida
			// 
			this.btnDuvida.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.btnDuvida.Location = new System.Drawing.Point(12, 384);
			this.btnDuvida.Name = "btnDuvida";
			this.btnDuvida.Size = new System.Drawing.Size(33, 29);
			this.btnDuvida.TabIndex = 1;
			this.btnDuvida.Text = "?";
			this.btnDuvida.UseVisualStyleBackColor = true;
			this.btnDuvida.Click += new System.EventHandler(this.BtnDuvidaClick);
			// 
			// UserConfigForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(488, 441);
			this.Controls.Add(this.btnWindowOk);
			this.Controls.Add(this.btnDuvida);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.panelConfiguracoes);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.label_aviso);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "UserConfigForm";
			this.Text = "UserConfig";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panelConfiguracoes.ResumeLayout(false);
			this.panelConfiguracoes.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
