using SistemaDeBiblioteca.Excecoes;

namespace SistemaDeBiblioteca;

public class GerenciadorDeBiblioteca
{
    public static void Interface()
    {
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Sistema de Gerenciamento de Biblioteca");
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("[1] Adicionar livro");
        Console.WriteLine("[2] Remover livro");
        Console.WriteLine("[3] Buscar livro");
        Console.WriteLine("[4] Realizar empréstimo");
        Console.WriteLine("[5] Realizar devolução");
        Console.WriteLine("[0] Encerrar");
        Console.WriteLine("--------------------------------------");
        Console.Write("Escolha uma opção:");
        string opcaoMenu = Console.ReadLine();

        do
        {
            switch (opcaoMenu)
            {
                case "1":
                    Biblioteca.AdicionarLivro();
                    break;
                case "2":
                    Biblioteca.RemoverLivro();
                    break;
                case "3":
                    if (Livro.TotalDeLivros > 0)
                    {
                        Biblioteca.BuscarLivro();
                    }
                    else
                    {
                        throw new NenhumLivroAdicionadoException("Não há livros para serem buscados. Adiocione um livro!");
                    }
                    break;
                case "4":
                    Biblioteca.RealizarEmprestimo();
                    break;
                case "5":
                    Biblioteca.RealizarDevolucao();
                    break;
                case "0":
                    Console.WriteLine("Consulta finalizada!");
                    break;
                
            } 
        } while (opcaoMenu != "0");
        
    }
}