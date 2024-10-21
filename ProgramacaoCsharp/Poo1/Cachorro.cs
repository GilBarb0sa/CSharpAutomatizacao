using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo1
{
    public class Cachorro : Animal
    {
        public string Apelido { get; set; }
        public Cachorro(int idade, string nome) : base(idade, nome)
        {
        }        
    }
}
