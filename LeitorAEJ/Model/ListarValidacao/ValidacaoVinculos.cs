using LeitorAEJ.AEJ;

namespace LeitorAEJ.Model.ListarValidacao;

public class ValidacaoVinculos
{
    public static string Listar()
    {
        string validacao = string.Empty;
        foreach (var item in VinculoeSocialAEJ.ErrosValidacao)
        {
            validacao += $"\t{item}";
        }
        return $"Registro 03 - Vínculos:\n{validacao}\n";
    }
}
