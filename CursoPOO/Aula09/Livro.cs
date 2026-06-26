using System;

namespace Aula09;

public class Livro(
    string titulo,
    string autor,
    int totPaginas,
    Pessoa leitor
) : Publicacao
{
    string Titulo = titulo;
    string Autor = autor;
    int TotPaginas = totPaginas;
    int PagAtual;
    bool Aberto;
    Pessoa Leitor = leitor;

    public void Abrir()
    {
        Aberto = true;
    }

    public void Fechar()
    {
        Aberto = false;
    }

    public void AvancarPag()
    {
        PagAtual++;
    }

    public void VoltarPag()
    {
        PagAtual++;
    }   

    public string Detalhes()
    {
        return $"Título: {Titulo}\nAutor: {Autor}\nTotPaginas: {TotPaginas}\nPagAtual: {PagAtual}\nAberto: {Aberto}\nLeitor: {Leitor.Nome}";
    }

    public void Folhear(int p)
    {
        PagAtual = p;
    }
}
