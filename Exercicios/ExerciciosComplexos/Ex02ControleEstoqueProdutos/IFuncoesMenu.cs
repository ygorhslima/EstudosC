interface IFuncoesMenu
{
    void ListarProdutosComMaioresPrecos(List<Produto> produtos);
    void VerTodosOsProdutos(List<Produto> produtos);
    void Lin(string TipoLinha);
    void Menu();
    void AdicionarNovoProduto(List<Produto> produtos);
    void ListarProdutosPelaCategoria(List<Produto> produtos);
}