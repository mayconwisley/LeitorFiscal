﻿using LeitorFiscal.AEJ;

namespace LeitorFiscal.Model.ListarValidacaoAEJ;

public class ValidacaoAusenciaBancoHoras
{
    public static string Listar()
    {
        string validacao = string.Empty;
        foreach (var item in AusenciaBancoHorasAEJ.ErrosValidacao)
        {
            validacao += $"\t{item}";
        }
        return $"Registro 07 - Ausências e Banco de Horas:\n{validacao}\n";
    }
}
