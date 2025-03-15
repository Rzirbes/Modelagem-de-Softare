using aula05;


Aluno aluno = new Aluno(nome: "Rômulo", matricula: 234234, idade: 28);

aluno.ExibirDetalhes();


Livro livro = new Livro(titulo: "Harry Potter", autor: "JK Rowling", anoPublicacao: "2001");

livro.ExixbirDetalhes();

Praia praia = new Praia
(
    nome: "Arroio do Sal",
    localizacao: "Rio Grande Do Sul",
    temperaturaMedia: 30,
    temQuiosque: false
);

praia.ExibirPraia();


Voo voo = new Voo("1234", "Latam", "Porto Alegre", "São Paulo", new DateTime(2024, 3, 15, 14, 30, 0));

voo.ExibirDetalhes();