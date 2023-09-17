namespace LeitorAEJ.Model.ListarDados;

public class Marcacao
{
    static TimeSpan horaCalculada = new();
    static TimeSpan horaTemp = new();
    static TimeSpan horaEntrada = new();
    static TimeSpan horaSaida = new();
    static string calculoMarcacao = string.Empty;

    public static string Listar(string idtVinculoAej)
    {
        string dataMarcacao = string.Empty;
        string horaMarcacao = string.Empty;

        var marcacoes = MarcacoesAEJ.MarcacoesAEJList
           .Where(w => w.IdtVinculoAej == idtVinculoAej)
           .ToList();

        var marcacoesData = marcacoes
           .GroupBy(g => DateTime.Parse(g.DataHoraMarc!).ToString("dd/MM/yyyy"))
           .ToList();

        foreach (var item in marcacoesData)
        {
            dataMarcacao += $"Data Marcação: {item.Key}\n";
            horaMarcacao = string.Empty;
            horaCalculada = TimeSpan.FromHours(0);

            var marcacoesAtual = marcacoes
                .Where(w => DateTime.Parse(w.DataHoraMarc!).ToString("dd/MM/yyyy") == item.Key)
                .ToList();
            foreach (var itemHora in marcacoesAtual)
            {
                horaMarcacao += $"\tHora: {DateTime.Parse(itemHora.DataHoraMarc!):HH:mm}, " +
                         $"Tipo de Marcação: {itemHora.TpMarc}, " +
                         $"Sequencia: {itemHora.SeqEntSaida}, " +
                         $"Fonte da Marcação: {itemHora.FonteMarc}, " +
                         $"Horário Contratual: {itemHora.CodHorContratual}, " +
                         $"Motivo: {itemHora.Motivo}\n";

                CalcularMarcacoes(itemHora.TpMarc!, itemHora.DataHoraMarc!);
            }
            dataMarcacao += horaMarcacao + "\n" + calculoMarcacao + "\n";
        }

        return dataMarcacao;
    }
    private static void CalcularMarcacoes(string tpMarc, string dataHoraMarc)
    {

        if (tpMarc == "E")
        {
            horaEntrada = TimeSpan.Parse(DateTime.Parse(dataHoraMarc).ToString("HH:mm"));
        }
        else if (tpMarc == "S")
        {
            horaSaida = TimeSpan.Parse(DateTime.Parse(dataHoraMarc).ToString("HH:mm"));

            if (horaSaida < horaEntrada)
            {
                horaSaida = horaSaida.Add(new TimeSpan(24, 0, 0));
            }
            horaTemp = (horaSaida - horaEntrada);

        }

        horaCalculada += horaTemp;
        horaTemp = TimeSpan.FromHours(0);

        calculoMarcacao = $"\tApuração: {horaCalculada.Hours:00}:{horaCalculada.Minutes:00}\n";

    }
}
