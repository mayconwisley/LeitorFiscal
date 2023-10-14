using LeitorFiscal.AFD;
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

        CabecalhoAFD.CabecalhoAfdList.Clear();
        CabecalhoAFD.ErrosValidacao.Clear();
        IdentificacaoEmpresaRepAFD.IdentificacaoEmpresaRepAfdList.Clear();
        IdentificacaoEmpresaRepAFD.ErrosValidacao.Clear();
        MarcacaoPontoAFD.MarcacaoPontoAfdList.Clear();
        MarcacaoPontoAFD.ErrosValidacao.Clear();
        TempoRealRepAFD.TempoRealRepAfdList.Clear();
        TempoRealRepAFD.ErrosValidacao.Clear();
        EmpregadoMtRepAFD.EmpregadoMtRepAfdList.Clear();
        EmpregadoMtRepAFD.ErrosValidacao.Clear();
        EventosSensiveisRepAFD.EventosSensiveisRepAfdList.Clear();
        EventosSensiveisRepAFD.ErrosValidacao.Clear();
        TrailerAFD.TrailerAfdList.Clear();
        TrailerAFD.ErrosValidacao.Clear();

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
                TrailerAFD.ErrosValidacao.Add("Erro, tamanho da linha do registro 9 - Trailer incorreto.");
            }


            switch (itemLinha)
            {
                case "1":
                    CabecalhoAFD.GetCabecalho(linha, portaria595);
                    break;
                case "2":
                    countIdentEmpresa++;
                    IdentificacaoEmpresaRepAFD.GetIdentificadorEmpresa(linha, portaria595);
                    break;
                case "3":
                    countMarcacaoPonto++;
                    MarcacaoPontoAFD.GetMarcacaoPonto(linha, portaria595);
                    break;
                case "4":
                    countTempoReal++;
                    TempoRealRepAFD.GetTempoReal(linha, portaria595);
                    break;
                case "5":
                    countEmpregadoMt++;
                    EmpregadoMtRepAFD.GetEmpregadoMtRep(linha, portaria595);
                    break;
                case "6":
                    countEventoSensiveis++;
                    EventosSensiveisRepAFD.GetEventosSensiveis(linha, portaria595);
                    break;
                case "9":
                    TrailerAFD.GetTrailer(linha, portaria595);
                    break;
                default:
                    MessageBox.Show($"Tipo de registro inválido: {itemLinha}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sr.ReadToEnd();
                    break;
            }
        }

        if (TrailerAFD.ValidarResgistrosAEJ(countIdentEmpresa, countMarcacaoPonto, countTempoReal, countEmpregadoMt, countEventoSensiveis))
        {
            MessageBox.Show("Não foi possivel validar a quantidade de registros!\nVeja a guia 9 - Trailer", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            IdentificacaoEmpresaRepAFD.IdentificacaoEmpresaRepAfdList.Clear();
            MarcacaoPontoAFD.MarcacaoPontoAfdList.Clear();
            TempoRealRepAFD.TempoRealRepAfdList.Clear();
            EmpregadoMtRepAFD.EmpregadoMtRepAfdList.Clear();
            EventosSensiveisRepAFD.EventosSensiveisRepAfdList.Clear();
        }
    }
}
