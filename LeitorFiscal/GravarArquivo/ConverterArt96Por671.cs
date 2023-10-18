using System.Text;

namespace LeitorFiscal.GravarArquivo;

public class ConverterArt96Por671
{
    private static string ModificarRegistro3(string linha, char itemModificar)
    {
        StringBuilder sb = new();

        if (linha.Length == 34)
        {
            sb.Append(linha.AsSpan(0, 22));
            sb.Append(itemModificar);
            sb.Append(linha.AsSpan(23, 11));

        }
        if (linha.Length == 38)
        {
            sb.Append(linha.AsSpan(0, 22));
            sb.Append(itemModificar);
            sb.Append(linha.AsSpan(23, 15));
        }

        return sb.ToString();
    }

    private static string ModificarRegistro5(string linha, char itemModificar)
    {
        StringBuilder sb = new();

        if (linha.Length == 87)
        {
            sb.Append(linha.AsSpan(0, 23));
            sb.Append(itemModificar);
            sb.Append(linha.AsSpan(24, 63));
        }
        if (linha.Length == 106)
        {
            sb.Append(linha.AsSpan(0, 23));
            sb.Append(itemModificar);
            sb.Append(linha.AsSpan(24, 82));
        }

        return sb.ToString();
    }

    public static void Converter(string caminhoOrigem, string caminhoSalvar, string forma)
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
                    if (forma == "I")
                    {
                        linhaModificada = ModificarRegistro3(linha, '0');

                    }
                    if (forma == "II")
                    {
                        linhaModificada = ModificarRegistro3(linha, '9');
                    }
                    if (forma == "III")
                    {
                        linhaModificada = ModificarRegistro3(linha, '8');
                    }

                    sw.WriteLine($"{linhaModificada}");
                    break;
                case "5":

                    if (forma == "I")
                    {
                        linhaModificada = ModificarRegistro5(linha, '0');
                    }

                    if (forma == "II")
                    {
                        linhaModificada = ModificarRegistro5(linha, '9');
                    }
                    if (forma == "III")
                    {
                        linhaModificada = ModificarRegistro5(linha, '8');
                    }
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
