using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Infraestrutura
{
    public class AlunoRepository
    {
        private readonly DbConnection _context = new DbConnection();
        public void Add(Aluno aluno)
        {
            _context.Alunos.Add(aluno);  //utilização do Entity para cadastrar alunos
            _context.SaveChanges();
        }

        public List<Aluno> Get()
        {
            return _context.Alunos.ToList();  //utilização do Entity para retornar uma lista de alunos cadastrados

        }
    }
}
