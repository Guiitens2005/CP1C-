using System;

namespace CP1C
{
   
    public class EntregadorMoto : FuncionarioTransporte
    {
        
        public string Regiao { get; private set; }
        public string PlacaMoto { get; private set; }

        
        public EntregadorMoto(string nome, string registro, string regiao, string placaMoto)
            : base(nome, registro)
        {
            Regiao = regiao;
            PlacaMoto = placaMoto;
        }

        
        public override void MostrarDetalhes()
        {
            

            Console.WriteLine($"[ENTREGADOR]: {Nome} | Registro: {Registro} | Região: {Regiao} | Placa: {PlacaMoto}");
        }
    }
}