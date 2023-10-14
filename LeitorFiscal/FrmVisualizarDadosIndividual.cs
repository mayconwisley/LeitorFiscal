using LeitorFiscal.Model.ListarDados;

namespace LeitorFiscal;

public partial class FrmVisualizarDadosIndividual : Form
{
    public FrmVisualizarDadosIndividual()
    {
        InitializeComponent();
    }

    private void MostrarDadosTela(string idtVinculoAej)
    {
        RTxtMarcacaoIndividual.Clear();

        RTxtMarcacaoIndividual.AppendText(VinculoeSocial.Listar(idtVinculoAej));
        RTxtMarcacaoIndividual.AppendText(HorarioContrato.Listar(idtVinculoAej));
        RTxtMarcacaoIndividual.AppendText(Marcacao.Listar(idtVinculoAej));
        RTxtMarcacaoIndividual.AppendText(AusenciaBancoHoras.Listar(idtVinculoAej));
    }

    private void FrmRelatorio_Load(object sender, EventArgs e)
    {
        CbxVinculos.DataSource = Vinculos.Listar();
    }

    private void CbxVinculos_SelectedIndexChanged(object sender, EventArgs e)
    {
        var idtVinculoAej = CbxVinculos.SelectedValue!.ToString()!;

        if (idtVinculoAej is not null)
        {
            MostrarDadosTela(idtVinculoAej);
        }
    }
}
