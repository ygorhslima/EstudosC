interface IFuncoesMenuGestaoContato
{
    public void Lin(string TipoLinha);
    public void Menu();
    public void AdicionarDados(List<Contato> contatos);
    public void BuscarContatoPeloNome(List<Contato> contatos);
    public void VerTodosOsContatos(List<Contato> contatos);
    
}