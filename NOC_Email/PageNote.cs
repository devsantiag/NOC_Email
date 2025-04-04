/*
 * Criado por SharpDevelop.
 * Usuário: fjstavares
 * Data: 04/04/2025
 * Hora: 09:01
 */

using System;
using System.Windows.Forms;

namespace NOC_Email
{
	public partial class PageNote : Form
	{
		public PageNote()
		{
			InitializeComponent();
			
		}
		
//		Responsável por copiar o conteúdo expresso no textBox_ConteudoEscrito
		void BtnCopiarClick(object sender, EventArgs e)
		{
			Clipboard.SetText(textBox_ConteudoEscrito.Text);
			textBox_ConteudoEscrito.Clear();
		}
		
//		Responsável por apagar o campo
		void BtnApagarClick(object sender, EventArgs e)
		{
			textBox_ConteudoEscrito.Clear();
		}
		
//		Organiza a tecla de atalho Tab
		void TabIndexOrdenar()
		{
			btnCopiar.TabIndex = 0;
			btnApagar.TabIndex = 1;
		}
	}
}
