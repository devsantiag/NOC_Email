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
		}
		
//		Button responsável por encaminhar informações
		void ButtonEncaminharEmail(object sender, EventArgs e)
		{
			
			string textContainer = "Prezados," +Environment.NewLine+ "\nFavor prosseguir com a abertura de reparo para o Contrato abaixo" +Environment.NewLine+   "\nNome do Cliente: " + nomeCliente.Text + Environment.NewLine +
				"Designação Contratual: " + designacao.Text + Environment.NewLine +
				"Expediente da unidade: " + expedienteDoCliente.Text + Environment.NewLine +
				"Formas de Contato: " + formaDeContato.Text + Environment.NewLine +
				"Motivo do Reparo: " + motivoDoReparo.Text;

			
			if(string.IsNullOrWhiteSpace(textContainer))
			{
				MessageBox.Show("Um ou mais campos encontram-se vazios. Tente novamente, por favor!");
			}
			else
			{
				CreateOutlookEmail(textContainer);
			}
		}
		
//		Responsável por processar o corpo de texto
		void CreateOutlookEmail (string body)
		{
			try {
				
				Outlook.Application outlookApp = new Outlook.Application();
				Outlook.MailItem mailItem = (Outlook.MailItem)outlookApp.CreateItem(Outlook.OlItemType.olMailItem);
				mailItem.Subject = "Solicitação de Abertura de Reparo";
				mailItem.Body = body;
				mailItem.Display(true);
				
			} catch (Exception ex) {
				MessageBox.Show("Erro de Envio", ex.Message);
				throw;
			}
			
		}
	}
}

