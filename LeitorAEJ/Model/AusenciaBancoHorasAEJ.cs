using LeitorAEJ.Model.Ultil;
using System.ComponentModel.DataAnnotations;

namespace LeitorAEJ.Model;

public class AusenciaBancoHorasAEJ
{
    [MaxLength(2, ErrorMessage = "O campo TipoReg deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '1'")]
    public string? TipoReg { get; private set; }
    [MaxLength(9, ErrorMessage = "O campo IdtVinculoAej deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '9'")]
    [MinLength(1, ErrorMessage = "O campo IdtVinculoAej deve ser um tipo de cadeia de caracteres ou matriz com um comprimento minimo de '1'")]
    public string? IdtVinculoAej { get; private set; }
    [MaxLength(1, ErrorMessage = "O campo TipoAusenOuComp deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '1'")]
    public string? TipoAusenOuComp { get; private set; }
    [MaxLength(10, ErrorMessage = "O campo Data deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '10'")]
    [MinLength(10, ErrorMessage = "O campo Data deve ser um tipo de cadeia de caracteres ou matriz com um comprimento minimo de '10'")]
    public string? Data { get; private set; }
    [MaxLength(12, ErrorMessage = "O campo QtMinutos deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '12'")]
    public string? QtMinutos { get; private set; }
    [MaxLength(1, ErrorMessage = "O campo TipoMovBH deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '1'")]
    public string? TipoMovBH { get; private set; }

    public static List<AusenciaBancoHorasAEJ> AusenciaBancoHorasAEJList { get; private set; } = new();
    public static List<string> ErrosValidacao { get; set; } = new();

    public static void GetAusenciaBancoHoras(string linhaAusenciaBancoHoras)
    {
        string[] itemLinha = linhaAusenciaBancoHoras.Split("|");

        var ausenciaBancoHoras = new AusenciaBancoHorasAEJ
        {
            TipoReg = itemLinha[0].Trim(),
            IdtVinculoAej = itemLinha[1].Trim(),
            TipoAusenOuComp = itemLinha[2].Trim(),
            Data = itemLinha[3].Trim(),
            QtMinutos = itemLinha[4].Trim(),
            TipoMovBH = itemLinha[5].Trim()
        };

        if (ValidacaoTamanhoDado.ValidarTamanho(ausenciaBancoHoras) && ValidarTipoDados(ausenciaBancoHoras))
        {
            if (ausenciaBancoHoras.TipoAusenOuComp != "1" & ausenciaBancoHoras.TipoAusenOuComp != "2" &
                ausenciaBancoHoras.TipoAusenOuComp != "3" & ausenciaBancoHoras.TipoAusenOuComp != "4")
            {
                ErrosValidacao.Add($"Data {ausenciaBancoHoras.Data} esta com o campo 'TipoAusenOuComp' com o valor ({ausenciaBancoHoras.TipoAusenOuComp}) inválido, deve ter os valores '1' ou '2' ou '3' ou '4'.\n");
                return;
            }

            if (ausenciaBancoHoras.TipoMovBH != "0" & ausenciaBancoHoras.TipoMovBH != "1" & ausenciaBancoHoras.TipoMovBH != "3")
            {
                ErrosValidacao.Add($"Data {ausenciaBancoHoras.Data} esta com o campo 'TipoMovBH' com o valor ({ausenciaBancoHoras.TipoMovBH}) inválido, deve ter os valores '0' ou '1' ou '2'.\n");
                return;
            }

            AusenciaBancoHorasAEJList.Add(ausenciaBancoHoras);
        }
        foreach (var item in ValidacaoTamanhoDado.ErrosValidacao)
        {
            ErrosValidacao.Add(item);
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
