using LeitorAEJ.Model.Ultil;
using System.ComponentModel.DataAnnotations;

namespace LeitorAEJ.Model;

public class VinculoeSocialAEJ
{
    [MaxLength(2, ErrorMessage = "O campo TipoReg deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '2'")]
    public string? TipoReg { get; set; }
    [MaxLength(9, ErrorMessage = "O campo IdtVinculoAej deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '9'")]
    public string? IdtVinculoAej { get; set; }
    [MaxLength(30, ErrorMessage = "O campo MatEsocial deve ser um tipo de cadeia de caracteres ou matriz com um comprimento máximo de '30'")]
    public string? MatEsocial { get; set; }

    public static List<VinculoeSocialAEJ> VinculoeSocialAEJList { get; private set; } = new();
    public static List<string> ErrosValidacao { get; set; } = new();

    public static void GetVinculoeSocial(string linhaVinculoeSocial, bool validarPortaria)
    {

        string[] itemLinha = linhaVinculoeSocial.Split("|");
        ErrosValidacao.Clear();

        var vinculoeSocial = new VinculoeSocialAEJ
        {
            TipoReg = itemLinha[0].Trim(),
            IdtVinculoAej = itemLinha[1].Trim(),
            MatEsocial = itemLinha[2].Trim()
        };

        if (validarPortaria)
        {
            if (ValidacaoTamanhoDado.ValidarTamanho(vinculoeSocial) && ValidarTipoDados(vinculoeSocial))
            {
                VinculoeSocialAEJList.Add(vinculoeSocial);
            }
            foreach (var item in ValidacaoTamanhoDado.ErrosValidacao)
            {
                ErrosValidacao.Add(item);
            }
        }
        else
        {
            VinculoeSocialAEJList.Add(vinculoeSocial);
        }
    }

    private static bool ValidarTipoDados(VinculoeSocialAEJ vinculoeSocialAEJ)
    {

        var camposComErro = new List<string>();

        if (!int.TryParse(vinculoeSocialAEJ.TipoReg, out _))
        {
            camposComErro.Add("TipoReg");
        }

        if (!double.TryParse(vinculoeSocialAEJ.IdtVinculoAej, out _))
        {
            camposComErro.Add("IdtVinculoAej");
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
