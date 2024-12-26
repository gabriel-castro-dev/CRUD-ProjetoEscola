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
    public partial class FrmProfessor : Form
    {
        public FrmProfessor()
        {
            InitializeComponent();
        }
        Conexao db = new Conexao();
        Professor dadosProfessor = new Professor();
        private void ArmazenarDados()
        {
            char turnoProfessor = rdbManha.Checked ? 'M' : rdbTarde.Checked ? 'T' : 'N';
            dadosProfessor.SetCpf(txtCPF.Text);
            dadosProfessor.SetDisciplina(cmbDisciplina.Text);
            dadosProfessor.SetNome(txtNome.Text);
            dadosProfessor.SetTelefone(txtTelefone.Text);
            dadosProfessor.SetEscolaridade(cmbEscolaridade.Text);
            dadosProfessor.SetTurno(turnoProfessor);
            dadosProfessor.SetDtAdmissao(dtpDataAdm.Value);
        }
        private void LimparDados()
        {
            txtCPF.Clear();
            txtID.Clear();
            txtNome.Clear();
            txtTelefone.Clear();
            cmbDisciplina.Text = "";
            rdbManha.Checked = false;
            rdbNoite.Checked = false;
            rdbTarde.Checked = false;
        }
        private void FrmProfessor_Load(object sender, EventArgs e)
        {
            ExibirDados();
        }

        private void ExibirDados()
        {
            dtgProfessor.DataSource = dadosProfessor.ListarProfessores();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ArmazenarDados();
            dadosProfessor.inserirProfessor();
            MessageBox.Show("Dados do novo professor foram cadastrados com sucesso.");
            ExibirDados();
            LimparDados();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            dadosProfessor.SetId(int.Parse(txtID.Text));
            ArmazenarDados();
            dadosProfessor.AlterarProfessor();
            MessageBox.Show("Dados do professor foram alterados com sucesso.");
            ExibirDados();
            LimparDados();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            dadosProfessor.SetId(int.Parse(txtID.Text));
            dadosProfessor.ExcluirProfessor();
            MessageBox.Show("Dados do professor foram excluidos com sucesso.");
            ExibirDados();
            LimparDados();
        }

        private void dtgProfessor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dtgProfessor.Rows[e.RowIndex].Cells["id"].Value.ToString();
            txtNome.Text = dtgProfessor.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            txtCPF.Text = dtgProfessor.Rows[e.RowIndex].Cells["cpf"].Value.ToString();
            txtTelefone.Text = dtgProfessor.Rows[e.RowIndex].Cells["telefone"].Value.ToString();
            dtpDataAdm.Value = DateTime.Parse(dtgProfessor.Rows[e.RowIndex].Cells["dtAdmissao"].Value.ToString());
            cmbDisciplina.Text = dtgProfessor.Rows[e.RowIndex].Cells["disciplina"].Value.ToString();
            cmbEscolaridade.Text = dtgProfessor.Rows[e.RowIndex].Cells["escolaridade"].Value.ToString();
            rdbManha.Checked = dtgProfessor.Rows[e.RowIndex].Cells["turno"].Value.ToString() == "M" ? true : false;
            rdbTarde.Checked = dtgProfessor.Rows[e.RowIndex].Cells["turno"].Value.ToString() == "T" ? true : false;
            rdbNoite.Checked = dtgProfessor.Rows[e.RowIndex].Cells["turno"].Value.ToString() == "N" ? true : false;
        }
    }
}
