using LeitorFiscal.Model.Util;
using System.Text;

namespace LeitorFiscal.GravarArquivo;

public class ConverterArt96Por671
{
    private static string ModificarRegistro3(string linha)
    {
        StringBuilder sb = new();
        string pis = linha.Substring(23, 11);

        sb.Append(linha.AsSpan(0, 22));

        if (ValidacaoCPF.Validar(pis))
        {
            sb.Append('9');
        }
        else if (ValidacaoPIS.Validar(pis))
        {
            sb.Append('0');
        }
        else
        {
            sb.Append('8');
        }

        if (linha.Length == 34)
        {
            sb.Append(linha.AsSpan(23, 11));
        }
        if (linha.Length == 38)
        {
            sb.Append(linha.AsSpan(23, 15));
        }

        return sb.ToString();
    }

    private static string ModificarRegistro5(string linha)
    {
        StringBuilder sb = new();
        string pis = linha.Substring(24, 11);

        sb.Append(linha.AsSpan(0, 23));
        if (ValidacaoCPF.Validar(pis))
        {
            sb.Append('9');
        }
        else if (ValidacaoPIS.Validar(pis))
        {
            sb.Append('0');
        }
        else
        {
            sb.Append('8');
        }
        if (linha.Length == 87)
        {
            sb.Append(linha.AsSpan(24, 63));
        }
        if (linha.Length == 106)
        {
            sb.Append(linha.AsSpan(24, 82));
        }

        return sb.ToString();
    }

    public static void Converter(string caminhoOrigem, string caminhoSalvar)
    {
        using StreamReader sr = new(caminhoOrigem, Encoding.Latin1, true, 1024 * 1024 * 1);
        using StreamWriter sw = new(caminhoSalvar, false, Encoding.Latin1);

        string? linha, linhaModificada = "";
        StringBuilder sb = new();

        while ((linha = sr.ReadLine()) != null)
        {
            string itemLinha = linha.Substring(9, 1);
            sb.Clear();
            switch (itemLinha)
            {
                case "3":
                    linhaModificada = ModificarRegistro3(linha);
                    sw.WriteLine($"{linhaModificada}");
                    break;
                case "5":
                    linhaModificada = ModificarRegistro5(linha);
                    sw.WriteLine($"{linhaModificada}");
                    break;
                default:
                    sw.WriteLine($"{linha}");
                    break;
            }
        }
        sw.Close();
    }
}
