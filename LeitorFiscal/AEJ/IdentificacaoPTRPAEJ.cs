﻿using LeitorFiscal.LeituraArquivo;
using LeitorFiscal.Model.Util;
using System.ComponentModel.DataAnnotations;

namespace LeitorFiscal.AEJ;

public class IdentificacaoPTRPAEJ
{
    [MaxLength(2, ErrorMessage = "O campo TipoReg deve ser um tipo de cadeia de caracteres com um comprimento máximo de '2'")]
    public string? TipoReg { get; private set; }
    [MaxLength(150, ErrorMessage = "O campo NomeProg deve ser um tipo de cadeia de caracteres com um comprimento máximo de '150'")]
    [MinLength(1, ErrorMessage = "O campo NomeProg deve ser um tipo de cadeia de caracteres com um comprimento minimo de '1'")]
    public string? NomeProg { get; private set; }
    [MaxLength(8, ErrorMessage = "O campo VersaoProg deve ser um tipo de cadeia de caracteres com um comprimento máximo de '8'")]
    [MinLength(1, ErrorMessage = "O campo VersaoProg deve ser um tipo de cadeia de caracteres com um comprimento minimo de '1'")]
    public string? VersaoProg { get; private set; }
    [MaxLength(1, ErrorMessage = "O campo TpIdtDesenv deve ser um tipo de cadeia de caracteres com um comprimento máximo de '1'")]
    public string? TpIdtDesenv { get; private set; }
    [MaxLength(14, ErrorMessage = "O campo IdtDesenv deve ser um tipo de cadeia de caracteres com um comprimento máximo de '14'")]
    [MinLength(11, ErrorMessage = "O campo IdtDesenv deve ser um tipo de cadeia de caracteres com um comprimento minimo de '11'")]
    public string? IdtDesenv { get; private set; }
    [MaxLength(150, ErrorMessage = "O campo RazaoNomeDesenv deve ser um tipo de cadeia de caracteres com um comprimento máximo de '150'")]
    [MinLength(1, ErrorMessage = "O campo RazaoNomeDesenv deve ser um tipo de cadeia de caracteres com um comprimento minimo de '1'")]
    public string? RazaoNomeDesenv { get; private set; }
    [MaxLength(50, ErrorMessage = "O campo EmailDesenv deve ser um tipo de cadeia de caracteres com um comprimento máximo de '50'")]
    [MinLength(1, ErrorMessage = "O campo EmailDesenv deve ser um tipo de cadeia de caracteres com um comprimento minimo de '1'")]
    public string? EmailDesenv { get; private set; }

    public static List<IdentificacaoPTRPAEJ> IdentificacaoPTRPAEJList { get; private set; } = new();
    public static List<string> ErrosValidacao { get; set; } = new();

    public static void GetIdentificacaoPTRP(string linhaIdentificacaoPTRPAEJ)
    {
        string[] itemLinha = linhaIdentificacaoPTRPAEJ.Split("|");
        if (itemLinha.Length < 7 || itemLinha.Length > 8)
        {
            throw new Exception($"Layout da sessão 08 esta fora do padrão definido pela a portaria\n{linhaIdentificacaoPTRPAEJ}");
        }
        var identificacaoPTRP = new IdentificacaoPTRPAEJ
        {
            TipoReg = itemLinha[0].Trim(),
            NomeProg = itemLinha[1].Trim(),
            VersaoProg = itemLinha[2].Trim(),
            TpIdtDesenv = itemLinha[3].Trim(),
            IdtDesenv = itemLinha[4].Trim(),
            RazaoNomeDesenv = itemLinha[5].Trim(),
            EmailDesenv = itemLinha[6].Trim()
        };

        if (ValidacaoTamanhoDado.ValidarTamanho(identificacaoPTRP, linhaIdentificacaoPTRPAEJ) && ValidarTipoDados(identificacaoPTRP, linhaIdentificacaoPTRPAEJ))
        {
            if (identificacaoPTRP.TpIdtDesenv != "1" && identificacaoPTRP.TpIdtDesenv != "2")
            {
                ErrosValidacao.Add($"O campo 'TpIdtDesenv' esta com o valor ({identificacaoPTRP.TpIdtDesenv}) inválido, deve ter o valor igual a '1' ou '2'\n\tLinha ({LerArquivoAEJ.NumeroLinha}): {linhaIdentificacaoPTRPAEJ}\n");
                return;
            }


            if (decimal.Parse(identificacaoPTRP.IdtDesenv) > 11 && decimal.Parse(identificacaoPTRP.IdtDesenv) < 14)
            {
                ErrosValidacao.Add($"O campo 'IdtDesenv' esta com a quantidade de digitos inválidos ({identificacaoPTRP.IdtDesenv.Length}) deve ter a quantidade igual a '11' ou '14'\n\tLinha ({LerArquivoAEJ.NumeroLinha}): {linhaIdentificacaoPTRPAEJ}\n");
                return;
            }

            IdentificacaoPTRPAEJList.Add(identificacaoPTRP);
        }
        foreach (var item in ValidacaoTamanhoDado.ErrosValidacao)
        {
            ErrosValidacao.Add(item);
        }

    }
    private static bool ValidarTipoDados(IdentificacaoPTRPAEJ identificacaoPTRP, string linha)
    {
        var camposComErro = new List<string>();

        if (!int.TryParse(identificacaoPTRP.TipoReg, out _))
        {
            camposComErro.Add("TipoReg");
        }

        if (!int.TryParse(identificacaoPTRP.TpIdtDesenv, out _))
        {
            camposComErro.Add("TpIdtDesenv");
        }

        if (!double.TryParse(identificacaoPTRP.IdtDesenv, out _))
        {
            camposComErro.Add("IdtDesenv");
        }

        if (camposComErro.Count == 0)
        {
            return true;
        }
        else
        {
            ErrosValidacao.Add($"Erro de tipo de dados nos campos: {string.Join(", ", camposComErro)}\n\tLinha ({LerArquivoAEJ.NumeroLinha}): {linha}\n");
            return false;
        }
    }
}
