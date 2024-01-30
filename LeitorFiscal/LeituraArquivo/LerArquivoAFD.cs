using LeitorFiscal.AFD;
using LeitorFiscal.AFD.LimparDados;
using System.Text;

namespace LeitorFiscal.LeituraArquivo;

public class LerArquivoAFD
{
    public static int NumeroLinha { get; private set; } = 0;

    static int countIdentEmpresa = 0, countMarcacaoPonto = 0, countTempoReal = 0, countEmpregadoMt = 0;
    static int countEventoSensiveis = 0, countMarcacaoPontoRepP = 0;
    static int trailer = 0;
    public async static Task<decimal> TotalLinhaArquivo(string caminho)
    {
        decimal totalLinhas = 0;

        using StreamReader srLinha = new(caminho);

        while (srLinha.ReadLine() != null)
        {
            totalLinhas++;
        }

        return await Task.FromResult(totalLinhas);
    }

    public static void Arquivo(string caminho)
    {
        NumeroLinha = 0;
        using StreamReader sr = new(caminho, Encoding.Latin1, true, 1024 * 1024 * 1);
        string? linha;

        LimparAFD.Limpar();
        ErrosDeLeitura.Erros.Clear();

        while ((linha = sr.ReadLine()) != null)
        {
            NumeroLinha++;

            string itemLinha = linha.Substring(9, 1);

            if (!string.IsNullOrEmpty(ValidarTrailer(linha)))
            {
                itemLinha = ValidarTrailer(linha);
                ItemLinha(itemLinha, linha);
            }

            ItemLinha(itemLinha, linha);
        }
        ValidarTrailerRegistro();
    }

    private static void ItemLinha(string itemLinha, string linha)
    {
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
                if (linha.Length == 298 || linha.Length == 302)
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
                if (linha.Length == 327 || linha.Length == 331)
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
                if (linha.Length == 46 || linha.Length == 50)
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
                if (linha.Length == 69 || linha.Length == 73)
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
                if (linha.Length == 114 || linha.Length == 118)
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
                if (linha.Length == 133 || linha.Length == 137)
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
                if (linha.Length == 60 || linha.Length == 64)
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
                    ErrosDeLeitura.Erros.Add($"Linha: {linha} - {itemLinha}");

                    //MessageBox.Show($"Tipo de registro inválido: {itemLinha}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //sr.ReadToEnd();
                }
                break;
        }
    }

    private static string ValidarTrailer(string linha)
    {
        string itemTrailer = linha[..9];
        string itemLinha = string.Empty;

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
            return itemLinha;
        }
        catch
        {
            TrailerAFD1510.ErrosValidacao.Add("Erro, tamanho da linha do registro 9 - Trailer incorreto.");
            return string.Empty;
        }
    }

    private static void ValidarTrailerRegistro()
    {
        if (trailer == 46)
        {
            if (TrailerAFD1510.ValidarResgistrosAEJ(countIdentEmpresa, countMarcacaoPonto, countTempoReal, countEmpregadoMt))
            {
                MessageBox.Show("Não foi possivel validar a quantidade de registros!\nVeja a guia 9 - Trailer", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                LimparAFD.Limpar();
            }
        }
        if (trailer == 55)
        {
            if (TrailerAFD595.ValidarResgistrosAEJ(countIdentEmpresa, countMarcacaoPonto, countTempoReal, countEmpregadoMt, countEventoSensiveis))
            {
                MessageBox.Show("Não foi possivel validar a quantidade de registros!\nVeja a guia 9 - Trailer", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                LimparAFD.Limpar();
            }
        }
        if (trailer == 64)
        {
            if (TrailerAFD671.ValidarResgistrosAEJ(countIdentEmpresa, countMarcacaoPonto, countTempoReal, countEmpregadoMt, countEventoSensiveis, countMarcacaoPontoRepP))
            {
                MessageBox.Show("Não foi possivel validar a quantidade de registros!\nVeja a guia 9 - Trailer", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                LimparAFD.Limpar();
            }
        }
    }

}
