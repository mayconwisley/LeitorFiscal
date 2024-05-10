using LeitorFiscal.LeituraArquivo;
using LeitorFiscal.Model.Util;
using System.ComponentModel.DataAnnotations;

namespace LeitorFiscal.FGTSDigital;

public class RemuneracaoTrabalhador
{
    [MaxLength(1, ErrorMessage = "O campo 'Identificador' deve ser um tipo de cadeia de caracteres com um comprimento máximo de '1'")]
    [AllowedValues("2")]
    public string? Identificador { get; set; } = "2";
    [MaxLength(7, ErrorMessage = "O campo 'Competencia' deve ser um tipo de cadeia de caracteres com um comprimento de '7' posições")]
    public string? Competencia { get; set; }
    [MaxLength(3, ErrorMessage = "O campo 'Categoria' deve ser um tipo de cadeia de caracteres com um comprimento de '3' posições")]
    public string? Categoria { get; set; }
    public string? ValorPrincipal { get; set; }
    public string? Valor13Salario { get; set; }
    public string? IndAusenciaFGTS { get; set; }

    public static List<RemuneracaoTrabalhador> RemuneracaoTrabalhadors { get; private set; } = [];
    public static List<string> ErrosValidacao { get; set; } = [];

    public static void GetLinha(string linhaUm)
    {
        string[] itensLinha = linhaUm.Split(';');

        var linha = new RemuneracaoTrabalhador
        {
            Identificador = itensLinha[0],
            Competencia = itensLinha[1],
            Categoria = itensLinha[2],
            ValorPrincipal = itensLinha[3],
            Valor13Salario = itensLinha[4],
            IndAusenciaFGTS = itensLinha[5]
        };

        if (ValidacaoTamanhoDado.ValidarTamanho(linha, linhaUm) && ValidarTipoDados(linha, linhaUm))
        {
            if (linha.Identificador != "2")
            {
                ErrosValidacao.Add($"O campo 'Identificador' esta com o valor({linha.Identificador}) inválido, o valor deve ser 2.\n\tLinha({LerArquivoFGTSDigital.NumeroLinha}): {linhaUm}\n");

            }

            if (linha.IndAusenciaFGTS != "S" && linha.IndAusenciaFGTS == string.Empty)
            {
                ErrosValidacao.Add($"O campo 'Ind. Ausencia FGTS' esta com o valor({linha.IndAusenciaFGTS}) inválido, o valor deve ser 'S'\n\tLinha({LerArquivoFGTSDigital.NumeroLinha}): {linhaUm}\n");
            }
        }

        RemuneracaoTrabalhadors.Add(linha);

        foreach (var item in ValidacaoTamanhoDado.ErrosValidacao)
        {
            ErrosValidacao.Add(item + "\n");
        }
    }

    private static bool ValidarTipoDados(RemuneracaoTrabalhador remuneracaoTrabalhador, string linha)
    {
        var campoErro = new List<string>();

        if (!DateTime.TryParse(remuneracaoTrabalhador.Competencia, out _))
        {
            campoErro.Add("Competência");
        }

        if (!decimal.TryParse(remuneracaoTrabalhador.ValorPrincipal, out _) && !string.IsNullOrEmpty(remuneracaoTrabalhador.ValorPrincipal))
        {
            campoErro.Add("Valor Princial");
        }

        if (!decimal.TryParse(remuneracaoTrabalhador.Valor13Salario, out _) && !string.IsNullOrEmpty(remuneracaoTrabalhador.Valor13Salario))
        {
            campoErro.Add("Valor 13º Salario");
        }
        if (campoErro.Count == 0)
        {
            return true;
        }
        else
        {
            ErrosValidacao.Add($"Erro de tipo de dados nos campos: {string.Join(", ", campoErro)}\n\tLinha({LerArquivoFGTSDigital.NumeroLinha}: {linha})");
            return false;
        }
    }
}
