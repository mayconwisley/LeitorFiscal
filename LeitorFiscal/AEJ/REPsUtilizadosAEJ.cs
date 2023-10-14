using LeitorFiscal.Model.Util;
using System.ComponentModel.DataAnnotations;

namespace LeitorFiscal.AEJ;

public class REPsUtilizadosAEJ
{
    [MaxLength(2, ErrorMessage = "O campo TipoReg deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '2'")]
    public string? TipoReg { get; private set; }
    [MaxLength(9, ErrorMessage = "O campo IdRepAej deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '9'")]
    [MinLength(1, ErrorMessage = "O campo IdRepAej deve ser um tipo de cadeia de caracteres ou matriz com um comprimento minimo de '1'")]
    public string? IdRepAej { get; private set; }
    [MaxLength(1, ErrorMessage = "O campo TpRep deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '1'")]
    [MinLength(1, ErrorMessage = "O campo TpRep deve ser um tipo de cadeia de caracteres ou matriz com um comprimento minimo de '1'")]
    public string? TpRep { get; private set; }
    [MaxLength(17, ErrorMessage = "O campo NrRep deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '17'")]
    [MinLength(17, ErrorMessage = "O campo NrRep deve ser um tipo de cadeia de caracteres ou matriz com um comprimento minimo de '17'")]
    public string? NrRep { get; private set; }


    public static List<REPsUtilizadosAEJ> REPsUtilizadosAEJList { get; private set; } = new();
    public static List<string> ErrosValidacao { get; set; } = new();

    public static void GetREPsUtilizados(string linhaRep)
    {
        string[] itemLinha = linhaRep.Split("|");

        var repsUtilizado = new REPsUtilizadosAEJ
        {
            TipoReg = itemLinha[0].Trim(),
            IdRepAej = itemLinha[1].Trim(),
            TpRep = itemLinha[2].Trim(),
            NrRep = itemLinha[3].Trim(),
        };

        if (ValidacaoTamanhoDado.ValidarTamanho(repsUtilizado) && ValidarTipoDados(repsUtilizado))
        {
            if (repsUtilizado.TpRep == "1" || repsUtilizado.TpRep == "2" || repsUtilizado.TpRep == "3")
            {
                REPsUtilizadosAEJList.Add(repsUtilizado);
            }
            else
            {
                ErrosValidacao.Add("Tipo de REP inválido\n");

            }

        }
        foreach (var item in ValidacaoTamanhoDado.ErrosValidacao)
        {
            ErrosValidacao.Add(item);
        }
    }
    private static bool ValidarTipoDados(REPsUtilizadosAEJ repsUtilizado)
    {

        var camposComErro = new List<string>();

        if (!int.TryParse(repsUtilizado.TipoReg, out _))
        {
            camposComErro.Add("TipoReg");
        }

        if (!int.TryParse(repsUtilizado.IdRepAej, out _))
        {
            camposComErro.Add("IdRepAej");
        }

        if (!int.TryParse(repsUtilizado.TpRep, out _))
        {
            camposComErro.Add("TpRep");
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
}
