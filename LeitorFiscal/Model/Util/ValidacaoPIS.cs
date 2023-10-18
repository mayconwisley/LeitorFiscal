namespace LeitorFiscal.Model.Util;

public class ValidacaoPIS
{
   public static bool Validar(string pis)
    {
        // Remover caracteres não numéricos
        string cleanPIS = new string(pis.ToCharArray(), 0, 11);

        if (cleanPIS.Length != 11)
        {
            return false; // O PIS deve ter 11 dígitos
        }

        int[] weights = { 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
        int sum = 0;

        for (int i = 0; i < 10; i++)
        {
            sum += (cleanPIS[i] - '0') * weights[i];
        }

        int remainder = 11 - (sum % 11);
        remainder = (remainder == 10 || remainder == 11) ? 0 : remainder;

        return remainder == (cleanPIS[10] - '0');
    }
}
