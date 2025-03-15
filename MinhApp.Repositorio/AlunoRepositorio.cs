using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhApp.Repositorio
{
    public class AlunoRepositorio : IAlunoRepositorio
    {
        public List<Aluno> _alunos = new List<Aluno>();

        public void Salvar(Aluno aluno)
        {
           _alunos.Add(aluno);
        }
    }
}
