public class Program
{
    public static void Main(string[] args)
    {
        string[] names = ["Fredi","Mariana"];
        /*
        for(int i = 0; i < names.Length; i++)
        {
            Console.WriteLine($"{names[i]}");
        }
        */
        foreach (var item in names)
        {
            Console.WriteLine(item);
        }
    }
}