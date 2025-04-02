/* 
 * Created by SharpDevelop.
 * User: fjstavares
 * Date: 01/04/2025
 * Time: 08:49
 */

using System;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace NOC_Email
{
	public partial class NotificarClientePorMensagemDeTexto : Form
	{
		public NotificarClientePorMensagemDeTexto()
		{
			InitializeComponent();
			OrdenarTabIndex();
		}

//		Button responsável por executar o Corpo de E-mail
		private void BtnEncaminharEmailClick(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBox1_TitutloEmail.Text) || string.IsNullOrWhiteSpace(richTextBox1_CorpoDeMensagemDeTexto.Text))
			{
				MessageBox.Show("Um ou mais campos encontram-se vazios. Tente novamente, por favor.", "ATENÇÃO:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			
//			Organiza e cria o Título e Corpo do E-mail por um todo para ser enviado ao destinatário final através do Button 'btnEncaminharEmailClick'
			try {
				string tituloEmail = textBox1_TitutloEmail.Text;
				string corpoMensagemTexto = richTextBox1_CorpoDeMensagemDeTexto.Text;
				
				string encodedTitulo = Uri.EscapeDataString(tituloEmail);
				string encodedCorpoMensagem = Uri.EscapeDataString(corpoMensagemTexto);

				Outlook.Application outLookApp = new Outlook.Application();
				Outlook.MailItem email = (Outlook.MailItem)outLookApp.CreateItem(Outlook.OlItemType.olMailItem);
				
//				tipo de E-mail (caracterizado como 'simples')
				email.Subject = tituloEmail.ToUpper();
				email.Body = corpoMensagemTexto;
				email.Display(false);
				string mailtoLink = string.Format("outlook:?subject={0}&body={1}", encodedTitulo, encodedCorpoMensagem);
				
			} catch (Exception ex)
			{
				MessageBox.Show("Erro ao tentar encaminhar o Email: " + ex.Message);
				throw;
			}
		}
		
//		Button responsável por apagar os campos de Texto
		void BtnApagarMensagemClick(object sender, EventArgs e)
		{
			ApagarConteudo();
		}
		
		void ApagarConteudo()
		{
			textBox1_TitutloEmail.Clear();
			richTextBox1_CorpoDeMensagemDeTexto.Clear();
		}
		
//		Organiza o atalho TAB
		void OrdenarTabIndex()
		{
			textBox1_TitutloEmail.TabIndex = 0;
			richTextBox1_CorpoDeMensagemDeTexto.TabIndex = 1;
			btnEncaminharEmail.TabIndex = 2;
			btnApagarMensagem.TabIndex = 3;
		}

	}
}
