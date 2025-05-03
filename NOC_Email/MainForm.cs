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
		}
		void BtnConfigClick(object sender, EventArgs e)
		{
			UserConfigForm userConfig = new UserConfigForm();
			userConfig.Show();
		}
	}
}
