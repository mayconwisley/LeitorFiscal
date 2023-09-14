using LeitorAEJ.Model.Ultil;
using System.ComponentModel.DataAnnotations;

namespace LeitorAEJ.Model;

public class AusenciaBancoHorasAEJ
{
    [MaxLength(2, ErrorMessage = "O campo TipoReg deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '1'")]
    public string? TipoReg { get; private set; }
    [MaxLength(9, ErrorMessage = "O campo IdtVinculoAej deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '9'")]
    public string? IdtVinculoAej { get; private set; }
    [MaxLength(1, ErrorMessage = "O campo TipoAusenOuComp deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '1'")]
    public string? TipoAusenOuComp { get; private set; }
    [MaxLength(10, ErrorMessage = "O campo Data deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '10'")]
    public string? Data { get; private set; }
    [MaxLength(12, ErrorMessage = "O campo QtMinutos deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '12'")]
    public string? QtMinutos { get; private set; }
    [MaxLength(1, ErrorMessage = "O campo TipoMovBH deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '1'")]
    public string? TipoMovBH { get; private set; }

    public static List<AusenciaBancoHorasAEJ> AusenciaBancoHorasAEJList { get; private set; } = new();
    public static List<string> ErrosValidacao { get; set; } = new();

    public static void GetAusenciaBancoHoras(string linhaAusenciaBancoHoras, bool validarPortaria)
    {
        string[] itemLinha = linhaAusenciaBancoHoras.Split("|");
        ErrosValidacao.Clear();

        var ausenciaBancoHoras = new AusenciaBancoHorasAEJ
        {
            TipoReg = itemLinha[0].Trim(),
            IdtVinculoAej = itemLinha[1].Trim(),
            TipoAusenOuComp = itemLinha[2].Trim(),
            Data = itemLinha[3].Trim(),
            QtMinutos = itemLinha[4].Trim(),
            TipoMovBH = itemLinha[5].Trim()
        };

        if (validarPortaria)
        {
            if (ValidacaoTamanhoDado.ValidarTamanho(ausenciaBancoHoras) && ValidarTipoDados(ausenciaBancoHoras))
            {
                AusenciaBancoHorasAEJList.Add(ausenciaBancoHoras);
            }
            foreach (var item in ValidacaoTamanhoDado.ErrosValidacao)
            {
                ErrosValidacao.Add(item);
            }
        }
        else
        {
            AusenciaBancoHorasAEJList.Add(ausenciaBancoHoras);
        }
    }
    private static bool ValidarTipoDados(AusenciaBancoHorasAEJ ausenciaBancoHorasAEJ)
    {

        var camposComErro = new List<string>();

        if (!int.TryParse(ausenciaBancoHorasAEJ.TipoReg, out _))
        {
            camposComErro.Add("TipoReg");
        }

        if (!double.TryParse(ausenciaBancoHorasAEJ.IdtVinculoAej, out _))
        {
            camposComErro.Add("IdtVinculoAej");
        }

        if (!int.TryParse(ausenciaBancoHorasAEJ.TipoAusenOuComp, out _))
        {
            camposComErro.Add("TipoAusenOuComp");
        }

        if (!int.TryParse(ausenciaBancoHorasAEJ.QtMinutos, out _))
        {
            camposComErro.Add("QtMinutos");
        }

        if (!int.TryParse(ausenciaBancoHorasAEJ.TipoMovBH, out _))
        {
            camposComErro.Add("TipoMovBH");
        }

        if (!DateTime.TryParse(ausenciaBancoHorasAEJ.Data, out _))
        {
            camposComErro.Add("Data");
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
