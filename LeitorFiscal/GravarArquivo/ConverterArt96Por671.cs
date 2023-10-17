using System.Text;

namespace LeitorFiscal.GravarArquivo
{
    public class ConverterArt96Por671
    {
        public static void Converter(string caminhoOrigem, string caminhoSalvar)
        {
            using StreamReader sr = new(caminhoOrigem, Encoding.Latin1, true, 1024 * 1024 * 1);
            using StreamWriter sw = new(caminhoSalvar, false, Encoding.Latin1);

            string? linha;
            StringBuilder sb = new();

            while ((linha = sr.ReadLine()) != null)
            {
                string itemLinha = linha.Substring(9, 1);
                sb.Clear();
                switch (itemLinha)
                {
                    case "3":

                        if (linha.Length == 34)
                        {
                            sb.Append(linha.AsSpan(0, 22));
                            sb.Append('9');
                            sb.Append(linha.AsSpan(23, 11));
                        }
                        if (linha.Length == 38)
                        {
                            sb.Append(linha.AsSpan(0, 22));
                            sb.Append('9');
                            sb.Append(linha.AsSpan(23, 15));
                        }

                        sw.WriteLine($"{sb}");
                        break;
                    case "5":

                        if (linha.Length == 87)
                        {
                            sb.Append(linha.AsSpan(0, 23));
                            sb.Append('9');
                            sb.Append(linha.AsSpan(24, 63));
                        }
                        if (linha.Length == 106)
                        {
                            sb.Append(linha.AsSpan(0, 23));
                            sb.Append('9');
                            sb.Append(linha.AsSpan(24, 82));
                        }
                        sw.WriteLine($"{sb}");
                        break;

                    default:
                        sw.WriteLine($"{linha}");
                        break;
                }
            }
            sw.Close();
        }
    }
}
