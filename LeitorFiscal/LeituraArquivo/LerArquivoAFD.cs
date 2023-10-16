using LeitorFiscal.AFD;
using System.Text;

namespace LeitorFiscal.LeituraArquivo;

public class LerArquivoAFD
{

    #region Funções para Limpar as classes
    private static void LimparCabecalho()
    {
        CabecalhoAFD1510.CabecalhoAfdList.Clear();
        CabecalhoAFD1510.ErrosValidacao.Clear();
        CabecalhoAFD1510.Portaria = "";
        CabecalhoAFD595.CabecalhoAfdList.Clear();
        CabecalhoAFD595.ErrosValidacao.Clear();
        CabecalhoAFD595.Portaria = "";
        CabecalhoAFD671.CabecalhoAfdList.Clear();
        CabecalhoAFD671.ErrosValidacao.Clear();
        CabecalhoAFD671.Portaria = "";
    }
    private static void LimparIdentificacaoEmpresa()
    {
        IdentificacaoEmpresaAFD1510.IdentificacaoEmpresaRepAfdList.Clear();
        IdentificacaoEmpresaAFD1510.ErrosValidacao.Clear();
        IdentificacaoEmpresaAFD1510.Portaria = "";
        IdentificacaoEmpresaAFD595.IdentificacaoEmpresaRepAfdList.Clear();
        IdentificacaoEmpresaAFD595.ErrosValidacao.Clear();
        IdentificacaoEmpresaAFD595.Portaria = "";
        IdentificacaoEmpresaAFD671.IdentificacaoEmpresaRepAfdList.Clear();
        IdentificacaoEmpresaAFD671.ErrosValidacao.Clear();
        IdentificacaoEmpresaAFD671.Portaria = "";
    }
    private static void LimparMarcacaoPonto()
    {
        MarcacaoPontoAFD1510.MarcacaoPontoAfdList.Clear();
        MarcacaoPontoAFD1510.ErrosValidacao.Clear();
        MarcacaoPontoAFD1510.Portaria = "";
        MarcacaoPontoAFD595.MarcacaoPontoAfdList.Clear();
        MarcacaoPontoAFD595.ErrosValidacao.Clear();
        MarcacaoPontoAFD595.Portaria = "";
        MarcacaoPontoAFD671.MarcacaoPontoAfdList.Clear();
        MarcacaoPontoAFD671.ErrosValidacao.Clear();
        MarcacaoPontoAFD671.Portaria = "";
    }
    private static void LimparTempoReal()
    {
        TempoRealRepAFD.TempoRealRepAfdList.Clear();
        TempoRealRepAFD.ErrosValidacao.Clear();
    }
    private static void LimparEmpregadoMt()
    {
        EmpregadoMtRepAFD.EmpregadoMtRepAfdList.Clear();
        EmpregadoMtRepAFD.ErrosValidacao.Clear();
    }
    private static void LimparEventosSensiveis()
    {
        EventosSensiveisRepAFD.EventosSensiveisRepAfdList.Clear();
        EventosSensiveisRepAFD.ErrosValidacao.Clear();
    }
    private static void LimparTrailer()
    {

        TrailerAFD.TrailerAfdList.Clear();
        TrailerAFD.ErrosValidacao.Clear();
    }
    #endregion
    public static void Arquivo(string caminho, bool portaria595)
    {
        using StreamReader sr = new(caminho, Encoding.Latin1, true, 1024 * 1024 * 1);
        string? linha;

        int countIdentEmpresa = 0, countMarcacaoPonto = 0, countTempoReal = 0, countEmpregadoMt = 0;
        int countEventoSensiveis = 0;
        LimparCabecalho();
        LimparIdentificacaoEmpresa();
        LimparMarcacaoPonto();
        LimparTempoReal();
        LimparEmpregadoMt();
        LimparEventosSensiveis();
        LimparTrailer();

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

                    if (linha.Length == 232)
                    {
                        CabecalhoAFD1510.GetCabecalho(linha);
                    }
                    if (linha.Length == 236)
                    {
                        CabecalhoAFD595.GetCabecalho(linha);
                    }
                    if (linha.Length == 302)
                    {
                        CabecalhoAFD671.GetCabecalho(linha);
                    }

                    break;
                case "2":
                    countIdentEmpresa++;
                    if (linha.Length == 299)
                    {
                        IdentificacaoEmpresaAFD1510.GetIdentificadorEmpresa(linha);
                    }
                    if (linha.Length == 317)
                    {
                        IdentificacaoEmpresaAFD595.GetIdentificadorEmpresa(linha);
                    }
                    if (linha.Length == 331)
                    {
                        IdentificacaoEmpresaAFD671.GetIdentificadorEmpresa(linha);
                    }

                    break;
                case "3":
                    countMarcacaoPonto++;
                    MarcacaoPontoAFD1510.GetMarcacaoPonto(linha, portaria595);
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

            IdentificacaoEmpresaAFD1510.IdentificacaoEmpresaRepAfdList.Clear();
            MarcacaoPontoAFD1510.MarcacaoPontoAfdList.Clear();
            TempoRealRepAFD.TempoRealRepAfdList.Clear();
            EmpregadoMtRepAFD.EmpregadoMtRepAfdList.Clear();
            EventosSensiveisRepAFD.EventosSensiveisRepAfdList.Clear();
        }
    }
}
