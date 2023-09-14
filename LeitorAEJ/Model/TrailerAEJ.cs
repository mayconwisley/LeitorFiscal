using LeitorAEJ.Model.Ultil;
using System.ComponentModel.DataAnnotations;

namespace LeitorAEJ.Model;

public class TrailerAEJ
{
    [MaxLength(2)]
    public string? TipoReg { get; set; }
    [MaxLength(9)]
    public string? QtRegistrosTipo01 { get; set; }
    [MaxLength(9)]
    public string? QtRegistrosTipo02 { get; set; }
    [MaxLength(9)]
    public string? QtRegistrosTipo03 { get; set; }
    [MaxLength(9)]
    public string? QtRegistrosTipo04 { get; set; }
    [MaxLength(9)]
    public string? QtRegistrosTipo05 { get; set; }
    [MaxLength(9)]
    public string? QtRegistrosTipo06 { get; set; }
    [MaxLength(9)]
    public string? QtRegistrosTipo07 { get; set; }
    [MaxLength(9)]
    public string? QtRegistrosTipo08 { get; set; }

    public static List<TrailerAEJ> TrailerAEJList { get; private set; } = new();
    public static List<string> ErrosValidacao { get; set; } = new();

    public static void GetTrailer(string linhaTrailer, bool validarPortaria)
    {
        string[] itemLinha = linhaTrailer.Split("|");
        ErrosValidacao.Clear();

        var trailer = new TrailerAEJ
        {
            TipoReg = itemLinha[0],
            QtRegistrosTipo01 = itemLinha[1],
            QtRegistrosTipo02 = itemLinha[2],
            QtRegistrosTipo03 = itemLinha[3],
            QtRegistrosTipo04 = itemLinha[4],
            QtRegistrosTipo05 = itemLinha[5],
            QtRegistrosTipo06 = itemLinha[6],
            QtRegistrosTipo07 = itemLinha[7],
            QtRegistrosTipo08 = itemLinha[8],
        };


        if (validarPortaria)
        {
            if (ValidacaoTamanhoDado.ValidarTamanho(trailer) && ValidarTipoDados(trailer))
            {
                TrailerAEJList.Add(trailer);
            }
            foreach (var item in ValidacaoTamanhoDado.ErrosValidacao)
            {
                ErrosValidacao.Add(item);
            }
        }
        else
        {
            TrailerAEJList.Add(trailer);
        }
    }
    private static bool ValidarTipoDados(TrailerAEJ trailerAEJ)
    {

        var camposComErro = new List<string>();

        if (!int.TryParse(trailerAEJ.TipoReg, out _))
        {
            camposComErro.Add("TipoReg");
        }

        if (!double.TryParse(trailerAEJ.QtRegistrosTipo01, out _))
        {
            camposComErro.Add("QtRegistrosTipo01");
        }
        if (!double.TryParse(trailerAEJ.QtRegistrosTipo02, out _))
        {
            camposComErro.Add("QtRegistrosTipo02");
        }
        if (!double.TryParse(trailerAEJ.QtRegistrosTipo03, out _))
        {
            camposComErro.Add("QtRegistrosTipo03");
        }
        if (!double.TryParse(trailerAEJ.QtRegistrosTipo04, out _))
        {
            camposComErro.Add("QtRegistrosTipo04");
        }
        if (!double.TryParse(trailerAEJ.QtRegistrosTipo05, out _))
        {
            camposComErro.Add("QtRegistrosTipo05");
        }
        if (!double.TryParse(trailerAEJ.QtRegistrosTipo06, out _))
        {
            camposComErro.Add("QtRegistrosTipo06");
        }
        if (!double.TryParse(trailerAEJ.QtRegistrosTipo07, out _))
        {
            camposComErro.Add("QtRegistrosTipo07");
        }
        if (!double.TryParse(trailerAEJ.QtRegistrosTipo08, out _))
        {
            camposComErro.Add("QtRegistrosTipo08");
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
