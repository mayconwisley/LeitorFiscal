using LeitorAEJ.Model;
using LeitorAEJ.Model.Ultil;
using System.Text;

namespace LeitorAEJ.LeituraArquivo;

public class LerArquivoAEJ
{
    public static void Arquivo(string caminho)
    {
        using StreamReader sr = new(caminho, Encoding.Latin1, true, 1024 * 1024 * 1);
        string? linha;

        CabecalhoAEJ.CabecalhoAEJList.Clear();
        REPsUtilizadosAEJ.REPsUtilizadosAEJList.Clear();
        VinculosAEJ.VinculosAEJList.Clear();
        HorarioContratualAEJ.HorarioContratualAEJList.Clear();
        MarcacoesAEJ.MarcacoesAEJList.Clear();
        VinculoeSocialAEJ.VinculoeSocialAEJList.Clear();
        AusenciaBancoHorasAEJ.AusenciaBancoHorasAEJList.Clear();
        IdentificacaoPTRPAEJ.IdentificacaoPTRPAEJList.Clear();
        TrailerAEJ.TrailerAEJList.Clear();
        ValidacaoTamanhoDado.ErrosValidacao.Clear();

        while ((linha = sr.ReadLine()) != null)
        {
            string itemLinha = linha[..2];

            switch (itemLinha)
            {
                case "01": //Cabeçalho
                    CabecalhoAEJ.GetCabecalhos(linha);
                    break;
                case "02": //REPs Utilizados
                    REPsUtilizadosAEJ.GetREPsUtilizados(linha);
                    break;
                case "03": //Vinculos
                    VinculosAEJ.GetVinculos(linha);
                    break;
                case "04": //Horário contratual
                    HorarioContratualAEJ.GetHorarioContratual(linha);
                    break;
                case "05": //Marcações
                    MarcacoesAEJ.GetMarcacoes(linha);
                    break;
                case "06": //Identificação da matrícula do vínculo no eSocial, para empregados com mais de um vínculo no AEJ
                    VinculoeSocialAEJ.GetVinculoeSocial(linha);
                    break;
                case "07": //Ausências e Banco de Horas
                    AusenciaBancoHorasAEJ.GetAusenciaBancoHoras(linha);
                    break;
                case "08": //Identificação do PTRP (Programa de Tratamento de Registro de Ponto)
                    IdentificacaoPTRPAEJ.GetIdentificacaoPTRP(linha);
                    break;
                case "99": //Trailer
                    TrailerAEJ.GetTrailer(linha);
                    break;
                default:
                    MessageBox.Show($"Tipo de registro inválido: {itemLinha}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sr.ReadToEnd();
                    break;
            }
        }
    }
}
