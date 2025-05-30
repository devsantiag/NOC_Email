﻿using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;

namespace NOC_Email
{
	public partial class UserConfigForm : Form
	{
		// Caminhos dos arquivos de dados
		string getArquivo_class_caminho_razaoSocial = Caminhos.ArquivoRazaoSocial;
		string getArquivo_class_caminho_ExpedienteDoCliente = Caminhos.ArquivoExpedienteDoCliente;
		string getArquivo_class_caminho_email = Caminhos.ArquivoEmail;
		string getArquivo_class_caminho_Telefone = Caminhos.ArquivoTelefone;
		string getArquivo_class_caminho_tipoDeDefeito = Caminhos.ArquivoTipoDeDefeito;

		public UserConfigForm()
		{
			InitializeComponent();
			this.Load += UserConfigForm_Load;
			this.StartPosition = FormStartPosition.CenterScreen;
			OrdenarTabIndex();
		}

		// Método para salvar a razão social no arquivo
		void BtnSalvarRazaoSocialClick(object sender, EventArgs e)
		{
			try
			{
				string entrada = comboBox_RazaoSocial.Text.Trim();

				// Verifica se o texto é um comando para limpar todos os dados
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
						File.WriteAllText(getArquivo_class_caminho_razaoSocial, string.Empty);
						AtualizarRazoesNaComboBox();
						MessageBox.Show("Todos os dados foram apagados com sucesso.");
					}
					else
					{
						MessageBox.Show("Operação cancelada.");
					}

				}

