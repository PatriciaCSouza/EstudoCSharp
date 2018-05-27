using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando condicionais");

            int idade = 16;
            int quantidadepessoas = 3;
            bool acompanhado = quantidadepessoas >= 2;

            if (idade >= 18 && acompanhado)
                Console.WriteLine("Seja bem-vindo");

            else
                Console.WriteLine("Infelizmente vcê não pode entrar");
        }
    }
}
