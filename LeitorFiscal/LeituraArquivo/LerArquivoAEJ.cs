using LeitorFiscal.AEJ;
using LeitorFiscal.Model.Util;
using System.Text;

namespace LeitorFiscal.LeituraArquivo;

public class LerArquivoAEJ
{
    public static void Arquivo(string caminho)
    {
        using StreamReader sr = new(caminho, Encoding.Latin1, true, 1024 * 1024 * 1);
        string? linha;

        int contaCabecalho = 0, contaReps = 0, contaVinculo = 0, contaHorarioContrato = 0;
        int contaMacacoes = 0, contaVinculoeSocial = 0, contaAusenciaBancoHoras = 0, contaIdentificadorPTRP = 0;
        CabecalhoAEJ.CabecalhoAEJList.Clear();
        CabecalhoAEJ.ErrosValidacao.Clear();
        REPsUtilizadosAEJ.REPsUtilizadosAEJList.Clear();
        REPsUtilizadosAEJ.ErrosValidacao.Clear();
        VinculosAEJ.VinculosAEJList.Clear();
        VinculosAEJ.ErrosValidacao.Clear();
        HorarioContratualAEJ.HorarioContratualAEJList.Clear();
        HorarioContratualAEJ.ErrosValidacao.Clear();
        MarcacoesAEJ.MarcacoesAEJList.Clear();
        MarcacoesAEJ.ErrosValidacao.Clear();
        VinculoeSocialAEJ.VinculoeSocialAEJList.Clear();
        VinculoeSocialAEJ.ErrosValidacao.Clear();
        AusenciaBancoHorasAEJ.AusenciaBancoHorasAEJList.Clear();
        AusenciaBancoHorasAEJ.ErrosValidacao.Clear();
        IdentificacaoPTRPAEJ.IdentificacaoPTRPAEJList.Clear();
        IdentificacaoPTRPAEJ.ErrosValidacao.Clear();
        TrailerAEJ.TrailerAEJList.Clear();
        TrailerAEJ.ErrosValidacao.Clear();
        ValidacaoTamanhoDado.ErrosValidacao.Clear();

        while ((linha = sr.ReadLine()) != null)
        {
            string itemLinha = linha[..2];

            switch (itemLinha)
            {
                case "01": //Cabeçalho
                    contaCabecalho++;
                    CabecalhoAEJ.GetCabecalhos(linha);
                    break;
                case "02": //REPs Utilizados
                    contaReps++;
                    REPsUtilizadosAEJ.GetREPsUtilizados(linha);
                    break;
                case "03": //Vinculos
                    contaVinculo++;
                    VinculosAEJ.GetVinculos(linha);
                    break;
                case "04": //Horário contratual
                    contaHorarioContrato++;
                    HorarioContratualAEJ.GetHorarioContratual(linha);
                    break;
                case "05": //Marcações
                    contaMacacoes++;
                    MarcacoesAEJ.GetMarcacoes(linha);
                    break;
                case "06": //Identificação da matrícula do vínculo no eSocial, para empregados com mais de um vínculo no AEJ
                    contaVinculoeSocial++;
                    VinculoeSocialAEJ.GetVinculoeSocial(linha);
                    break;
                case "07": //Ausências e Banco de Horas
                    contaAusenciaBancoHoras++;
                    AusenciaBancoHorasAEJ.GetAusenciaBancoHoras(linha);
                    break;
                case "08": //Identificação do PTRP (Programa de Tratamento de Registro de Ponto)
                    contaIdentificadorPTRP++;
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

        if (TrailerAEJ.ValidarResgistrosAEJ(contaCabecalho, contaReps, contaVinculo, contaHorarioContrato, contaMacacoes, contaVinculoeSocial, contaAusenciaBancoHoras, contaIdentificadorPTRP))
        {
            MessageBox.Show("Não foi possivel validar a quantidade de registros!\nVeja a guia 99 - Trailer", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
        }
    }
}
