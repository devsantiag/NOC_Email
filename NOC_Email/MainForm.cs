/*
 * Created by SharpDevelop.
 * User: fjstavares
 * Date: 17/09/2024
 * Time: 10:57
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace NOC_Email
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
//		Button responsável por encaminhar informações
		void ButtonEncaminharEmail(object sender, EventArgs e)
		{
			
			string containerTexto = nomeCliente.Text + " " +
				designacao.Text + " " +
				expedienteDoCliente.Text + " " +
				formaDeContato.Text + " " +
				motivoDoReparo.Text;
			
			string resultado = string.IsNullOrWhiteSpace(containerTexto) ? "Um ou mais campos encontram-se vazios. Tente novamente, por favor!" : "";
			MessageBox.Show(resultado);
		}
		
//		Responsável por processar o corpo de texto
		void sendEmail (object sender, EventArgs e)
		{
			
		}
	}
}