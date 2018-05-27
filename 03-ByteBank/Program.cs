using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
            contaDaGabrielaCosta.titular = "Gabriela";
            contaDaGabrielaCosta.agencia = 863;
            contaDaGabrielaCosta.numero = 863452;

            //por mais que as referencias são do mesmo tipo, elas apontam para diferentes objetos guardados na memoria do pc
            Console.WriteLine("Igualdade de tipo de referencia: " + (contaDaGabriela == contaDaGabrielaCosta));

            int idade = 27;
            int idade2 = 27;

            Console.WriteLine("Igualdade do tipo de valor: " + (idade == idade2));

            contaDaGabriela = contaDaGabrielaCosta;
            Console.WriteLine("Igualdade do tipo de valor: " + (contaDaGabriela == contaDaGabrielaCosta));

            contaDaGabriela.saldo = 300;
            Console.WriteLine(contaDaGabriela.saldo);
            Console.WriteLine(contaDaGabrielaCosta.saldo);

            if (contaDaGabriela.saldo >= 100)
            {
                contaDaGabriela.saldo -= 100;
            }

            Console.Read();
        }
    }
}
