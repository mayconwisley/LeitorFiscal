using LeitorFiscal.AEJ;
using LeitorFiscal.LeituraArquivo;

namespace LeitorFiscal;

public partial class FrmLeitorFiscal : Form
{
    string caminhoArquivo = string.Empty;
    public FrmLeitorFiscal()
    {
        InitializeComponent();
    }
    private void LocalizarArquivo()
    {
        using OpenFileDialog openFileDialog = new();
        openFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt";
        openFileDialog.Multiselect = false;
        openFileDialog.Title = "Abrir arquivo AEJ";

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            caminhoArquivo = openFileDialog.FileName;
        }
    }
    private void CabecalhoAej()
    {
        RTxtLogCabecalho.Clear();
        DgvListCabecalho.DataSource = null;
        DgvListCabecalho.DataSource = CabecalhoAEJ.CabecalhoAEJList;

        foreach (var item in CabecalhoAEJ.ErrosValidacao)
        {
            RTxtLogCabecalho.AppendText(item);
        }
    }
    private void RepUtilizadosAej()
    {
        RTxtLogRepUtilizado.Clear();
        DgvListRepsUtilizados.DataSource = null;
        DgvListRepsUtilizados.DataSource = REPsUtilizadosAEJ.REPsUtilizadosAEJList;

        foreach (var item in REPsUtilizadosAEJ.ErrosValidacao)
        {
            RTxtLogRepUtilizado.AppendText(item);
        }
    }
    private void VinculosAej()
    {
        RTxtLogVinculo.Clear();
        DgvListVinculo.DataSource = null;
        DgvListVinculo.DataSource = VinculosAEJ.VinculosAEJList;
        foreach (var item in VinculosAEJ.ErrosValidacao)
        {
            RTxtLogVinculo.AppendText(item);
        }
    }
    private void HorarioContratualAej()
    {
        RTxtLogHorarioContratual.Clear();
        DgvListHorarioContratual.DataSource = null;
        DgvListHorarioContratual.DataSource = HorarioContratualAEJ.HorarioContratualAEJList;
        foreach (var item in HorarioContratualAEJ.ErrosValidacao)
        {
            RTxtLogHorarioContratual.AppendText(item);
        }
    }
    private void MarcacoesAej()
    {
        RTxtLogMarcacoes.Clear();
        DgvListMarcacao.DataSource = null;
        DgvListMarcacao.DataSource = MarcacoesAEJ.MarcacoesAEJList;
        foreach (var item in MarcacoesAEJ.ErrosValidacao)
        {
            RTxtLogMarcacoes.AppendText(item);
        }
    }
    private void VinculoeSocialAej()
    {
        RTxtLogVinculoeSocial.Clear();
        DgvListVinculoeSocial.DataSource = null;
        DgvListVinculoeSocial.DataSource = VinculoeSocialAEJ.VinculoeSocialAEJList;
        foreach (var item in VinculoeSocialAEJ.ErrosValidacao)
        {
            RTxtLogVinculoeSocial.AppendText(item);
        }
    }
    private void AusenciaBancoHorasAej()
    {
        RTxtLogAusenciaBancoHoras.Clear();
        DgvListAusenciaBancoHoras.DataSource = null;
        DgvListAusenciaBancoHoras.DataSource = AusenciaBancoHorasAEJ.AusenciaBancoHorasAEJList;
        foreach (var item in AusenciaBancoHorasAEJ.ErrosValidacao)
        {
            RTxtLogAusenciaBancoHoras.AppendText(item);
        }
    }
    private void IdentificaoPTRPAej()
    {
        RTxtLogIdentificaoPTRP.Clear();
        DgvListIdentificaoPTRP.DataSource = null;
        DgvListIdentificaoPTRP.DataSource = IdentificacaoPTRPAEJ.IdentificacaoPTRPAEJList;
        foreach (var item in IdentificacaoPTRPAEJ.ErrosValidacao)
        {
            RTxtLogIdentificaoPTRP.AppendText(item);
        }
    }
    private void TrailerAej()
    {
        RTxtLogTrailer.Clear();
        DgvListTrailer.DataSource = null;
        DgvListTrailer.DataSource = TrailerAEJ.TrailerAEJList;
        foreach (var item in TrailerAEJ.ErrosValidacao)
        {
            RTxtLogTrailer.AppendText(item);
        }
    }
    private void AssinaturaDigitalAej()
    {
        RTxtLogAssinaturaDigital.Clear();
        DgvListAssinaturaDigital.DataSource = null;
        DgvListAssinaturaDigital.DataSource = AssinaturaDigitalAEJ.AssinaturaDigitalAEJList;
        foreach (var item in AssinaturaDigitalAEJ.ErrosValidacao)
        {
            RTxtLogAssinaturaDigital.AppendText(item);
        }
    }
    private void SubMenuLerArquivo_Click(object sender, EventArgs e)
    {
        LocalizarArquivo();

        try
        {
            LerArquivoAEJ.Arquivo(caminhoArquivo);
            CabecalhoAej();
            RepUtilizadosAej();
            VinculosAej();
            HorarioContratualAej();
            MarcacoesAej();
            VinculoeSocialAej();
            AusenciaBancoHorasAej();
            IdentificaoPTRPAej();
            TrailerAej();
            AssinaturaDigitalAej();

            MenuVisualizar.Enabled = true;
            MenuValidacao.Enabled = true;

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
    private void SubMenuVisualizarListar_Click(object sender, EventArgs e)
    {
        FrmVisualizarDadosIndividual frmVisualizarDadosIndividual = new();
        frmVisualizarDadosIndividual.ShowDialog();
    }
    private void SubMenuValidacaoListar_Click(object sender, EventArgs e)
    {
        FrmListarValidacao frmListarValidacao = new("AEJ");
        frmListarValidacao.ShowDialog();
    }
}