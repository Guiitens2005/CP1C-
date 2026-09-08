using System;

namespace CP1C
{
   
    public class MotoristaCarreta : FuncionarioTransporte
    {
       
        public string CategoriaCNH { get; private set; }
        public string TipoCarga { get; private set; }

        
        public MotoristaCarreta(string nome, string registro, string categoriaCnh, string tipoCarga)
            : base(nome, registro)
        {
            CategoriaCNH = categoriaCnh;
            TipoCarga = tipoCarga;
        }

        
        public override void MostrarDetalhes()
        {
            Console.WriteLine($"[MOTORISTA DE CARRETA]: {Nome} | Registro: {Registro} | CNH: {CategoriaCNH} | Carga: {TipoCarga}");
        }
    }
}