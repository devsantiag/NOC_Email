/*
 * Created by SharpDevelop.
 * User: fjstavares
 * Date: 17/09/2024
 * Time: 10:57
 */
namespace NOC_Email
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox designacao;
		private System.Windows.Forms.TextBox enderecoComercial;
		private System.Windows.Forms.Button buttonEncaminharEmail;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button buttonApagar;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tituloDeReparo;
		private System.Windows.Forms.Button btnNotificarCliente;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox comboBox_RazaoSocial;
		private System.Windows.Forms.ComboBox comboBox_FormaDeContatoComCliente_Telefone;
		private System.Windows.Forms.Button btnConfig;
		private System.Windows.Forms.ComboBox comboBox_ExpedienteDoCliente;
		private System.Windows.Forms.ComboBox comboBox_TipoDeReparo;
		private System.Windows.Forms.ComboBox comboBox_FormaDeContatoComCliente_Email;
		private System.Windows.Forms.Label label8;
		
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
			this.designacao = new System.Windows.Forms.TextBox();
			this.enderecoComercial = new System.Windows.Forms.TextBox();
			this.buttonEncaminharEmail = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.buttonApagar = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.tituloDeReparo = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.comboBox_RazaoSocial = new System.Windows.Forms.ComboBox();
			this.comboBox_FormaDeContatoComCliente_Telefone = new System.Windows.Forms.ComboBox();
			this.btnNotificarCliente = new System.Windows.Forms.Button();
			this.btnConfig = new System.Windows.Forms.Button();
			this.comboBox_ExpedienteDoCliente = new System.Windows.Forms.ComboBox();
			this.comboBox_TipoDeReparo = new System.Windows.Forms.ComboBox();
			this.comboBox_FormaDeContatoComCliente_Email = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// designacao
			// 
			this.designacao.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.designacao.Location = new System.Drawing.Point(148, 77);
			this.designacao.MaxLength = 700000;
			this.designacao.Multiline = true;
			this.designacao.Name = "designacao";
			this.designacao.Size = new System.Drawing.Size(264, 25);
			this.designacao.TabIndex = 0;
			// 
			// enderecoComercial
			// 
			this.enderecoComercial.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.enderecoComercial.Location = new System.Drawing.Point(148, 114);
			this.enderecoComercial.MaxLength = 700000;
			this.enderecoComercial.Multiline = true;
			this.enderecoComercial.Name = "enderecoComercial";
			this.enderecoComercial.Size = new System.Drawing.Size(264, 25);
			this.enderecoComercial.TabIndex = 1;
			// 
			// buttonEncaminharEmail
			// 
			this.buttonEncaminharEmail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonEncaminharEmail.Location = new System.Drawing.Point(237, 305);
			this.buttonEncaminharEmail.Name = "buttonEncaminharEmail";
			this.buttonEncaminharEmail.Size = new System.Drawing.Size(85, 40);
			this.buttonEncaminharEmail.TabIndex = 8;
			this.buttonEncaminharEmail.Text = "Encaminhar";
			this.buttonEncaminharEmail.UseVisualStyleBackColor = true;
			this.buttonEncaminharEmail.Click += new System.EventHandler(this.ButtonEncaminharEmailClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 77);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 16);
			this.label1.TabIndex = 10;
			this.label1.Text = "Designação";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 114);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 16);
			this.label2.TabIndex = 11;
			this.label2.Text = "Endereço";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 151);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 16);
			this.label3.TabIndex = 12;
			this.label3.Text = "Expediente";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 260);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(116, 16);
			this.label4.TabIndex = 13;
			this.label4.Text = "Motivo do Reparo";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 223);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(62, 16);
			this.label5.TabIndex = 14;
			this.label5.Text = "Telefone";
			// 
			// buttonApagar
			// 
			this.buttonApagar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonApagar.Location = new System.Drawing.Point(328, 305);
			this.buttonApagar.Name = "buttonApagar";
			this.buttonApagar.Size = new System.Drawing.Size(85, 40);
			this.buttonApagar.TabIndex = 15;
			this.buttonApagar.Text = "Apagar";
			this.buttonApagar.UseVisualStyleBackColor = true;
			this.buttonApagar.Click += new System.EventHandler(this.ButtonApagarClick);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(12, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(82, 16);
			this.label6.TabIndex = 17;
			this.label6.Text = "Título E-mail";
			// 
			// tituloDeReparo
			// 
			this.tituloDeReparo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.tituloDeReparo.Location = new System.Drawing.Point(148, 5);
			this.tituloDeReparo.MaxLength = 700000;
			this.tituloDeReparo.Multiline = true;
			this.tituloDeReparo.Name = "tituloDeReparo";
			this.tituloDeReparo.Size = new System.Drawing.Size(264, 25);
			this.tituloDeReparo.TabIndex = 16;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(12, 42);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(89, 16);
			this.label7.TabIndex = 21;
			this.label7.Text = "Razão Social";
			// 
			// comboBox_RazaoSocial
			// 
			this.comboBox_RazaoSocial.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.comboBox_RazaoSocial.FormattingEnabled = true;
			this.comboBox_RazaoSocial.Location = new System.Drawing.Point(148, 42);
			this.comboBox_RazaoSocial.Name = "comboBox_RazaoSocial";
			this.comboBox_RazaoSocial.Size = new System.Drawing.Size(264, 25);
			this.comboBox_RazaoSocial.TabIndex = 22;
			// 
			// comboBox_FormaDeContatoComCliente_Telefone
			// 
			this.comboBox_FormaDeContatoComCliente_Telefone.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.comboBox_FormaDeContatoComCliente_Telefone.FormattingEnabled = true;
			this.comboBox_FormaDeContatoComCliente_Telefone.Location = new System.Drawing.Point(148, 223);
			this.comboBox_FormaDeContatoComCliente_Telefone.Name = "comboBox_FormaDeContatoComCliente_Telefone";
			this.comboBox_FormaDeContatoComCliente_Telefone.Size = new System.Drawing.Size(264, 25);
			this.comboBox_FormaDeContatoComCliente_Telefone.TabIndex = 23;
			// 
			// btnNotificarCliente
			// 
			this.btnNotificarCliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNotificarCliente.Location = new System.Drawing.Point(146, 305);
			this.btnNotificarCliente.Name = "btnNotificarCliente";
			this.btnNotificarCliente.Size = new System.Drawing.Size(85, 40);
			this.btnNotificarCliente.TabIndex = 19;
			this.btnNotificarCliente.Text = "Notificar Cliente";
			this.btnNotificarCliente.UseVisualStyleBackColor = true;
			this.btnNotificarCliente.Click += new System.EventHandler(this.BtnNotificarClienteClick);
			// 
			// btnConfig
			// 
			this.btnConfig.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConfig.Location = new System.Drawing.Point(55, 305);
			this.btnConfig.Name = "btnConfig";
			this.btnConfig.Size = new System.Drawing.Size(85, 40);
			this.btnConfig.TabIndex = 24;
			this.btnConfig.Text = "Config ...";
			this.btnConfig.UseVisualStyleBackColor = true;
			this.btnConfig.Click += new System.EventHandler(this.BtnConfigClick);
			// 
			// comboBox_ExpedienteDoCliente
			// 
			this.comboBox_ExpedienteDoCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.comboBox_ExpedienteDoCliente.FormattingEnabled = true;
			this.comboBox_ExpedienteDoCliente.Location = new System.Drawing.Point(148, 151);
			this.comboBox_ExpedienteDoCliente.Name = "comboBox_ExpedienteDoCliente";
			this.comboBox_ExpedienteDoCliente.Size = new System.Drawing.Size(264, 25);
			this.comboBox_ExpedienteDoCliente.TabIndex = 25;
			// 
			// comboBox_TipoDeReparo
			// 
			this.comboBox_TipoDeReparo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.comboBox_TipoDeReparo.FormattingEnabled = true;
			this.comboBox_TipoDeReparo.Location = new System.Drawing.Point(148, 260);
			this.comboBox_TipoDeReparo.Name = "comboBox_TipoDeReparo";
			this.comboBox_TipoDeReparo.Size = new System.Drawing.Size(264, 25);
			this.comboBox_TipoDeReparo.TabIndex = 26;
			// 
			// comboBox_FormaDeContatoComCliente_Email
			// 
			this.comboBox_FormaDeContatoComCliente_Email.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.comboBox_FormaDeContatoComCliente_Email.FormattingEnabled = true;
			this.comboBox_FormaDeContatoComCliente_Email.Location = new System.Drawing.Point(148, 187);
			this.comboBox_FormaDeContatoComCliente_Email.Name = "comboBox_FormaDeContatoComCliente_Email";
			this.comboBox_FormaDeContatoComCliente_Email.Size = new System.Drawing.Size(264, 25);
			this.comboBox_FormaDeContatoComCliente_Email.TabIndex = 28;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(12, 187);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(46, 16);
			this.label8.TabIndex = 27;
			this.label8.Text = "E-mail";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Menu;
			this.ClientSize = new System.Drawing.Size(424, 365);
			this.Controls.Add(this.comboBox_FormaDeContatoComCliente_Email);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.comboBox_TipoDeReparo);
			this.Controls.Add(this.comboBox_ExpedienteDoCliente);
			this.Controls.Add(this.btnConfig);
			this.Controls.Add(this.comboBox_FormaDeContatoComCliente_Telefone);
			this.Controls.Add(this.comboBox_RazaoSocial);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.btnNotificarCliente);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.tituloDeReparo);
			this.Controls.Add(this.buttonApagar);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonEncaminharEmail);
			this.Controls.Add(this.enderecoComercial);
			this.Controls.Add(this.designacao);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "NOC | Sistema de Abertura de Reparo";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}