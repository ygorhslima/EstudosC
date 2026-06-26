
using Aula12;

public class Program
{
    public static void Main(string[] args)
    {
        //Animal n = new Animal();
        Mamifero m = new(85.3f,2,4, "Castanho");
        Reptil r = new(60f, 10, 4, "Verde");
        Peixe p = new(1,1,3,"Ciano");
        Ave a = new(10, 6, 4, "Branca");
        
        Console.WriteLine(m.ToString());

        m.Alimentar();
        m.Locomover();
        m.EmitirSom();

        r.Alimentar();
        r.Locomover();
        r.EmitirSom();
          
        p.Alimentar();
        p.Locomover();
        p.EmitirSom();
        p.SoltarBolha();

        a.Alimentar();
        a.Locomover();
        a.EmitirSom();
        a.FazerNinho();

    }
}
