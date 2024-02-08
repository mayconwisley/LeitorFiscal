using LeitorFiscal.AFD;
using LeitorFiscal.AFD.LimparDados;
using LeitorFiscal.LeituraArquivo.Enum;
using System.Text;

namespace LeitorFiscal.LeituraArquivo;

public class LerArquivoAFD
{
    public static int NumeroLinha { get; private set; } = 0;

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
            ValidarTrailerRegistro(linha!.Length);
        }
    }

    private static void ValidarTipoRegistro(string itemLinha, string linha)
    {
        bool isItem = int.TryParse(itemLinha, out int item);
        if (isItem)
        {
            TipoRegistro tipoRegistro = (TipoRegistro)item;
            ItemLinha(tipoRegistro, linha);
        }
        else
        {
            TipoRegistro tipoRegistro = (TipoRegistro)linha.Length;
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

    private static void ValidarTrailerRegistro(int len)
    {
        TamanhoTrailer tamanhoTrailer = (TamanhoTrailer)len;

        if (ValidarRegistrosAEJ(tamanhoTrailer))
        {
            MessageBox.Show("Não foi possivel validar a quantidade de registros!\nVeja a guia 9 - Trailer", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //LimparAFD.Limpar();
        }
    }

    private static bool ValidarRegistrosAEJ(TamanhoTrailer tamanhoTrailer)
    {
        return tamanhoTrailer switch
        {
            TamanhoTrailer.AFD1510 => TrailerAFD1510.ValidarResgistrosAEJ(ProcessarGets.CountIdentEmpresa, ProcessarGets.CountMarcacaoPonto, ProcessarGets.CountTempoReal, ProcessarGets.CountEmpregadoMt),
            TamanhoTrailer.AFD595 => TrailerAFD595.ValidarResgistrosAEJ(ProcessarGets.CountIdentEmpresa, ProcessarGets.CountMarcacaoPonto, ProcessarGets.CountTempoReal, ProcessarGets.CountEmpregadoMt, ProcessarGets.CountEventoSensiveis),
            TamanhoTrailer.AFD671 => TrailerAFD671.ValidarResgistrosAEJ(ProcessarGets.CountIdentEmpresa, ProcessarGets.CountMarcacaoPonto, ProcessarGets.CountTempoReal, ProcessarGets.CountEmpregadoMt, ProcessarGets.CountEventoSensiveis, ProcessarGets.CountMarcacaoPontoRepP),
            _ => false,
        };
    }

}
