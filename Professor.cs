using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEscola
{
    internal class Professor
    {
        private int id;
        private string nome, cpf, telefone, disciplina, escolaridade;
        private DateTime dtAdimissao;
        private char turno;
        public void SetId(int idProfessor)
        {
            this.id = idProfessor;
        }
        public int GetId()
        {
            return this.id;
        }
        public void SetNome(string n)
        {
            this.nome = n;
        }
        public string GetNome()
        {
            return this.nome;
        }
        public void SetCpf(string c)
        {
            this.cpf = c;
        }
        public string GetCpf()
        {
            return this.cpf;
        }
        public void SetTelefone(string tel)
        {
            this.telefone = tel;
        }
        public string GetTelefone()
        {
            return this.telefone;
        }
        public void SetDisciplina(string disci)
        {
            this.disciplina = disci;
        }
        public string GetDisciplina()
        {
            return this.disciplina;
        }
        public void SetEscolaridade(string escol)
        {
            this.escolaridade = escol;
        }
        public string GetEscolaridade()
        {
            return this.escolaridade;
        }
        public void SetDtAdmissao(DateTime data)
        {
            this.dtAdimissao = data;
        }
        public DateTime GetDtAdmissao()
        {
            return this.dtAdimissao;
        }
        public void SetTurno(char tur)
        {
            this.turno = tur;
        }
        public char GetTurno()
        {
            return this.turno;
        }
        Conexao bd = new Conexao();
        public void inserirProfessor()
        {
            string inserir = $"insert into tblprofessores values (null,'{this.nome}','{this.dtAdimissao.ToString("yyyy/MM/dd")}','{this.cpf}', '{this.telefone}','{this.disciplina}','{this.turno}','{this.escolaridade}');";
            bd.ExecutarComando(inserir);
        }
        public void AlterarProfessor()
        {
            string alterar = $"update tblprofessores set nome = '{this.nome}',dtAdmissao = '{this.dtAdimissao.ToString("yyyy/MM/dd")}', cpf = '{this.cpf}', telefone = '{this.telefone}',disciplina = '{this.disciplina}',turno = '{this.turno}',escolaridade = '{this.escolaridade}' WHERE id = '{this.id}'";
            bd.ExecutarComando(alterar);
        }
        public void ExcluirProfessor()
        {
            string deletar = $"delete from tblprofessores where id = '{this.id}'";
            bd.ExecutarComando(deletar);
        }
        public DataTable ListarProfessores()
        {
            string query = "SELECT * FROM tblprofessores ORDER BY nome;";
            return bd.ExecutarConsulta(query);
        }
    }
}
