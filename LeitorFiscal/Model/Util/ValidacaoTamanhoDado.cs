﻿using LeitorFiscal.LeituraArquivo;
using System.ComponentModel.DataAnnotations;

namespace LeitorFiscal.Model.Util;

public static class ValidacaoTamanhoDado
{
    public static List<string> ErrosValidacao { get; } = new List<string>();

    public static bool ValidarTamanho<T>(T objeto, string linha)
    {
        var validarResultados = new List<ValidationResult>();
        var validarContexto = new ValidationContext(objeto!, null, null);
        ErrosValidacao.Clear();

        if (Validator.TryValidateObject(objeto!, validarContexto, validarResultados, true))
        {
            return true;
        }
        else
        {
            foreach (ValidationResult validarResultado in validarResultados)
            {
                ErrosValidacao.Add(validarResultado.ErrorMessage! + $"\n\tLinha ({LerArquivoAEJ.NumeroLinha}): {linha}\n");
            }
            return false;
        }
    }
}
