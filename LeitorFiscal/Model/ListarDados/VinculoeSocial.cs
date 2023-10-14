using LeitorFiscal.AEJ;

namespace LeitorFiscal.Model.ListarDados;

public class VinculoeSocial
{
    public static string Listar(string idtVinculoAej)
    {
        string matEsocial = string.Empty;
        var vinculoeSocial = VinculoeSocialAEJ.VinculoeSocialAEJList
            .Where(w => w.IdtVinculoAej == idtVinculoAej)
            .ToList();

        foreach (var item in vinculoeSocial)
        {
            matEsocial += item.MatEsocial + "\n";
        }
        return $"Matrícula eSocial mais de um vínculo:\n\t{matEsocial}\n";
    }
}
