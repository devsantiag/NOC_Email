using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NOC_Email
{
	public partial class UserConfigForm : Form
	{
		string getArquivo_class_caminho_razaoSocial = Caminhos.ArquivoRazaoSocial;
		string getArquivo_class_caminho_ExpedienteDoCliente = Caminhos.ArquivoExpedienteDoCliente;
		
		
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
					var resultado = MessageBox.Show(
						"Você está prestes a apagar todos os dados salvos da razão social. " +
						"Esta ação não pode ser desfeita e todos os registros serão removidos permanentemente. " +
						"Deseja continuar?",
						"Confirmação de Exclusão",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Warning
					);

					if (resultado == DialogResult.Yes)
					{
						comboBox_RazaoSocial.Text = "";
						File.WriteAllText(getArquivo_class_caminho_razaoSocial, string.Empty); // limpa o conteúdo do arquivo
						AtualizarRazoesNaComboBox();
						MessageBox.Show("Todos os dados foram apagados com sucesso.");
					}
					else
					{
						comboBox_RazaoSocial.Text = "";
						MessageBox.Show("Operação cancelada.");
					}

					return; // encerra aqui, não continua com o salvamento
				}

				if (!string.IsNullOrEmpty(entrada))
				{
					File.AppendAllText(getArquivo_class_caminho_razaoSocial, entrada + Environment.NewLine);
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

		private void AtualizarRazoesNaComboBox()
		{
			if (File.Exists(getArquivo_class_caminho_razaoSocial))
			{
				string[] linhas = File.ReadAllLines(getArquivo_class_caminho_razaoSocial);
				comboBox_RazaoSocial.Items.Clear();

				foreach (var linha in linhas.Distinct().Where(l => !string.IsNullOrWhiteSpace(l)))
				{
					comboBox_RazaoSocial.Items.Add(linha.Trim());
				}
			}
		}
		
//		expediente do cliente
		void BtnSalvarExpedienteDoClienteClick(object sender, EventArgs e)
		{
			
			try
			{
				string entrada = comboBox_ExpedienteDoCliente.Text.Trim();
				
				if (entrada.Equals(":empty all expediente", StringComparison.OrdinalIgnoreCase))
				{
					var resultado = MessageBox.Show(
						"Você está prestes a apagar todos os dados salvos do Expediente do Cliente. " +
						"Esta ação não pode ser desfeita e todos os registros serão removidos permanentemente. " +
						"Deseja continuar?",
						"Confirmação de Exclusão",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Warning
					);

					if (resultado == DialogResult.Yes)
					{
						comboBox_ExpedienteDoCliente.Text = "";
						File.WriteAllText(getArquivo_class_caminho_ExpedienteDoCliente, string.Empty); // limpa o conteúdo do arquivo
						AtualizarExpedientesNoComboBox();
						MessageBox.Show("Todos os dados foram apagados com sucesso.");
					}
					else
					{
						comboBox_RazaoSocial.Text = "";
						MessageBox.Show("Operação cancelada.");
					}

					return; // encerra aqui, não continua com o salvamento
				}
				
				if (!string.IsNullOrEmpty(entrada))
				{
					File.AppendAllText(getArquivo_class_caminho_ExpedienteDoCliente, entrada + Environment.NewLine);
					AtualizarExpedientesNoComboBox();
					MessageBox.Show("Expediente do cliente salvo com Sucesso");
				}
				else
				{
					MessageBox.Show("Por favor, o expediente do cliente.");
				}
				
			} catch (Exception ex) {
				
				MessageBox.Show("Erro ao processar: " + ex.Message);
				
			}
		}
		
		private void AtualizarExpedientesNoComboBox()
		{
			if (File.Exists(getArquivo_class_caminho_ExpedienteDoCliente))
			{
				string[] linhas = File.ReadAllLines(getArquivo_class_caminho_ExpedienteDoCliente);
				comboBox_ExpedienteDoCliente.Items.Clear();

				foreach (var linha in linhas.Distinct().Where(l => !string.IsNullOrWhiteSpace(l)))
				{
					comboBox_ExpedienteDoCliente.Items.Add(linha.Trim());
				}
			}
		}
		
		private void UserConfigForm_Load(object sender, EventArgs e)
		{
			AtualizarRazoesNaComboBox();
			AtualizarExpedientesNoComboBox();
		}
	}
}
