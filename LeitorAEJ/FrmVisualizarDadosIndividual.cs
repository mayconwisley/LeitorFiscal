using LeitorAEJ.Model;
using System.Data;

namespace LeitorAEJ;

public partial class FrmVisualizarDadosIndividual : Form
{
    string dataMarcacao = string.Empty;
    string horaMarcacao = string.Empty;
    string horaContrato = string.Empty;
    string matEsocial = string.Empty;
    string ausenciaBancoHora = string.Empty;

    public FrmVisualizarDadosIndividual()
    {
        InitializeComponent();
    }

    private void ListarVinculos()
    {
        var lista = VinculosAEJ.VinculosAEJList;
        if (lista is not null)
        {
            CbxVinculos.DataSource = lista.Select(s => new
            {
                IdtVinculoAej = s.IdtVinculoAej!.Trim(),
                NomeEmp = s.CPF + " - " + s.NomeEmp!.Trim()
            }).ToList();
        }
    }

    private void ListarMarcacao(string idtVinculoAej)
    {
        var marcacoes = MarcacoesAEJ.MarcacoesAEJList
           .Where(w => w.IdtVinculoAej!.Trim() == idtVinculoAej)
           .ToList();

        var marcacoesData = marcacoes
           .GroupBy(g => DateTime.Parse(g.DataHoraMarc!).ToString("dd/MM/yyyy"))
           .ToList();

        var marcacaoContratual = HorarioContratualAEJ.HorarioContratualAEJList
          .ToList();

        foreach (var item in marcacoesData)
        {
            dataMarcacao += $"Data Marcação: {item.Key}\n";
            horaMarcacao = string.Empty;

            var marcacoesAtual = marcacoes
                .Where(w => DateTime.Parse(w.DataHoraMarc!).ToString("dd/MM/yyyy") == item.Key)
                .ToList();
            foreach (var itemHora in marcacoesAtual)
            {
                horaMarcacao += $"\tHora: {DateTime.Parse(itemHora.DataHoraMarc!.Trim()):HH:mm} " +
                         $"Tipo de Marcação: {itemHora.TpMarc!.Trim()} " +
                         $"Sequencia: {itemHora.SeqEntSaida!.Trim()} " +
                         $"Fonte da Marcação: {itemHora.FonteMarc!.Trim()} " +
                         $"Horário Contratual: {itemHora.CodHorContratual!.Trim()} " +
                         $"Motivo: {itemHora.Motivo!.Trim()}\n";
            }
            dataMarcacao += horaMarcacao + "\n";
        }
    }

    private void ListarHorarioContrato(string idtVinculoAej)
    {
        var marcacoes = MarcacoesAEJ.MarcacoesAEJList
            .Where(w => w.IdtVinculoAej!.Trim() == idtVinculoAej.Trim())
            .Select(s => new
            {
                s.CodHorContratual
            })
          .GroupBy(g => g.CodHorContratual)
          .ToList();
        foreach (var item in marcacoes)
        {
            var marcacaoContratual = HorarioContratualAEJ.HorarioContratualAEJList
                .Where(w => w.CodHorContratual!.Trim() == item.Key!.Trim())
                .ToList();
            foreach (var itemHora in marcacaoContratual)
            {
                horaContrato += $"\t{itemHora.CodHorContratual!.Trim()} - " +
                                $"{itemHora.HrEntrada01!.Insert(2, ":")} - " +
                                $"{itemHora.HrSaida01!.Insert(2, ":")} - " +
                                $"{itemHora.HrEntrada02!.Insert(2, ":")} - " +
                                $"{itemHora.HrSaida02!.Insert(2, ":")}\n";
            }
        }
    }

    private void ListarVinculoeSocial(string idtVinculoAej)
    {
        var vinculoeSocial = VinculoeSocialAEJ.VinculoeSocialAEJList
            .Where(w => w.IdtVinculoAej!.Trim() == idtVinculoAej)
            .ToList();
        foreach (var item in vinculoeSocial)
        {
            matEsocial += item.MatEsocial!.Trim() + "\n";
        }
    }
    private void ListarAusenciaBancoHoras(string idtVinculoAej)
    {
        var ausenciaBancoHoras = AusenciaBancoHorasAEJ.AusenciaBancoHorasAEJList
            .Where(w => w.IdtVinculoAej!.Trim() == idtVinculoAej)
            .ToList();

        string[] tipoAusencia = { "", "Descanso Semanal Remunerado (DSR)", "Falta não justificada", "Movimento no banco de horas", "Folga compensatória de feriado" };
        string[] tipoMov = { "", "Inclusão de horas no banco de horas", "Compensação de horas do banco de horas" };
        foreach (var item in ausenciaBancoHoras)
        {
            ausenciaBancoHora += $"Data: {DateTime.Parse(item.Data!):dd/MM/yyyy}\n" +
                                 $"\tTipo de Ausência ou Compensação: {item.TipoAusenOuComp!.Trim()} - " +
                                 $"{tipoAusencia[int.Parse(item.TipoAusenOuComp!.Trim())]}\n" +
                                 $"\tTipo Movimento Banco: {item.TipoMovBH!.Trim()} - " +
                                 $"{tipoMov[int.Parse(item.TipoMovBH!.Trim())]}\n";
        }
    }

    private void MostrarDadosTela()
    {
        RTxtMarcacaoIndividual.Clear();
        RTxtMarcacaoIndividual.Text = $"Matrícula eSocial: {matEsocial}\n\n" +
                                      $"Horário Contratual:\n{horaContrato}\n" +
                                      $"{dataMarcacao}\n" +
                                      $"Ausência e Banco de Horas:\n{ausenciaBancoHora}";
    }

    private void FrmRelatorio_Load(object sender, EventArgs e)
    {
        ListarVinculos();
    }

    private void CbxVinculos_SelectedIndexChanged(object sender, EventArgs e)
    {
        var idtVinculoAej = CbxVinculos.SelectedValue!.ToString()!;

        if (idtVinculoAej is not null)
        {
            ListarMarcacao(idtVinculoAej);
            ListarHorarioContrato(idtVinculoAej);
            ListarVinculoeSocial(idtVinculoAej!);
            ListarAusenciaBancoHoras(idtVinculoAej!);
            MostrarDadosTela();
        }
    }
}
