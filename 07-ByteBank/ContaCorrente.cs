//using _05_ByteBank;

namespace _07_ByteBank
{

    public class ContaCorrente
    {
        public Cliente Titular { get; set; }

        //static quer dizer que o valor atraibuído á variável é compartilhada com todos os membros da classe, e não só com um objeto individual
        //Exemplo: nome = Gabriela quer dizer que esse valor atribuído ao nome só está relacionado ao objeto Gabriela
        //TotalDeContasCriadas = 2, que dizer que esse valor 2 estará associado á todos os objetos, tanto para a Gabriela, quanto para o João
        //Apenas a variável set está como privada, pois esse valor não pode ser alterados fora dessa classe. Esse valor somente pode ser consultado(get)
        public static int TotalDeContasCriadas { get; private set; }

        private int _agencia;
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                _agencia = value;
            }
        }
        public int Numero { get; set; }

        private double _saldo = 100; //encapsulamos a variavel saldo

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

        //Torna a agencia e o numero obrigatórios ao chamar a ContaCorrente
        //Isso é um construtor. Ele não retorna nenhum tipo de dado específico e sempre tem o mesmo nome da classe
        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
        }

        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            return true;

        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;

        }
    }
}