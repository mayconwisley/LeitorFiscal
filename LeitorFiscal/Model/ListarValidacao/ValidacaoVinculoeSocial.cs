using LeitorFiscal.AEJ;

namespace LeitorFiscal.Model.ListarValidacao;

public class ValidacaoVinculoeSocial
{
    public static string Listar()
    {
        string validacao = string.Empty;
        foreach (var item in VinculoeSocialAEJ.ErrosValidacao)
        {
            validacao += $"\t{item}";
        }
        return $"Registro 06 - Identificação da matrícula do vínculo no eSocial:\n{validacao}\n";
    }
}
