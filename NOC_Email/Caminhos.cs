using System;
using System.IO;

namespace NOC_Email
{
	public static class Caminhos
	{
		public static readonly string PastaConfig = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "NOC_Email");

        public static readonly string ArquivoRazaoSocial = Path.Combine(PastaConfig, "razao_social_da_empresa.txt");
        public static readonly string ArquivoExpedienteDoCliente = Path.Combine(PastaConfig, "expediente_do_cliente.txt");
        public static readonly string ArquivoFormaDeContato = Path.Combine(PastaConfig, "forma_de_contato_com_a_telecom.txt");
        
        static Caminhos()
        {
        	if (!Directory.Exists(PastaConfig))
            {
                Directory.CreateDirectory(PastaConfig);
            }
        }
        
	}
}
