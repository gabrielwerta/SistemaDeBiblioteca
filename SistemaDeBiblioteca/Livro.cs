namespace SistemaDeBiblioteca;

public class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string Editora { get; set; }
    public bool Disponibilidade { get; set; }
    public static int TotalDeLivros { get; private set; }

    public Livro()
    {
        TotalDeLivros++;
    }
}