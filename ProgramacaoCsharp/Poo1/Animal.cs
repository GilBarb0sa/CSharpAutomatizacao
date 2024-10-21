using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo1
{
    public class Animal
    {
        public int Idade { get; set; }
        public string Nome { get; set; }
        public Animal(int idade, string nome)
        {
            Idade = idade;
            Nome = nome;
        }
    }
}
