using LeitorFiscal.LeituraArquivo;
using LeitorFiscal.Model.Util;
using System.ComponentModel.DataAnnotations;

namespace LeitorFiscal.AEJ;

public class TrailerAEJ
{
    [MaxLength(2, ErrorMessage = "O campo TipoReg deve ser um tipo de cadeia de caracteres com um comprimento máximo de '2'")]
    public string? TipoReg { get; set; }
    [MaxLength(9, ErrorMessage = "O campo QtRegistrosTipo01 deve ser um tipo de cadeia de caracteres com um comprimento máximo de '9'")]
    [MinLength(1, ErrorMessage = "O campo QtRegistrosTipo01 deve ser um tipo de cadeia de caracteres com um comprimento minimo de '1'")]
    public string? QtRegistrosTipo01 { get; set; }
    [MaxLength(9, ErrorMessage = "O campo QtRegistrosTipo02 deve ser um tipo de cadeia de caracteres com um comprimento máximo de '9'")]
    [MinLength(1, ErrorMessage = "O campo QtRegistrosTipo02 deve ser um tipo de cadeia de caracteres com um comprimento minimo de '1'")]
    public string? QtRegistrosTipo02 { get; set; }
    [MaxLength(9, ErrorMessage = "O campo QtRegistrosTipo03 deve ser um tipo de cadeia de caracteres com um comprimento máximo de '9'")]
    [MinLength(1, ErrorMessage = "O campo QtRegistrosTipo02 deve ser um tipo de cadeia de caracteres com um comprimento minimo de '1'")]
    public string? QtRegistrosTipo03 { get; set; }
    [MaxLength(9, ErrorMessage = "O campo QtRegistrosTipo04 deve ser um tipo de cadeia de caracteres com um comprimento máximo de '9'")]
    [MinLength(1, ErrorMessage = "O campo QtRegistrosTipo04 deve ser um tipo de cadeia de caracteres com um comprimento minimo de '1'")]
    public string? QtRegistrosTipo04 { get; set; }
    [MaxLength(9, ErrorMessage = "O campo QtRegistrosTipo05 deve ser um tipo de cadeia de caracteres com um comprimento máximo de '9'")]
    [MinLength(1, ErrorMessage = "O campo QtRegistrosTipo05 deve ser um tipo de cadeia de caracteres com um comprimento minimo de '1'")]
    public string? QtRegistrosTipo05 { get; set; }
    [MaxLength(9, ErrorMessage = "O campo QtRegistrosTipo06 deve ser um tipo de cadeia de caracteres com um comprimento máximo de '9'")]
    [MinLength(1, ErrorMessage = "O campo QtRegistrosTipo06 deve ser um tipo de cadeia de caracteres com um comprimento minimo de '1'")]
    public string? QtRegistrosTipo06 { get; set; }
    [MaxLength(9, ErrorMessage = "O campo QtRegistrosTipo07 deve ser um tipo de cadeia de caracteres com um comprimento máximo de '9'")]
    [MinLength(1, ErrorMessage = "O campo QtRegistrosTipo07 deve ser um tipo de cadeia de caracteres com um comprimento minimo de '1'")]
    public string? QtRegistrosTipo07 { get; set; }
    [MaxLength(9, ErrorMessage = "O campo QtRegistrosTipo08 deve ser um tipo de cadeia de caracteres com um comprimento máximo de '9'")]
    [MinLength(1, ErrorMessage = "O campo QtRegistrosTipo08 deve ser um tipo de cadeia de caracteres com um comprimento minimo de '1'")]
    public string? QtRegistrosTipo08 { get; set; }

    public static List<TrailerAEJ> TrailerAEJList { get; private set; } = new();
    public static List<string> ErrosValidacao { get; set; } = new();

    public static void GetTrailer(string linhaTrailer)
    {
        string[] itemLinha = linhaTrailer.Split("|");
        if (itemLinha.Length < 9 || itemLinha.Length > 10)
        {
            throw new Exception($"Layout da sessão 99 esta fora do padrão definido pela a portaria\n{linhaTrailer}");
        }
        var trailer = new TrailerAEJ
        {
            TipoReg = itemLinha[0].Trim(),
            QtRegistrosTipo01 = itemLinha[1].Trim(),
            QtRegistrosTipo02 = itemLinha[2].Trim(),
            QtRegistrosTipo03 = itemLinha[3].Trim(),
            QtRegistrosTipo04 = itemLinha[4].Trim(),
            QtRegistrosTipo05 = itemLinha[5].Trim(),
            QtRegistrosTipo06 = itemLinha[6].Trim(),
            QtRegistrosTipo07 = itemLinha[7].Trim(),
            QtRegistrosTipo08 = itemLinha[8].Trim(),
        };


        if (ValidacaoTamanhoDado.ValidarTamanho(trailer,linhaTrailer) && ValidarTipoDados(trailer, linhaTrailer))
        {
            TrailerAEJList.Add(trailer);
        }
        foreach (var item in ValidacaoTamanhoDado.ErrosValidacao)
        {
            ErrosValidacao.Add(item);
        }
    }

