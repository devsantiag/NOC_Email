/*
 * Criado por SharpDevelop.
 * Usuário: fjstavares
 * Data: 25/04/2025
 * Hora: 11:19
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace NOC_Email
{
	partial class Historico
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ListBox lista_de_historico;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		
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
			this.lista_de_historico = new System.Windows.Forms.ListBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lista_de_historico
			// 
			this.lista_de_historico.FormattingEnabled = true;
			this.lista_de_historico.Location = new System.Drawing.Point(1, 1);
			this.lista_de_historico.Name = "lista_de_historico";
			this.lista_de_historico.Size = new System.Drawing.Size(520, 316);
			this.lista_de_historico.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(420, 331);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(89, 34);
			this.button1.TabIndex = 1;
			this.button1.Text = "Ok";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(324, 331);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(89, 34);
			this.button2.TabIndex = 2;
			this.button2.Text = "Excluir";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// Historico
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(521, 377);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lista_de_historico);
			this.Name = "Historico";
			this.Text = "Historico";
			this.ResumeLayout(false);

		}
	}
}
