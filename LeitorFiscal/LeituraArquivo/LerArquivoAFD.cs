using LeitorFiscal.AFD;
using LeitorFiscal.AFD.LimparDados;
using LeitorFiscal.LeituraArquivo.Enum;
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

    public async static Task Arquivo(string caminho)
    {
        NumeroLinha = 0;
        countIdentEmpresa = 0; countMarcacaoPonto = 0; countTempoReal = 0; countEmpregadoMt = 0;
        countEventoSensiveis = 0; countMarcacaoPontoRepP = 0;
        trailer = 0;

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
                ValidarTipoRegistro(itemLinha, linha);
            }
            else
            {
                ValidarTipoRegistro(itemLinha, linha);
            }
        }
        ValidarTrailerRegistro();
    }

    private static void ValidarTipoRegistro(string itemLinha, string linha)
    {
        bool isItem = int.TryParse(itemLinha, out int item);
        if (isItem)
        {
            TipoRegistro tipoRegistro = (TipoRegistro)item;
            ItemLinha(tipoRegistro, linha);
        }
    }

    private static void ItemLinha(TipoRegistro tipoRegistro, string linha)
    {
        Dictionary<TipoRegistro, Func<string, bool>> registroHandlers = new()
    {
        { TipoRegistro.Cabecalho, ProcessarGets.ProcessarCabecalho },
        { TipoRegistro.IdentificacaoEmpresa, ProcessarGets.ProcessarIdentificacaoEmpresa },
        { TipoRegistro.MarcacaoPontoREP_C_A, ProcessarGets.ProcessarMarcacaoPonto },
        { TipoRegistro.AjusteRelogio,ProcessarGets.ProcessarAjusteRelogio },
        { TipoRegistro.EmpregadoREP, ProcessarGets.ProcessarEmpregado },
        { TipoRegistro.EventosSensiveisREP,ProcessarGets.ProcessarEventoSensivel },
        { TipoRegistro.MarcacaoPontoREP_P, ProcessarGets.ProcessarMarcacaoPontoRepP },
        { TipoRegistro.Trailer, ProcessarGets.ProcessarTrailer }
    };

        if (registroHandlers.TryGetValue(tipoRegistro, out var handler))
        {
            if (handler(linha))
            {
                // Lógica adicional, se necessário
            }
        }
        else
        {
            ProcessarGets.ProcessarDefault(linha, tipoRegistro);
        }
    }



    private static void ItemLinha0(TipoRegistro tipoRegistro, string linha)
    {
        switch (tipoRegistro)
        {
            case TipoRegistro.Cabecalho:
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
            case TipoRegistro.IdentificacaoEmpresa:
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
            case TipoRegistro.MarcacaoPontoREP_C_A:
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
            case TipoRegistro.AjusteRelogio:
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
            case TipoRegistro.EmpregadoREP:
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
            case TipoRegistro.EventosSensiveisREP:
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
            case TipoRegistro.MarcacaoPontoREP_P:
                countMarcacaoPontoRepP++;
                if (linha.Length == 133 || linha.Length == 137)
                {
                    MarcacaoPontoRepPAFD671.GetMarcacaoPonto(linha);
                }
                break;
            case TipoRegistro.Trailer:
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
                    ErrosDeLeitura.Erros.Add($"Linha: {linha} - {tipoRegistro}");

                    //MessageBox.Show($"Tipo de registro inválido: {itemLinha}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //sr.ReadToEnd();
                }
                break;
        }
    }

    private static string ValidarTrailer(string linha)
    {
        string itemTrailer = linha[..9];
        try
        {
            return linha.Length switch
            {
                46 when itemTrailer == "999999999" => linha.Substring(45, 1),
                55 when itemTrailer == "999999999" => linha.Substring(54, 1),
                64 when itemTrailer == "999999999" => linha.Substring(63, 1),
                _ => string.Empty,
            };
        }
        catch
        {
            TrailerAFD1510.ErrosValidacao.Add("Erro, tamanho da linha do registro 9 - Trailer incorreto.");
            return string.Empty;
        }
    }

    private static void ValidarTrailerRegistro()
    {
        TamanhoTrailer tamanhoTrailer = (TamanhoTrailer)trailer;

        if (ValidarRegistrosAEJ(tamanhoTrailer))
        {
            MessageBox.Show("Não foi possivel validar a quantidade de registros!\nVeja a guia 9 - Trailer", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            LimparAFD.Limpar();
        }
    }

    private static bool ValidarRegistrosAEJ(TamanhoTrailer tamanhoTrailer)
    {
        return tamanhoTrailer switch
        {
            TamanhoTrailer.AFD1510 => TrailerAFD1510.ValidarResgistrosAEJ(countIdentEmpresa, countMarcacaoPonto, countTempoReal, countEmpregadoMt),
            TamanhoTrailer.AFD595 => TrailerAFD595.ValidarResgistrosAEJ(countIdentEmpresa, countMarcacaoPonto, countTempoReal, countEmpregadoMt, countEventoSensiveis),
            TamanhoTrailer.AFD671 => TrailerAFD671.ValidarResgistrosAEJ(countIdentEmpresa, countMarcacaoPonto, countTempoReal, countEmpregadoMt, countEventoSensiveis, countMarcacaoPontoRepP),
            _ => false,
        };
    }

}
