using LeitorFiscal.Model.Util;
using System.ComponentModel.DataAnnotations;

namespace LeitorFiscal.AFD;

public class EmpregadoMtAFD1510
{
    [MaxLength(9, ErrorMessage = "O campo Nsr deve ter um comprimento máximo de '9'")]
    [MinLength(9, ErrorMessage = "O campo Nsr deve ter um comprimento minimo de '9'")]
    public string? Nsr { get; private set; } /*Tamanho: 9, Posição: 1 a 9, Tipo: numérico*/

    [MaxLength(1, ErrorMessage = "O campo TpRegistro deve ter um comprimento máximo de '1'")]
    [MinLength(1, ErrorMessage = "O campo TpRegistro deve ter um comprimento minimo de '1'")]
    public string? TpRegistro { get; private set; } /*Tamanho: 1, Posição 10 a 10, Tipo: numérico, Dado: = 5*/

    [MaxLength(8, ErrorMessage = "O campo DataGravacao deve ter um comprimento máximo de '8'")]
    [MinLength(8, ErrorMessage = "O campo DataGravacao deve ter um comprimento minimo de '8'")]
    public string? DataGravacao { get; private set; } /*Tamanho: 8, Posição: 11 a 18, Tipo: numérico, Formato: ddmmaaaa*/

    [MaxLength(4, ErrorMessage = "O campo HoraGravacao deve ter um comprimento máximo de '4'")]
    [MinLength(4, ErrorMessage = "O campo HoraGravacao deve ter um comprimento minimo de '4'")]
    public string? HoraGravacao { get; private set; } /*Tamanho: 4, Posição: 19 a 22, Tipo: numérico, Formato: hhmm*/

    [MaxLength(1, ErrorMessage = "O campo TpOperacao deve ter um comprimento máximo de '1'")]
    [MinLength(1, ErrorMessage = "O campo TpOperacao deve ter um comprimento minimo de '1'")]
    public string? TpOperacao { get; private set; } /*Tamanho: 1, Posição? 23 a 23, Tipo: alfanumérico, Dado: = I - Inclusão ou A - Alteracao ou E - Exclusão*/

    [MaxLength(12, ErrorMessage = "O campo Pis deve ter um comprimento máximo de '12'")]
    [MinLength(12, ErrorMessage = "O campo Pis deve ter um comprimento minimo de '12'")]
    public string? Pis { get; private set; } /*Tamanho: 12, Posição: 24 a 35, Tipo: numérico*/

    [MaxLength(52, ErrorMessage = "O campo Nome deve ter um comprimento máximo de '52'")]
    [MinLength(52, ErrorMessage = "O campo Nome deve ter um comprimento minimo de '52'")]
    public string? Nome { get; private set; } /*Tamanho: 52, Posição: 36 a 87, Tipo: alfanumérico*/

    public static List<EmpregadoMtAFD1510> EmpregadoMtRepAfdList { get; private set; } = new();
    public static List<string> ErrosValidacao { get; private set; } = new();
    public static string? Portaria { get; set; }
    #region Funções
    public static void GetEmpregadoMtRep(string linhaArquivo)
    {
        EmpregadoMtAFD1510 empregadoMt;
        int tamanhoLinha = linhaArquivo.Length;
        if (tamanhoLinha != 87)
        {
            ErrosValidacao.Add($"O registro '5 - Empregado MT' possui o tamanho de caracteres diferentes que o definido pela a Portaria n.º 1510, de 21 de agosto de 2009. Tamanho encontrado: {tamanhoLinha}\n");
            return;
        }
        else
        {
            Portaria = "Portaria n.º 1510, de 21 de agosto de 2009\n";

            empregadoMt = new()
            {
                Nsr = linhaArquivo[..9],
                TpRegistro = linhaArquivo.Substring(9, 1),
                DataGravacao = linhaArquivo.Substring(10, 8),
                HoraGravacao = linhaArquivo.Substring(18, 4),
                TpOperacao = linhaArquivo.Substring(22, 1),
                Pis = linhaArquivo.Substring(23, 12),
                Nome = linhaArquivo.Substring(35, 52)
            };
        }

        if (ValidacaoTamanhoDado.ValidarTamanho(empregadoMt) && ValidarTipoDados(empregadoMt))
        {
            if (empregadoMt.TpRegistro != "5")
            {
                ErrosValidacao.Add($"O campo 'TpRegistro' esta com o valor ({empregadoMt.TpRegistro}) inválido, deve ter o valor '5'.\n");
                return;
            }
            if (empregadoMt.TpOperacao != "I" && empregadoMt.TpOperacao != "A" && empregadoMt.TpOperacao != "E")
            {
                ErrosValidacao.Add($"O campo 'TpOperacao' esta com o valor ({empregadoMt.TpOperacao}) inválido, deve ter o valor 'I' ou 'A' ou 'E'.\n");
                return;
            }

            EmpregadoMtRepAfdList.Add(empregadoMt);
        }
        foreach (var item in ValidacaoTamanhoDado.ErrosValidacao)
        {
            ErrosValidacao.Add(item + "\n");
        }

    }
    private static bool ValidarTipoDados(EmpregadoMtAFD1510 empregadoMtRep)
    {

        var camposComErro = new List<string>();

        if (!int.TryParse(empregadoMtRep.Nsr, out _))
        {
            camposComErro.Add("Nsr");
        }

        if (!int.TryParse(empregadoMtRep.TpRegistro, out _))
        {
            camposComErro.Add("TpRegistro");
        }

        if (!double.TryParse(empregadoMtRep.DataGravacao, out _))
        {
            camposComErro.Add("DataGravacao");
        }

        if (!double.TryParse(empregadoMtRep.HoraGravacao, out _))
        {
            camposComErro.Add("HoraGravacao");
        }

        if (!double.TryParse(empregadoMtRep.Pis, out _))
        {
            camposComErro.Add("Pis");
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
