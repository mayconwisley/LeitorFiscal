using LeitorFiscal.FGTSDigital;
using System.Text;

namespace LeitorFiscal.LeituraArquivo;

public class LerArquivoFGTSDigital
{
    public static int NumeroLinha { get; set; } = 0;

    public static void Arquivo(string caminho)
    {
        using StreamReader sr = new(caminho, Encoding.Latin1, true, 1024 * 1024 * 1);
        string? linha;
        int contaIdentificacao = 0, contaRemuneracao = 0;

        IdentificacaoTrabalhador.ErrosValidacao.Clear();
        IdentificacaoTrabalhador.IdentificacaoTrabalhadors.Clear();
        RemuneracaoTrabalhador.ErrosValidacao.Clear();
        RemuneracaoTrabalhador.RemuneracaoTrabalhadors.Clear();

        while ((linha = sr.ReadLine()) != null)
        {
            string itemLinha = linha[..1];
            switch (itemLinha)
            {
                case "1":
                    contaIdentificacao++;
                    IdentificacaoTrabalhador.GetLinha(linha);
                    break;
                case "2":
                    contaRemuneracao++;
                    RemuneracaoTrabalhador.GetLinha(linha);
                    break;
                default:
                    MessageBox.Show("Erro no arquivo");
                    sr.ReadToEnd();
                    break;
            }
        }

    }
}
