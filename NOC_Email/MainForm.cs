/*
 * Created by SharpDevelop.
 * User: fjstavares
 * Date: 17/09/2024
 * Time: 10:57
 */

using System;
using System.Text;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace NOC_Email
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			InicializaTabIndex();
//			CommandCloSeApplication();
			
			tituloDeReparo.TextChanged += new EventHandler(CommandCloSeApplication);
		}

		private void InicializaTabIndex()
		{
			tituloDeReparo.TabIndex = 0;
			designacao.TabIndex = 1;
			enderecoComercial.TabIndex = 2;
			expedienteDoCliente.TabIndex = 3;
			formaDeContato.TabIndex = 4;
			motivoDoReparo.TabIndex = 5;
			buttonApagar.TabIndex = 7;
			buttonEncaminharEmail.TabIndex = 6;
		}

		private void MessageBoxErrorWarning(string mensagem)
		{
			MessageBox.Show(mensagem, "ATENÇÃO:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private bool FieldsAreFilled()
		{
			return !string.IsNullOrWhiteSpace(tituloDeReparo.Text) &&
				!string.IsNullOrWhiteSpace(designacao.Text) &&
				!string.IsNullOrWhiteSpace(enderecoComercial.Text) &&
				!string.IsNullOrWhiteSpace(expedienteDoCliente.Text) &&
				!string.IsNullOrWhiteSpace(formaDeContato.Text) &&
				!string.IsNullOrWhiteSpace(motivoDoReparo.Text);
		}

		private string CreateBodyEmail()
		{
			StringBuilder corpo = new StringBuilder();
			corpo.AppendLine("Prezados,");
			corpo.AppendLine();
			corpo.AppendLine("Favor prosseguir com a abertura de reparo para o Contrato abaixo:");
			corpo.AppendLine();
			corpo.AppendLine("Designação Contratual: " + designacao.Text);
			corpo.AppendLine("Endereço Comercial: "+ enderecoComercial.Text);
			corpo.AppendLine("Expediente da Unidade: " + expedienteDoCliente.Text);
			corpo.AppendLine("Formas de Contato: " + formaDeContato.Text);
			corpo.AppendLine("Motivo do Reparo: " + motivoDoReparo.Text);
			corpo.AppendLine();
			corpo.AppendLine("Atenciosamente,");
			return corpo.ToString();
		}

		private void ButtonEncaminharEmail(object sender, EventArgs e)
		{
			if (!FieldsAreFilled())
			{
				MessageBoxErrorWarning("Um ou mais campos encontram-se vazios. Tente novamente, por favor.");
				return;
			}
			
			string tituloReparo = "ABERTURA DE REPARO | " + tituloDeReparo.Text;
			string email = CreateBodyEmail();
			
			CreateOutlookEmail(tituloReparo, email);
		}

		private void CreateOutlookEmail(string title, string body)
		{
			try
			{
				Outlook.Application outlookApp = new Outlook.Application();
				Outlook.MailItem mailItem = (Outlook.MailItem)outlookApp.CreateItem(Outlook.OlItemType.olMailItem);
				
				mailItem.Subject = title;
				mailItem.Body = body;
				
				mailItem.Display(true);
			}
			catch (Exception ex)
			{
				MessageBoxErrorWarning("Erro ao tentar encaminhar o Email: " + ex.Message);
				throw;
			}
		}

		private void ButtonApagarClick(object sender, EventArgs e)
		{
			ClearContent();
		}

		private void ClearContent()
		{
			tituloDeReparo.Text = "";
			designacao.Text = "";
			enderecoComercial.Text = "";
			expedienteDoCliente.Text = "";
			formaDeContato.Text = "";
			motivoDoReparo.Text = "";
		}

		private void BtnSairClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		private void CommandCloSeApplication(object sender, EventArgs e)
		{
			if (tituloDeReparo.Text.Trim().ToLower() == "exit")
			{
				Application.Exit();
			}
		}
	}
}