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
		void BtnCopiarClick(object sender, EventArgs e)
		{
			Clipboard.SetText(textBox_ConteudoEscrito.Text);
		}
		void BtnApagarClick(object sender, EventArgs e)
		{
			textBox_ConteudoEscrito.Clear();
		}
	}
}
