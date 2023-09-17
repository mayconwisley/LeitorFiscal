namespace LeitorAEJ.Model.ListarDados;

public class HorarioContrato
{
    public static string Listar(string idtVinculoAej)
    {
        string horaContrato = string.Empty;

        var marcacoes = MarcacoesAEJ.MarcacoesAEJList
                .Where(w => w.IdtVinculoAej == idtVinculoAej.Trim())
                .Select(s => new
                {
                    s.CodHorContratual
                })
                .OrderBy(o => o.CodHorContratual)
                .GroupBy(g => g.CodHorContratual)
                .ToList();

        foreach (var item in marcacoes)
        {
            var marcacaoContratual = HorarioContratualAEJ.HorarioContratualAEJList
                .Where(w => w.CodHorContratual == item.Key)
                .ToList();

            foreach (var itemHora in marcacaoContratual)
            {
                horaContrato += $"\t{itemHora.CodHorContratual} - " +
                                $"{itemHora.HrEntrada01!.Insert(2, ":")} - " +
                                $"{itemHora.HrSaida01!.Insert(2, ":")} - " +
                                $"{itemHora.HrEntrada02!.Insert(2, ":")} - " +
                                $"{itemHora.HrSaida02!.Insert(2, ":")}\n";
            }
        }

        return $"Horário Contratual:\n{horaContrato}\n\n";
    }
}