    public static bool ValidarResgistrosAEJ(int reg01, int reg02, int reg03, int reg04, int reg05, int reg06, int reg07, int reg08)
    {
        int count = 0;
        foreach (var item in TrailerAEJList)
        {
            if (int.Parse(item.QtRegistrosTipo01!) != reg01)
            {
                ErrosValidacao.Add($"Quantidade de registros '01 - Cabecalho' inválido, quantidade verificada: {reg01}, quantidade no registro 99 - Trailer: {item.QtRegistrosTipo01}\n");
                count++;
            }
            if (int.Parse(item.QtRegistrosTipo02!) != reg02)
            {
                ErrosValidacao.Add($"Quantidade de registros '02 - REPs utilizados' inválido, quantidade verificada: {reg02}, quantidade no registro 99 - Trailer: {item.QtRegistrosTipo02}\n");
                count++;
            }
            if (int.Parse(item.QtRegistrosTipo03!) != reg03)
            {
                ErrosValidacao.Add($"Quantidade de registros '03 - Vínculos' inválido, quantidade verificada: {reg03}, quantidade no registro 99 - Trailer: {item.QtRegistrosTipo03}\n");
                count++;
            }
            if (int.Parse(item.QtRegistrosTipo04!) != reg04)
            {
                ErrosValidacao.Add($"Quantidade de registros '04 - Horário contratual' inválido, quantidade verificada: {reg04}, quantidade no registro 99 - Trailer: {item.QtRegistrosTipo04}\n");
                count++;
            }
            if (int.Parse(item.QtRegistrosTipo05!) != reg05)
            {
                ErrosValidacao.Add($"Quantidade de registros '05 - Marcações' inválido, quantidade verificada: {reg05}, quantidade no registro 99 - Trailer: {item.QtRegistrosTipo05}\n");
                count++;
            }
            if (int.Parse(item.QtRegistrosTipo06!) != reg06)
            {
                ErrosValidacao.Add($"Quantidade de registros '06 - Identificação da matrícula do vínculo no eSocial' inválido, quantidade verificada: {reg06}, quantidade no registro 99 - Trailer: {item.QtRegistrosTipo06}\n");
                count++;
            }
            if (int.Parse(item.QtRegistrosTipo07!) != reg07)
            {
                ErrosValidacao.Add($"Quantidade de registros '07 - Ausências e Banco de Horas' inválido, quantidade verificada: {reg07}, quantidade no registro 99 - Trailer: {item.QtRegistrosTipo07}\n");
                count++;
            }
            if (int.Parse(item.QtRegistrosTipo08!) != reg08)
            {
                ErrosValidacao.Add($"Quantidade de registros '08 - Identificação do PTRP' inválido, quantidade verificada: {reg08}, quantidade no registro 99 - Trailer: {item.QtRegistrosTipo08}\n");
                count++;
            }
            if (count > 0)
            {
                return true;
            }
        }
        return false;
    }

    private static bool ValidarTipoDados(TrailerAEJ trailerAEJ, string linha)
    {

        var camposComErro = new List<string>();

        if (!int.TryParse(trailerAEJ.TipoReg, out _))
        {
            camposComErro.Add("TipoReg");
        }

        if (!double.TryParse(trailerAEJ.QtRegistrosTipo01, out _))
        {
            camposComErro.Add("QtRegistrosTipo01");
        }
        if (!double.TryParse(trailerAEJ.QtRegistrosTipo02, out _))
        {
            camposComErro.Add("QtRegistrosTipo02");
        }
        if (!double.TryParse(trailerAEJ.QtRegistrosTipo03, out _))
        {
            camposComErro.Add("QtRegistrosTipo03");
        }
        if (!double.TryParse(trailerAEJ.QtRegistrosTipo04, out _))
        {
            camposComErro.Add("QtRegistrosTipo04");
        }
        if (!double.TryParse(trailerAEJ.QtRegistrosTipo05, out _))
        {
            camposComErro.Add("QtRegistrosTipo05");
        }
        if (!double.TryParse(trailerAEJ.QtRegistrosTipo06, out _))
        {
            camposComErro.Add("QtRegistrosTipo06");
        }
        if (!double.TryParse(trailerAEJ.QtRegistrosTipo07, out _))
        {
            camposComErro.Add("QtRegistrosTipo07");
        }
        if (!double.TryParse(trailerAEJ.QtRegistrosTipo08, out _))
        {
            camposComErro.Add("QtRegistrosTipo08");
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
