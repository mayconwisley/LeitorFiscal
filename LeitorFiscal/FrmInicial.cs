using LeitorFiscal.Model.Util;
using System.Diagnostics;

namespace LeitorFiscal;

public partial class FrmInicial : Form
{
    public FrmInicial()
    {
        InitializeComponent();
    }

    private void BtnValidadeAej_Click(object sender, EventArgs e)
    {
        try
        {
            FrmLeitorFiscal frmLeitorFiscal = new();
            frmLeitorFiscal.ShowDialog();
        }
        catch (Exception ex)
        {

            MessageBox.Show(ex.Message);
        }
    }

    private void BtnValidarAej_Click(object sender, EventArgs e)
    {
        try
        {
            FrmLeitorAfd frmLeitorAfd = new();
            frmLeitorAfd.ShowDialog();
        }
        catch (Exception ex)
        {

            MessageBox.Show(ex.Message);
        }
    }

    private void LkPortarias_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        try
        {
            AbrirPastaPortaria.AbrirPasta();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void LkProjetoGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        try
        {
            AbrirProjetoGithub.AbrirLink();
        }
        catch (Exception ex)
        {

            MessageBox.Show(ex.Message);
        }
    }
}