				// Verifica se a entrada não está vazia e salva no arquivo
				if (!string.IsNullOrEmpty(entrada))
				{
					File.AppendAllText(getArquivo_class_caminho_razaoSocial, entrada + Environment.NewLine);
					AtualizarRazoesNaComboBox();
					MessageBox.Show("Razão Social salva com sucesso!");
					comboBox_RazaoSocial.Text = "";
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

		// Atualiza os itens da ComboBox com as razões sociais salvas
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

		// Método para salvar o expediente do cliente no arquivo
		void BtnSalvarExpedienteDoClienteClick(object sender, EventArgs e)
		{
			try
			{
				string entrada = comboBox_ExpedienteDoCliente.Text.Trim();

				// Verifica se o texto é um comando para limpar todos os dados
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
						File.WriteAllText(getArquivo_class_caminho_ExpedienteDoCliente, string.Empty);
						AtualizarExpedientesNoComboBox();
						MessageBox.Show("Todos os dados foram apagados com sucesso.");
					}
					else
					{
						MessageBox.Show("Operação cancelada.");
					}
				}

				// Verifica se a entrada não está vazia e salva no arquivo
				if (!string.IsNullOrEmpty(entrada))
				{
					File.AppendAllText(getArquivo_class_caminho_ExpedienteDoCliente, entrada + Environment.NewLine);
					AtualizarExpedientesNoComboBox();
					MessageBox.Show("Expediente do cliente salvo com sucesso");
					comboBox_ExpedienteDoCliente.Text = "";
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

		// Atualiza os itens da ComboBox com os expedientes do cliente salvos
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

		// Método para salvar o e-mail do cliente no arquivo
		void BtnSalvarEmailClick(object sender, EventArgs e)
		{
			try
			{
				string emailEntrada = comboBox_EmailDaTelecom.Text.Trim().ToLower();

				if (emailEntrada.Equals(":empty all emails", StringComparison.OrdinalIgnoreCase))
				{
					var resultado = MessageBox.Show(
						"Você está prestes a apagar todos os dados salvos de E-mail. " +
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
						MessageBox.Show("Todos os dados de E-mails foram apagados com sucesso.");
					}
					else
					{
						MessageBox.Show("Operação cancelada.");
					}
					return;
				}

				// Validação simples de e-mail
				if (!IsValidEmail(emailEntrada))
				{
					MessageBox.Show("Por favor, digite um e-mail válido.");
					return;
				}

				if (!string.IsNullOrEmpty(emailEntrada))
				{
					File.AppendAllText(getArquivo_class_caminho_email, emailEntrada + Environment.NewLine);
					AtualizarEmailsNoComboBox();
					MessageBox.Show("E-mail salvo com sucesso!");
					comboBox_EmailDaTelecom.Text = "";
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao processar: " + ex.Message);
			}
		}


		// Atualiza os itens da ComboBox com os e-mails salvos
		private void AtualizarEmailsNoComboBox()
		{
			if (File.Exists(getArquivo_class_caminho_email))
			{
				string[] linhas = File.ReadAllLines(getArquivo_class_caminho_email);
				comboBox_EmailDaTelecom.Items.Clear();

				// Adiciona os e-mails distintos e não vazios
				foreach (var linha in linhas.Distinct().Where(l => !string.IsNullOrWhiteSpace(l)))
				{
					comboBox_EmailDaTelecom.Items.Add(linha.Trim());
				}
			}
		}

		// Método para salvar o telefone de contato no arquivo
		void BtnSalvarTelefoneClick(object sender, EventArgs e)
		{
			try
			{
				string telefoneDeContato = comboBox_TelefoneDeContato.Text.Trim();

				// Verifica se o texto é um comando para limpar todos os telefones
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

				// Verifica se a entrada não está vazia e salva no arquivo
				if (!IsValidPhoneNumber(telefoneDeContato))
				{
					MessageBox.Show("Por favor, digite um telefone válido.");
					return;
				}

				if (!string.IsNullOrEmpty(telefoneDeContato))
				{
					File.AppendAllText(getArquivo_class_caminho_Telefone, telefoneDeContato + Environment.NewLine);
					AtualizarTelefonesNoComboBox();
					MessageBox.Show("Telefone para contato salvo com sucesso!");
					comboBox_TelefoneDeContato.Text = "";
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

		private bool IsValidPhoneNumber(string telefone)
		{
			var regex = new System.Text.RegularExpressions.Regex(@"^(\d{10,11}|\d{2,3}[\s-]?\d{4}[\s-]?\d{4})$");
			return regex.IsMatch(telefone);
		}

		// Atualiza os itens da ComboBox com os telefones salvos
		private void AtualizarTelefonesNoComboBox()
		{
			if (File.Exists(getArquivo_class_caminho_Telefone))
			{
				string[] linhas = File.ReadAllLines(getArquivo_class_caminho_Telefone);
				comboBox_TelefoneDeContato.Items.Clear();

				// Adiciona os telefones distintos e não vazios
				foreach (var linha in linhas.Distinct().Where(l => !string.IsNullOrWhiteSpace(l)))
				{
					comboBox_TelefoneDeContato.Items.Add(linha.Trim());
				}
			}
		}

		// Carrega os dados quando o formulário for aberto
		private void UserConfigForm_Load(object sender, EventArgs e)
		{
			AtualizarRazoesNaComboBox();
			AtualizarExpedientesNoComboBox();
			AtualizarEmailsNoComboBox();
			AtualizarTelefonesNoComboBox();
			AtualizarTiposDeDefeitoNoComboBox();
		}

		// Método para excluir o item selecionado no ComboBox
		void BtnExcluirClick(object sender, EventArgs e)
		{
			bool algoFoiExcluido = false;

			try
			{
				if (comboBox_RazaoSocial.SelectedItem != null)
				{
					ExcluirItemSelecionado(comboBox_RazaoSocial, getArquivo_class_caminho_razaoSocial);
					AtualizarRazoesNaComboBox();
					comboBox_RazaoSocial.Focus();
					comboBox_RazaoSocial.Text = "";
					algoFoiExcluido = true;
				}

				if (comboBox_ExpedienteDoCliente.SelectedItem != null)
				{
					ExcluirItemSelecionado(comboBox_ExpedienteDoCliente, getArquivo_class_caminho_ExpedienteDoCliente);
					AtualizarExpedientesNoComboBox();
					comboBox_ExpedienteDoCliente.Focus();
					comboBox_ExpedienteDoCliente.Text = "";
					algoFoiExcluido = true;
				}

				if (comboBox_EmailDaTelecom.SelectedItem != null)
				{
					ExcluirItemSelecionado(comboBox_EmailDaTelecom, getArquivo_class_caminho_email);
					AtualizarEmailsNoComboBox();
					comboBox_EmailDaTelecom.Focus();
					comboBox_EmailDaTelecom.Text = "";
					algoFoiExcluido = true;
				}

				if (comboBox_TelefoneDeContato.SelectedItem != null)
				{
					ExcluirItemSelecionado(comboBox_TelefoneDeContato, getArquivo_class_caminho_Telefone);
					AtualizarTelefonesNoComboBox();
					comboBox_TelefoneDeContato.Focus();
					comboBox_TelefoneDeContato.Text = "";
					algoFoiExcluido = true;
				}
				
				if (comboBox_TipoDeDefeito.SelectedItem != null)
				{
					ExcluirItemSelecionado(comboBox_TipoDeDefeito, getArquivo_class_caminho_tipoDeDefeito);
					AtualizarTiposDeDefeitoNoComboBox();
					comboBox_TipoDeDefeito.Focus();
					comboBox_TipoDeDefeito.Text = "";
					algoFoiExcluido = true;
				}
				
				if (!algoFoiExcluido)
				{
					MessageBox.Show("Nenhum item selecionado para exclusão.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao excluir item: " + ex.Message);
			}
		}

		// Exclui o item selecionado no ComboBox
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
				// Atualiza o ComboBox após a exclusão
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

		// Evento disparado ao clicar no botão "Salvar Tipo de Defeito"
		// Este método salva o valor digitado no ComboBox_TipoDeDefeito no arquivo de armazenamento
		// Também permite apagar todos os registros se o comando ":empty all tipo defeito" for digitado
		void BtnSalvarTipoDeDefeitoClick(object sender, EventArgs e)

		{
			try
			{
				string tipoDefeito = comboBox_TipoDeDefeito.Text.Trim();

				if (tipoDefeito.Equals(":empty all tipo defeito", StringComparison.OrdinalIgnoreCase))
				{
					var resultado = MessageBox.Show(
						"Você está prestes a apagar todos os dados salvos de Tipo de Defeito. " +
						"Esta ação não pode ser desfeita e todos os registros serão removidos permanentemente. " +
						"Deseja continuar?",
						"Confirmação de Exclusão",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Warning
					);

					if (resultado == DialogResult.Yes)
					{
						comboBox_TipoDeDefeito.Text = "";
						File.WriteAllText(getArquivo_class_caminho_tipoDeDefeito, string.Empty);
						AtualizarTiposDeDefeitoNoComboBox();
						MessageBox.Show("Todos os tipos de defeito foram apagados com sucesso.");
					}
					else
					{
						MessageBox.Show("Operação cancelada.");
					}

					return;
				}

				if (!string.IsNullOrEmpty(tipoDefeito))
				{
					File.AppendAllText(getArquivo_class_caminho_tipoDeDefeito, tipoDefeito + Environment.NewLine);
					AtualizarTiposDeDefeitoNoComboBox();
					MessageBox.Show("Tipo de defeito salvo com sucesso!");
				}
				else
				{
					MessageBox.Show("Por favor, digite o tipo de defeito.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao processar: " + ex.Message);
			}
		}

		// Carrega os tipos de defeito ao ComboBox quando o formulário é iniciado
		private void AtualizarTiposDeDefeitoNoComboBox()
		{
			if (File.Exists(getArquivo_class_caminho_tipoDeDefeito))
			{
				string[] linhas = File.ReadAllLines(getArquivo_class_caminho_tipoDeDefeito);
				comboBox_TipoDeDefeito.Items.Clear();

				foreach (var linha in linhas.Distinct().Where(l => !string.IsNullOrWhiteSpace(l)))
				{
					comboBox_TipoDeDefeito.Items.Add(linha.Trim());
				}
			}
		}
		
		// Verifica se o e-mail fornecido possui um formato válido, utilizando a classe MailAddress para validação formal
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
		
		// Método genérico para fechar ou ocultar a janela, dependendo do valor de 'fechar'.
		void WindowClose(bool fechar)
		{
			if (fechar)
				this.Close();
			else
				this.Hide();
		}
		void BtnCloseWindowClick(object sender, EventArgs e)
		{
			WindowClose(fechar: true);
		}
		void btnWindowOkClick (object sender, EventArgs e)
		{
			WindowClose(fechar: false);
		}
		
		private void MostrarManualDeUso()
		{
			string manual =
				@"MANUAL DE USO - COMANDOS :empty all

Este sistema permite apagar todos os registros de forma rápida através de comandos especiais digitados nas caixas de seleção (ComboBox).

⚠️ Atenção: ao utilizar qualquer um dos comandos abaixo, todos os dados relacionados serão apagados permanentemente após a sua confirmação.

1️⃣ :empty all razao social
- Ao digitar este comando na ComboBox de Razão Social e pressionar 'Salvar', o sistema solicitará confirmação.
- Confirmando, todos os registros de Razão Social serão apagados.

2️⃣ :empty all expediente
- Ao digitar este comando na ComboBox de Expediente do Cliente e pressionar 'Salvar', o sistema solicitará confirmação.
- Confirmando, todos os registros de Expediente serão apagados.

3️⃣ :empty all emails
- Ao digitar este comando na ComboBox de E-mails e pressionar 'Salvar', o sistema solicitará confirmação.
- Confirmando, todos os registros de E-mails serão apagados.

4️⃣ :empty all telefone
- Ao digitar este comando na ComboBox de Telefone e pressionar 'Salvar', o sistema solicitará confirmação.
- Confirmando, todos os registros de Telefones serão apagados.

5️⃣ :empty all tipo de defeito
- Ao digitar este comando na ComboBox de Tipo de Defeito e pressionar 'Salvar', o sistema solicitará confirmação.
- Confirmando, todos os registros de Tipos de Defeito serão apagados.

✅ Sempre que utilizar um comando :empty all, certifique-se de que deseja realmente apagar todos os dados.

❓ Dúvidas? Procure o responsável pelo sistema.

Obrigado por utilizar o sistema NOC_Email!";

			MessageBox.Show(manual, "Manual de Uso - Comando :empty all", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		
		//		Responsável por apresentar o Manual de uso ao Usuário
		void BtnDuvidaClick(object sender, EventArgs e)
		{
			MostrarManualDeUso();
		}

		// Define a ordem de navegação entre os campos usando a tecla TAB
		void OrdenarTabIndex()
		{
			comboBox_RazaoSocial.TabIndex = 0;
			btnSalvarRazaoSocial.TabIndex = 1;

			comboBox_ExpedienteDoCliente.TabIndex = 2;
			btnSalvarExpedienteDoCliente.TabIndex = 3;

			comboBox_EmailDaTelecom.TabIndex = 4;
			btnSalvarEmail.TabIndex = 5;

			comboBox_TelefoneDeContato.TabIndex = 6;
			btnSalvarTelefone.TabIndex = 7;

			comboBox_TipoDeDefeito.TabIndex = 8;
			btnSalvarTipoDeDefeito.TabIndex = 9;
			btnExcluir.TabIndex = 11;
			btnDuvida.TabIndex = 12;
			btnCloseWindow.TabIndex = 13;
		}
	}
}