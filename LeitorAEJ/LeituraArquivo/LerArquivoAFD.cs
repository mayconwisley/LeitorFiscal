using LeitorAEJ.AFD.Portaria_1510;
using System.Text;

namespace LeitorAEJ.LeituraArquivo;

public class LerArquivoAFD
{
    public static void Arquivo(string caminho)
    {
        using StreamReader sr = new(caminho, Encoding.Latin1, true, 1024 * 1024 * 1);
        string? linha;

        int countIdentEmpresa = 0, countMarcacaoPonto = 0, countTempoReal = 0, countEmpregadoMt = 0;

        Cabecalho1510.Cabecalho1510List.Clear();
        Cabecalho1510.ErrosValidacao.Clear();
        IdentificacaoEmpresaRep1510.IdentificacaoEmpresaRep1510List.Clear();
        IdentificacaoEmpresaRep1510.ErrosValidacao.Clear();
        MarcacaoPonto1510.MarcacaoPonto1510List.Clear();
        MarcacaoPonto1510.ErrosValidacao.Clear();
        TempoRealRep1510.TempoRealRep1510List.Clear();
        TempoRealRep1510.ErrosValidacao.Clear();
        EmpregadoMtRep1510.EmpregadoMtRep1510List.Clear();
        EmpregadoMtRep1510.ErrosValidacao.Clear();

        while ((linha = sr.ReadLine()) != null)
        {
            string itemLinha = linha.Substring(9, 1);

            switch (itemLinha)
            {
                case "1":
                    Cabecalho1510.GetCabecalho(linha);
                    break;
                case "2":
                    countIdentEmpresa++;
                    IdentificacaoEmpresaRep1510.GetIdentificadorEmpresa(linha);
                    break;
                case "3":
                    countMarcacaoPonto++;
                    MarcacaoPonto1510.GetMarcacaoPonto(linha);
                    break;
                case "4":
                    countTempoReal++;
                    TempoRealRep1510.GetTempoReal(linha);
                    break;
                case "5":
                    countEmpregadoMt++;
                    EmpregadoMtRep1510.GetEmpregadoMtRep(linha);
                    break;
                case "6":
                    EventosSensiveisRep1510.GetEventosSensiveis(linha);
                    break;
                case "0":
                    Trailer1510.GetTrailer(linha);
                    break;
                default:
                    MessageBox.Show($"Tipo de registro inválido: {itemLinha}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sr.ReadToEnd();
                    break;
            }
        }

    }
}
