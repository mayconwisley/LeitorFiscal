using System.ComponentModel.DataAnnotations;

namespace LeitorAEJ.Model;

public class MarcacoesAEJ
{
    [MaxLength(2)]
    public string? TipoReg { get; private set; }
    [MaxLength(9)]
    public string? IdtVinculoAej { get; private set; }
    [MaxLength(24)]
    public string? DataHoraMarc { get; private set; }
    [MaxLength(9)]
    public string? IdRepAej { get; private set; }
    [MaxLength(1)]
    public string? TpMarc { get; private set; }
    [MaxLength(3)]
    public string? SeqEntSaida { get; private set; }
    [MaxLength(12)] //validar portaria 671 o tamanho é 1
    public string? FonteMarc { get; private set; }
    [MaxLength(30)]
    public string? CodHorContratual { get; private set; }
    [MaxLength(150)]
    public string? Motivo { get; private set; }

    public static List<MarcacoesAEJ> MarcacoesAEJList { get; private set; } = new();
    public static string ErroValidacao { get; set; } = string.Empty;

    public static void GetMarcacoes(string linhaMarcacoes)
    {
        string[] itemLinha = linhaMarcacoes.Split("|");
        ErroValidacao = string.Empty;

        var marcacoes = new MarcacoesAEJ
        {
            TipoReg = itemLinha[0],
            IdtVinculoAej = itemLinha[1],
            DataHoraMarc = itemLinha[2],
            IdRepAej = itemLinha[3],
            TpMarc = itemLinha[4],
            SeqEntSaida = itemLinha[5],
            FonteMarc = itemLinha[6],
            CodHorContratual = itemLinha[7],
            Motivo = itemLinha[8]
        };
        var validarResultados = new List<ValidationResult>();
        var validarContexto = new ValidationContext(marcacoes, null, null);

        if (Validator.TryValidateObject(marcacoes, validarContexto, validarResultados, true))
        {
            MarcacoesAEJList.Add(marcacoes);
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
