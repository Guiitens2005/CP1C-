namespace CP1C
{

    class Motorista : Funcionario
    {
        public string TipoVeiculo { get; set; }
        public Motorista(string nome, string tipoVeiculo) : base(nome) => TipoVeiculo = tipoVeiculo;
        public override void ExibirInformacoes()
        {
            Console.WriteLine($"[MOTORISTA]: {Nome}, Tipo de Veículo: {TipoVeiculo}");
        }
    }
}