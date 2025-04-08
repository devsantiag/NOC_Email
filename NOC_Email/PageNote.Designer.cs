/*
 * Criado por SharpDevelop.
 * Usuário: fjstavares
 * Data: 04/04/2025
 * Hora: 09:01
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace NOC_Email
{
	partial class PageNote
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.RichTextBox textBox_ConteudoEscrito;
		private System.Windows.Forms.Button btnApagar;
		private System.Windows.Forms.Button btnCopiar;
		
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
			this.textBox_ConteudoEscrito = new System.Windows.Forms.RichTextBox();
			this.btnApagar = new System.Windows.Forms.Button();
			this.btnCopiar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox_ConteudoEscrito
			// 
			this.textBox_ConteudoEscrito.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_ConteudoEscrito.ForeColor = System.Drawing.Color.Red;
			this.textBox_ConteudoEscrito.Location = new System.Drawing.Point(8, 5);
			this.textBox_ConteudoEscrito.Name = "textBox_ConteudoEscrito";
			this.textBox_ConteudoEscrito.Size = new System.Drawing.Size(572, 175);
			this.textBox_ConteudoEscrito.TabIndex = 0;
			this.textBox_ConteudoEscrito.Text = "";
			// 
			// btnApagar
			// 
			this.btnApagar.Location = new System.Drawing.Point(481, 186);
			this.btnApagar.Name = "btnApagar";
			this.btnApagar.Size = new System.Drawing.Size(99, 45);
			this.btnApagar.TabIndex = 1;
			this.btnApagar.Text = "Apagar";
			this.btnApagar.UseVisualStyleBackColor = true;
			this.btnApagar.Click += new System.EventHandler(this.BtnApagarClick);
			// 
			// btnCopiar
			// 
			this.btnCopiar.Location = new System.Drawing.Point(376, 186);
			this.btnCopiar.Name = "btnCopiar";
			this.btnCopiar.Size = new System.Drawing.Size(99, 45);
			this.btnCopiar.TabIndex = 2;
			this.btnCopiar.Text = "Copiar";
			this.btnCopiar.UseVisualStyleBackColor = true;
			this.btnCopiar.Click += new System.EventHandler(this.BtnCopiarClick);
			// 
			// PageNote
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(589, 239);
			this.Controls.Add(this.btnCopiar);
			this.Controls.Add(this.btnApagar);
			this.Controls.Add(this.textBox_ConteudoEscrito);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "PageNote";
			this.Text = "PageNote";
			this.ResumeLayout(false);

		}
	}
}
