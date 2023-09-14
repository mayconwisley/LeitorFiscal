using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace LeitorAEJ.Model.Ultil;

public static class ValidacaoTamanhoDado
{
    public static List<string> ErrosValidacao { get; } = new List<string>();

    public static bool ValidarTamanho<T>(T objeto)
    {
        var validarResultados = new List<ValidationResult>();
        var validarContexto = new ValidationContext(objeto, null, null);

        if (Validator.TryValidateObject(objeto, validarContexto, validarResultados, true))
        {
            return true;
        }
        else
        {
            foreach (ValidationResult validarResultado in validarResultados)
            {
                ErrosValidacao.Add(validarResultado.ErrorMessage!);
            }
            return false;
        }
    }
    public static bool ValidarTipoDados<T>(T objeto)
    {
        var camposComErro = new List<string>();

        foreach (PropertyInfo prop in typeof(T).GetProperties())
        {
            if (prop.PropertyType == typeof(int) || prop.PropertyType == typeof(double))
            {
                if (!ValidarTipoNumero(prop.GetValue(objeto)))
                {
                    camposComErro.Add(prop.Name);
                }
            }
            else if (prop.PropertyType == typeof(DateTime))
            {
                if (!ValidarTipoData(prop.GetValue(objeto)))
                {
                    camposComErro.Add(prop.Name);
                }
            }
        }

        if (camposComErro.Count == 0)
        {
            return true;
        }
        else
        {
            ErrosValidacao.Add($"Erro de tipo de dados nos campos: {string.Join(", ", camposComErro)}");
            return false;
        }
    }

    private static bool ValidarTipoNumero(object valor)
    {
        if (valor == null)
        {
            return false;
        }

        return valor is int || valor is double;
    }

    private static bool ValidarTipoData(object valor)
    {
        if (valor == null)
        {
            return false;
        }

        return valor is DateTime;
    }

}
