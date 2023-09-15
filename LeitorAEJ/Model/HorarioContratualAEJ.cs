using LeitorAEJ.Model.Ultil;
using System.ComponentModel.DataAnnotations;

namespace LeitorAEJ.Model;

public class HorarioContratualAEJ
{
    [MaxLength(2, ErrorMessage = "O campo TipoReg deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '2'")]
    public string? TipoReg { get; set; }
    [MaxLength(30, ErrorMessage = "O campo CodHorContratual deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '30'")]
    [MinLength(1, ErrorMessage = "O campo CodHorContratual deve ser um tipo de cadeia de caracteres ou matriz com um comprimento minimo de '1'")]
    public string? CodHorContratual { get; set; }
    [MaxLength(12, ErrorMessage = "O campo DurJornada deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '12'")]
    [MinLength(1, ErrorMessage = "O campo DurJornada deve ser um tipo de cadeia de caracteres ou matriz com um comprimento minimo de '1'")]
    public string? DurJornada { get; set; }
    [MaxLength(4, ErrorMessage = "O campo HrEntrada01 deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '4'")]
    [MinLength(4, ErrorMessage = "O campo HrEntrada01 deve ser um tipo de cadeia de caracteres ou matriz com um comprimento minimo de '4'")]
    public string? HrEntrada01 { get; set; }
    [MaxLength(4, ErrorMessage = "O campo HrSaida01 deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '4'")]
    [MinLength(4, ErrorMessage = "O campo HrSaida01 deve ser um tipo de cadeia de caracteres ou matriz com um comprimento minimo de '4'")]
    public string? HrSaida01 { get; set; }
    [MaxLength(4, ErrorMessage = "O campo HrEntrada02 deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '4'")]
    public string? HrEntrada02 { get; set; }
    [MaxLength(4, ErrorMessage = "O campo HrSaida02 deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '4'")]
    public string? HrSaida02 { get; set; }


    [MaxLength(4, ErrorMessage = "O campo HrEntrada03 deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '4'")]
    public string? HrEntrada03 { get; set; }
    [MaxLength(4, ErrorMessage = "O campo HrSaida03 deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '4'")]
    public string? HrSaida03 { get; set; }
    [MaxLength(4, ErrorMessage = "O campo HrEntrada04 deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '4'")]
    public string? HrEntrada04 { get; set; }
    [MaxLength(4, ErrorMessage = "O campo HrSaida04 deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '4'")]
    public string? HrSaida04 { get; set; }
    [MaxLength(4, ErrorMessage = "O campo HrEntrada05 deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '4'")]
    public string? HrEntrada05 { get; set; }
    [MaxLength(4, ErrorMessage = "O campo HrSaida05 deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '4'")]
    public string? HrSaida05 { get; set; }
    [MaxLength(4, ErrorMessage = "O campo HrEntrada06 deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '4'")]
    public string? HrEntrada06 { get; set; }
    [MaxLength(4, ErrorMessage = "O campo HrSaida06 deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '4'")]
    public string? HrSaida06 { get; set; }


    public static List<HorarioContratualAEJ> HorarioContratualAEJList { get; private set; } = new();
    public static List<string> ErrosValidacao { get; set; } = new();

    public static void GetHorarioContratual(string linhaHoraContratual)
    {
        string[] itemLinha = linhaHoraContratual.Split("|");
        ErrosValidacao.Clear();

        var horarioContratual = new HorarioContratualAEJ
        {
            TipoReg = itemLinha[0].Trim(),
            CodHorContratual = itemLinha[1].Trim(),
            DurJornada = itemLinha[2].Trim(),
            HrEntrada01 = itemLinha[3].Trim(),
            HrSaida01 = itemLinha[4].Trim(),
            HrEntrada02 = itemLinha[5].Trim(),
            HrSaida02 = itemLinha[6].Trim()
        };


        if (ValidacaoTamanhoDado.ValidarTamanho(horarioContratual) && ValidarTipoDados(horarioContratual))
        {
            HorarioContratualAEJList.Add(horarioContratual);
        }
        foreach (var item in ValidacaoTamanhoDado.ErrosValidacao)
        {
            ErrosValidacao.Add(item);
        }

    }

    private static bool ValidarTipoDados(HorarioContratualAEJ horarioContratualAEJ)
    {

        var camposComErro = new List<string>();

        if (!int.TryParse(horarioContratualAEJ.TipoReg, out _))
        {
            camposComErro.Add("TipoReg");
        }

        if (!int.TryParse(horarioContratualAEJ.DurJornada, out _))
        {
            camposComErro.Add("DurJornada");
        }

        if (!TimeSpan.TryParse(horarioContratualAEJ.HrEntrada01, out _))
        {
            camposComErro.Add("HrEntrada01");
        }

        if (!TimeSpan.TryParse(horarioContratualAEJ.HrSaida01, out _))
        {
            camposComErro.Add("HrSaida01");
        }

        if (!TimeSpan.TryParse(horarioContratualAEJ.HrEntrada02, out _))
        {
            camposComErro.Add("HrEntrada02");
        }

        if (!TimeSpan.TryParse(horarioContratualAEJ.HrSaida02, out _))
        {
            camposComErro.Add("HrSaida02");
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
