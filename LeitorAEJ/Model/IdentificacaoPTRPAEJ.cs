using System.ComponentModel.DataAnnotations;

namespace LeitorAEJ.Model;

public class IdentificacaoPTRPAEJ
{
    [MaxLength(2)]
    public string? TipoReg { get; private set; }
    [MaxLength(150)]
    public string? NomeProg { get; private set; }
    [MaxLength(8)]
    public string? VersaoProg { get; private set; }
    [MaxLength(1)]
    public string? TpIdtDesenv { get; private set; }
    [MaxLength(14)]
    public string? IdtDesenv { get; private set; }
    [MaxLength(150)]
    public string? RazaoNomeDesenv { get; private set; }
    [MaxLength(50)]
    public string? EmailDesenv { get; private set; }

    public static List<IdentificacaoPTRPAEJ> IdentificacaoPTRPAEJList { get; private set; } = new();
    public static string ErroValidacao { get; set; } = string.Empty;

    public static void GetIdentificacaoPTRP(string linhaIdentificacaoPTRPAEJ)
    {
        string[] itemLinha = linhaIdentificacaoPTRPAEJ.Split("|");
        ErroValidacao = string.Empty;

        var identificacaoPTRP = new IdentificacaoPTRPAEJ
        {
            TipoReg = itemLinha[0],
            NomeProg = itemLinha[1],
            VersaoProg = itemLinha[2],
            TpIdtDesenv = itemLinha[3],
            IdtDesenv = itemLinha[4],
            RazaoNomeDesenv = itemLinha[5],
            EmailDesenv = itemLinha[6]
        };

        var validarResultados = new List<ValidationResult>();
        var validarContexto = new ValidationContext(identificacaoPTRP, null, null);

        if (Validator.TryValidateObject(identificacaoPTRP, validarContexto, validarResultados, true))
        {
            IdentificacaoPTRPAEJList.Add(identificacaoPTRP);
        }
        else
        {
            foreach (ValidationResult validarResultado in validarResultados)
            {
                ErroValidacao += validarResultado.ErrorMessage +"\n";
            }
        }
    }
}
