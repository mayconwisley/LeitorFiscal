using LeitorAEJ.AEJ;

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
        string repUtilizado = string.Empty;
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
                var listRepUtilizado = REPsUtilizadosAEJ.REPsUtilizadosAEJList
                    .Where(w => w.IdRepAej == itemHora.IdRepAej)
                    .ToList();
                repUtilizado = string.Empty;
                foreach (var itemRep in listRepUtilizado)
                {
                    var tipoRep = itemRep.TpRep == "1" ? "REP-C" : itemRep.TpRep == "2" ? "REP-A" : "REP-P";

                    repUtilizado += $"\n\t\tTipo de Rep: {itemRep.TpRep} - {tipoRep}\n\t\t" +
                                    $"Numero Rep: {itemRep.NrRep}";
                }

                if (listRepUtilizado.Count == 0)
                {
                    repUtilizado = "";
                }
                string descTpMarc = itemHora.TpMarc == "E" ?
                        "Entrada" : itemHora.TpMarc == "S" ?
                        "Saída" :
                        "Desconsiderada";
                string descFonteMarc = itemHora.FonteMarc == "O" ?
                        "Marcação original do REP" : itemHora.FonteMarc == "I" ?
                        "Marcação incluída manualmente" : itemHora.FonteMarc == "P" ?
                        "Marcação pré-assinalada" : itemHora.FonteMarc == "X" ?
                        "Ponto por exceção" :
                        "outras fontes de marcação";

                horaMarcacao += $"\tHora: {DateTime.Parse(itemHora.DataHoraMarc!):HH:mm}, " +
                         $"Tipo de Marcação: {itemHora.TpMarc} - {descTpMarc}, " +
                         $"Sequencia: {itemHora.SeqEntSaida}, " +
                         $"Horário Contratual: {itemHora.CodHorContratual}\n " +
                         $"\t\tFonte da Marcação: {itemHora.FonteMarc} - {descFonteMarc}, " +
                         $"Motivo: {itemHora.Motivo}" +
                         $"{repUtilizado}\n";

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
