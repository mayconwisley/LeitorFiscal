namespace LeitorAEJ.Model.ListarDados;

public static class Vinculos
{
    public static List<VinculoCombox> Listar()
    {
        var lista = VinculosAEJ.VinculosAEJList
            .Select(s => new VinculoCombox
            {
                IdtVinculoAej = s.IdtVinculoAej,
                NomeEmpregado = s.CPF + " - " + s.NomeEmp
            }).ToList();

        return lista;
    }
}
