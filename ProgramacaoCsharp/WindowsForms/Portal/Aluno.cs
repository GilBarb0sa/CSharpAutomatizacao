using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal
{
    [Table("alunos")]
    public class Aluno
    {
        [Key]
        public int id { get; private set; }
        public string nome { get; private set; }
        public int idade { get; private set; }
        public string curso { get; private set; }

        public Aluno() { }

        public Aluno(string nome, string idade, string curso)
        {
            if (string.IsNullOrEmpty(nome))
            {
                throw new Exception("Nome é obrigatório!");
            }

            if (string.IsNullOrEmpty(idade))
            {
                throw new Exception("Idade é obrigatório!");
            }

            if (string.IsNullOrEmpty(curso))
            {
                throw new Exception("Curso é obrigatório!");
            }

            this.nome = nome;
            this.idade = int.Parse(idade);
            this.curso = curso;
        }
    }
}
