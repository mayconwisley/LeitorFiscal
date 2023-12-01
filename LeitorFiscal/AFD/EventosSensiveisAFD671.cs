using LeitorFiscal.LeituraArquivo;
using LeitorFiscal.Model.Util;
using System.ComponentModel.DataAnnotations;

namespace LeitorFiscal.AFD;

public class EventosSensiveisAFD671
{
    [MaxLength(9, ErrorMessage = "O campo Nsr deve ter um comprimento máximo de '9'")]
    [MinLength(9, ErrorMessage = "O campo Nsr deve ter um comprimento minimo de '9'")]
    public string? Nsr { get; private set; } /*Tamanho: 9, Posição: 1 a 9, Tipo: numérico*/

    [MaxLength(1, ErrorMessage = "O campo TpRegistro deve ter um comprimento máximo de '1'")]
    [MinLength(1, ErrorMessage = "O campo TpRegistro deve ter um comprimento minimo de '1'")]
    public string? TpRegistro { get; private set; } /*Tamanho: 1, Posição: 10 a 10, Tipo: numérico, Dado: = 6*/

    [MaxLength(24, ErrorMessage = "O campo DataHoraRegistro deve ter um comprimento máximo de '24'")]
    [MinLength(24, ErrorMessage = "O campo DataHoraRegistro deve ter um comprimento minimo de '24'")]
    public string? DataHoraRegistro { get; private set; } /*Tamanho: 24, Posição: 11 a 34, Tipo: numerico*/

    [MaxLength(2, ErrorMessage = "O campo TpEvento deve ter um comprimento máximo de '2'")]
    [MinLength(2, ErrorMessage = "O campo TpEvento deve ter um comprimento minimo de '2'")]
    public string? TpEvento { get; private set; } /*Tamanho: 2, Posição: 35 a 36, Tipo: numérico*/
    /*  Tipo de evento, “01” para abertura do REP por 
        manutenção ou violação, “02” para retorno de energia, 
        “03” para introdução de dispositivo externo de 
        memória na Porta Fiscal, “04” para retirada de 
        dispositivo externo de memória na Porta Fiscal, “05” 
        para emissão da Relação Instantânea de Marcações e 
        “06” para erro de impressão.
     */

    public static List<EventosSensiveisAFD671> EventosSensiveisRepAfdList { get; private set; } = new();
    public static List<string> ErrosValidacao { get; private set; } = new();
    public static string? Portaria { get; set; }
    #region Funções
    public static void GetEventosSensiveis(string linhaArquivo)
    {
        EventosSensiveisAFD671 eventosSensiveis;
        int tamanhoLinha = linhaArquivo.Length;

        if (tamanhoLinha != 24)
        {
            ErrosValidacao.Add($"O registro '6 - Eventos Sensíveis' possui o tamanho de caracteres diferentes que o definido pela a Portaria Nº 671, de 8 de novembro de 2021. Tamanho encotrado {tamanhoLinha}\n");
            return;
        }
        else
        {
            Portaria = "Portaria Nº 671, de 8 de novembro de 2021\n";
            eventosSensiveis = new()
            {
                Nsr = linhaArquivo[..9],
                TpRegistro = linhaArquivo.Substring(9, 1),
                DataHoraRegistro = linhaArquivo.Substring(10, 24),
                TpEvento = linhaArquivo.Substring(34, 2)
            };
        }
        if (ValidacaoTamanhoDado.ValidarTamanho(eventosSensiveis, linhaArquivo) && ValidarTipoDados(eventosSensiveis, linhaArquivo))
        {
            if (eventosSensiveis.TpRegistro != "6")
            {
                ErrosValidacao.Add($"O campo 'TpRegistro' esta com o valor ({eventosSensiveis.TpRegistro}) inválido, deve ter o valor '6'.\n\tLinha ({LerArquivoAFD.NumeroLinha}): {linhaArquivo}\n");
                return;
            }

            if (eventosSensiveis.TpEvento != "01" && eventosSensiveis.TpEvento != "02" && eventosSensiveis.TpEvento != "03" &&
                eventosSensiveis.TpEvento != "04" && eventosSensiveis.TpEvento != "05" && eventosSensiveis.TpEvento != "06")
            {
                ErrosValidacao.Add($"O campo 'TpEvento' esta com o valor ({eventosSensiveis.TpEvento}) inválido, deve ter o valor '01', '02', '03', '04', '05' ou '06'.\n\tLinha ({LerArquivoAFD.NumeroLinha}): {linhaArquivo}\n");
                return;
            }

            EventosSensiveisRepAfdList.Add(eventosSensiveis);
        }
        foreach (var item in ValidacaoTamanhoDado.ErrosValidacao)
        {
            ErrosValidacao.Add(item + "\n");
        }
    }
    private static bool ValidarTipoDados(EventosSensiveisAFD671 eventosSensiveis, string linha)
    {
        var camposComErro = new List<string>();

        if (!int.TryParse(eventosSensiveis.Nsr, out _))
        {
            camposComErro.Add("Nsr");
        }

        if (!int.TryParse(eventosSensiveis.TpRegistro, out _))
        {
            camposComErro.Add("TpRegistro");
        }

        if (!DateTime.TryParse(eventosSensiveis.DataHoraRegistro, out _))
        {
            camposComErro.Add("DataHoraRegistro");
        }

        if (!double.TryParse(eventosSensiveis.TpEvento, out _))
        {
            camposComErro.Add("TpEvento");
        }

        if (camposComErro.Count == 0)
        {
            return true;
        }
        else
        {
            ErrosValidacao.Add($"Erro de tipo de dados nos campos: {string.Join(", ", camposComErro)}\n\tLinha ({LerArquivoAFD.NumeroLinha}): {linha}\n");
            return false;
        }
    }
    #endregion
}
