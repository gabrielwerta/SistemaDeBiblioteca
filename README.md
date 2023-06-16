# SistemaDeBiblioteca
Esse é o meu segundo projeto de estudo de POO com o C#. Seguindo nos problemas clássicos, dessa vez me dispus a criar um sistema de gerenciamento de biblioteca seguindo uma documentanção que gerei pelo chatGPT.
Documentação do Sistema de Gerenciamento de Biblioteca
Visão Geral

O Sistema de Gerenciamento de Biblioteca é um aplicativo desenvolvido para facilitar o gerenciamento de livros em uma biblioteca. O sistema permite que os usuários adicionem, removam e busquem livros no acervo, além de fornecer funcionalidades adicionais para melhorar a experiência do usuário.
Funcionalidades

Adicionar livro: Permite aos usuários adicionar um novo livro ao acervo da biblioteca. Os detalhes do livro, como título, autor, editora e número de páginas, devem ser fornecidos durante o processo de adição.
Remover livro: Permite aos usuários remover um livro do acervo da biblioteca. O usuário deve fornecer o identificador único do livro para realizar a remoção.
Buscar livro: Permite aos usuários buscar livros no acervo da biblioteca com base em critérios de pesquisa, como título, autor ou categoria. O sistema retorna uma lista de livros que correspondem aos critérios de busca.
Visualizar detalhes do livro: Permite aos usuários visualizar os detalhes de um livro específico, incluindo título, autor, editora, número de páginas e disponibilidade.
Realizar empréstimo: Permite aos usuários realizar o empréstimo de um livro específico. O sistema registra o usuário que realizou o empréstimo e atualiza a disponibilidade do livro.
Devolver livro: Permite aos usuários devolver um livro emprestado. O sistema atualiza o status do livro para disponível.

Estrutura do Sistema
O sistema é composto pelas seguintes classes:

Livro: Representa um livro no acervo da biblioteca. Possui atributos como título, autor, editora, número de páginas e status de disponibilidade.
Biblioteca: Representa a biblioteca em si. Contém uma coleção de livros e métodos para adicionar, remover e buscar livros no acervo.
Usuário: Representa um usuário do sistema, que pode realizar empréstimos de livros. Possui informações como nome, ID do usuário e histórico de empréstimos.
GerenciadorDeBiblioteca: Classe responsável por coordenar as interações entre as outras classes e fornecer a interface do sistema para os usuários.

Fluxo de Uso
O usuário inicia o sistema de gerenciamento de biblioteca.
O sistema exibe um menu com as opções disponíveis: adicionar livro, remover livro, buscar livro, visualizar detalhes do livro, realizar empréstimo e devolver livro.
O usuário seleciona a opção desejada e fornece os detalhes necessários, como título, autor, ID do livro, critérios de busca, etc.
O sistema executa a operação solicitada pelo usuário, atualiza os dados relevantes e exibe os resultados, quando necessário.
O usuário pode continuar a interagir com o sistema, selecionando outras opções do menu, até que deseje encerrar o programa.

Considerações Finais
Esta documentação fornece uma visão geral do Sistema de Gerenciamento de Biblioteca, descrevendo suas funcionalidades principais e a estrutura das classes envolvidas. Ao desenvolver o sistema, você pode utilizar essa documentação como guia para implementar as funcionalidades descritas e expandir o sistema conforme necessário.
Lembre-se de considerar os princípios da programação orientada a objetos, como encapsulamento, herança e polimorfismo, ao projetar e implementar as classes do sistema.

