using LeitorAEJ.AFD.Portaria_1510;
using System.Text;

namespace LeitorAEJ.LeituraArquivo;

public class LerArquivoAFD
{
    public static void Arquivo(string caminho)
    {
        using StreamReader sr = new(caminho, Encoding.Latin1, true, 1024 * 1024 * 1);
        string? linha;

        while ((linha = sr.ReadLine()) != null)
        {
            string itemLinha = linha.Substring(9, 1);

            switch (itemLinha)
            {
                case "1": //Cabeçalho
                    Cabecalho1510.GetCabecalho(linha);
                    break;
                default:
                    MessageBox.Show($"Tipo de registro inválido: {itemLinha}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sr.ReadToEnd();
                    break;
            }
        }

    }
}
