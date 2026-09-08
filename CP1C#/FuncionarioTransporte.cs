namespace CP1C
{
class Funcionario
{
    private string nome;

    public string Nome
    {
        get { return Nome; }
        set { nome = value; }
    }


        public Funcionario(string nome) => Nome = nome;


        public virtual void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}");
    }
}
}
