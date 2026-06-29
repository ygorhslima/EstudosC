public class Produto
{
    public string Nome { get; set; } = "";
    public float Preco
    {
        get;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("ERRO! o preço deve ser maior que 0");
            }
            else
            {
                field = value;
            }
        }
    }
    public int QuantidadeEmEstoque
    {
        get;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("ERRO! a quantidade em estoque deve ser maior que 0");
            }
            else
            {
                field = value;
            }
        }
    }
}