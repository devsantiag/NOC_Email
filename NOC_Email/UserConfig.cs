/*
 * Criado por SharpDevelop.
 * Usuário: fjstavares
 * Data: 25/04/2025
 * Hora: 10:25
 */
using System;
using System.Windows.Forms;

namespace NOC_Email
{
	public partial class UserConfig : Form
	{
		public UserConfig()
		{
			InitializeComponent();
		}
		void BtnExitApplicationClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
