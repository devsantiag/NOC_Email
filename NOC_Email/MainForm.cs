using System;
using System.Text;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;
using System.IO;

namespace NOC_Email
{
	public partial class MainForm : Form
	{
		string arquivo_razaoSocial = @"C:\Users\fjstavares\Tel&Com_desenvolvimento_noc\NOC_Email\NOC_Email\arquivos\arq_razao_social\razao_social.txt";
		string razaoSocial = "";

		public MainForm()
		{
			InitializeComponent();
			InicializaTabIndex();
			tituloDeReparo.TextChanged += new EventHandler(CommandCloSeApplication);
			CarregarRazõesSociais();

			try
			{
				razaoSocial = File.ReadAllText(arquivo_razaoSocial);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao ler a razão social: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void InicializaTabIndex()
		{
			tituloDeReparo.TabIndex = 0;
			designacao.TabIndex = 1;
			enderecoComercial.TabIndex = 2;
			expedienteDoCliente.TabIndex = 3;
			// formaDeContato.TabIndex = 4;
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
			corpo.AppendLine("Endereço Comercial: " + enderecoComercial.Text);
			corpo.AppendLine("Expediente da Unidade: " + expedienteDoCliente.Text);
			corpo.AppendLine("Formas de Contato: " + formaDeContato.Text);
			corpo.AppendLine("Motivo do Reparo: " + motivoDoReparo.Text);
			corpo.AppendLine();
			corpo.AppendLine("Atenciosamente,");
			corpo.AppendLine("Razão Social: " + razaoSocial);
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
			// formaDeContato.Text = "";
			motivoDoReparo.Text = "";
		}

		private void BtnSairClick(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void CommandCloSeApplication(object sender, EventArgs e)
		{
			string texto = tituloDeReparo.Text.Trim().ToLower();
			if (texto == "exit")
			{
				Application.Exit();
			}
			else if (texto == "config")
			{
				UserConfig userConfig = new UserConfig();
				userConfig.ShowDialog();
			}
		}

		private void BtnMensagemAoClientePorEmailClick(object sender, EventArgs e)
		{
			NotificarClientePorMensagemDeTexto notificarCliente = new NotificarClientePorMensagemDeTexto();
			notificarCliente.Show();
		}
		
		private void CarregarRazõesSociais()
		{
			if(File.Exists(arquivo_razaoSocial))
			{
				string[] linhas = File.ReadAllLines(arquivo_razaoSocial);
					comboBox_RazaoSocial.Items.Clear();
					
					foreach(string linha in linhas)
					{
						if(!string.IsNullOrWhiteSpace(linha) && !comboBox_RazaoSocial.Items.Contains(linha))
						{
							comboBox_RazaoSocial.Items.Add(linha.Trim());
						}
					}
			}
		}
		
	}
}
