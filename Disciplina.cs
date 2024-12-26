using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEscola
{
    internal class Disciplina
    {
        private int id, cargaHoraria;
        private string nome;
        public void SetId(int idDisciplina)
        {
            this.id = idDisciplina;
        }
        public int GetId()
        {
            return this.id;
        }
        public void SetCargahoraria(int cargaH)
        {
            this.cargaHoraria = cargaH;
        }
        public int GetCargahoraria()
        {
            return this.cargaHoraria;
        }
        public void SetNome(string n)
        {
            this.nome = n;
        }
        public string GetNome()
        {
            return this.nome;
        }
        Conexao bd = new Conexao();
        public void inserirdisciplina()
        {
            string inserir = $"insert into tbldisciplinas values (null,'{this.nome}','{this.cargaHoraria}');";
            bd.ExecutarComando(inserir);
        }
        public void AlterarDisciplina()
        {
            string alterar = $"update tbldisciplinas set nome = '{this.nome}',cargaH = '{this.cargaHoraria}', WHERE id = '{this.id}'";
            bd.ExecutarComando(alterar);
        }
        public void ExcluirDisciplina()
        {
            string deletar = $"delete from tbldisciplinas where id = '{this.id}'";
            bd.ExecutarComando(deletar);
        }
        public DataTable ListarDisciplina()
        {
            string query = "SELECT * FROM tbldisciplinas ORDER BY nome;";
            return bd.ExecutarConsulta(query);
        }
    }
}
