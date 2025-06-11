namespace LeitorFiscal.Model.Empregado;

public class Empregado
{
	public int Id { get; set; }
	public string Nome { get; set; } = string.Empty;
	public string PisCpf { get; set; } = string.Empty;
	public int QtdMarcacoes { get; set; }
}
