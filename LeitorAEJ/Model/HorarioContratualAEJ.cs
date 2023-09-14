using LeitorAEJ.Model.Ultil;
using System.ComponentModel.DataAnnotations;

namespace LeitorAEJ.Model;

public class HorarioContratualAEJ
{
    [MaxLength(2, ErrorMessage = "O campo TipoReg deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '2'")]
    public string? TipoReg { get; set; }
    [MaxLength(30, ErrorMessage = "O campo CodHorContratual deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '30'")]
    public string? CodHorContratual { get; set; }
    [MaxLength(12, ErrorMessage = "O campo DurJornada deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '12'")]
    public string? DurJornada { get; set; }
    [MaxLength(4, ErrorMessage = "O campo HrEntrada01 deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '4'")]
    public string? HrEntrada01 { get; set; }
    [MaxLength(4, ErrorMessage = "O campo HrSaida01 deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '4'")]
    public string? HrSaida01 { get; set; }
    [MaxLength(4, ErrorMessage = "O campo HrEntrada02 deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '4'")]
    public string? HrEntrada02 { get; set; }
    [MaxLength(4, ErrorMessage = "O campo HrSaida02 deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '4'")]
    public string? HrSaida02 { get; set; }

    public static List<HorarioContratualAEJ> HorarioContratualAEJList { get; private set; } = new();
    public static List<string> ErrosValidacao { get; set; } = new();

    public static void GetHorarioContratual(string linhaHoraContratual, bool validarPortaria)
    {
        string[] itemLinha = linhaHoraContratual.Split("|");
        ErrosValidacao.Clear();

        var horarioContratual = new HorarioContratualAEJ
        {
            TipoReg = itemLinha[0],
            CodHorContratual = itemLinha[1],
            DurJornada = itemLinha[2],
            HrEntrada01 = itemLinha[3],
            HrSaida01 = itemLinha[4],
            HrEntrada02 = itemLinha[5],
            HrSaida02 = itemLinha[6]
        };

        if (validarPortaria)
        {
            if (ValidacaoTamanhoDado.ValidarTamanho(horarioContratual) && ValidarTipoDados(horarioContratual))
            {
                HorarioContratualAEJList.Add(horarioContratual);
            }
            foreach (var item in ValidacaoTamanhoDado.ErrosValidacao)
            {
                ErrosValidacao.Add(item);
            }
        }
        else
        {
            HorarioContratualAEJList.Add(horarioContratual);
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


        if (!int.TryParse(horarioContratualAEJ.HrEntrada01, out int horasInt))
        {
            int horas = horasInt / 100;
            int minutos = horasInt % 100;

            if (horas >= 0 && horas <= 23 && minutos >= 0 && minutos <= 59)
            {
                _ = DateTime.Today.AddHours(horas).AddMinutes(minutos);

            }
            else
            {
                camposComErro.Add("HrEntrada01");
            }
        }

        if (!int.TryParse(horarioContratualAEJ.HrSaida01, out int horasInt1))
        {
            int horas = horasInt1 / 100;
            int minutos = horasInt1 % 100;

            if (horas >= 0 && horas <= 23 && minutos >= 0 && minutos <= 59)
            {
                _ = DateTime.Today.AddHours(horas).AddMinutes(minutos);

            }
            else
            {
                camposComErro.Add("HrSaida01");
            }
        }

        if (!int.TryParse(horarioContratualAEJ.HrEntrada02, out int horasInt2))
        {
            int horas = horasInt2 / 100;
            int minutos = horasInt2 % 100;

            if (horas >= 0 && horas <= 23 && minutos >= 0 && minutos <= 59)
            {
                _ = DateTime.Today.AddHours(horas).AddMinutes(minutos);

            }
            else
            {
                camposComErro.Add("HrEntrHrEntrada02ada01");
            }
        }

        if (!int.TryParse(horarioContratualAEJ.HrSaida02, out int horasInt3))
        {
            int horas = horasInt3 / 100;
            int minutos = horasInt3 % 100;

            if (horas >= 0 && horas <= 23 && minutos >= 0 && minutos <= 59)
            {
                _ = DateTime.Today.AddHours(horas).AddMinutes(minutos);

            }
            else
            {
                camposComErro.Add("HrSaida02");
            }
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
