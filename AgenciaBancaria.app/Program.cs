using AgenciaBancaria.dominio;
using System;

namespace AgenciaBancaria.app
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Endereco endereco = new Endereco("Rua Teste", "12234", "Pederneiras", "SP");
                Cliente cliente = new Cliente("Carla", "1235456", "458662", endereco);

                ContaCorrente conta = new ContaCorrente(cliente, 100);

                Console.WriteLine("Conta criada: "  + conta.Situacao + ": " + conta.NumeroConta + "-" + conta.DigitoVerificador);

                string senha = "abc123d3";
                conta.Abrir(senha);

                Console.WriteLine("Conta criada: "  + conta.Situacao + ": " + conta.NumeroConta + "-" + conta.DigitoVerificador);

                
                conta.Sacar(10, senha);

                Console.WriteLine("Saldo: " + conta.Saldo);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
