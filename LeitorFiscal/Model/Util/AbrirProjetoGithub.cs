using System.Diagnostics;

namespace LeitorFiscal.Model.Util;

public class AbrirProjetoGithub
{

    public static void AbrirLink()
    {
        string? link = "https://github.com/mayconwisley/LeitorFiscal";
        string? navegador = NavegadorPadrao();

        if (!string.IsNullOrEmpty(navegador))
        {
            Process.Start(new ProcessStartInfo(navegador, link));
        }
    }
    private static string NavegadorPadrao()
    {
        string? navegadorPadrao = "";

        Microsoft.Win32.RegistryKey? registryKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(@"HTTP\shell\open\command");

        if (registryKey != null)
        {
            string? defaultNavegador = registryKey.GetValue(null) as string;
            if (!string.IsNullOrEmpty(defaultNavegador))
            {
                defaultNavegador = defaultNavegador.Replace("%1", "");
                navegadorPadrao = defaultNavegador;
            }
        }
        return navegadorPadrao;
    }
}
