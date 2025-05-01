/*
 * Criado por SharpDevelop.
 * Usuário: fjstavares
 * Data: 25/04/2025
 * Hora: 10:25
 */

using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;


namespace NOC_Email
{
	public partial class UserConfig : Form
	{
		public static string arquivo_razaoSocial = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "razao_social_da_empresa.txt");
		public static string arquivo_formaDeContato = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "forma_de_contato_com_a_telecom.txt");
		
		public UserConfig()
		{
			InitializeComponent();
			CarregarRazoesSociais();
		}
		void BtnExitApplicationClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void BtnHistoricoDeInformacoesSalvasClick(object sender, EventArgs e)
		{
			Historico historicoDeRegistros = new Historico();
			historicoDeRegistros.Show();
		}
		void BtnSalvarRazaoSocialClick(object sender, EventArgs e)
		{
			string getValueComboBox = comboBox_RazaoSocial.Text.Trim();
			
			if (string.IsNullOrWhiteSpace(getValueComboBox))
			{
				MessageBox.Show("Campo vazio! Digite uma razão social antes de salvar.");
				return;
			}
			
			List<string> jaSalvos;

			if (File.Exists(arquivo_razaoSocial))
			{
				var linhasCheck = File.ReadAllLines(arquivo_razaoSocial);
				jaSalvos = linhasCheck != null ? linhasCheck.ToList() : new List<string>();
			}
			else
			{
				jaSalvos = new List<string>();
			}

			if (!jaSalvos.Contains(getValueComboBox))
			{
				jaSalvos.Add(getValueComboBox);
				jaSalvos = jaSalvos
					.Where(l => !string.IsNullOrWhiteSpace(l))
					.Select(l => l.Trim())
					.OrderBy(l => l)
					.ToList();

				File.WriteAllLines(arquivo_razaoSocial, jaSalvos);
			}

			// Atualiza o ComboBox com os itens ordenados
			comboBox_RazaoSocial.Items.Clear();
			comboBox_RazaoSocial.Items.AddRange(jaSalvos.ToArray());
			comboBox_RazaoSocial.Text = getValueComboBox;
		}
		private void CarregarRazoesSociais()
		{
			if (File.Exists(arquivo_razaoSocial))
			{
				var linhas = File.ReadAllLines(arquivo_razaoSocial)
					.Where(l => !string.IsNullOrWhiteSpace(l))
					.Select(l => l.Trim())
					.OrderBy(l => l)
					.ToArray();

				comboBox_RazaoSocial.Items.Clear();
				comboBox_RazaoSocial.Items.AddRange(linhas);
			}
		}

	}
}
