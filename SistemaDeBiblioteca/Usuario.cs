namespace SistemaDeBiblioteca;

public class Usuario
{
    public string Nome { get; set; }
    public string Id_usuario { get; set; }
    public List<Livro> LivrosEmprestados = new List<Livro>();
}