using LeitorFiscal.Model.Util;
using System.ComponentModel.DataAnnotations;

namespace LeitorFiscal.AEJ;

public class AssinaturaDigitalAEJ
{
    [MaxLength(100, ErrorMessage = "O campo AssinDigital deve ser um tipo de cadeia de caracteres com um comprimento máximo de '100'")]
    [MinLength(100, ErrorMessage = "O campo AssinDigital deve ser um tipo de cadeia de caracteres com um comprimento minimo de '100'")]
    public string? AssinDigital { get; private set; }

    public static List<AssinaturaDigitalAEJ> AssinaturaDigitalAEJList { get; private set; } = new();

    public static List<string> ErrosValidacao { get; set; } = new();

    public static void GetAssinaturaDigital(string linhaCabecalho)
    {
        string itemLinha = linhaCabecalho[..100];

        var cabecalho = new AssinaturaDigitalAEJ
        {
            AssinDigital = itemLinha,
        };


        if (ValidacaoTamanhoDado.ValidarTamanho(cabecalho))
        {
            AssinaturaDigitalAEJList.Add(cabecalho);
        }
        foreach (var item in ValidacaoTamanhoDado.ErrosValidacao)
        {
            ErrosValidacao.Add(item + "\n");
        }
    }
}
