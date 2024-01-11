using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V2_Biblioteca
{
    internal class Emprestimo
    {
        private int codAluno;
        private int codLivro;
        private string dataEmprestimo;
        private string dataDevolucao;

        public int CodAluno { get => codAluno; set => codAluno = value; }
        public int CodLivro { get => codLivro; set => codLivro = value; }
        public string DataEmprestimo { get => dataEmprestimo; set => dataEmprestimo = value; }
        public string DataDevolucao { get => dataDevolucao; set => dataDevolucao = value; }

        public Emprestimo(int codAluno, int codLivro, string dataEmprestimo, string dataDevolucao) 
        {
            CodAluno = codAluno;
            CodLivro = codLivro;
            DataEmprestimo = dataEmprestimo;
            DataDevolucao = dataDevolucao;

        }
    }
}
