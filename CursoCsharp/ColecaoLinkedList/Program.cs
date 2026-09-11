class Program
{
    public static void Main(string[] args)
    {
        LinkedList<string> transp = new LinkedList<string>();

        // AddFirst adiciona o elemento no inicio da lista
        transp.AddFirst("Carro");
        transp.AddFirst("Aviao");
        transp.AddFirst("Navio");
        transp.AddFirst("Motocicleta");

        // AddLast adiciona o elemento no final da lista
        transp.AddLast("Moto");

        LinkedListNode<string> no;
        no = transp.FindLast("Navio");
        transp.AddAfter(no,"Patinete");

        if(transp.Find("Carro") == null)
        {
            Console.WriteLine("Não encontrado");
        }
        else
        {
            Console.WriteLine("Elemento encontrado");
        }

        foreach (var item in transp)
        {
            Console.WriteLine(item);
        }

    }
}
