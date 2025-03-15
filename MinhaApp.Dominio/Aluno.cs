using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaApp.Dominio
{
    public class Aluno
    {
        public int id { get; set; }
        public int Nome { get; private set; } //private - apenas essa camda pode editar
        public int Nota { get; private set; }

        public Aluno(string nome, decimal nota) 
        {
            Nome = nome;
            Nota = nota;
        }

        public bool EstaAprovado()
        {
            return Nota > 7;
        }
    }
}
