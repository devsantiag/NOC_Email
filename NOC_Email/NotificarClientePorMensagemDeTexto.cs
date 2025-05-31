using System;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace NOC_Email
{
	public partial class NotificarClientePorMensagemDeTexto : Form
	{
		// Lista que armazena os caminhos dos arquivos anexados
		private List<string> arquivoAnexadoPeloAgente = new List<string>();
		
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		[DllImport("user32.dll")]
		public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		private const int WM_NCLBUTTONDOWN = 0xA1;
		private const int HTCAPTION = 0x2;

		// Construtor do formulário
		public NotificarClientePorMensagemDeTexto()
		{
			InitializeComponent();
			OrdenarTabIndex();
			panelConfiguracoes.MouseDown += PanelConfiguracoes_MouseDown;
			textTitle.MouseDown += PanelConfiguracoes_MouseDown;
		}

		private void PanelConfiguracoes_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
			}
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
				string tituloEmail = textBox1_TitutloEmail.Text;
				string corpoMensagemTexto = richTextBox1_CorpoDeMensagemDeTexto.Text;

				string encodedTitulo = Uri.EscapeDataString(tituloEmail);
				string encodedCorpoMensagem = Uri.EscapeDataString(corpoMensagemTexto);
				Outlook.Application outLookApp = new Outlook.Application();
				Outlook.MailItem email = (Outlook.MailItem)outLookApp.CreateItem(Outlook.OlItemType.olMailItem);

				email.Subject = tituloEmail.ToUpper();
				email.Body = corpoMensagemTexto;

				foreach (string arquivo in arquivoAnexadoPeloAgente)
				{
					email.Attachments.Add(arquivo);
				}

				email.Display(false);

				string mailtoLink = string.Format("outlook:?subject={0}&body={1}", encodedTitulo, encodedCorpoMensagem);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao tentar encaminhar o Email: " + ex.Message);
				throw;
			}
		}

		// Função que limpa os campos do título e corpo da mensagem
		void BtnApagarMensagemClick(object sender, EventArgs e)
		{
			textBox1_TitutloEmail.Clear();
			richTextBox1_CorpoDeMensagemDeTexto.Clear();
			btnAnexar.Text = "Anexar";
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
			dialogo.Filter = "Todos os arquivos (*.*)|*.*";
			dialogo.Multiselect = true;

			if (dialogo.ShowDialog() == DialogResult.OK)
			{
				foreach (string arq in dialogo.FileNames)
				{
					arquivoAnexadoPeloAgente.Add(arq);
					btnAnexar.Text = "Anexar*";
				}
			}
		}
		
		// Botão responsável por fechar a janela
		void BtnCloseWindowClick(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}