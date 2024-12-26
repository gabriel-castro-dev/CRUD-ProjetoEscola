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
    public partial class FrmDisciplina : Form
    {
        public FrmDisciplina()
        {
            InitializeComponent();
        }
        Conexao db = new Conexao();
        Disciplina dadosDisciplina = new Disciplina();
        private void ArmazenarDados()
        {
            dadosDisciplina.SetCargahoraria(int.Parse(txtCargaHoraria.Text));
            dadosDisciplina.SetNome(txtNome.Text);

        }
        private void LimparDados()
        {
            txtCargaHoraria.Clear();
            txtID.Clear();
            txtNome.Clear();
        }
        private void ExibirDados()
        {
            dtgDisciplina.DataSource = dadosDisciplina.ListarDisciplina();
        }
        private void FrmDisciplina_Load(object sender, EventArgs e)
        {
            ExibirDados();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ArmazenarDados();
            dadosDisciplina.inserirdisciplina();
            MessageBox.Show("Dados da nova disciplina foram cadastrados com sucesso.");
            ExibirDados();
            LimparDados();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            dadosDisciplina.SetId(int.Parse(txtID.Text));
            dadosDisciplina.ExcluirDisciplina();
            MessageBox.Show("Dados do aluno foram excluidos com sucesso.");
            ExibirDados();
            LimparDados();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            dadosDisciplina.SetId(int.Parse(txtID.Text));
            ArmazenarDados();
            dadosDisciplina.AlterarDisciplina();
            MessageBox.Show("Dados do aluno foram alterados com sucesso.");
            ExibirDados();
            LimparDados();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void dtgDisciplina_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dtgDisciplina.Rows[e.RowIndex].Cells["id"].Value.ToString();
            txtNome.Text = dtgDisciplina.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            txtCargaHoraria.Text = dtgDisciplina.Rows[e.RowIndex].Cells["cargaH"].Value.ToString();
        }
    }
}
