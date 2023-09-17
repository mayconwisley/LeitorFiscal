using LeitorAEJ.Model.Util;
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

        var horarioContratual = new HorarioContratualAEJ
        {
            TipoReg = itemLinha[0].Trim(),
            CodHorContratual = itemLinha[1].Trim(),
            DurJornada = itemLinha[2].Trim(),
            HrEntrada01 = itemLinha[3].Trim(),
            HrSaida01 = itemLinha[4].Trim(),

        };

        if (itemLinha.Length == 7)
        {
            horarioContratual.HrEntrada02 = itemLinha[5].Trim();
            horarioContratual.HrSaida02 = itemLinha[6].Trim();
        }

        if (itemLinha.Length == 9)
        {
            horarioContratual.HrEntrada03 = itemLinha[7].Trim();
            horarioContratual.HrSaida03 = itemLinha[8].Trim();
        }

        if (itemLinha.Length == 11)
        {
            horarioContratual.HrEntrada04 = itemLinha[9].Trim();
            horarioContratual.HrSaida04 = itemLinha[10].Trim();
        }

        if (itemLinha.Length == 13)
        {
            horarioContratual.HrEntrada05 = itemLinha[11].Trim();
            horarioContratual.HrSaida05 = itemLinha[12].Trim();
        }

        if (itemLinha.Length == 15)
        {
            horarioContratual.HrEntrada06 = itemLinha[13].Trim();
            horarioContratual.HrSaida06 = itemLinha[14].Trim();
        }

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

        if (!TimeSpan.TryParse(horarioContratualAEJ.HrEntrada02, out _) && !string.IsNullOrEmpty(horarioContratualAEJ.HrEntrada02))
        {
            camposComErro.Add("HrEntrada02");
        }

        if (!TimeSpan.TryParse(horarioContratualAEJ.HrSaida02, out _) && !string.IsNullOrEmpty(horarioContratualAEJ.HrSaida02))
        {
            camposComErro.Add("HrSaida02");
        }
        if (!TimeSpan.TryParse(horarioContratualAEJ.HrEntrada03, out _) && !string.IsNullOrEmpty(horarioContratualAEJ.HrEntrada03))
        {
            camposComErro.Add("HrEntrada03");
        }

        if (!TimeSpan.TryParse(horarioContratualAEJ.HrSaida03, out _) && !string.IsNullOrEmpty(horarioContratualAEJ.HrSaida03))
        {
            camposComErro.Add("HrSaida03");
        }
        if (!TimeSpan.TryParse(horarioContratualAEJ.HrEntrada04, out _) && !string.IsNullOrEmpty(horarioContratualAEJ.HrEntrada04))
        {
            camposComErro.Add("HrEntrada04");
        }

        if (!TimeSpan.TryParse(horarioContratualAEJ.HrSaida04, out _) && !string.IsNullOrEmpty(horarioContratualAEJ.HrSaida04))
        {
            camposComErro.Add("HrSaida04");
        }
        if (!TimeSpan.TryParse(horarioContratualAEJ.HrEntrada05, out _) && !string.IsNullOrEmpty(horarioContratualAEJ.HrEntrada05))
        {
            camposComErro.Add("HrEntrada05");
        }

        if (!TimeSpan.TryParse(horarioContratualAEJ.HrSaida05, out _) && !string.IsNullOrEmpty(horarioContratualAEJ.HrSaida05))
        {
            camposComErro.Add("HrSaida05");
        }
        if (!TimeSpan.TryParse(horarioContratualAEJ.HrEntrada06, out _) && !string.IsNullOrEmpty(horarioContratualAEJ.HrEntrada06))
        {
            camposComErro.Add("HrEntrada06");
        }

        if (!TimeSpan.TryParse(horarioContratualAEJ.HrSaida06, out _) && !string.IsNullOrEmpty(horarioContratualAEJ.HrSaida06))
        {
            camposComErro.Add("HrSaida06");
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
