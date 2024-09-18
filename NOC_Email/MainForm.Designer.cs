﻿/*
 * Created by SharpDevelop.
 * User: fjstavares
 * Date: 17/09/2024
 * Time: 10:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NOC_Email
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox nomeCliente;
		private System.Windows.Forms.TextBox designacao;
		private System.Windows.Forms.TextBox expedienteDoCliente;
		private System.Windows.Forms.TextBox motivoDoReparo;
		private System.Windows.Forms.TextBox formaDeContato;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button3;
		
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
			this.nomeCliente = new System.Windows.Forms.TextBox();
			this.designacao = new System.Windows.Forms.TextBox();
			this.expedienteDoCliente = new System.Windows.Forms.TextBox();
			this.motivoDoReparo = new System.Windows.Forms.TextBox();
			this.formaDeContato = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// nomeCliente
			// 
			this.nomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nomeCliente.Location = new System.Drawing.Point(151, 13);
			this.nomeCliente.MaxLength = 70;
			this.nomeCliente.Multiline = true;
			this.nomeCliente.Name = "nomeCliente";
			this.nomeCliente.Size = new System.Drawing.Size(250, 27);
			this.nomeCliente.TabIndex = 0;
			// 
			// designacao
			// 
			this.designacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.designacao.Location = new System.Drawing.Point(151, 51);
			this.designacao.MaxLength = 70;
			this.designacao.Multiline = true;
			this.designacao.Name = "designacao";
			this.designacao.Size = new System.Drawing.Size(250, 27);
			this.designacao.TabIndex = 1;
			// 
			// expedienteDoCliente
			// 
			this.expedienteDoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.expedienteDoCliente.Location = new System.Drawing.Point(151, 90);
			this.expedienteDoCliente.MaxLength = 70;
			this.expedienteDoCliente.Multiline = true;
			this.expedienteDoCliente.Name = "expedienteDoCliente";
			this.expedienteDoCliente.Size = new System.Drawing.Size(250, 27);
			this.expedienteDoCliente.TabIndex = 4;
			// 
			// motivoDoReparo
			// 
			this.motivoDoReparo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.motivoDoReparo.Location = new System.Drawing.Point(151, 167);
			this.motivoDoReparo.MaxLength = 70;
			this.motivoDoReparo.Multiline = true;
			this.motivoDoReparo.Name = "motivoDoReparo";
			this.motivoDoReparo.Size = new System.Drawing.Size(250, 27);
			this.motivoDoReparo.TabIndex = 6;
			// 
			// formaDeContato
			// 
			this.formaDeContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.formaDeContato.Location = new System.Drawing.Point(151, 129);
			this.formaDeContato.MaxLength = 70;
			this.formaDeContato.Multiline = true;
			this.formaDeContato.Name = "formaDeContato";
			this.formaDeContato.Size = new System.Drawing.Size(250, 27);
			this.formaDeContato.TabIndex = 5;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(317, 202);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(84, 32);
			this.button1.TabIndex = 8;
			this.button1.Text = "Encaminhar";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 16);
			this.label1.TabIndex = 10;
			this.label1.Text = "Nome Cliente";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 16);
			this.label2.TabIndex = 11;
			this.label2.Text = "Designação";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 95);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 16);
			this.label3.TabIndex = 12;
			this.label3.Text = "Expediente";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 172);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(116, 16);
			this.label4.TabIndex = 13;
			this.label4.Text = "Motivo do Reparo";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 134);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(115, 16);
			this.label5.TabIndex = 14;
			this.label5.Text = "Forma de Contato";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(227, 202);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(84, 32);
			this.button3.TabIndex = 15;
			this.button3.Text = "Apagar";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Menu;
			this.ClientSize = new System.Drawing.Size(417, 246);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.motivoDoReparo);
			this.Controls.Add(this.formaDeContato);
			this.Controls.Add(this.expedienteDoCliente);
			this.Controls.Add(this.designacao);
			this.Controls.Add(this.nomeCliente);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "NOC_Email";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
