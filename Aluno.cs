using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V2_Biblioteca
{
    internal class Aluno
    {
        private string alunos;
        private string cpf;
        private string matricula;

        public string Alunos { get => alunos; set => alunos = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Matricula { get => matricula; set => matricula = value; }

        public Aluno(string alunos, string cpf, string matricula)
        {
            Alunos = alunos;
            Cpf = cpf;
            Matricula = matricula;
        }
    }
}
