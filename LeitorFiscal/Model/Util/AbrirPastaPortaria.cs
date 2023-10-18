using System.Diagnostics;

namespace LeitorFiscal.Model.Util;

public class AbrirPastaPortaria
{
    public static void AbrirPasta()
    {
        try
        {
            string caminhoAplicacao = Application.StartupPath + "Portarias";

            Process.Start("explorer.exe", caminhoAplicacao);
        }
        catch (Exception)
        {
            throw;
        }
    }


}
