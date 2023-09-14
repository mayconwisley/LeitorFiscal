using LeitorAEJ.Model;
using LeitorAEJ.Model.Ultil;
using System.Text;

namespace LeitorAEJ.LeituraArquivo;

public class LerArquivoAEJ
{
    public static void Arquivo(string caminho, bool validarPortaria)
    {
        using StreamReader sr = new(caminho, Encoding.Latin1, true, 1024 * 1024 * 64);
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
                    CabecalhoAEJ.GetCabecalhos(linha, validarPortaria);
                    break;
                case "02": //REPs Utilizados
                    REPsUtilizadosAEJ.GetREPsUtilizados(linha, validarPortaria);
                    break;
                case "03": //Vinculos
                    VinculosAEJ.GetVinculos(linha, validarPortaria);
                    break;
                case "04": //Horário contratual
                    HorarioContratualAEJ.GetHorarioContratual(linha, validarPortaria);
                    break;
                case "05": //Marcações
                    MarcacoesAEJ.GetMarcacoes(linha, validarPortaria);
                    break;
                case "06": //Identificação da matrícula do vínculo no eSocial, para empregados com mais de um vínculo no AEJ
                    VinculoeSocialAEJ.GetVinculoeSocial(linha, validarPortaria);
                    break;
                case "07": //Ausências e Banco de Horas
                    AusenciaBancoHorasAEJ.GetAusenciaBancoHoras(linha, validarPortaria);
                    break;
                case "08": //Identificação do PTRP (Programa de Tratamento de Registro de Ponto)
                    IdentificacaoPTRPAEJ.GetIdentificacaoPTRP(linha, validarPortaria);
                    break;
                case "99": //Trailer
                    TrailerAEJ.GetTrailer(linha, validarPortaria);
                    break;
                default:
                    MessageBox.Show($"Tipo de registro inválido: {itemLinha}");
                    break;
            }
        }
    }
}
