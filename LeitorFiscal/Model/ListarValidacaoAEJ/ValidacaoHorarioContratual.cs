using LeitorFiscal.AEJ;

namespace LeitorFiscal.Model.ListarValidacaoAEJ;

public class ValidacaoHorarioContratual
{
    public static string Listar()
    {
        string validacao = string.Empty;
        foreach (var item in HorarioContratualAEJ.ErrosValidacao)
        {
            validacao += $"\t{item}";
        }
        return $"Registro 04 - Horário contratual:\n{validacao} \n";
    }
}
