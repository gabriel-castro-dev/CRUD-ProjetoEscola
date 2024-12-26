using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace ProjetoEscola
{
    internal class Aluno
    {
        private int id, idade, serie;
        private string nome;
        private char unidade, turma;
        public void SetId(int idAluno)
        {
            this.id = idAluno;
        }
        public int GetId()
        {
            return this.id;
        }
        public void SetIdade(int idadeAluno)
        {
            this.idade = idadeAluno;
        }
        public int GetIdade()
        {
            return this.idade;
        }
        public void SetSerie(int serieAluno)
        {
            this.serie = serieAluno;
        }
        public int GetSerie()
        {
            return this.serie;
        }
        public void SetNome(string nomeAluno)
        {
            this.nome = nomeAluno;
        }
        public string GetNome()
        {
            return this.nome;
        }
        public void SetTurma(char turmaAluno)
        {
            this.turma = turmaAluno;
        }
        public char GetTurma()
        {
            return this.turma;
        }
        public void SetUnidade(char unidadeAluno)
        {
            this.unidade = unidadeAluno;
        }
        public char GetUnidade()
        {
            return this.unidade;
        }
        Conexao bd = new Conexao();
        public void inserirAlunos()
        {
            string inserir = $"insert into tblalunos values (null,'{this.nome}', '{this.idade}', '{this.unidade}','{this.serie}','{this.turma}');";
            bd.ExecutarComando(inserir);
        }
        public void AlterarAluno()
        {
            string alterar = $"update tblalunos set nome = '{this.nome}',idade = '{this.idade}',unidade = '{this.unidade}',serie ='{this.serie}', turma = '{this.turma}' WHERE id = '{this.id}'";
            bd.ExecutarComando(alterar);
        }
        public void ExcluirAluno()
        {
            string deletar = $"delete from tblalunos where id = '{this.id}'";
            bd.ExecutarComando(deletar);
        }
        public DataTable ListarAlunos()
        {
            string query = "SELECT * FROM tblalunos ORDER BY nome;";
            return bd.ExecutarConsulta(query);
        }
    }
}
