using LeitorAEJ.Model.Enumeradores;
using System.ComponentModel.DataAnnotations;

namespace LeitorAEJ.Model;

public class AusenciaBancoHorasAEJ
{
    [MaxLength(2)]
    public string? TipoReg { get; private set; }
    [MaxLength(9)]
    public string? VinculosAEJ { get; private set; }
    [MaxLength(1)]
    public string? TipoAusenOuComp { get; private set; }
    [MaxLength(10)]
    public string? Data { get; private set; }
    [MaxLength(12)]
    public string? QtMinutos { get; private set; }
    [MaxLength(1)]
    public string? TipoMovBH { get; private set; }

    public static List<AusenciaBancoHorasAEJ> AusenciaBancoHorasAEJList { get; private set; } = new();
    public static string ErroValidacao { get; set; } = string.Empty;

    public static void GetAusenciaBancoHoras(string linhaAusenciaBancoHoras)
    {
        string[] itemLinha = linhaAusenciaBancoHoras.Split("|");
        ErroValidacao = string.Empty;

        var ausenciaBancoHoras = new AusenciaBancoHorasAEJ
        {
            TipoReg = itemLinha[0],
            VinculosAEJ = itemLinha[1],
            TipoAusenOuComp = itemLinha[2],
            Data = itemLinha[3],
            QtMinutos = itemLinha[4],
            TipoMovBH = itemLinha[5]
        };

        var validarResultados = new List<ValidationResult>();
        var validarContexto = new ValidationContext(ausenciaBancoHoras, null, null);

        if (Validator.TryValidateObject(ausenciaBancoHoras, validarContexto, validarResultados, true))
        {
            AusenciaBancoHorasAEJList.Add(ausenciaBancoHoras);
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
