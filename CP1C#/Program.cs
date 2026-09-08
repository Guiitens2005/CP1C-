using System;
using System.Collections.Generic;

namespace CP1C
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<FuncionarioTransporte> frota = new List<FuncionarioTransporte>();
                int opcao = 0;

                do
                {
                    Console.Clear();
                    Console.WriteLine("=== SISTEMA DE LOGÍSTICA PARA TRANSPORTADORA ===");
                    Console.WriteLine("1- Cadastrar Entregador (Moto)");
                    Console.WriteLine("2- Cadastrar Motorista (Carreta)");
                    Console.WriteLine("3- Exibir todos Cadastros");
                    Console.WriteLine("0- Sair");
                    Console.WriteLine("Escolha uma opção:");

                    string entrada = Console.ReadLine();

                    if (int.TryParse(entrada, out opcao))
                    {
                        switch (opcao)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("--- Cadastro de Entregador (Moto) ---");
                                Console.Write("Digite o nome: ");
                                string nomeEntregador = Console.ReadLine();

                                Console.Write("Digite o registro (Matrícula/ID): ");
                                string regEntregador = Console.ReadLine();

                                Console.Write("Digite a Região de Atuação: ");
                                string regiao = Console.ReadLine();

                                Console.Write("Digite a Placa da Moto: ");
                                string placa = Console.ReadLine();

                               
                                frota.Add(new EntregadorMoto(nomeEntregador, regEntregador, regiao, placa));
                                Console.WriteLine("\nEntregador cadastrado com sucesso!");
                                Console.ReadKey();
                                break;

                            case 2:
                                Console.Clear();
                                Console.WriteLine("--- Cadastro de Motorista (Carreta) ---");
                                Console.Write("Digite o nome: ");
                                string nomeMotorista = Console.ReadLine();

                                Console.Write("Digite o registro (Matrícula/ID): ");
                                string regMotorista = Console.ReadLine();

                                Console.Write("Digite a categoria da CNH: ");
                                string cnh = Console.ReadLine();

                                Console.Write("Digite o tipo de carga (ex: Frigorífica, Seca): ");
                                string tipoCarga = Console.ReadLine();

                                
                                frota.Add(new MotoristaCarreta(nomeMotorista, regMotorista, cnh, tipoCarga));
                                Console.WriteLine("\nMotorista cadastrado com sucesso!");
                                Console.ReadKey();
                                break;

                            case 3:
                                Console.Clear();
                                Console.WriteLine("--- Lista de Frota (Polimorfismo em Ação) ---");
                                if (frota.Count == 0)
                                {
                                    Console.WriteLine("\nNenhum cadastro encontrado.");
                                }
                                else
                                {
                                    
                                    foreach (var pessoa in frota)
                                    {
                                       
                                        pessoa.MostrarDetalhes();
                                    }
                                }
                                Console.WriteLine("\nPressione qualquer tecla para voltar...");
                                Console.ReadKey();
                                break;
                        }
                    }
                } while (opcao != 0);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nErro no sistema: {ex.Message}");
                Console.ReadKey();
            }
        }
    }
}