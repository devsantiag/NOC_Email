using System;
using System.Text;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;
using System.IO;
using System.Linq;

namespace NOC_Email
{
	public partial class MainForm : Form
	{
		string seeValue = Caminhos.ArquivoEmail;
		
		public MainForm()
		{
			InitializeComponent();
			this.Load += MainForm_Load;
		}
		
		private void MainForm_Load(object sender, EventArgs e)
		{
			CarregarConfiguracoesSalvas();
		}
		
		void BtnConfigClick(object sender, EventArgs e)
		{
			UserConfigForm userConfig = new UserConfigForm();
			userConfig.Show();
		}
		
		
		void ButtonEncaminharEmailClick(object sender, EventArgs e)
		{
			EnviarEmail(
				tituloDeReparo.Text,
				comboBox_RazaoSocial.Text,
				designacao.Text,
				enderecoComercial.Text,
				comboBox_ExpedienteDoCliente.Text,
				comboBox_FormaDeContatoComCliente.Text,
				motivoDoReparo.Text
			);
		}
		
		private void EnviarEmail(
			string tituloEmail,
			string razaoSocialDoCliente,
			string designacaoDoCliente,
			string enderecoDoCliente,
			string expedienteDeFuncionamento,
			string formaDeContatoComCliente,
			string motivoDoReparoParaOCliente)
		{
			Outlook.Application outlookApp = new Outlook.Application();
			Outlook.MailItem mail = (Outlook.MailItem)outlookApp.CreateItem(Outlook.OlItemType.olMailItem);

			string corpoHtml =
				"<p>Prezados,</p>" +
				"<p>Favor processar o chamado abaixo.</p>" +
				"<p>" +
				"Razão Social: " + razaoSocialDoCliente + "<br>" +
				"Designação: " + designacaoDoCliente + "<br>" +
				"Endereço: " + enderecoDoCliente + "<br>" +
				"Expediente: " + expedienteDeFuncionamento + "<br>" +
				"Forma de Contato: " + formaDeContatoComCliente + "<br>" +
				"Motivo do Reparo: " + motivoDoReparoParaOCliente + "<br>" +
				"</p>" +
				"<p>Atenciosamente,</p>";

			mail.Subject = tituloEmail;
			mail.HTMLBody = corpoHtml;

			mail.Display(); // ou mail.Send() para enviar direto
		}
		
		private void CarregarConfiguracoesSalvas()
		{
			// Razão Social
			if (File.Exists(Caminhos.ArquivoRazaoSocial))
			{
				var linhas = File.ReadAllLines(Caminhos.ArquivoRazaoSocial)
					.Where(l => !string.IsNullOrWhiteSpace(l))
					.Distinct()
					.ToArray();

				comboBox_RazaoSocial.Items.Clear();
				comboBox_RazaoSocial.Items.AddRange(linhas);
			}

			// Expediente
			if (File.Exists(Caminhos.ArquivoExpedienteDoCliente))
			{
				var linhas = File.ReadAllLines(Caminhos.ArquivoExpedienteDoCliente)
					.Where(l => !string.IsNullOrWhiteSpace(l))
					.Distinct()
					.ToArray();

				comboBox_ExpedienteDoCliente.Items.Clear();
				comboBox_ExpedienteDoCliente.Items.AddRange(linhas);
			}

			// Forma de contato
			if (File.Exists(Caminhos.ArquivoTelefone)) // ou outro arquivo se preferir o email
			{
				var linhas = File.ReadAllLines(Caminhos.ArquivoTelefone)
					.Where(l => !string.IsNullOrWhiteSpace(l))
					.Distinct()
					.ToArray();

				comboBox_FormaDeContatoComCliente.Items.Clear();
				comboBox_FormaDeContatoComCliente.Items.AddRange(linhas);
			}
		}

		
	}
}
