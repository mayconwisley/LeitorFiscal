using LeitorAEJ.Model.ListarValidacao;

namespace LeitorAEJ;

public partial class FrmListarValidacao : Form
{
    public FrmListarValidacao()
    {
        InitializeComponent();
    }

    private void ListarValidacao()
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
    }

    private void FrmListarValidacao_Load(object sender, EventArgs e)
    {
        ListarValidacao();
    }
}
