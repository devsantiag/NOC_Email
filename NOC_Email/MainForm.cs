using System;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;
using System.IO;
using System.Linq;

namespace NOC_Email
{
	// Formulário principal do aplicativo de envio de e-mails.
	public partial class MainForm : Form
	{
		// Caminho para o arquivo de e-mail configurado.
		string seeValue = Caminhos.ArquivoEmail;

		// Construtor do formulário. Inicializa o formulário e define o evento de carregamento.
		public MainForm()
		{
			InitializeComponent();
			this.Load += MainForm_Load;
			atalhoTabIndex();
		}
		
		// Evento acionado quando o formulário é carregado. Carrega as configurações salvas.
		private void MainForm_Load(object sender, EventArgs e)
		{
			CarregarConfiguracoesSalvas();
		}
		
		// Evento que abre o formulário de configurações do usuário.
		void BtnConfigClick(object sender, EventArgs e)
		{
			UserConfigForm userConfig = new UserConfigForm();
			userConfig.Show();
		}

		// Evento para encaminhar um e-mail com as informações do reparo.
		void ButtonEncaminharEmailClick(object sender, EventArgs e)
		{
			// Verifica se os campos obrigatórios não estão vazios
			if (string.IsNullOrEmpty(tituloDeReparo.Text) ||
			    string.IsNullOrEmpty(comboBox_RazaoSocial.Text) ||
			    string.IsNullOrEmpty(designacao.Text) ||
			    string.IsNullOrEmpty(enderecoComercial.Text) ||
			    string.IsNullOrEmpty(comboBox_ExpedienteDoCliente.Text) ||
			    string.IsNullOrEmpty(comboBox_FormaDeContatoComCliente_Email.Text) ||
			    string.IsNullOrEmpty(comboBox_FormaDeContatoComCliente_Telefone.Text) ||
			    string.IsNullOrEmpty(comboBox_TipoDeReparo.Text))
			{
				MessageBox.Show("Ação Bloqueada! Por favor, preencha todos os campos obrigatórios antes de enviar o e-mail.");
				return; // Sai do método se algum campo estiver vazio
			}

			// Chama o método de envio de e-mail passando os dados do formulário.
			EnviarEmail(
				tituloDeReparo.Text,
				comboBox_RazaoSocial.Text,
				designacao.Text,
				enderecoComercial.Text,
				comboBox_ExpedienteDoCliente.Text,
				comboBox_FormaDeContatoComCliente_Email.Text,
				comboBox_FormaDeContatoComCliente_Telefone.Text,
				comboBox_TipoDeReparo.Text
			);
		}
		
		// Método que cria e envia um e-mail com as informações fornecidas.
		private void EnviarEmail(
			string tituloEmail,
			string razaoSocialDoCliente,
			string designacaoDoCliente,
			string enderecoDoCliente,
			string expedienteDeFuncionamento,
			string formaDeContatoComCliente_Telefone,
			string formaDeContatoComCliente_Email,
			string motivoDoReparoParaOCliente)
		{
			// Cria uma nova instância do Outlook e prepara o e-mail.
			Outlook.Application outlookApp = new Outlook.Application();
			Outlook.MailItem mail = (Outlook.MailItem)outlookApp.CreateItem(Outlook.OlItemType.olMailItem);

			// Corpo do e-mail em formato HTML com os dados do cliente e do reparo.
			string corpoHtml =
				"<p>Prezados,</p>" +
				"<p>Solicitamos o devido processamento do chamado conforme as informações abaixo:</p>" +
				"<p>" +
				"<strong>Razão Social:</strong> " + razaoSocialDoCliente + "<br>" +
				"<strong>Designação:</strong> " + designacaoDoCliente.ToUpper() + "<br>" +
				"<strong>Endereço:</strong> " + enderecoDoCliente + "<br>" +
				"<strong>Expediente:</strong> " + expedienteDeFuncionamento + "<br>" +
				"<strong>Forma de Contato:</strong> E-mail: " + formaDeContatoComCliente_Email + " | Telefone: " + formaDeContatoComCliente_Telefone + "<br>" +
				"<strong>Motivo do Reparo:</strong> " + motivoDoReparoParaOCliente + "<br>" +
				"</p>" +
				"<p>Atenciosamente,</p>";


			// Define o título e o corpo do e-mail.
			mail.Subject = "🔧 REPARO | " + tituloEmail.ToUpper() + " | "  +designacao.Text.ToUpper();
			mail.HTMLBody = corpoHtml;

			// Exibe o e-mail para revisão antes de enviar. Pode ser alterado para enviar diretamente.
			mail.Display(); // ou mail.Send() para enviar diretamente.
		}

