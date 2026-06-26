using Aula09;


var p = new List<Pessoa>
{
    new("João",20,"M"),
    new("Maria",20,"F") 
};

var l = new List<Livro>
{
    new("Aprendendo Java", "José da silva", 300, p[0]),
    new("Java Avançado", "Maria Candido", 800, p[1]),
    new("POO para iniciantes", "Pedro Paulo", 500, p[0])
};

Console.WriteLine(l[0].Detalhes());