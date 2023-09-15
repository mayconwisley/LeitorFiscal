using LeitorAEJ.Model.Ultil;
using System.ComponentModel.DataAnnotations;

namespace LeitorAEJ.Model;

public class VinculosAEJ
{
    [MaxLength(2, ErrorMessage = "O campo TipoReg deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '2'")]
    public string? TipoReg { get; private set; }
    [MaxLength(9, ErrorMessage = "O campo IdtVinculoAej deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '9'")]
    [MinLength(1, ErrorMessage = "O campo IdtVinculoAej deve ser um tipo de cadeia de caracteres ou matriz com um comprimento minimo de '1'")]
    public string? IdtVinculoAej { get; private set; }
    [MaxLength(11, ErrorMessage = "O campo CPF deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '11'")]
    [MinLength(11, ErrorMessage = "O campo CPF deve ser um tipo de cadeia de caracteres ou matriz com um comprimento minimo de '11'")]
    public string? CPF { get; private set; }
    [MaxLength(150, ErrorMessage = "O campo NomeEmp deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '150'")]
    [MinLength(1, ErrorMessage = "O campo NomeEmp deve ser um tipo de cadeia de caracteres ou matriz com um comprimento minimo de '150'")]
    public string? NomeEmp { get; private set; }

    public static List<VinculosAEJ> VinculosAEJList { get; private set; } = new();
    public static List<string> ErrosValidacao { get; set; } = new();

    public static void GetVinculos(string linhaVinculo)
    {
        string[] itemLinha = linhaVinculo.Split("|");
        ErrosValidacao.Clear();

        var vinculo = new VinculosAEJ
        {
            TipoReg = itemLinha[0].Trim(),
            IdtVinculoAej = itemLinha[1].Trim(),
            CPF = itemLinha[2].Trim(),
            NomeEmp = itemLinha[3].Trim()
        };
        if (ValidacaoTamanhoDado.ValidarTamanho(vinculo) && ValidarTipoDados(vinculo))
        {
            VinculosAEJList.Add(vinculo);
        }
        foreach (var item in ValidacaoTamanhoDado.ErrosValidacao)
        {
            ErrosValidacao.Add(item);
        }
    }
    private static bool ValidarTipoDados(VinculosAEJ vinculosAEJ)
    {

        var camposComErro = new List<string>();

        if (!int.TryParse(vinculosAEJ.TipoReg, out _))
        {
            camposComErro.Add("TipoReg");
        }

        if (!double.TryParse(vinculosAEJ.IdtVinculoAej, out _))
        {
            camposComErro.Add("IdtVinculoAej");
        }

        if (!double.TryParse(vinculosAEJ.CPF, out _))
        {
            camposComErro.Add("cpf");
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
