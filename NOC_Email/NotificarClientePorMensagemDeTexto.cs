// Referências necessárias para o projeto
using System;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook; // Alias para facilitar a chamada do Outlook
using System.Collections.Generic;

namespace NOC_Email
{
	public partial class NotificarClientePorMensagemDeTexto : Form
	{
		// Lista que armazena os caminhos dos arquivos anexados
		private List<string> arquivoAnexadoPeloAgente = new List<string>();

		// Construtor do formulário
		public NotificarClientePorMensagemDeTexto()
		{
			InitializeComponent(); // Inicializa os componentes do formulário
			OrdenarTabIndex(); // Define a ordem de navegação via tecla TAB
		}

		// Botão que dispara o envio do e-mail
		private void BtnEncaminharEmailClick(object sender, EventArgs e)
		{
			// Valida se os campos obrigatórios estão preenchidos
			if (string.IsNullOrWhiteSpace(textBox1_TitutloEmail.Text) || string.IsNullOrWhiteSpace(richTextBox1_CorpoDeMensagemDeTexto.Text))
			{
				MessageBox.Show("Um ou mais campos encontram-se vazios. Tente novamente, por favor.", "ATENÇÃO:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try {
				// Captura os valores dos campos
				string tituloEmail = textBox1_TitutloEmail.Text;
				string corpoMensagemTexto = richTextBox1_CorpoDeMensagemDeTexto.Text;

				// Codifica os dados para compatibilidade com URI, caso fosse usado um link mailto (neste caso, está redundante)
				string encodedTitulo = Uri.EscapeDataString(tituloEmail);
				string encodedCorpoMensagem = Uri.EscapeDataString(corpoMensagemTexto);

				// Cria uma instância do Outlook e um novo e-mail
				Outlook.Application outLookApp = new Outlook.Application();
				Outlook.MailItem email = (Outlook.MailItem)outLookApp.CreateItem(Outlook.OlItemType.olMailItem);

				// Define o título e corpo da mensagem
				email.Subject = tituloEmail.ToUpper();
				email.Body = corpoMensagemTexto;

				// Adiciona os anexos à mensagem
				foreach (string arquivo in arquivoAnexadoPeloAgente)
				{
				    email.Attachments.Add(arquivo);
				}

				// Exibe a janela do Outlook com a mensagem pronta (não envia automaticamente)
				email.Display(false);

				// (Opcional) Criação de link "mailto" - atualmente não está sendo usado
				string mailtoLink = string.Format("outlook:?subject={0}&body={1}", encodedTitulo, encodedCorpoMensagem);
			} 
			catch (Exception ex)
			{
				// Exibe mensagem de erro ao usuário
				MessageBox.Show("Erro ao tentar encaminhar o Email: " + ex.Message);
				throw;
			}
		}

		// Botão que limpa os campos do formulário e os anexos
		void BtnApagarMensagemClick(object sender, EventArgs e)
		{
			ApagarConteudo(); // Limpa título e corpo do texto
			arquivoAnexadoPeloAgente.Clear(); // Limpa a lista de anexos
			btnAnexar.Text = "Anexar"; // Reseta o texto do botão de anexo
		}

		// Função que limpa os campos do título e corpo da mensagem
		void ApagarConteudo()
		{
			textBox1_TitutloEmail.Clear();
			richTextBox1_CorpoDeMensagemDeTexto.Clear();
		}

		// Define a ordem de navegação entre os campos usando a tecla TAB
		void OrdenarTabIndex()
		{
			textBox1_TitutloEmail.TabIndex = 0;
			richTextBox1_CorpoDeMensagemDeTexto.TabIndex = 1;
			btnEncaminharEmail.TabIndex = 2;
			btnApagarMensagem.TabIndex = 3;
		}

		// Botão responsável por abrir a janela de seleção de arquivos e armazenar os caminhos dos anexos
		void BtnAnexarClick(object sender, EventArgs e)
		{
			OpenFileDialog dialogo = new OpenFileDialog();
			dialogo.Title = "Selecione o(s) arquivo(s)";
			dialogo.Filter = "Todos os arquivos (*.*)|*.*"; // Permite todos os tipos de arquivos
			dialogo.Multiselect = true; // Permite seleção múltipla

			if (dialogo.ShowDialog() == DialogResult.OK)
			{
				foreach (string arq in dialogo.FileNames)
				{
					arquivoAnexadoPeloAgente.Add(arq); // Adiciona o caminho do arquivo à lista
					btnAnexar.Text = "Anexar*"; // Indica que há arquivos anexados
				}
			}
		}
	}
}