using LeitorFiscal.LeituraArquivo;
using LeitorFiscal.Model.Util;
using System.ComponentModel.DataAnnotations;

namespace LeitorFiscal.AFD;

public class TempoRealAFD595
{
    [MaxLength(9, ErrorMessage = "O campo Nsr deve ter um comprimento máximo de '9'")]
    [MinLength(9, ErrorMessage = "O campo Nsr deve ter um comprimento minimo de '9'")]
    public string? Nsr { get; private set; } /*Tamanho: 9, Posição: 1 a 9, Tipo: numérico*/

    [MaxLength(1, ErrorMessage = "O campo TpRegistro deve ter um comprimento máximo de '1'")]
    [MinLength(1, ErrorMessage = "O campo TpRegistro deve ter um comprimento minimo de '1'")]
    public string? TpRegistro { get; private set; } /*Tamanho: 1, Posição 10 a 10, Tipo: numérico, Dado: = 4*/

    [MaxLength(8, ErrorMessage = "O campo DataAntesAjuste deve ter um comprimento máximo de '8'")]
    [MinLength(8, ErrorMessage = "O campo DataAntesAjuste deve ter um comprimento minimo de '8'")]
    public string? DataAntesAjuste { get; private set; } /*Tamanho: 8, Posição: 11 a 18, Tipo: numérico, Formato: ddmmaaaa*/

    [MaxLength(4, ErrorMessage = "O campo HoraAntesAjuste deve ter um comprimento máximo de '4'")]
    [MinLength(4, ErrorMessage = "O campo HoraAntesAjuste deve ter um comprimento minimo de '4'")]
    public string? HoraAntesAjuste { get; private set; } /*Tamanho: 4, Posição: 19 a 22, Tipo: numérico, Formato: hhmm*/

    [MaxLength(8, ErrorMessage = "O campo DataAjustada deve ter um comprimento máximo de '8'")]
    [MinLength(8, ErrorMessage = "O campo DataAjustada deve ter um comprimento minimo de '8'")]
    public string? DataAjustada { get; private set; } /*Tamanho: 8, Posição: 23 a 30, Tipo: numérico, Formato: ddmmaaaa*/

    [MaxLength(4, ErrorMessage = "O campo HoraAjustada deve ter um comprimento máximo de '4'")]
    [MinLength(4, ErrorMessage = "O campo HoraAjustada deve ter um comprimento minimo de '4'")]
    public string? HoraAjustada { get; private set; } /*Tamanho: 4, Posição: 31 a 34, Tipo: numérico, Formato: hhmm*/

    [MaxLength(11, ErrorMessage = "O campo CpfResponsavel deve ter um comprimento máximo de '11'")]
    [MinLength(11, ErrorMessage = "O campo CpfResponsavel deve ter um comprimento minimo de '11'")]
    public string? CpfResponsavel { get; private set; } /*Tamanho: 11, Posição: 35 a 45, Tipo: numérico*/

    [MaxLength(4, ErrorMessage = "O campo Crc16 deve ter um comprimento máximo de '4'")]
    [MinLength(4, ErrorMessage = "O campo Crc16 deve ter um comprimento minimo de '4'")]
    public string? Crc16 { get; private set; } /*Tamanho: 4, Posição: 46 a 49, Tipo: alfanumérico*/

    public static List<TempoRealAFD595> TempoRealRepAfdList { get; private set; } = new();
    public static List<string> ErrosValidacao { get; private set; } = new();
    public static string? Portaria { get; set; }
    #region Funções
    public static void GetTempoReal(string linhaArquivo)
    {
        TempoRealAFD595 tempoRealRep;
        int tamanhoLinha = linhaArquivo.Length;
        if (tamanhoLinha != 49)
        {
            ErrosValidacao.Add($"O registro '4 - Tempo Real' possui o tamanho de caracteres diferentes que o definido pela a Portaria n.º 595, de 05 de dezembro de 2013. Tamanho encotrado {tamanhoLinha}\n");
            return;
        }
        else
        {
            Portaria = "Portaria n.º 595, de 05 de dezembro de 2013\n";
            tempoRealRep = new()
            {
                Nsr = linhaArquivo[..9],
                TpRegistro = linhaArquivo.Substring(9, 1),
                DataAntesAjuste = linhaArquivo.Substring(10, 8),
                HoraAntesAjuste = linhaArquivo.Substring(18, 4),
                DataAjustada = linhaArquivo.Substring(22, 8),
                HoraAjustada = linhaArquivo.Substring(30, 4),
                CpfResponsavel = linhaArquivo.Substring(34, 11),
                Crc16 = linhaArquivo.Substring(45, 4)
            };
        }

        if (ValidacaoTamanhoDado.ValidarTamanho(tempoRealRep, linhaArquivo) && ValidarTipoDados(tempoRealRep, linhaArquivo))
        {
            if (tempoRealRep.TpRegistro != "4")
            {
                ErrosValidacao.Add($"O campo 'TpRegistro' esta com o valor ({tempoRealRep.TpRegistro}) inválido, deve ter o valor '4'.\n\tLinha ({LerArquivoAFD.NumeroLinha}): {linhaArquivo}\n");
                return;
            }

            TempoRealRepAfdList.Add(tempoRealRep);
        }
        foreach (var item in ValidacaoTamanhoDado.ErrosValidacao)
        {
            ErrosValidacao.Add(item + "\n");
        }
    }
    private static bool ValidarTipoDados(TempoRealAFD595 tempoRealRep, string linha)
    {

        var camposComErro = new List<string>();

        if (!int.TryParse(tempoRealRep.Nsr, out _))
        {
            camposComErro.Add("Nsr");
        }

        if (!int.TryParse(tempoRealRep.TpRegistro, out _))
        {
            camposComErro.Add("TpRegistro");
        }

        if (!double.TryParse(tempoRealRep.DataAntesAjuste, out _))
        {
            camposComErro.Add("DataAntesAjuste");
        }

        if (!double.TryParse(tempoRealRep.HoraAntesAjuste, out _))
        {
            camposComErro.Add("HoraAntesAjuste");
        }

        if (!double.TryParse(tempoRealRep.DataAjustada, out _))
        {
            camposComErro.Add("DataAjustada");
        }

        if (!double.TryParse(tempoRealRep.HoraAjustada, out _))
        {
            camposComErro.Add("HoraAjustada");
        }

        if (!double.TryParse(tempoRealRep.CpfResponsavel, out _))
        {
            camposComErro.Add("CpfResponsavel");
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
