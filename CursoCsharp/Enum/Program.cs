class Program
{
    // enum pode ser utilizado para definir conjunto de valores fixos
    public enum StatusPedido
    {
        Aprovado,
        Pendente,
        Cancelado
    }   
    public static void Main(string[] args)
    {
        StatusPedido pedido = StatusPedido.Aprovado;
        switch (pedido)
        {
            case StatusPedido.Pendente:
                Console.WriteLine("Pendente");
                break;
            case StatusPedido.Cancelado:
                Console.WriteLine("Cancelado");
                break;
            case StatusPedido.Aprovado:
                Console.WriteLine("Aprovado");
                break;
        }
    }    
}