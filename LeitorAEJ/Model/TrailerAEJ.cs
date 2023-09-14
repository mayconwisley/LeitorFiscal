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
    public static string ErroValidacao { get; set; } = string.Empty;

    public static void GetTrailer(string linhaTrailer)
    {
        string[] itemLinha = linhaTrailer.Split("|");
        ErroValidacao = string.Empty;

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


        var validarResultados = new List<ValidationResult>();
        var validarContexto = new ValidationContext(trailer, null, null);

        if (Validator.TryValidateObject(trailer, validarContexto, validarResultados, true))
        {
            TrailerAEJList.Add(trailer);
        }
        else
        {
            foreach (ValidationResult validarResultado in validarResultados)
            {
                ErroValidacao += validarResultado.ErrorMessage + "\n";
            }
        }
    }
}
