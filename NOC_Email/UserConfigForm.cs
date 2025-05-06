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

		string getArquivo_class_caminho_email = Caminhos.ArquivoEmail;
		string getArquivo_class_caminho_Telefone = Caminhos.ArquivoTelefone;

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

		// expediente do cliente
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
			}
			catch (Exception ex)
			{
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

		void BtnSalvarEmailClick(object sender, EventArgs e)
		{
			try
			{
				string emailEntrada = comboBox_EmailDaTelecom.Text.Trim();

				// Validação simples de e-mail
				if (!IsValidEmail(emailEntrada))
				{
					MessageBox.Show("Por favor, digite um e-mail válido.");
					return;
				}

				if (emailEntrada.Equals(":empty all email", StringComparison.OrdinalIgnoreCase))
				{
					var resultado = MessageBox.Show(
						"Você está prestes a apagar todos os dados salvos de e-mail. " +
						"Esta ação não pode ser desfeita e todos os registros serão removidos permanentemente. " +
						"Deseja continuar?",
						"Confirmação de Exclusão",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Warning
					);

					if (resultado == DialogResult.Yes)
					{
						comboBox_EmailDaTelecom.Text = "";
						File.WriteAllText(getArquivo_class_caminho_email, string.Empty);
						AtualizarEmailsNoComboBox();
						MessageBox.Show("Todos os dados de e-mail foram apagados com sucesso.");
					}
					else
					{
						MessageBox.Show("Operação cancelada.");
					}

					return;
				}

				if (!string.IsNullOrEmpty(emailEntrada))
				{
					File.AppendAllText(getArquivo_class_caminho_email, emailEntrada + Environment.NewLine);
					AtualizarEmailsNoComboBox();
					MessageBox.Show("E-mail salvo com sucesso!");
				}
				else
				{
					MessageBox.Show("Por favor, digite um e-mail válido.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao processar: " + ex.Message);
			}
		}

		private void AtualizarEmailsNoComboBox()
		{
			if (File.Exists(getArquivo_class_caminho_email))
			{
				string[] linhas = File.ReadAllLines(getArquivo_class_caminho_email);
				comboBox_EmailDaTelecom.Items.Clear();

				foreach (var linha in linhas.Distinct().Where(l => !string.IsNullOrWhiteSpace(l)))
				{
					comboBox_EmailDaTelecom.Items.Add(linha.Trim());
				}
			}
		}

		void BtnSalvarTelefoneClick(object sender, EventArgs e)
		{
			try
			{
				string telefoneDeContato = comboBox_TelefoneDeContato.Text.Trim();

				if (telefoneDeContato.Equals(":empty all telefone", StringComparison.OrdinalIgnoreCase))
				{
					var resultado = MessageBox.Show(
						"Você está prestes a apagar todos os dados salvos de Telefone. " +
						"Esta ação não pode ser desfeita e todos os registros serão removidos permanentemente. " +
						"Deseja continuar?",
						"Confirmação de Exclusão",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Warning
					);

					if (resultado == DialogResult.Yes)
					{
						comboBox_TelefoneDeContato.Text = "";
						File.WriteAllText(getArquivo_class_caminho_Telefone, string.Empty);
						AtualizarTelefonesNoComboBox();
						MessageBox.Show("Todos os dados de telefone foram apagados com sucesso.");
					}
					else
					{
						MessageBox.Show("Operação cancelada.");
					}

					return;
				}

				if (!string.IsNullOrEmpty(telefoneDeContato))
				{
					File.AppendAllText(getArquivo_class_caminho_Telefone, telefoneDeContato + Environment.NewLine);
					AtualizarTelefonesNoComboBox();
					MessageBox.Show("Telefone para contato salvo com sucesso!");
				}
				else
				{
					MessageBox.Show("Por favor, digite um telefone válido.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao processar: " + ex.Message);
			}
		}

		private void AtualizarTelefonesNoComboBox()
		{
			if (File.Exists(getArquivo_class_caminho_Telefone))
			{
				string[] linhas = File.ReadAllLines(getArquivo_class_caminho_Telefone);
				comboBox_TelefoneDeContato.Items.Clear();

				foreach (var linha in linhas.Distinct().Where(l => !string.IsNullOrWhiteSpace(l)))
				{
					comboBox_TelefoneDeContato.Items.Add(linha.Trim());
				}
			}
		}

		private void UserConfigForm_Load(object sender, EventArgs e)
		{
			AtualizarRazoesNaComboBox();
			AtualizarExpedientesNoComboBox();
			AtualizarEmailsNoComboBox();
			AtualizarTelefonesNoComboBox();
		}

		// responsável por excluir valores selecionados no comboBox pelo usuário
		void BtnExcluirClick(object sender, EventArgs e)
		{
			try
			{
				if (comboBox_RazaoSocial.SelectedItem != null)
				{
					ExcluirItemSelecionado(comboBox_RazaoSocial, getArquivo_class_caminho_razaoSocial);
					AtualizarRazoesNaComboBox();
					return;
				}

				if (comboBox_ExpedienteDoCliente.SelectedItem != null)
				{
					ExcluirItemSelecionado(comboBox_ExpedienteDoCliente, getArquivo_class_caminho_ExpedienteDoCliente);
					AtualizarExpedientesNoComboBox();
					return;
				}

				if (comboBox_EmailDaTelecom.SelectedItem != null)
				{
					ExcluirItemSelecionado(comboBox_EmailDaTelecom, getArquivo_class_caminho_email);
					AtualizarEmailsNoComboBox();
					return;
				}

				if (comboBox_TelefoneDeContato.SelectedItem != null)
				{
					ExcluirItemSelecionado(comboBox_TelefoneDeContato, getArquivo_class_caminho_Telefone);
					AtualizarTelefonesNoComboBox();
					return;
				}

				MessageBox.Show("Nenhum item selecionado para exclusão.");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao excluir item: " + ex.Message);
			}
		}

		private void ExcluirItemSelecionado(ComboBox comboBox, string caminhoArquivo)
		{
			string itemSelecionado = comboBox.SelectedItem.ToString();

			if (File.Exists(caminhoArquivo))
			{
				var linhas = File.ReadAllLines(caminhoArquivo)
					.Where(l => !string.IsNullOrWhiteSpace(l) && l.Trim() != itemSelecionado)
					.Distinct()
					.ToArray();

				File.WriteAllLines(caminhoArquivo, linhas);
				// Recarregar o ComboBox após a exclusão
				comboBox.Items.Clear();
				foreach (var linha in linhas)
				{
					comboBox.Items.Add(linha.Trim());
				}
				MessageBox.Show("O item '" + itemSelecionado + "' foi excluído com sucesso.");
			}
			else
			{
				MessageBox.Show("Erro ao tentar acessar o arquivo de dados.");
			}
		}

		// Validação simples para e-mail
		private bool IsValidEmail(string email)
		{
			try
			{
				var addr = new System.Net.Mail.MailAddress(email);
				return addr.Address == email;
			}
			catch
			{
				return false;
			}
		}
	}
}

