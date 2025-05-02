using System;
using System.Text;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;
using System.IO;

namespace NOC_Email
{
	public partial class MainForm : Form
	{
		
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
