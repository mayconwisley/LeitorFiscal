namespace LeitorFiscal.LeituraArquivo;

public class ErrosDeLeitura
{
    public static List<string> Erros { get; set; } = [];

    public static string ListaDeErro()
    {
        string erro = string.Empty;

        foreach (var item in Erros)
        {
            erro += item + "\n";
        }

        return erro;
    }

}
