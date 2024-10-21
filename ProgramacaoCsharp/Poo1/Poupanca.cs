using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo1
{
    public class Poupanca : Conta
    {
        public Poupanca(string proprietario, int saldo) : base(proprietario, saldo)
        {
        }

        public override void Deposito(int valor) //override é usado para sobrescever um metodo
        {
            base.Deposito(valor + 5);
        }
    }
}
