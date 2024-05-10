using LeitorFiscal.LeituraArquivo;
using LeitorFiscal.Model.Util;
using System.ComponentModel.DataAnnotations;

namespace LeitorFiscal.FGTSDigital;

public class IdentificacaoTrabalhador
{
    [MaxLength(1, ErrorMessage = "O campo 'Identificador' deve ser um tipo de cadeia de caracteres com um comprimento máximo de '1'")]
    [AllowedValues("1")]
    public string? Identificador { get; set; } = "1";
    [MaxLength(11, ErrorMessage = "O campo 'CNPJ_CPF' deve ser um tipo de cadeia de caracteres com um comprimento máximo de '11'")]
    [MinLength(8, ErrorMessage = "O campo 'CNPJ_CPF' deve ser um tipo de cadeia de caracteres com um comprimento minimo de '8'")]
    public string? CNPJ_CPF { get; set; }
    [MaxLength(11, ErrorMessage = "O campo 'CPF' deve ser um tipo de cadeia de caracteres com um comprimento máximo de '11'")]
    [MinLength(11, ErrorMessage = "O campo 'CPF' deve ser um tipo de cadeia de caracteres com um comprimento minimo de '11'")]
    public string? CPF { get; set; }
    [MaxLength(10, ErrorMessage = "O campo 'CPF' deve ser um tipo de cadeia de caracteres com um comprimento máximo de '11'")]
    [MinLength(10, ErrorMessage = "O campo 'CPF' deve ser um tipo de cadeia de caracteres com um comprimento minimo de '11'")]
    public string? DataAdmissao { get; set; }
    public string? Matricula { get; set; }
    public string? CategoriaTSVE { get; set; }

    public static List<IdentificacaoTrabalhador> IdentificacaoTrabalhadors { get; private set; } = [];
    public static List<string> ErrosValidacao { get; set; } = [];

    public static void GetLinha(string linhaUm)
    {
        string[] itensLinha = linhaUm.Split(';');

        var linha = new IdentificacaoTrabalhador
        {
            Identificador = itensLinha[0],
            CNPJ_CPF = itensLinha[1],
            CPF = itensLinha[2],
            DataAdmissao = itensLinha[3],
            Matricula = itensLinha[4],
            CategoriaTSVE = itensLinha[5]
        };

        if (ValidacaoTamanhoDado.ValidarTamanho(linha, linhaUm) && ValidarTipoDados(linha, linhaUm))
        {
            if (linha.Identificador != "1")
            {
                ErrosValidacao.Add($"O campo 'Identificador' esta com o valor({linha.Identificador}) inválido, o valor deve ser 2.\n\tLinha({LerArquivoFGTSDigital.NumeroLinha}): {linhaUm}\n");

            }

            if (linha.CNPJ_CPF.Count() != 8 && linha.CNPJ_CPF.Count() != 11)
            {
                ErrosValidacao.Add($"O campo 'CNPJ_CPF' esta com o valor({linha.CNPJ_CPF}) inválido, o valor deve conter 8 ou 11 digitos.\n\tLinha({LerArquivoFGTSDigital.NumeroLinha}): {linhaUm}\n");
            }

            bool eCpf = ValidacaoCPF.Validar(linha.CPF);

            if (!eCpf)
            {
                ErrosValidacao.Add($"O campo 'CPF' esta com o valor({linha.CNPJ_CPF}) inválido, o valor deve ser um CPF valido.\n\tLinha({LerArquivoFGTSDigital.NumeroLinha}): {linhaUm}\n");
            }
        }

        IdentificacaoTrabalhadors.Add(linha);

        foreach (var item in ValidacaoTamanhoDado.ErrosValidacao)
        {
            ErrosValidacao.Add(item + "\n");
        }
    }

    private static bool ValidarTipoDados(IdentificacaoTrabalhador identificacaoTrabalhador, string linha)
    {
        var campoErro = new List<string>();

        if (!DateTime.TryParse(identificacaoTrabalhador.DataAdmissao, out _))
        {
            campoErro.Add("Competência");
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
