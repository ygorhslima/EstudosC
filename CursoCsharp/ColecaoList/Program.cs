class Program
{
    public static void Main(string[] args)
    {
        List<string> carros = new List<string>();
        string[] carros2 = new string[10];

        carros.Add("Golf");
        carros.Add("HRV");
        carros.Add("Focus");
        carros.Add("Argo");
        
        /*
        carros.Add(carros2);
        carros.Clear();
        */

        if (carros.Contains("Golf"))
        {
            Console.WriteLine("Esta na lista");
        }
        else
        {
            Console.WriteLine("Não encontrado");
        }

        carros.CopyTo(carros2 ,2);

        foreach (var item in carros)
        {
            Console.WriteLine($"Carro: {item}");
        }

        string ca = "HRV";
        int pos = carros.IndexOf(ca);
        Console.WriteLine($"carro {ca} está na posição {pos}");

    }
}