using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo1
{
    public class Conta
    {
        public int Numero { get; private set; }
        public string Proprietario { get; private set; }
        public int Saldo { get; private set; }

        public Conta(string proprietario, int saldo)
        {
            Proprietario = proprietario;
            Saldo = saldo;
        }

        public virtual void Deposito(int valor) // void retorna um valor vazio, virtual sobrescreve um metodo em outra classe que esta herdando ela
        {
            Saldo += valor;
        }

        public void Saque(int valor) 
        {
            if (valor > Saldo)
            {
                throw new Exception("Saldo Insuficiente!");
            }
            Saldo -= valor;           
        }
    }
}
