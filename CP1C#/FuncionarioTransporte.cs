using System;

namespace CP1C
{
 
    public abstract class FuncionarioTransporte
    {
        
        public string Nome { get; protected set; }
        public string Registro { get; protected set; }

       
        public FuncionarioTransporte(string nome, string registro)
        {
            Nome = nome;
            Registro = registro;
        }

        
        public virtual void MostrarDetalhes()
        {
            Console.WriteLine($"Nome: {Nome} | Registro: {Registro}");
        }
    }
}