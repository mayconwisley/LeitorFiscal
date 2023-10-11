using LeitorAEJ.AEJ;

namespace LeitorAEJ.Model.ListarDados
{
    public class AusenciaBancoHoras
    {
        public static string Listar(string idtVinculoAej)
        {
            string ausenciaBancoHora = string.Empty;

            var ausenciaBancoHoras = AusenciaBancoHorasAEJ.AusenciaBancoHorasAEJList
                .Where(w => w.IdtVinculoAej == idtVinculoAej)
                .ToList();

            string[] tipoAusencia = { "", "Descanso Semanal Remunerado (DSR)", "Falta não justificada", "Movimento no banco de horas", "Folga compensatória de feriado" };
            string[] tipoMov = { "", "Inclusão de horas no banco de horas", "Compensação de horas do banco de horas" };
            foreach (var item in ausenciaBancoHoras)
            {
                ausenciaBancoHora += $"Data: {DateTime.Parse(item.Data!):dd/MM/yyyy}\n" +
                                     $"\tQuantidade Minutos: {item.QtMinutos}\n" +
                                     $"\tTipo de Ausência ou Compensação: {item.TipoAusenOuComp} - " +
                                     $"{tipoAusencia[int.Parse(item.TipoAusenOuComp!)]}\n" +
                                     $"\tTipo Movimento Banco: {item.TipoMovBH} - " +
                                     $"{tipoMov[int.Parse(item.TipoMovBH!)]}\n";
            }

            return $"Ausência e Banco de Horas:\n{ausenciaBancoHora}\n";
        }
    }
}
