using LeitorAEJ.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeitorAEJ
{
    public partial class FrmRelatorio : Form
    {
        string? idtVinculoAej = string.Empty;

        public FrmRelatorio()
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
                    NomeEmp = s.NomeEmp!.Trim()

                }).ToList();
            }
        }


        private void ListarDados(string idtVinculoAej)
        {
            RTxtMarcacaoIndividual.Clear();

            string empregado = string.Empty;
            string marcacao = string.Empty;

            var vinculo = VinculosAEJ.VinculosAEJList
                .Where(w => w.IdtVinculoAej!.Trim() == idtVinculoAej)
                .ToList();

            foreach (var item in vinculo)
            {
                empregado = $"Nome: {item.NomeEmp}\n" +
                            $"CPF: {item.CPF}";
            }

            var listaMarcacoes = MarcacoesAEJ.MarcacoesAEJList
                .Where(w => w.IdtVinculoAej!.Trim() == idtVinculoAej)
                .ToList();


            foreach (var item in listaMarcacoes)
            {
                marcacao += $"Data Marcação: {item.DataHoraMarc} - Tipo Marcação: {item.TpMarc} - " +
                           $"Sequencia: {item.SeqEntSaida}\n";
            }

            RTxtMarcacaoIndividual.Text = empregado + "\n" + marcacao;
        }

        private void FrmRelatorio_Load(object sender, EventArgs e)
        {
            ListarVinculos();
        }

        private void CbxVinculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            idtVinculoAej = CbxVinculos.SelectedValue!.ToString();
            ListarDados(idtVinculoAej!);
        }
    }
}
