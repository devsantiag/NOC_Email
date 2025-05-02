using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NOC_Email
{
	public partial class UserConfigForm : Form
	{
		string getArquivo_class_caminho = Caminhos.ArquivoRazaoSocial;

		public UserConfigForm()
		{
			InitializeComponent();
			this.Load += UserConfigForm_Load;
		}

		void BtnSalvarRazaoSocialClick(object sender, EventArgs e)
		{
			try
			{
				string entrada = comboBox_RazaoSocial.Text.Trim();

				if (entrada.Equals(":empty all razao social", StringComparison.OrdinalIgnoreCase))
				{
					var resultado = MessageBox.Show("Deseja realmente apagar todos os dados salvos?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

					if (resultado == DialogResult.Yes)
					{
						comboBox_RazaoSocial.Text = "";
						File.WriteAllText(getArquivo_class_caminho, string.Empty); // limpa o conteúdo do arquivo
						AtualizarRazoesNaComboBox();
						MessageBox.Show("Todos os dados foram apagados com sucesso.");
					}
					else
					{
						MessageBox.Show("Operação cancelada.");
					}

					return; // encerra aqui, não continua com o salvamento
				}

				if (!string.IsNullOrEmpty(entrada))
				{
					File.AppendAllText(getArquivo_class_caminho, entrada + Environment.NewLine);
					AtualizarRazoesNaComboBox();
					MessageBox.Show("Razão Social salva com sucesso!");
				}
				else
				{
					MessageBox.Show("Por favor, digite a razão social.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao processar: " + ex.Message);
			}
		}


		private void UserConfigForm_Load(object sender, EventArgs e)
		{
			AtualizarRazoesNaComboBox();
		}

		private void AtualizarRazoesNaComboBox()
		{
			if (File.Exists(getArquivo_class_caminho))
			{
				string[] linhas = File.ReadAllLines(getArquivo_class_caminho);
				comboBox_RazaoSocial.Items.Clear();

				foreach (var linha in linhas.Distinct().Where(l => !string.IsNullOrWhiteSpace(l)))
				{
					comboBox_RazaoSocial.Items.Add(linha.Trim());
				}
			}
		}
	}
}