		// Método que carrega as configurações salvas nos arquivos e as exibe nos ComboBoxes.
		private void CarregarConfiguracoesSalvas()
		{
			// Carrega as opções de razão social a partir de um arquivo e as adiciona ao ComboBox.
			if (File.Exists(Caminhos.ArquivoRazaoSocial))
			{
				var linhas = File.ReadAllLines(Caminhos.ArquivoRazaoSocial)
					.Where(l => !string.IsNullOrWhiteSpace(l)) // Filtra linhas em branco.
					.Distinct() // Remove entradas duplicadas.
					.ToArray();

				comboBox_RazaoSocial.Items.Clear(); // Limpa as opções existentes.
				comboBox_RazaoSocial.Items.AddRange(linhas); // Adiciona as novas opções.
			}

			// Carrega as opções de expediente do cliente a partir de um arquivo e as adiciona ao ComboBox.
			if (File.Exists(Caminhos.ArquivoExpedienteDoCliente))
			{
				var linhas = File.ReadAllLines(Caminhos.ArquivoExpedienteDoCliente)
					.Where(l => !string.IsNullOrWhiteSpace(l)) // Filtra linhas em branco.
					.Distinct() // Remove entradas duplicadas.
					.ToArray();

				comboBox_ExpedienteDoCliente.Items.Clear(); // Limpa as opções existentes.
				comboBox_ExpedienteDoCliente.Items.AddRange(linhas); // Adiciona as novas opções.
			}

			// Carrega as opções de forma de contato com o cliente a partir de um arquivo e as adiciona ao ComboBox.
			if (File.Exists(Caminhos.ArquivoTelefone))
			{
				var linhas = File.ReadAllLines(Caminhos.ArquivoTelefone)
					.Where(l => !string.IsNullOrWhiteSpace(l)) // Filtra linhas em branco.
					.Distinct() // Remove entradas duplicadas.
					.ToArray();

				comboBox_FormaDeContatoComCliente_Telefone.Items.Clear(); // Limpa as opções existentes.
				comboBox_FormaDeContatoComCliente_Telefone.Items.AddRange(linhas); // Adiciona as novas opções.
			}
			
			if (File.Exists(Caminhos.ArquivoTipoDeDefeito))
			{
				var linhas = File.ReadAllLines(Caminhos.ArquivoTipoDeDefeito)
					.Where(l => !string.IsNullOrWhiteSpace(l)) // Filtra linhas em branco.
					.Distinct() // Remove entradas duplicadas.
					.ToArray();
				
				comboBox_TipoDeReparo.Items.Clear();
				comboBox_TipoDeReparo.Items.AddRange(linhas);
			};

			if (File.Exists(Caminhos.ArquivoEmail))
			{
				var linhas = File.ReadAllLines(Caminhos.ArquivoEmail)
					.Where(l => !string.IsNullOrWhiteSpace(l)) // Filtra linhas em branco.
					.Distinct() // Remove entradas duplicadas.
					.ToArray();

				comboBox_FormaDeContatoComCliente_Email.Items.Clear();
				comboBox_FormaDeContatoComCliente_Email.Items.AddRange(linhas);
			}
		}

		// Responsável por acessar o ambitente de Configuração de usuário
		void BtnNotificarClienteClick(object sender, EventArgs e)
		{
			NotificarClientePorMensagemDeTexto notificarCliente = new NotificarClientePorMensagemDeTexto();
			notificarCliente.Show();
		}
		
		void ButtonApagarClick(object sender, EventArgs e)
		{
			// Limpeza dos campos de texto
			tituloDeReparo.Clear();
			designacao.Clear();
			enderecoComercial.Clear();

			// Limpeza dos ComboBoxes (textos selecionados)
			comboBox_RazaoSocial.Text = string.Empty;
			comboBox_ExpedienteDoCliente.Text = string.Empty;
			comboBox_FormaDeContatoComCliente_Email.Text = string.Empty;
			comboBox_FormaDeContatoComCliente_Telefone.Text = string.Empty;
			comboBox_TipoDeReparo.Text = string.Empty;
		}
		
//		Método responsável por alinhar o atalho Tab
		private void atalhoTabIndex()
		{
			tituloDeReparo.TabIndex = 0;
			comboBox_RazaoSocial.TabIndex = 1;
			designacao.TabIndex = 2;
			enderecoComercial.TabIndex = 3;
			comboBox_ExpedienteDoCliente.TabIndex = 4;
			comboBox_FormaDeContatoComCliente_Email.TabIndex = 5;
			comboBox_FormaDeContatoComCliente_Telefone.TabIndex = 6;
			comboBox_TipoDeReparo.TabIndex = 7;
		}
	}
}