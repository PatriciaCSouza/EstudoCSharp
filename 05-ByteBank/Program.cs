using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente gabriela = new Cliente();

            gabriela.nome = "Gabriela";
            gabriela.profissao = "Dev C#";
            gabriela.cpf = "433.958.647-06";

            ContaCorrente conta = new ContaCorrente();

            conta.titular = gabriela;
            conta.titular = new Cliente();
            conta.titular.nome = "Gabriela Costa";
            conta.titular.cpf = "433.958.647-06";
            conta.titular.profissao = "Dev C#";

            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 647362;

            if (conta.titular == null)
            {
                Console.WriteLine("Ops, a refereência em conta.titular é nula");
            }

            else
            {
                Console.WriteLine(gabriela.nome);
                Console.WriteLine(conta.titular.nome);
                Console.WriteLine(conta.titular.cpf);
                Console.WriteLine(conta.titular.profissao);
            }

            Console.ReadLine();
        }
    }
}
