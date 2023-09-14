using LeitorAEJ.Model.Ultil;
using System.ComponentModel.DataAnnotations;

namespace LeitorAEJ.Model;

public class REPsUtilizadosAEJ
{
    [MaxLength(2)]
    public string? TipoReg { get; private set; }
    [MaxLength(9)]
    public string? IdRepAej { get; private set; }
    [MaxLength(1)]
    public string? TpRep { get; private set; }
    [MaxLength(17)]
    public string? NrRep { get; private set; }


    public static List<REPsUtilizadosAEJ> REPsUtilizadosAEJList { get; private set; } = new();
    public static List<string> ErrosValidacao { get; set; } = new();

    public static void GetREPsUtilizados(string linhaRep, bool validarPortaria)
    {
        string[] itemLinha = linhaRep.Split("|");
        ErrosValidacao.Clear();

        var repsUtilizado = new REPsUtilizadosAEJ
        {
            TipoReg = itemLinha[0],
            IdRepAej = itemLinha[1],
            TpRep = itemLinha[2],
            NrRep = itemLinha[3],
        };

        if (validarPortaria)
        {
            if (ValidacaoTamanhoDado.ValidarTamanho(repsUtilizado) && ValidarTipoDados(repsUtilizado))
            {
                REPsUtilizadosAEJList.Add(repsUtilizado);
            }
        }
        else
        {
            REPsUtilizadosAEJList.Add(repsUtilizado);
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
            ErrosValidacao.Add($"Erro de tipo de dados nos campos: {string.Join(", ", camposComErro)}");
            return false;
        }
    }
}
