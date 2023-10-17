using LeitorFiscal.Model.Util;
using System.ComponentModel.DataAnnotations;

namespace LeitorFiscal.AFD;

public class TempoRealAFD671
{

    [MaxLength(9, ErrorMessage = "O campo Nsr deve ter um comprimento máximo de '9'")]
    [MinLength(9, ErrorMessage = "O campo Nsr deve ter um comprimento minimo de '9'")]
    public string? Nsr { get; set; } /*Tamanho: 9, Posição: 1 a 9, Tipo: numérico*/

    [MaxLength(1, ErrorMessage = "O campo TpRegistro deve ter um comprimento máximo de '1'")]
    [MinLength(1, ErrorMessage = "O campo TpRegistro deve ter um comprimento minimo de '1'")]
    public string? TpRegistro { get; set; } /*Tamanho: 1, Posição 10 a 10, Tipo: numérico, Dado: = 4*/

    [MaxLength(24, ErrorMessage = "O campo DataHoraDoAjuste deve ter um comprimento máximo de '24'")]
    [MinLength(24, ErrorMessage = "O campo DataHoraDoAjuste deve ter um comprimento minimo de '24'")]
    public string? DataHoraDoAjuste { get; set; } /*Tamanho: 24, Posição: 11 a 34, Tipo: numérico, Formato: AAAA-MM-ddThh:mm:00ZZZZZ*/

    [MaxLength(24, ErrorMessage = "O campo DataHoraAjustada deve ter um comprimento máximo de '24'")]
    [MinLength(24, ErrorMessage = "O campo DataHoraAjustada deve ter um comprimento minimo de '24'")]
    public string? DataHoraAjustada { get; set; } /*Tamanho: 24, Posição: 35 a 58, Tipo: numérico, Formato: AAAA-MM-ddThh:mm:00ZZZZZ*/

    [MaxLength(11, ErrorMessage = "O campo CpfResponsavel deve ter um comprimento máximo de '11'")]
    [MinLength(11, ErrorMessage = "O campo CpfResponsavel deve ter um comprimento minimo de '11'")]
    public string? CpfResponsavel { get; set; } /*Tamanho: 11, Posição: 59 a 69, Tipo: numérico*/

    [MaxLength(4, ErrorMessage = "O campo Crc16 deve ter um comprimento máximo de '4'")]
    [MinLength(4, ErrorMessage = "O campo Crc16 deve ter um comprimento minimo de '4'")]
    public string? Crc16 { get; set; } /*Tamanho: 4, Posição: 70 a 73, Tipo: alfanumérico*/

    public static List<TempoRealAFD671> TempoRealRepAfdList { get; set; } = new();
    public static List<string> ErrosValidacao { get; set; } = new();
    public static string? Portaria { get; set; }
    #region Funções
    public static void GetTempoReal(string linhaArquivo)
    {
        TempoRealAFD671 tempoRealRep;
        int tamanhoLinha = linhaArquivo.Length;
        if (tamanhoLinha != 49)
        {
            ErrosValidacao.Add($"O registro '4 - Tempo Real' possui o tamanho de caracteres diferentes que o definido pela a Portaria Nº 671, de 8 de novembro de 2021. Tamanho encotrado {tamanhoLinha}\n");
            return;
        }
        else
        {
            Portaria = "Portaria Nº 671, de 8 de novembro de 2021\n";
            tempoRealRep = new()
            {
                Nsr = linhaArquivo[..9],
                TpRegistro = linhaArquivo.Substring(9, 1),
                DataHoraDoAjuste = linhaArquivo.Substring(10, 24),
                DataHoraAjustada = linhaArquivo.Substring(34, 24),
                CpfResponsavel = linhaArquivo.Substring(58, 11),
                Crc16 = linhaArquivo.Substring(69, 4)
            };
        }

        if (ValidacaoTamanhoDado.ValidarTamanho(tempoRealRep) && ValidarTipoDados(tempoRealRep))
        {
            if (tempoRealRep.TpRegistro != "4")
            {
                ErrosValidacao.Add($"O campo 'TpRegistro' esta com o valor ({tempoRealRep.TpRegistro}) inválido, deve ter o valor '4'.\n");
                return;
            }

            TempoRealRepAfdList.Add(tempoRealRep);
        }
        foreach (var item in ValidacaoTamanhoDado.ErrosValidacao)
        {
            ErrosValidacao.Add(item + "\n");
        }
    }
    private static bool ValidarTipoDados(TempoRealAFD671 tempoRealRep)
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

        if (!DateTime.TryParse(tempoRealRep.DataHoraDoAjuste, out _))
        {
            camposComErro.Add("DataAntesAjuste");
        }

        if (!DateTime.TryParse(tempoRealRep.DataHoraAjustada, out _))
        {
            camposComErro.Add("HoraAntesAjuste");
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
            ErrosValidacao.Add($"Erro de tipo de dados nos campos: {string.Join(", ", camposComErro)}\n");
            return false;
        }
    }
    #endregion
}
