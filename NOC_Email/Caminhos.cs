using System;
using System.IO;

namespace NOC_Email
{
    public static class Caminhos
    {
        public static readonly string PastaConfig = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "NOC_Email");

        public static readonly string ArquivoRazaoSocial = Path.Combine(PastaConfig, "razao_social_da_empresa.txt");
        public static readonly string ArquivoExpedienteDoCliente = Path.Combine(PastaConfig, "expediente_do_cliente.txt");
        public static readonly string ArquivoEmail = Path.Combine(PastaConfig, "emails_da_telecom.txt");
        public static readonly string ArquivoTelefone = Path.Combine(PastaConfig, "telefones_de_contato.txt");
        public static readonly string ArquivoTipoDeDefeito = Path.Combine(PastaConfig, "tipo_de_defeito_do_contrato.txt");

        static Caminhos()
        {
            if (!Directory.Exists(PastaConfig))
            {
                Directory.CreateDirectory(PastaConfig);
            }
        }
    }
}
