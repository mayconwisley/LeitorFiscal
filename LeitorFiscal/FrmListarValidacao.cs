using LeitorFiscal.Model.ListarValidacaoAEJ;
namespace LeitorFiscal;

public partial class FrmListarValidacao : Form
{
    readonly string? _layout;

    public FrmListarValidacao()
    {
        InitializeComponent();
    }
    public FrmListarValidacao(string layout) : this()
    {
        _layout = layout;
    }
    private void ListarValidacaoAej()
    {
        RTxtListaValidacao.Clear();
        RTxtListaValidacao.AppendText(ValidacaoCabecalho.Listar());
        RTxtListaValidacao.AppendText(ValidacaoRepUtilizados.Listar());
        RTxtListaValidacao.AppendText(ValidacaoVinculos.Listar());
        RTxtListaValidacao.AppendText(ValidacaoHorarioContratual.Listar());
        RTxtListaValidacao.AppendText(ValidacaoMarcacao.Listar());
        RTxtListaValidacao.AppendText(ValidacaoVinculoeSocial.Listar());
        RTxtListaValidacao.AppendText(ValidacaoAusenciaBancoHoras.Listar());
        RTxtListaValidacao.AppendText(ValidacaoIdentificacaoPTRP.Listar());
        RTxtListaValidacao.AppendText(ValidacaoTrailer.Listar());
        RTxtListaValidacao.AppendText(ValidacaoAssinaturaDigital.Listar());
    }

    private void ListarValidacaoAfd()
    {
        RTxtListaValidacao.Clear();
        RTxtListaValidacao.AppendText(Model.ListarValidacaoAFD.ValidacaoCabecalho.Listar());
        RTxtListaValidacao.AppendText(Model.ListarValidacaoAFD.ValidacaoIdentificacaoEmpregador.Listar());
        RTxtListaValidacao.AppendText(Model.ListarValidacaoAFD.ValidacaoMarcacaoPonto.Listar());
        RTxtListaValidacao.AppendText(Model.ListarValidacaoAFD.ValidacaoTempoReal.Listar());
        RTxtListaValidacao.AppendText(Model.ListarValidacaoAFD.ValidacaoEmpregadoMT.Listar());
        RTxtListaValidacao.AppendText(Model.ListarValidacaoAFD.ValidacaoEventosSensiveis.Listar());
        RTxtListaValidacao.AppendText(Model.ListarValidacaoAFD.ValidacaoMarcacaoPontoRepP.Listar());
        RTxtListaValidacao.AppendText(Model.ListarValidacaoAFD.ValidacaoTrailer.Listar());
        RTxtListaValidacao.AppendText(Model.ListarValidacaoAFD.ValidacaoAssinaturaDigital.Listar());
    }

    private void FrmListarValidacao_Load(object sender, EventArgs e)
    {
        if (_layout == "AFD")
        {
            ListarValidacaoAfd();
        }
        if (_layout == "AEJ")
        {
            ListarValidacaoAej();
        }
    }
}
