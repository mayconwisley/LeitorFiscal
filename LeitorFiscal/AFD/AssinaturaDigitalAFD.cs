using LeitorFiscal.Model.Util;
using System.ComponentModel.DataAnnotations;

namespace LeitorFiscal.AFD;

public class AssinaturaDigitalAFD
{
    [MaxLength(100, ErrorMessage = "O campo AssinaturaDigital deve ter um comprimento máximo de '100")]
    [MinLength(100, ErrorMessage = "O campo AssinaturaDigital deve ter um comprimento minimo de '100'")]
    public string? AssinaturaDigital { get; private set; }

    public static List<AssinaturaDigitalAFD> AssinaturaDigitalAfdList { get; private set; } = new();
    public static List<string> ErrosValidacao { get; private set; } = new();
    public static string? Portaria { get; set; }

    #region Funções
    public static void GetAssinaturaDigital(string linhaArquivo)
    {
        AssinaturaDigitalAFD assinaturaDigital;

        int tamanhoLinha = linhaArquivo.Length;

        if (tamanhoLinha != 100)
        {
            ErrosValidacao.Add($"A 'Assinatura Digital' possui o tamanho de caracteres diferentes que o definido pela as Portarias 595 e 671. Tamanho encontrado: {tamanhoLinha}\n");
            return;
        }
        else
        {
            Portaria = "Portarias n.º 595 e 671\n";

            assinaturaDigital = new()
            {
                AssinaturaDigital = linhaArquivo[..100],
            };
        }

        if (ValidacaoTamanhoDado.ValidarTamanho(assinaturaDigital))
        {
            AssinaturaDigitalAfdList.Add(assinaturaDigital);
        }

        foreach (var item in ValidacaoTamanhoDado.ErrosValidacao)
        {
            ErrosValidacao.Add(item + "\n");
        }
    }
    #endregion
}
