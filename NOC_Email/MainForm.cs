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
			designacao.TabIndex = 1;
			enderecoComercial.TabIndex = 2;
			expedienteDoCliente.TabIndex = 3;
			formaDeContato.TabIndex = 4;
			motivoDoReparo.TabIndex = 5;
			buttonApagar.TabIndex = 7;
			buttonEncaminharEmail.TabIndex = 6;
		}
		
//		Certifica que os campos de preenchimento encontram-se corretamente preenchidos
		private bool FieldsAreFilled()
		{
			return
				!string.IsNullOrWhiteSpace(tituloDeReparo.Text) &&
				!string.IsNullOrWhiteSpace(designacao.Text) &&
				!string.IsNullOrWhiteSpace(enderecoComercial.Text) &&
				!string.IsNullOrWhiteSpace(expedienteDoCliente.Text) &&
				!string.IsNullOrWhiteSpace(formaDeContato.Text) &&
				!string.IsNullOrWhiteSpace(motivoDoReparo.Text);
		}
		
//		Button responsável por encaminhar informações
		void ButtonEncaminharEmail(object sender, EventArgs e)
		{
			if(!FieldsAreFilled())
			{
				MessageBox.Show("Um ou mais campos encontram-se vazios. Tente novamente, por favor.");
				return;
			}
			
			string tituloReparo = "REPARO DE CIRCUITO | " +tituloDeReparo.Text;
			string textContainer = "Prezados," +Environment.NewLine+ "\nFavor prosseguir com a abertura de reparo para o Contrato abaixo" +Environment.NewLine+   "\nDesignação Contratual: " + designacao.Text + Environment.NewLine +
				"Endereço Comercial: " + enderecoComercial.Text + Environment.NewLine +
				"Expediente da unidade: " + expedienteDoCliente.Text + Environment.NewLine +
				"Formas de Contato: " + formaDeContato.Text + Environment.NewLine +
				"Motivo do Reparo: " + motivoDoReparo.Text +
				"\n\nAtenciosamente,";
			
//			Realiza a criação do E-mail no Outlook
			CreateOutlookEmail(tituloReparo, textContainer);
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
		
		void ClearContent()
		{
			tituloDeReparo.Text = "";
			designacao.Text = "";
			enderecoComercial.Text = "";
			expedienteDoCliente.Text = "";
			formaDeContato.Text = "";
			motivoDoReparo.Text = "";
		}
		
//		Responsável por apagar os Campos de informações contratuais
		void ButtonApagarClick(object sender, EventArgs e)
		{
			ClearContent();
		}
	}
}