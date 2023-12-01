using LeitorFiscal.AFD;
using System.Text;

namespace LeitorFiscal.LeituraArquivo;

public class LerArquivoAFD
{
    public static int NumeroLinha { get; private set; } = 0;

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
        TempoRealAFD1510.TempoRealRepAfdList.Clear();
        TempoRealAFD1510.ErrosValidacao.Clear();
        TempoRealAFD1510.Portaria = "";
        TempoRealAFD595.TempoRealRepAfdList.Clear();
        TempoRealAFD595.ErrosValidacao.Clear();
        TempoRealAFD595.Portaria = "";
        TempoRealAFD671.TempoRealRepAfdList.Clear();
        TempoRealAFD671.ErrosValidacao.Clear();
        TempoRealAFD671.Portaria = "";
    }
    private static void LimparEmpregadoMt()
    {
        EmpregadoMtAFD1510.EmpregadoMtRepAfdList.Clear();
        EmpregadoMtAFD1510.ErrosValidacao.Clear();
        EmpregadoMtAFD1510.Portaria = "";
        EmpregadoMtAFD595.EmpregadoMtRepAfdList.Clear();
        EmpregadoMtAFD595.ErrosValidacao.Clear();
        EmpregadoMtAFD595.Portaria = "";
        EmpregadoMtAFD671.EmpregadoMtRepAfdList.Clear();
        EmpregadoMtAFD671.ErrosValidacao.Clear();
        EmpregadoMtAFD671.Portaria = "";
    }
    private static void LimparEventosSensiveis()
    {
        EventosSensiveisAFD595.EventosSensiveisRepAfdList.Clear();
        EventosSensiveisAFD595.ErrosValidacao.Clear();
        EventosSensiveisAFD595.Portaria = "";
        EventosSensiveisAFD671.EventosSensiveisRepAfdList.Clear();
        EventosSensiveisAFD671.ErrosValidacao.Clear();
        EventosSensiveisAFD671.Portaria = "";
    }
    private static void LimparMarcacaoPontoRepP()
    {
        MarcacaoPontoRepPAFD671.MarcacaoPontoRepPAfdList.Clear();
        MarcacaoPontoRepPAFD671.ErrosValidacao.Clear();
        MarcacaoPontoRepPAFD671.Portaria = "";
    }
    private static void LimparTrailer()
    {
        TrailerAFD1510.TrailerAfdList.Clear();
        TrailerAFD1510.ErrosValidacao.Clear();
        TrailerAFD1510.Portaria = "";
        TrailerAFD595.TrailerAfdList.Clear();
        TrailerAFD595.ErrosValidacao.Clear();
        TrailerAFD595.Portaria = "";
        TrailerAFD671.TrailerAfdList.Clear();
        TrailerAFD671.ErrosValidacao.Clear();
        TrailerAFD671.Portaria = "";
    }
    private static void LimparAssinaturaDigital()
    {
        AssinaturaDigitalAFD.AssinaturaDigitalAfdList.Clear();
        AssinaturaDigitalAFD.ErrosValidacao.Clear();
        AssinaturaDigitalAFD.Portaria = "";
    }

    #endregion
    public static void Arquivo(string caminho)
    {
        NumeroLinha = 0;
        using StreamReader sr = new(caminho, Encoding.UTF8, true, 1024 * 1024 * 1);
        string? linha;
        int trailer = 0;

        int countIdentEmpresa = 0, countMarcacaoPonto = 0, countTempoReal = 0, countEmpregadoMt = 0;
        int countEventoSensiveis = 0, countMarcacaoPontoRepP = 0;
        LimparCabecalho();
        LimparIdentificacaoEmpresa();
        LimparMarcacaoPonto();
        LimparTempoReal();
        LimparEmpregadoMt();
        LimparEventosSensiveis();
        LimparMarcacaoPontoRepP();
        LimparTrailer();
        LimparAssinaturaDigital();

        while ((linha = sr.ReadLine()) != null)
        {
            string itemLinha = linha.Substring(9, 1);
            string itemTrailer = linha[..9];
            NumeroLinha++;
            try
            {
                if (linha.Length == 46)
                {
                    if (itemTrailer == "999999999")
                    {
                        itemLinha = linha.Substring(45, 1);
                    }
                }
                if (linha.Length == 55)
                {
                    if (itemTrailer == "999999999")
                    {
                        itemLinha = linha.Substring(54, 1);
                    }
                }
                if (linha.Length == 64)
                {
                    if (itemTrailer == "999999999")
                    {
                        itemLinha = linha.Substring(63, 1);
                    }
                }
            }
            catch
            {
                TrailerAFD1510.ErrosValidacao.Add("Erro, tamanho da linha do registro 9 - Trailer incorreto.");
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
                    if (linha.Length == 34)
                    {
                        MarcacaoPontoAFD1510.GetMarcacaoPonto(linha);
                    }
                    if (linha.Length == 38)
                    {
                        MarcacaoPontoAFD595.GetMarcacaoPonto(linha);
                    }
                    if (linha.Length == 50)
                    {
                        MarcacaoPontoAFD671.GetMarcacaoPonto(linha);
                    }
                    break;
                case "4":
                    countTempoReal++;
                    if (linha.Length == 34)
                    {
                        TempoRealAFD1510.GetTempoReal(linha);
                    }
                    if (linha.Length == 49)
                    {
                        TempoRealAFD595.GetTempoReal(linha);
                    }
                    if (linha.Length == 73)
                    {
                        TempoRealAFD671.GetTempoReal(linha);
                    }

                    break;
                case "5":
                    countEmpregadoMt++;

                    if (linha.Length == 87)
                    {
                        EmpregadoMtAFD1510.GetEmpregadoMtRep(linha);
                    }
                    if (linha.Length == 106)
                    {
                        EmpregadoMtAFD595.GetEmpregadoMtRep(linha);
                    }
                    if (linha.Length == 118)
                    {
                        EmpregadoMtAFD671.GetEmpregadoMtRep(linha);
                    }

                    break;
                case "6":
                    countEventoSensiveis++;

                    if (linha.Length == 24)
                    {
                        EventosSensiveisAFD595.GetEventosSensiveis(linha);
                    }
                    if (linha.Length == 36)
                    {
                        EventosSensiveisAFD671.GetEventosSensiveis(linha);
                    }

                    break;
                case "7":
                    countMarcacaoPontoRepP++;
                    if (linha.Length == 137)
                    {
                        MarcacaoPontoRepPAFD671.GetMarcacaoPonto(linha);
                    }

                    break;
                case "9":
                    if (linha.Length == 46)
                    {
                        TrailerAFD1510.GetTrailer(linha);
                    }
                    if (linha.Length == 55)
                    {
                        TrailerAFD595.GetTrailer(linha);
                    }
                    if (linha.Length == 64)
                    {
                        TrailerAFD671.GetTrailer(linha);
                    }
                    trailer = linha.Length;
                    break;
                default:
                    if (linha.Length == 100)
                    {
                        AssinaturaDigitalAFD.GetAssinaturaDigital(linha);
                    }
                    else
                    {
                        MessageBox.Show($"Tipo de registro inválido: {itemLinha}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        sr.ReadToEnd();
                    }
                    break;
            }
        }
        if (trailer == 46)
        {
            if (TrailerAFD1510.ValidarResgistrosAEJ(countIdentEmpresa, countMarcacaoPonto, countTempoReal, countEmpregadoMt))
            {
                MessageBox.Show("Não foi possivel validar a quantidade de registros!\nVeja a guia 9 - Trailer", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                LimparCabecalho();
                LimparIdentificacaoEmpresa();
                LimparMarcacaoPonto();
                LimparTempoReal();
                LimparEmpregadoMt();
            }
        }
        if (trailer == 55)
        {
            if (TrailerAFD595.ValidarResgistrosAEJ(countIdentEmpresa, countMarcacaoPonto, countTempoReal, countEmpregadoMt, countEventoSensiveis))
            {
                MessageBox.Show("Não foi possivel validar a quantidade de registros!\nVeja a guia 9 - Trailer", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                LimparCabecalho();
                LimparIdentificacaoEmpresa();
                LimparMarcacaoPonto();
                LimparTempoReal();
                LimparEmpregadoMt();
                LimparEventosSensiveis();
            }
        }
        if (trailer == 64)
        {
            if (TrailerAFD671.ValidarResgistrosAEJ(countIdentEmpresa, countMarcacaoPonto, countTempoReal, countEmpregadoMt, countEventoSensiveis, countMarcacaoPontoRepP))
            {
                MessageBox.Show("Não foi possivel validar a quantidade de registros!\nVeja a guia 9 - Trailer", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                LimparCabecalho();
                LimparIdentificacaoEmpresa();
                LimparMarcacaoPonto();
                LimparTempoReal();
                LimparEmpregadoMt();
                LimparEventosSensiveis();
                LimparMarcacaoPontoRepP();
            }
        }
    }
}
