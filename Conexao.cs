using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace ProjetoEscola
{
    internal class Conexao
    {
        MySqlConnection conn;
        private void conectar()
        {
            string dadosConexao = "Persist Security info = false; server = localhost; database = DBEscola; user = root; pwd=; ";
            conn = new MySqlConnection(dadosConexao);
            conn.Open();
        }
        public DataTable ExecutarConsulta(string query)
        {
            conectar();
            MySqlDataAdapter dados = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            dados.Fill(dt);
            conn.Close();
            return dt;
        }
        public void ExecutarComando(string sql)
        {
            conectar();
            MySqlCommand comando = new MySqlCommand(sql, conn);
            comando.ExecuteNonQuery();
            conn.Close();
        }
    }
}
