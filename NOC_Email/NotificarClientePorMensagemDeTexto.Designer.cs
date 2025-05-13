/*
 * Criado por SharpDevelop.
 * Usuário: fjstavares
 * Data: 01/04/2025
 * Hora: 08:49
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace NOC_Email
{
	partial class NotificarClientePorMensagemDeTexto
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.RichTextBox richTextBox1_CorpoDeMensagemDeTexto;
		private System.Windows.Forms.Button btnApagarMensagem;
		private System.Windows.Forms.Button btnEncaminharEmail;
		private System.Windows.Forms.TextBox textBox1_TitutloEmail;
		private System.Windows.Forms.Button btnAnexar;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Panel panelConfiguracoes;
		private System.Windows.Forms.Label btnCloseWindow;
		private System.Windows.Forms.Label label11;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.richTextBox1_CorpoDeMensagemDeTexto = new System.Windows.Forms.RichTextBox();
			this.btnApagarMensagem = new System.Windows.Forms.Button();
			this.btnEncaminharEmail = new System.Windows.Forms.Button();
			this.textBox1_TitutloEmail = new System.Windows.Forms.TextBox();
			this.btnAnexar = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.panelConfiguracoes = new System.Windows.Forms.Panel();
			this.btnCloseWindow = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.panelConfiguracoes.SuspendLayout();
			this.SuspendLayout();
			// 
			// richTextBox1_CorpoDeMensagemDeTexto
			// 
			this.richTextBox1_CorpoDeMensagemDeTexto.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.richTextBox1_CorpoDeMensagemDeTexto.Location = new System.Drawing.Point(4, 68);
			this.richTextBox1_CorpoDeMensagemDeTexto.Name = "richTextBox1_CorpoDeMensagemDeTexto";
			this.richTextBox1_CorpoDeMensagemDeTexto.Size = new System.Drawing.Size(482, 164);
			this.richTextBox1_CorpoDeMensagemDeTexto.TabIndex = 0;
			this.richTextBox1_CorpoDeMensagemDeTexto.Text = "";
			// 
			// btnApagarMensagem
			// 
			this.btnApagarMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnApagarMensagem.Location = new System.Drawing.Point(352, 238);
			this.btnApagarMensagem.Name = "btnApagarMensagem";
			this.btnApagarMensagem.Size = new System.Drawing.Size(134, 47);
			this.btnApagarMensagem.TabIndex = 1;
			this.btnApagarMensagem.Text = "Apagar";
			this.btnApagarMensagem.UseVisualStyleBackColor = true;
			this.btnApagarMensagem.Click += new System.EventHandler(this.BtnApagarMensagemClick);
			// 
			// btnEncaminharEmail
			// 
			this.btnEncaminharEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEncaminharEmail.Location = new System.Drawing.Point(212, 238);
			this.btnEncaminharEmail.Name = "btnEncaminharEmail";
			this.btnEncaminharEmail.Size = new System.Drawing.Size(134, 47);
			this.btnEncaminharEmail.TabIndex = 2;
			this.btnEncaminharEmail.Text = "Encaminhar";
			this.btnEncaminharEmail.UseVisualStyleBackColor = true;
			this.btnEncaminharEmail.Click += new System.EventHandler(this.BtnEncaminharEmailClick);
			// 
			// textBox1_TitutloEmail
			// 
			this.textBox1_TitutloEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1_TitutloEmail.Location = new System.Drawing.Point(4, 35);
			this.textBox1_TitutloEmail.Name = "textBox1_TitutloEmail";
			this.textBox1_TitutloEmail.Size = new System.Drawing.Size(482, 26);
			this.textBox1_TitutloEmail.TabIndex = 3;
			// 
			// btnAnexar
			// 
			this.btnAnexar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAnexar.Location = new System.Drawing.Point(72, 238);
			this.btnAnexar.Name = "btnAnexar";
			this.btnAnexar.Size = new System.Drawing.Size(134, 47);
			this.btnAnexar.TabIndex = 4;
			this.btnAnexar.Text = "Anexar";
			this.btnAnexar.UseVisualStyleBackColor = true;
			this.btnAnexar.Click += new System.EventHandler(this.BtnAnexarClick);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog_AnexarArquivo";
			// 
			// panelConfiguracoes
			// 
			this.panelConfiguracoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(93)))));
			this.panelConfiguracoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.panelConfiguracoes.Controls.Add(this.btnCloseWindow);
			this.panelConfiguracoes.Controls.Add(this.label11);
			this.panelConfiguracoes.Location = new System.Drawing.Point(-1, 0);
			this.panelConfiguracoes.Name = "panelConfiguracoes";
			this.panelConfiguracoes.Size = new System.Drawing.Size(492, 32);
			this.panelConfiguracoes.TabIndex = 24;
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
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.White;
			this.label11.Location = new System.Drawing.Point(3, 3);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(375, 25);
			this.label11.TabIndex = 23;
			this.label11.Text = "NOC | Comunicação com Cliente via E-mail";
			// 
			// NotificarClientePorMensagemDeTexto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(490, 296);
			this.Controls.Add(this.btnAnexar);
			this.Controls.Add(this.textBox1_TitutloEmail);
			this.Controls.Add(this.btnEncaminharEmail);
			this.Controls.Add(this.btnApagarMensagem);
			this.Controls.Add(this.richTextBox1_CorpoDeMensagemDeTexto);
			this.Controls.Add(this.panelConfiguracoes);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "NotificarClientePorMensagemDeTexto";
			this.Text = "NOC | Comunicação com Cliente via E-mail";
			this.panelConfiguracoes.ResumeLayout(false);
			this.panelConfiguracoes.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
