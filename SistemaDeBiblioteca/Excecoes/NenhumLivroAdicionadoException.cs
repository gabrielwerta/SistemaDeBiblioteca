namespace SistemaDeBiblioteca.Excecoes;

public class NenhumLivroAdicionadoException : Exception
{
    public NenhumLivroAdicionadoException(string mensagem) : base(mensagem)
    {
        
    }
}