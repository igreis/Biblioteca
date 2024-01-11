using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V2_Biblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno(textAluno.Text, textCpf.Text,textMatricula.Text);
            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.ConnString();

            NpgsqlConnection conn = new NpgsqlConnection(conexao); // Cria uma conexao com o BD

            conn.Open();

            string commandText = String.Format("INSERT INTO aluno(nome, cpf, matricula)" +
                "values('{0}','{1}','{2}')", aluno.Alunos, aluno.Cpf, aluno.Matricula);
              

            using (NpgsqlCommand comando = new NpgsqlCommand(commandText, conn))
            {
                comando.ExecuteNonQuery();
            }

            conn.Close();

            MessageBox.Show("Cadastro Inserido com Sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void dgvDados_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textAluno.Text = Convert.ToString(dgvDados.Rows[e.RowIndex].Cells[1].Value);
            textCpf.Text = Convert.ToString(dgvDados.Rows[e.RowIndex].Cells[2].Value);
            textMatricula.Text = Convert.ToString(dgvDados.Rows[e.RowIndex].Cells[3].Value);
        }
        private void btn_Click(object sender, EventArgs e)
        {
            ExibirDados();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExibirDados();
            LimparTextBox();
        }

        void ExibirDados()
        {
            {
                ConexaoString stringConexao = new ConexaoString();

                string conexao = stringConexao.ConnString();

                NpgsqlConnection conn = new NpgsqlConnection(conexao); // Cria uma conexao com o BD

                conn.Open(); // Abre a conexao com o BD

                DataTable dt = new DataTable(); // Objeto que pode conter tabelas string

                string commandText = "SELECT * FROM aluno ORDER BY id_aluno";

                using (NpgsqlDataAdapter adpt = new NpgsqlDataAdapter(commandText, conn)) // faz a ligacao entre o BD e o DataTable
                {
                    adpt.Fill(dt);
                }

                dgvDados.DataSource = dt;

                conn.Close(); // Fecha a conexao com o BD
            }
        }

            void LimparTextBox()
            {
                textAluno.Text = string.Empty;
                textCpf.Text = string.Empty;
                textMatricula.Text = string.Empty;
            }

        private void button4_Click(object sender, EventArgs e)
        {
            string cpf = textCpf.Text;

            ConexaoString stringConexao = new ConexaoString();

            string conexao = stringConexao.ConnString();

            NpgsqlConnection conn = new NpgsqlConnection(conexao); // Cria uma conexao com o BD

            conn.Open(); // Abre a conexao com o BD

            //string commandText = string.Format(
            //    "DELETE FROM aluno" +
            //    " WHERE cpf_cliente = '{0}'", cpf);

            string commandText =
                $"DELETE FROM aluno" +
                $" WHERE cpf = '{cpf}'";

            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, conn))
            {
                pgsqlcommand.ExecuteNonQuery();
            }

            conn.Close();

            MessageBox.Show("Cadastro Excluído com Sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            ExibirDados();

            LimparTextBox();
        }

        private void txtinserirlivros_Click(object sender, EventArgs e)
        {

        }

        private void txtexibirlivros_Click(object sender, EventArgs e)
        {

        }

        private void txtatualizarlivros_Click(object sender, EventArgs e)
        {

        }

        private void txtexcluirlivros_Click(object sender, EventArgs e)
        {

        }

        private void txtexibiremprestimo_Click(object sender, EventArgs e)
        {

        }
    }
}
