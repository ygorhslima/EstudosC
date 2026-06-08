namespace Exercicios.Ex108;


public class Moeda
{
    public float Aumentar(float preco, float taxa)
    {
        float res = preco + (preco * taxa/100);
        return res;
    }
    public float Diminuir(float preco, float taxa)
    {
        float res = preco - (preco * taxa/100);
        return res;
    }
    public float Dobro(float preco)
    {
        float res = preco * 2;
        return res;
    }
    public float Metade(float preco)
    {
        float res = preco / 2;
        return res;
    }

    public string MoedaFormatacao(float preco, string moeda = "R$")
    {
        return $"{moeda}{preco}";
    }
}