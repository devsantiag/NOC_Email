/*
 * Created by SharpDevelop.
 * User: fjstavares
 * Date: 17/09/2024
 * Time: 10:57
 */
 
using System;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace NOC_Email
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			tituloDeReparo.TabIndex = 0;
			nomeCliente.TabIndex = 1;
			designacao.TabIndex = 2;
			expedienteDoCliente.TabIndex = 3;
			formaDeContato.TabIndex = 4;
			motivoDoReparo.TabIndex = 5;
			buttonEncaminharEmail.TabIndex = 6;
			buttonApagar.TabIndex = 7;
		}
		
//		Button responsável por encaminhar informações
		void ButtonEncaminharEmail(object sender, EventArgs e)
		{
			string tituloReparo = tituloDeReparo.Text;
			string textContainer = "Prezados," +Environment.NewLine+ "\nFavor prosseguir com a abertura de reparo para o Contrato abaixo" +Environment.NewLine+   "\nNome do Cliente: " + nomeCliente.Text + Environment.NewLine +
				"Designação Contratual: " + designacao.Text + Environment.NewLine +
				"Expediente da unidade: " + expedienteDoCliente.Text + Environment.NewLine +
				"Formas de Contato: " + formaDeContato.Text + Environment.NewLine +
				"Motivo do Reparo: " + motivoDoReparo.Text +
				"\n\nAtenciosamente,";
			
			if(string.IsNullOrWhiteSpace(textContainer))
			{
				MessageBox.Show("Um ou mais campos encontram-se vazios. Tente novamente, por favor!");
			}
			else
			{
				CreateOutlookEmail(tituloReparo, textContainer);
			}
		}
		
//		Responsável por processar o corpo de texto
		void CreateOutlookEmail (string title, string body)
		{
			try {
				
				Outlook.Application outlookApp = new Outlook.Application();
				Outlook.MailItem mailItem = (Outlook.MailItem)outlookApp.CreateItem(Outlook.OlItemType.olMailItem);
				mailItem.Subject = title;
				mailItem.Body = body;
				mailItem.Display(true);
				
			} catch (Exception ex) {
				MessageBox.Show("Erro de Envio", ex.Message);
				throw;
			}
			
		}
		
//		Responsável por apagar os Campos de informações contratuais
		void ButtonApagarClick(object sender, EventArgs e)
		{
			tituloDeReparo.Text = "";
			nomeCliente.Text = "";
			designacao.Text = "";
			expedienteDoCliente.Text = "";
			formaDeContato.Text = "";
			motivoDoReparo.Text = "";
		}
	}
}

