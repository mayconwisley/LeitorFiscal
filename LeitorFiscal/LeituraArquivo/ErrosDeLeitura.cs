using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeitorFiscal.LeituraArquivo
{
    public class ErrosDeLeitura
    {
        public static List<string> Erros { get; set; } = new();

        public static string ListaDeErro()
        {
            string erro = string.Empty;

            foreach (var item in Erros)
            {
                erro += item + "\n";
            }

            return erro;
        }

    }
}
