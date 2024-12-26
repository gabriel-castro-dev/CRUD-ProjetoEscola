using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEscola
{
    public partial class frmAlunos : Form
    {
        public frmAlunos()
        {
            InitializeComponent();
        }
        Conexao bd = new Conexao();
        Aluno dadosAlunos = new Aluno();
        private void ExibirDados()
        {
            dtgAlunos.DataSource = dadosAlunos.ListarAlunos(); 
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAlunos_Load(object sender, EventArgs e)
        {
            ExibirDados();
        }
        private void ArmazenarDados()
        {
            char unidadeAluno = rdbBarroca.Checked ? 'B' : rdbFloresta.Checked ? 'F' : ' ';
            int serieAluno = rdb1Serie.Checked ? 1 : rdb2Serie.Checked ? 2 : rdb3Serie.Checked ? 3 : 0;
            dadosAlunos.SetNome(txtNome.Text);
            dadosAlunos.SetIdade(int.Parse(txtIdade.Text));
            dadosAlunos.SetTurma(char.Parse(cmbTurma.Text));
            dadosAlunos.SetSerie(serieAluno);
            dadosAlunos.SetUnidade(unidadeAluno);

        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ArmazenarDados();
            dadosAlunos.inserirAlunos();
            MessageBox.Show("Dados do novo aluno foram cadastrados com sucesso.");
            ExibirDados();
            LimparDados();
        }
        private void LimparDados()
        {
            txtID.Clear();
            txtIdade.Clear();
            txtNome.Clear();
            cmbTurma.Text = "";
            rdb1Serie.Checked = false;
            rdb2Serie.Checked = false;
            rdb3Serie.Checked = false;
            rdbBarroca.Checked = false;
            rdbFloresta.Checked = false;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            dadosAlunos.SetId(int.Parse(txtID.Text));
            ArmazenarDados();
            dadosAlunos.AlterarAluno();
            MessageBox.Show("Dados do aluno foram alterados com sucesso.");
            ExibirDados();
            LimparDados();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            dadosAlunos.SetId(int.Parse(txtID.Text));
            dadosAlunos.ExcluirAluno();
            MessageBox.Show("Dados do aluno foram excluidos com sucesso.");
            ExibirDados();
            LimparDados();
        }

        private void dtgAlunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dtgAlunos.Rows[e.RowIndex].Cells["id"].Value.ToString();
            txtNome.Text = dtgAlunos.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            txtIdade.Text = dtgAlunos.Rows[e.RowIndex].Cells["idade"].Value.ToString();
            cmbTurma.Text = dtgAlunos.Rows[e.RowIndex].Cells["turma"].Value.ToString();
            if(dtgAlunos.Rows[e.RowIndex].Cells["turma"].Value.ToString() == "B")
            {
                rdbBarroca.Checked = true;
            }
            else if (dtgAlunos.Rows[e.RowIndex].Cells["turma"].Value.ToString() == "F")
            {
                rdbFloresta.Checked = true;
            }

            rdb1Serie.Checked = dtgAlunos.Rows[e.RowIndex].Cells["serie"].Value.ToString() == "1" ? true : false;
            rdb2Serie.Checked = dtgAlunos.Rows[e.RowIndex].Cells["serie"].Value.ToString() == "2" ? true : false;
            rdb3Serie.Checked = dtgAlunos.Rows[e.RowIndex].Cells["serie"].Value.ToString() == "3" ? true : false;
        }
    }
}
