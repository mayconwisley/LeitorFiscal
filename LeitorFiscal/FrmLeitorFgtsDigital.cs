using LeitorFiscal.FGTSDigital;
using LeitorFiscal.LeituraArquivo;

namespace LeitorFiscal;

public partial class FrmLeitorFgtsDigital : Form
{
    string caminhoArquivo = string.Empty;

    public FrmLeitorFgtsDigital()
    {
        InitializeComponent();
    }

    private void LocalizarArquivo()
    {
        using OpenFileDialog openFileDialog = new();
        openFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt";
        openFileDialog.Multiselect = false;
        openFileDialog.Title = "Abrir arquivo FGTS Digital";

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            caminhoArquivo = openFileDialog.FileName;
        }
    }

    private void Identificacao()
    {
        RtxValidacaoIdentificacao.Clear();
        DgvIdentificacao.DataSource = null;
        DgvIdentificacao.DataSource = IdentificacaoTrabalhador.IdentificacaoTrabalhadors;

        foreach (var item in IdentificacaoTrabalhador.ErrosValidacao)
        {
            RtxValidacaoIdentificacao.AppendText(item);
        }
    }

    private void Remuneracao()
    {
        RtxValidacaoRemuneracao.Clear();
        DgvRemuneracao.DataSource = null;
        DgvRemuneracao.DataSource = RemuneracaoTrabalhador.RemuneracaoTrabalhadors;

        foreach (var item in RemuneracaoTrabalhador.ErrosValidacao)
        {
            RtxValidacaoRemuneracao.AppendText(item);
        }
    }

    private void SubMenuLerArquivo_Click(object sender, EventArgs e)
    {
        LocalizarArquivo();

        try
        {
            LerArquivoFGTSDigital.Arquivo(caminhoArquivo);
            Identificacao();
            Remuneracao();

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
}
