namespace ProjetoEscola
{
    partial class FrmProfessor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProfessor));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.pnlDados = new System.Windows.Forms.Panel();
            this.cmbEscolaridade = new System.Windows.Forms.ComboBox();
            this.lblEscolaridade = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.grpTurno = new System.Windows.Forms.GroupBox();
            this.rdbNoite = new System.Windows.Forms.RadioButton();
            this.rdbTarde = new System.Windows.Forms.RadioButton();
            this.rdbManha = new System.Windows.Forms.RadioButton();
            this.dtpDataAdm = new System.Windows.Forms.DateTimePicker();
            this.lblDataAdm = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.cmbDisciplina = new System.Windows.Forms.ComboBox();
            this.pctEscola = new System.Windows.Forms.PictureBox();
            this.pnlID = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dtgProfessor = new System.Windows.Forms.DataGridView();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblDisciplina = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            this.pnlDados.SuspendLayout();
            this.grpTurno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctEscola)).BeginInit();
            this.pnlID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProfessor)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.White;
            this.pnlMenu.Controls.Add(this.btnSair);
            this.pnlMenu.Controls.Add(this.btnPesquisar);
            this.pnlMenu.Controls.Add(this.btnExcluir);
            this.pnlMenu.Controls.Add(this.btnAlterar);
            this.pnlMenu.Controls.Add(this.btnCadastrar);
            this.pnlMenu.Location = new System.Drawing.Point(752, 22);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(167, 427);
            this.pnlMenu.TabIndex = 23;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(8, 362);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(149, 49);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(8, 269);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(2);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(149, 49);
            this.btnPesquisar.TabIndex = 13;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.DarkCyan;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(8, 186);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(149, 49);
            this.btnExcluir.TabIndex = 12;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(8, 95);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(149, 49);
            this.btnAlterar.TabIndex = 11;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(8, 4);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(149, 49);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // pnlDados
            // 
            this.pnlDados.BackColor = System.Drawing.Color.White;
            this.pnlDados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDados.Controls.Add(this.cmbEscolaridade);
            this.pnlDados.Controls.Add(this.lblEscolaridade);
            this.pnlDados.Controls.Add(this.txtTelefone);
            this.pnlDados.Controls.Add(this.lblTelefone);
            this.pnlDados.Controls.Add(this.grpTurno);
            this.pnlDados.Controls.Add(this.dtpDataAdm);
            this.pnlDados.Controls.Add(this.lblDataAdm);
            this.pnlDados.Controls.Add(this.txtCPF);
            this.pnlDados.Controls.Add(this.lblCPF);
            this.pnlDados.Controls.Add(this.cmbDisciplina);
            this.pnlDados.Controls.Add(this.pctEscola);
            this.pnlDados.Controls.Add(this.pnlID);
            this.pnlDados.Controls.Add(this.dtgProfessor);
            this.pnlDados.Controls.Add(this.txtNome);
            this.pnlDados.Controls.Add(this.lblDisciplina);
            this.pnlDados.Controls.Add(this.lblNome);
            this.pnlDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDados.Location = new System.Drawing.Point(8, 22);
            this.pnlDados.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDados.Name = "pnlDados";
            this.pnlDados.Size = new System.Drawing.Size(739, 427);
            this.pnlDados.TabIndex = 22;
            // 
            // cmbEscolaridade
            // 
            this.cmbEscolaridade.FormattingEnabled = true;
            this.cmbEscolaridade.Items.AddRange(new object[] {
            "ENSINO MEDIO",
            "POS GRADUAÇÃO",
            "FACULDADE",
            "MESTRADO"});
            this.cmbEscolaridade.Location = new System.Drawing.Point(568, 165);
            this.cmbEscolaridade.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEscolaridade.Name = "cmbEscolaridade";
            this.cmbEscolaridade.Size = new System.Drawing.Size(163, 28);
            this.cmbEscolaridade.TabIndex = 8;
            // 
            // lblEscolaridade
            // 
            this.lblEscolaridade.AutoSize = true;
            this.lblEscolaridade.Location = new System.Drawing.Point(565, 139);
            this.lblEscolaridade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEscolaridade.Name = "lblEscolaridade";
            this.lblEscolaridade.Size = new System.Drawing.Size(105, 20);
            this.lblEscolaridade.TabIndex = 19;
            this.lblEscolaridade.Text = "Escolaridade:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(405, 103);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefone.Mask = "(99)99999-9999";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(146, 26);
            this.txtTelefone.TabIndex = 3;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(401, 80);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(75, 20);
            this.lblTelefone.TabIndex = 17;
            this.lblTelefone.Text = "Telefone:";
            // 
            // grpTurno
            // 
            this.grpTurno.Controls.Add(this.rdbNoite);
            this.grpTurno.Controls.Add(this.rdbTarde);
            this.grpTurno.Controls.Add(this.rdbManha);
            this.grpTurno.Location = new System.Drawing.Point(255, 139);
            this.grpTurno.Margin = new System.Windows.Forms.Padding(2);
            this.grpTurno.Name = "grpTurno";
            this.grpTurno.Padding = new System.Windows.Forms.Padding(2);
            this.grpTurno.Size = new System.Drawing.Size(296, 58);
            this.grpTurno.TabIndex = 16;
            this.grpTurno.TabStop = false;
            this.grpTurno.Text = "Turno:";
            // 
            // rdbNoite
            // 
            this.rdbNoite.AutoSize = true;
            this.rdbNoite.Location = new System.Drawing.Point(224, 26);
            this.rdbNoite.Margin = new System.Windows.Forms.Padding(2);
            this.rdbNoite.Name = "rdbNoite";
            this.rdbNoite.Size = new System.Drawing.Size(64, 24);
            this.rdbNoite.TabIndex = 7;
            this.rdbNoite.TabStop = true;
            this.rdbNoite.Text = "Noite";
            this.rdbNoite.UseVisualStyleBackColor = true;
            // 
            // rdbTarde
            // 
            this.rdbTarde.AutoSize = true;
            this.rdbTarde.Location = new System.Drawing.Point(120, 26);
            this.rdbTarde.Margin = new System.Windows.Forms.Padding(2);
            this.rdbTarde.Name = "rdbTarde";
            this.rdbTarde.Size = new System.Drawing.Size(68, 24);
            this.rdbTarde.TabIndex = 6;
            this.rdbTarde.TabStop = true;
            this.rdbTarde.Text = "Tarde";
            this.rdbTarde.UseVisualStyleBackColor = true;
            // 
            // rdbManha
            // 
            this.rdbManha.AutoSize = true;
            this.rdbManha.Location = new System.Drawing.Point(12, 26);
            this.rdbManha.Margin = new System.Windows.Forms.Padding(2);
            this.rdbManha.Name = "rdbManha";
            this.rdbManha.Size = new System.Drawing.Size(76, 24);
            this.rdbManha.TabIndex = 5;
            this.rdbManha.TabStop = true;
            this.rdbManha.Text = "Manhã";
            this.rdbManha.UseVisualStyleBackColor = true;
            // 
            // dtpDataAdm
            // 
            this.dtpDataAdm.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataAdm.Location = new System.Drawing.Point(568, 46);
            this.dtpDataAdm.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDataAdm.Name = "dtpDataAdm";
            this.dtpDataAdm.Size = new System.Drawing.Size(151, 26);
            this.dtpDataAdm.TabIndex = 1;
            // 
            // lblDataAdm
            // 
            this.lblDataAdm.AutoSize = true;
            this.lblDataAdm.Location = new System.Drawing.Point(565, 23);
            this.lblDataAdm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataAdm.Name = "lblDataAdm";
            this.lblDataAdm.Size = new System.Drawing.Size(144, 20);
            this.lblDataAdm.TabIndex = 14;
            this.lblDataAdm.Text = "Data de Admissão:";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(253, 103);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(2);
            this.txtCPF.Mask = "999.999.999-99";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(136, 26);
            this.txtCPF.TabIndex = 2;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(249, 80);
            this.lblCPF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(44, 20);
            this.lblCPF.TabIndex = 12;
            this.lblCPF.Text = "CPF:";
            // 
            // cmbDisciplina
            // 
            this.cmbDisciplina.FormattingEnabled = true;
            this.cmbDisciplina.Items.AddRange(new object[] {
            "MATEMATICA ",
            "FISICA",
            "PORTUGUES",
            "LOGP"});
            this.cmbDisciplina.Location = new System.Drawing.Point(568, 102);
            this.cmbDisciplina.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDisciplina.Name = "cmbDisciplina";
            this.cmbDisciplina.Size = new System.Drawing.Size(163, 28);
            this.cmbDisciplina.TabIndex = 4;
            // 
            // pctEscola
            // 
            this.pctEscola.Image = ((System.Drawing.Image)(resources.GetObject("pctEscola.Image")));
            this.pctEscola.Location = new System.Drawing.Point(10, 213);
            this.pctEscola.Margin = new System.Windows.Forms.Padding(2);
            this.pctEscola.Name = "pctEscola";
            this.pctEscola.Size = new System.Drawing.Size(230, 197);
            this.pctEscola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctEscola.TabIndex = 10;
            this.pctEscola.TabStop = false;
            // 
            // pnlID
            // 
            this.pnlID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlID.Controls.Add(this.lblID);
            this.pnlID.Controls.Add(this.txtID);
            this.pnlID.Location = new System.Drawing.Point(10, 11);
            this.pnlID.Margin = new System.Windows.Forms.Padding(2);
            this.pnlID.Name = "pnlID";
            this.pnlID.Size = new System.Drawing.Size(230, 187);
            this.pnlID.TabIndex = 9;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(8, 60);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(26, 20);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(11, 83);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(209, 26);
            this.txtID.TabIndex = 7;
            // 
            // dtgProfessor
            // 
            this.dtgProfessor.BackgroundColor = System.Drawing.Color.White;
            this.dtgProfessor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProfessor.Location = new System.Drawing.Point(253, 213);
            this.dtgProfessor.Margin = new System.Windows.Forms.Padding(2);
            this.dtgProfessor.Name = "dtgProfessor";
            this.dtgProfessor.RowHeadersWidth = 51;
            this.dtgProfessor.RowTemplate.Height = 24;
            this.dtgProfessor.Size = new System.Drawing.Size(472, 197);
            this.dtgProfessor.TabIndex = 9;
            this.dtgProfessor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProfessor_CellClick);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(253, 46);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(299, 26);
            this.txtNome.TabIndex = 0;
            // 
            // lblDisciplina
            // 
            this.lblDisciplina.AutoSize = true;
            this.lblDisciplina.Location = new System.Drawing.Point(565, 80);
            this.lblDisciplina.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDisciplina.Name = "lblDisciplina";
            this.lblDisciplina.Size = new System.Drawing.Size(80, 20);
            this.lblDisciplina.TabIndex = 2;
            this.lblDisciplina.Text = "Disciplina:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(249, 21);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(149, 20);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome do Professor:";
            // 
            // FrmProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 465);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlDados);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmProfessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Professores - Gabriel Castro Inacio";
            this.Load += new System.EventHandler(this.FrmProfessor_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            this.grpTurno.ResumeLayout(false);
            this.grpTurno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctEscola)).EndInit();
            this.pnlID.ResumeLayout(false);
            this.pnlID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProfessor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Panel pnlDados;
        private System.Windows.Forms.PictureBox pctEscola;
        private System.Windows.Forms.Panel pnlID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dtgProfessor;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblDisciplina;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DateTimePicker dtpDataAdm;
        private System.Windows.Forms.Label lblDataAdm;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.ComboBox cmbDisciplina;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.GroupBox grpTurno;
        private System.Windows.Forms.RadioButton rdbNoite;
        private System.Windows.Forms.RadioButton rdbTarde;
        private System.Windows.Forms.RadioButton rdbManha;
        private System.Windows.Forms.ComboBox cmbEscolaridade;
        private System.Windows.Forms.Label lblEscolaridade;
    }
}