using LeitorFiscal.LeituraArquivo;
using LeitorFiscal.Model.Util;
using System.ComponentModel.DataAnnotations;

namespace LeitorFiscal.AEJ;

public class VinculoeSocialAEJ
{
    [MaxLength(2, ErrorMessage = "O campo TipoReg deve ser um tipo de cadeia de caracteres com um comprimento máximo de '2'")]
    public string? TipoReg { get; set; }
    [MaxLength(9, ErrorMessage = "O campo IdtVinculoAej deve ser um tipo de cadeia de caracteres com um comprimento máximo de '9'")]
    [MinLength(1, ErrorMessage = "O campo IdtVinculoAej deve ser um tipo de cadeia de caracteres com um comprimento minimo de '1'")]
    public string? IdtVinculoAej { get; set; }
    [MaxLength(30, ErrorMessage = "O campo MatEsocial deve ser um tipo de cadeia de caracteres com um comprimento máximo de '30'")]
    [MinLength(1, ErrorMessage = "O campo MatEsocial deve ser um tipo de cadeia de caracteres com um comprimento minimo de '1'")]
    public string? MatEsocial { get; set; }

    public static List<VinculoeSocialAEJ> VinculoeSocialAEJList { get; private set; } = new();
    public static List<string> ErrosValidacao { get; set; } = new();

    public static void GetVinculoeSocial(string linhaVinculoeSocial)
    {
        string[] itemLinha = linhaVinculoeSocial.Split("|");
        if (itemLinha.Length < 3 || itemLinha.Length > 4)
        {
            throw new Exception($"Layout da sessão 06 esta fora do padrão definido pela a portaria\n{linhaVinculoeSocial}");
        }
        var vinculoeSocial = new VinculoeSocialAEJ
        {
            TipoReg = itemLinha[0].Trim(),
            IdtVinculoAej = itemLinha[1].Trim(),
            MatEsocial = itemLinha[2].Trim()
        };


        if (ValidacaoTamanhoDado.ValidarTamanho(vinculoeSocial,linhaVinculoeSocial) && ValidarTipoDados(vinculoeSocial, linhaVinculoeSocial))
        {
            VinculoeSocialAEJList.Add(vinculoeSocial);
        }
        foreach (var item in ValidacaoTamanhoDado.ErrosValidacao)
        {
            ErrosValidacao.Add(item);
        }

    }

    private static bool ValidarTipoDados(VinculoeSocialAEJ vinculoeSocialAEJ, string linha)
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
            ErrosValidacao.Add($"Erro de tipo de dados nos campos: {string.Join(", ", camposComErro)}\n\tLinha ({LerArquivoAEJ.NumeroLinha}):{linha}\n");
            return false;
        }
    }
}
