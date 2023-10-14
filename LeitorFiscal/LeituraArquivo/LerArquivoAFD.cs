using LeitorFiscal.AFD.Portaria_1510;
using System.Text;

namespace LeitorFiscal.LeituraArquivo;

public class LerArquivoAFD
{
    public static void Arquivo(string caminho, bool portaria595)
    {
        using StreamReader sr = new(caminho, Encoding.Latin1, true, 1024 * 1024 * 1);
        string? linha;

        int countIdentEmpresa = 0, countMarcacaoPonto = 0, countTempoReal = 0, countEmpregadoMt = 0;
        int countEventoSensiveis = 0;

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
        EventosSensiveisRep1510.EventosSensiveisRep1510List.Clear();
        EventosSensiveisRep1510.ErrosValidacao.Clear();
        Trailer1510.Trailer1510List.Clear();
        Trailer1510.ErrosValidacao.Clear();

        while ((linha = sr.ReadLine()) != null)
        {
            string itemLinha = linha.Substring(9, 1);
            string itemTrailer = linha[..9];

            try
            {
                if (portaria595)
                {
                    if (itemTrailer == "999999999")
                    {
                        itemLinha = linha.Substring(54, 1);
                    }
                }
                else
                {
                    if (itemTrailer == "999999999")
                    {
                        itemLinha = linha.Substring(45, 1);
                    }
                }
            }
            catch
            {
                Trailer1510.ErrosValidacao.Add("Erro, tamanho da linha do registro 9 - Trailer incorreto.");
            }


            switch (itemLinha)
            {
                case "1":
                    Cabecalho1510.GetCabecalho(linha, portaria595);
                    break;
                case "2":
                    countIdentEmpresa++;
                    IdentificacaoEmpresaRep1510.GetIdentificadorEmpresa(linha, portaria595);
                    break;
                case "3":
                    countMarcacaoPonto++;
                    MarcacaoPonto1510.GetMarcacaoPonto(linha, portaria595);
                    break;
                case "4":
                    countTempoReal++;
                    TempoRealRep1510.GetTempoReal(linha, portaria595);
                    break;
                case "5":
                    countEmpregadoMt++;
                    EmpregadoMtRep1510.GetEmpregadoMtRep(linha, portaria595);
                    break;
                case "6":
                    countEventoSensiveis++;
                    EventosSensiveisRep1510.GetEventosSensiveis(linha, portaria595);
                    break;
                case "9":
                    Trailer1510.GetTrailer(linha, portaria595);
                    break;
                default:
                    MessageBox.Show($"Tipo de registro inválido: {itemLinha}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sr.ReadToEnd();
                    break;
            }
        }

        if (Trailer1510.ValidarResgistrosAEJ(countIdentEmpresa, countMarcacaoPonto, countTempoReal, countEmpregadoMt, countEventoSensiveis))
        {
            MessageBox.Show("Não foi possivel validar a quantidade de registros!\nVeja a guia 9 - Trailer", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            IdentificacaoEmpresaRep1510.IdentificacaoEmpresaRep1510List.Clear();
            MarcacaoPonto1510.MarcacaoPonto1510List.Clear();
            TempoRealRep1510.TempoRealRep1510List.Clear();
            EmpregadoMtRep1510.EmpregadoMtRep1510List.Clear();
            EventosSensiveisRep1510.EventosSensiveisRep1510List.Clear();
        }
    }
}
