// Bibliotecas padrão do .NET e do Outlook para manipulação de e-mail
using System;
using System.Text;
using System.Windows.Forms;
using NOC_Email;
using Outlook = Microsoft.Office.Interop.Outlook;
using System.IO;

namespace NOC_Email
{
	public partial class MainForm : Form
	{
		string razaoSocial = System.IO.File.ReadAllText(arquivo_razaoSocial);
			
		// Construtor do formulário principal
		public MainForm()
		{
			InitializeComponent(); // Inicializa os componentes visuais
			InicializaTabIndex(); // Define a ordem de navegação com TAB
			tituloDeReparo.TextChanged += new EventHandler(CommandCloSeApplication); // Escuta alterações no campo título
		}
		
		// Define a ordem dos campos quando o usuário navega com a tecla TAB
		private void InicializaTabIndex()
		{
			tituloDeReparo.TabIndex = 0;
			designacao.TabIndex = 1;
			enderecoComercial.TabIndex = 2;
			expedienteDoCliente.TabIndex = 3;
			// formaDeContato.TabIndex = 4; // comentado, talvez o campo não esteja mais presente
			motivoDoReparo.TabIndex = 5;
			buttonApagar.TabIndex = 7;
			buttonEncaminharEmail.TabIndex = 6;
		}

		// Exibe uma mensagem de erro ao usuário
		private void MessageBoxErrorWarning(string mensagem)
		{
			MessageBox.Show(mensagem, "ATENÇÃO:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
		
		// Verifica se todos os campos obrigatórios estão preenchidos
		private bool FieldsAreFilled()
		{
			return !string.IsNullOrWhiteSpace(tituloDeReparo.Text) &&
				!string.IsNullOrWhiteSpace(designacao.Text) &&
				!string.IsNullOrWhiteSpace(enderecoComercial.Text) &&
				!string.IsNullOrWhiteSpace(expedienteDoCliente.Text) &&
				//!string.IsNullOrWhiteSpace(formaDeContato.Text) &&
				!string.IsNullOrWhiteSpace(motivoDoReparo.Text);
		}
		
		// Monta o corpo do e-mail com base nos campos preenchidos
		private string CreateBodyEmail()
		{
			string test_getArquivo = razaoSocial;
			MessageBox.Show(test_getArquivo);
				
			StringBuilder corpo = new StringBuilder();
			corpo.AppendLine("Prezados,");
			corpo.AppendLine();
			corpo.AppendLine("Favor prosseguir com a abertura de reparo para o Contrato abaixo:");
			corpo.AppendLine();
			corpo.AppendLine("Razão Social: " + test_getArquivo);
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

		// Evento do botão "Encaminhar Email" que valida os campos e gera o e-mail
		private void ButtonEncaminharEmail(object sender, EventArgs e)
		{
			if (!FieldsAreFilled())
			{
				MessageBoxErrorWarning("Um ou mais campos encontram-se vazios. Tente novamente, por favor.");
				return;
			}
			
			string tituloReparo = "ABERTURA DE REPARO | " + tituloDeReparo.Text; // Cria o assunto do e-mail
			string email = CreateBodyEmail(); // Gera o corpo do e-mail
			
			CreateOutlookEmail(tituloReparo, email); // Chama a função que cria o e-mail no Outlook
		}

		// Cria o e-mail no Outlook com título e corpo definidos
		private void CreateOutlookEmail(string title, string body)
		{
			try
			{
				Outlook.Application outlookApp = new Outlook.Application();
				Outlook.MailItem mailItem = (Outlook.MailItem)outlookApp.CreateItem(Outlook.OlItemType.olMailItem);
				
				mailItem.Subject = title;
				mailItem.Body = body;
				
				mailItem.Display(true); // Exibe o e-mail na tela para o usuário revisar
			}
			catch (Exception ex)
			{
				MessageBoxErrorWarning("Erro ao tentar encaminhar o Email: " + ex.Message);
				throw; // Repassa o erro para o depurador
			}
		}

		// Evento do botão "Apagar", que limpa todos os campos
		private void ButtonApagarClick(object sender, EventArgs e)
		{
			ClearContent();
		}

		// Limpa o conteúdo dos campos do formulário
		private void ClearContent()
		{
			tituloDeReparo.Text = "";
			designacao.Text = "";
			enderecoComercial.Text = "";
			expedienteDoCliente.Text = "";
			// formaDeContato.Text = ""; // campo comentado
			motivoDoReparo.Text = "";
		}

		// Evento do botão "Sair", fecha a aplicação
		private void BtnSairClick(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Detecta se o usuário digita "exit" ou "config" no campo "tituloDeReparo"
		private void CommandCloSeApplication(object sender, EventArgs e)
		{
			if (tituloDeReparo.Text.Trim().ToLower() == "exit")
			{
				Application.Exit(); // Fecha a aplicação
			}
			else if (tituloDeReparo.Text.Trim().ToLower() == "config")
			{
				// Abre o formulário de configuração
				UserConfig userConfig = new UserConfig();
				userConfig.ShowDialog(); // Modal
			}
		}
		
		// Evento do botão que abre o outro formulário para notificação por mensagem de texto
		void BtnMensagemAoClientePorEmailClick(object sender, EventArgs e)
		{
			NotificarClientePorMensagemDeTexto notificarClientePorMensagemDeTexto = new NotificarClientePorMensagemDeTexto();
			notificarClientePorMensagemDeTexto.Show(); // Abre de forma não-modal
		}
	}
}
