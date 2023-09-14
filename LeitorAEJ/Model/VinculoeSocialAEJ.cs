using System.ComponentModel.DataAnnotations;

namespace LeitorAEJ.Model;

public class VinculoeSocialAEJ
{
    [MaxLength(2)]
    public string? TipoReg { get; set; }
    [MaxLength(9)]
    public string? IdtVinculoAej { get; set; }
    [MaxLength(30)]
    public string? MatEsocial { get; set; }

    public static List<VinculoeSocialAEJ> VinculoeSocialAEJList { get; private set; } = new();
    public static string ErroValidacao { get; set; } = string.Empty;

    public static void GetVinculoeSocial(string linhaVinculoeSocial)
    {

        string[] itemLinha = linhaVinculoeSocial.Split("|");
        ErroValidacao = string.Empty;

        var vinculoeSocial = new VinculoeSocialAEJ
        {
            TipoReg = itemLinha[0],
            IdtVinculoAej = itemLinha[1],
            MatEsocial = itemLinha[2]
        };

        var validarResultados = new List<ValidationResult>();
        var validarContexto = new ValidationContext(vinculoeSocial, null, null);

        if (Validator.TryValidateObject(vinculoeSocial, validarContexto, validarResultados, true))
        {
            VinculoeSocialAEJList.Add(vinculoeSocial);
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
