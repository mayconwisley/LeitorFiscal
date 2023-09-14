using LeitorAEJ.LeituraArquivo;
using LeitorAEJ.Model;
using LeitorAEJ.Model.Ultil;

namespace LeitorAEJ;

public partial class FrmPrincipal : Form
{
    string caminhoArquivo = string.Empty;
    bool validarPortaria = false;
    public FrmPrincipal()
    {
        InitializeComponent();
    }

    private void LocalizarArquivo()
    {
        using OpenFileDialog openFileDialog = new();
        openFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt";
        openFileDialog.Multiselect = false;
        openFileDialog.Title = "Abrir arquivo";
        validarPortaria = false;
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            caminhoArquivo = openFileDialog.FileName;

            if (MessageBox.Show("Deseja validar o arquivo com a Portaria 671?", "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                validarPortaria = true;
            }

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
        foreach (var item in ValidacaoTamanhoDado.ErrosValidacao)
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
        foreach (var item in ValidacaoTamanhoDado.ErrosValidacao)
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
        foreach (var item in ValidacaoTamanhoDado.ErrosValidacao)
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
        foreach (var item in ValidacaoTamanhoDado.ErrosValidacao)
        {
            RTxtLogHorarioContratual.AppendText(item);
        }
    }
    private void MarcacoesAej()
    {
        RTxtLogMarcacoes.Clear();
        DgvListMarcacao.DataSource = null;
        DgvListMarcacao.DataSource = MarcacoesAEJ.MarcacoesAEJList;
        RTxtLogMarcacoes.Text = MarcacoesAEJ.ErroValidacao;
    }
    private void VinculoeSocialAej()
    {
        RTxtLogVinculoeSocial.Clear();
        DgvListVinculoeSocial.DataSource = null;
        DgvListVinculoeSocial.DataSource = VinculoeSocialAEJ.VinculoeSocialAEJList;
        RTxtLogVinculoeSocial.Text = VinculoeSocialAEJ.ErroValidacao;
    }
    private void AusenciaBancoHorasAej()
    {
        RTxtLogAusenciaBancoHoras.Clear();
        DgvListAusenciaBancoHoras.DataSource = null;
        DgvListAusenciaBancoHoras.DataSource = AusenciaBancoHorasAEJ.AusenciaBancoHorasAEJList;
        RTxtLogAusenciaBancoHoras.Text = AusenciaBancoHorasAEJ.ErroValidacao;
    }
    private void IdentificaoPTRPAej()
    {
        RTxtLogIdentificaoPTRP.Clear();
        DgvListIdentificaoPTRP.DataSource = null;
        DgvListIdentificaoPTRP.DataSource = IdentificacaoPTRPAEJ.IdentificacaoPTRPAEJList;
        RTxtLogIdentificaoPTRP.Text = IdentificacaoPTRPAEJ.ErroValidacao;
    }
    private void TrailerAej()
    {
        RTxtLogTrailer.Clear();
        DgvListTrailer.DataSource = null;
        DgvListTrailer.DataSource = TrailerAEJ.TrailerAEJList;
        RTxtLogTrailer.Text = TrailerAEJ.ErroValidacao;
    }

    private void SubMenuLerArquivo_Click(object sender, EventArgs e)
    {
        LocalizarArquivo();

        try
        {
            LerArquivoAEJ.Arquivo(caminhoArquivo, validarPortaria);
            CabecalhoAej();
            RepUtilizadosAej();
            VinculosAej();
            HorarioContratualAej();
            MarcacoesAej();
            VinculoeSocialAej();
            AusenciaBancoHorasAej();
            IdentificaoPTRPAej();
            TrailerAej();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void SubMenuRelatorioListar_Click(object sender, EventArgs e)
    {
        FrmRelatorio frmRelatorio = new();
        frmRelatorio.ShowDialog();
    }
}