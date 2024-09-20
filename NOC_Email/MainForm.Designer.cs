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
		private System.Windows.Forms.TextBox expedienteDoCliente;
		private System.Windows.Forms.TextBox motivoDoReparo;
		private System.Windows.Forms.TextBox formaDeContato;
		private System.Windows.Forms.Button buttonEncaminharEmail;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button buttonApagar;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tituloDeReparo;
		
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
			this.expedienteDoCliente = new System.Windows.Forms.TextBox();
			this.motivoDoReparo = new System.Windows.Forms.TextBox();
			this.formaDeContato = new System.Windows.Forms.TextBox();
			this.buttonEncaminharEmail = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.buttonApagar = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.tituloDeReparo = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// designacao
			// 
			this.designacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.designacao.Location = new System.Drawing.Point(154, 47);
			this.designacao.MaxLength = 70;
			this.designacao.Multiline = true;
			this.designacao.Name = "designacao";
			this.designacao.Size = new System.Drawing.Size(250, 27);
			this.designacao.TabIndex = 0;
			// 
			// enderecoComercial
			// 
			this.enderecoComercial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.enderecoComercial.Location = new System.Drawing.Point(154, 84);
			this.enderecoComercial.MaxLength = 70;
			this.enderecoComercial.Multiline = true;
			this.enderecoComercial.Name = "enderecoComercial";
			this.enderecoComercial.Size = new System.Drawing.Size(250, 27);
			this.enderecoComercial.TabIndex = 1;
			// 
			// expedienteDoCliente
			// 
			this.expedienteDoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.expedienteDoCliente.Location = new System.Drawing.Point(154, 121);
			this.expedienteDoCliente.MaxLength = 70;
			this.expedienteDoCliente.Multiline = true;
			this.expedienteDoCliente.Name = "expedienteDoCliente";
			this.expedienteDoCliente.Size = new System.Drawing.Size(250, 27);
			this.expedienteDoCliente.TabIndex = 4;
			// 
			// motivoDoReparo
			// 
			this.motivoDoReparo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.motivoDoReparo.Location = new System.Drawing.Point(154, 193);
			this.motivoDoReparo.MaxLength = 70;
			this.motivoDoReparo.Multiline = true;
			this.motivoDoReparo.Name = "motivoDoReparo";
			this.motivoDoReparo.Size = new System.Drawing.Size(250, 27);
			this.motivoDoReparo.TabIndex = 6;
			// 
			// formaDeContato
			// 
			this.formaDeContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.formaDeContato.Location = new System.Drawing.Point(154, 157);
			this.formaDeContato.MaxLength = 70;
			this.formaDeContato.Multiline = true;
			this.formaDeContato.Name = "formaDeContato";
			this.formaDeContato.Size = new System.Drawing.Size(250, 27);
			this.formaDeContato.TabIndex = 5;
			// 
			// buttonEncaminharEmail
			// 
			this.buttonEncaminharEmail.Location = new System.Drawing.Point(320, 231);
			this.buttonEncaminharEmail.Name = "buttonEncaminharEmail";
			this.buttonEncaminharEmail.Size = new System.Drawing.Size(84, 47);
			this.buttonEncaminharEmail.TabIndex = 8;
			this.buttonEncaminharEmail.Text = "Encaminhar";
			this.buttonEncaminharEmail.UseVisualStyleBackColor = true;
			this.buttonEncaminharEmail.Click += new System.EventHandler(this.ButtonEncaminharEmail);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 16);
			this.label1.TabIndex = 10;
			this.label1.Text = "Designação";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 89);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 16);
			this.label2.TabIndex = 11;
			this.label2.Text = "Endereço";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(16, 126);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 16);
			this.label3.TabIndex = 12;
			this.label3.Text = "Expediente";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(16, 198);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(116, 16);
			this.label4.TabIndex = 13;
			this.label4.Text = "Motivo do Reparo";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(16, 162);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(115, 16);
			this.label5.TabIndex = 14;
			this.label5.Text = "Forma de Contato";
			// 
			// buttonApagar
			// 
			this.buttonApagar.Location = new System.Drawing.Point(230, 231);
			this.buttonApagar.Name = "buttonApagar";
			this.buttonApagar.Size = new System.Drawing.Size(84, 47);
			this.buttonApagar.TabIndex = 15;
			this.buttonApagar.Text = "Apagar";
			this.buttonApagar.UseVisualStyleBackColor = true;
			this.buttonApagar.Click += new System.EventHandler(this.ButtonApagarClick);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(16, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(109, 16);
			this.label6.TabIndex = 17;
			this.label6.Text = "Título de Reparo";
			// 
			// tituloDeReparo
			// 
			this.tituloDeReparo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tituloDeReparo.Location = new System.Drawing.Point(154, 11);
			this.tituloDeReparo.MaxLength = 70;
			this.tituloDeReparo.Multiline = true;
			this.tituloDeReparo.Name = "tituloDeReparo";
			this.tituloDeReparo.Size = new System.Drawing.Size(250, 27);
			this.tituloDeReparo.TabIndex = 16;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Menu;
			this.ClientSize = new System.Drawing.Size(417, 291);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.tituloDeReparo);
			this.Controls.Add(this.buttonApagar);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonEncaminharEmail);
			this.Controls.Add(this.motivoDoReparo);
			this.Controls.Add(this.formaDeContato);
			this.Controls.Add(this.expedienteDoCliente);
			this.Controls.Add(this.enderecoComercial);
			this.Controls.Add(this.designacao);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "NOC_Email";
			this.ResumeLayout(false);
			this.PerformLayout();

		}// 
//			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
//			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//			this.BackColor = System.Drawing.SystemColors.Menu;
//			this.ClientSize = new System.Drawing.Size(417, 291);
//			this.Controls.Add(this.label6);
//			this.Controls.Add(this.textBox1);
//			this.Controls.Add(this.button3);
//			this.Controls.Add(this.label5);
//			this.Controls.Add(this.label4);
//			this.Controls.Add(this.label3);
//			this.Controls.Add(this.label2);
//			this.Controls.Add(this.label1);
//			this.Controls.Add(this.buttonEncaminharEmail);
//			this.Controls.Add(this.motivoDoReparo);
//			this.Controls.Add(this.formaDeContato);
//			this.Controls.Add(this.expedienteDoCliente);
//			this.Controls.Add(this.designacao);
//			this.Controls.Add(this.nomeCliente);
//			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
//			this.MaximizeBox = false;
//			this.Name = "MainForm";
//			this.Text = "NOC_Email";
//			this.ResumeLayout(false);
//			this.PerformLayout();

		}
	}
