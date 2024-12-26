namespace ProjetoEscola
{
    partial class frmAlunos
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlunos));
            this.lblID = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.grpUnidade = new System.Windows.Forms.GroupBox();
            this.rdbFloresta = new System.Windows.Forms.RadioButton();
            this.rdbBarroca = new System.Windows.Forms.RadioButton();
            this.grpSerie = new System.Windows.Forms.GroupBox();
            this.rdb3Serie = new System.Windows.Forms.RadioButton();
            this.rdb2Serie = new System.Windows.Forms.RadioButton();
            this.rdb1Serie = new System.Windows.Forms.RadioButton();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dtgAlunos = new System.Windows.Forms.DataGridView();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pnlDados = new System.Windows.Forms.Panel();
            this.cmbTurma = new System.Windows.Forms.ComboBox();
            this.lblTurma = new System.Windows.Forms.Label();
            this.pctEscola = new System.Windows.Forms.PictureBox();
            this.pnlID = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.grpUnidade.SuspendLayout();
            this.grpSerie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlunos)).BeginInit();
            this.pnlDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctEscola)).BeginInit();
            this.pnlID.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(5, 27);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(26, 20);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(249, 9);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(120, 20);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome do aluno:";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(601, 9);
            this.lblIdade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(54, 20);
            this.lblIdade.TabIndex = 2;
            this.lblIdade.Text = "Idade:";
            // 
            // grpUnidade
            // 
            this.grpUnidade.Controls.Add(this.rdbFloresta);
            this.grpUnidade.Controls.Add(this.rdbBarroca);
            this.grpUnidade.Location = new System.Drawing.Point(253, 72);
            this.grpUnidade.Margin = new System.Windows.Forms.Padding(2);
            this.grpUnidade.Name = "grpUnidade";
            this.grpUnidade.Padding = new System.Windows.Forms.Padding(2);
            this.grpUnidade.Size = new System.Drawing.Size(176, 50);
            this.grpUnidade.TabIndex = 3;
            this.grpUnidade.TabStop = false;
            this.grpUnidade.Text = "Unidade";
            // 
            // rdbFloresta
            // 
            this.rdbFloresta.AutoSize = true;
            this.rdbFloresta.Location = new System.Drawing.Point(94, 21);
            this.rdbFloresta.Margin = new System.Windows.Forms.Padding(2);
            this.rdbFloresta.Name = "rdbFloresta";
            this.rdbFloresta.Size = new System.Drawing.Size(85, 24);
            this.rdbFloresta.TabIndex = 1;
            this.rdbFloresta.TabStop = true;
            this.rdbFloresta.Text = "Floresta";
            this.rdbFloresta.UseVisualStyleBackColor = true;
            // 
            // rdbBarroca
            // 
            this.rdbBarroca.AutoSize = true;
            this.rdbBarroca.Location = new System.Drawing.Point(4, 21);
            this.rdbBarroca.Margin = new System.Windows.Forms.Padding(2);
            this.rdbBarroca.Name = "rdbBarroca";
            this.rdbBarroca.Size = new System.Drawing.Size(83, 24);
            this.rdbBarroca.TabIndex = 0;
            this.rdbBarroca.TabStop = true;
            this.rdbBarroca.Text = "Barroca";
            this.rdbBarroca.UseVisualStyleBackColor = true;
            // 
            // grpSerie
            // 
            this.grpSerie.Controls.Add(this.rdb3Serie);
            this.grpSerie.Controls.Add(this.rdb2Serie);
            this.grpSerie.Controls.Add(this.rdb1Serie);
            this.grpSerie.Location = new System.Drawing.Point(443, 72);
            this.grpSerie.Margin = new System.Windows.Forms.Padding(2);
            this.grpSerie.Name = "grpSerie";
            this.grpSerie.Padding = new System.Windows.Forms.Padding(2);
            this.grpSerie.Size = new System.Drawing.Size(148, 50);
            this.grpSerie.TabIndex = 4;
            this.grpSerie.TabStop = false;
            this.grpSerie.Text = "Série";
            // 
            // rdb3Serie
            // 
            this.rdb3Serie.AutoSize = true;
            this.rdb3Serie.Location = new System.Drawing.Point(101, 24);
            this.rdb3Serie.Margin = new System.Windows.Forms.Padding(2);
            this.rdb3Serie.Name = "rdb3Serie";
            this.rdb3Serie.Size = new System.Drawing.Size(42, 24);
            this.rdb3Serie.TabIndex = 3;
            this.rdb3Serie.TabStop = true;
            this.rdb3Serie.Text = "3ª";
            this.rdb3Serie.UseVisualStyleBackColor = true;
            // 
            // rdb2Serie
            // 
            this.rdb2Serie.AutoSize = true;
            this.rdb2Serie.Location = new System.Drawing.Point(58, 24);
            this.rdb2Serie.Margin = new System.Windows.Forms.Padding(2);
            this.rdb2Serie.Name = "rdb2Serie";
            this.rdb2Serie.Size = new System.Drawing.Size(42, 24);
            this.rdb2Serie.TabIndex = 2;
            this.rdb2Serie.TabStop = true;
            this.rdb2Serie.Text = "2ª";
            this.rdb2Serie.UseVisualStyleBackColor = true;
            // 
            // rdb1Serie
            // 
            this.rdb1Serie.AutoSize = true;
            this.rdb1Serie.Location = new System.Drawing.Point(11, 24);
            this.rdb1Serie.Margin = new System.Windows.Forms.Padding(2);
            this.rdb1Serie.Name = "rdb1Serie";
            this.rdb1Serie.Size = new System.Drawing.Size(42, 24);
            this.rdb1Serie.TabIndex = 1;
            this.rdb1Serie.TabStop = true;
            this.rdb1Serie.Text = "1ª";
            this.rdb1Serie.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(253, 32);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(339, 26);
            this.txtNome.TabIndex = 5;
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(604, 32);
            this.txtIdade.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(121, 26);
            this.txtIdade.TabIndex = 6;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(9, 50);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(209, 26);
            this.txtID.TabIndex = 7;
            // 
            // dtgAlunos
            // 
            this.dtgAlunos.BackgroundColor = System.Drawing.Color.White;
            this.dtgAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAlunos.Location = new System.Drawing.Point(253, 140);
            this.dtgAlunos.Margin = new System.Windows.Forms.Padding(2);
            this.dtgAlunos.Name = "dtgAlunos";
            this.dtgAlunos.RowHeadersWidth = 51;
            this.dtgAlunos.RowTemplate.Height = 24;
            this.dtgAlunos.Size = new System.Drawing.Size(472, 249);
            this.dtgAlunos.TabIndex = 8;
            this.dtgAlunos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAlunos_CellClick);
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
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(8, 84);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(149, 49);
            this.btnAlterar.TabIndex = 10;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.DarkCyan;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(8, 173);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(149, 49);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(8, 261);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(2);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(149, 49);
            this.btnPesquisar.TabIndex = 12;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(8, 342);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(149, 49);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pnlDados
            // 
            this.pnlDados.BackColor = System.Drawing.Color.White;
            this.pnlDados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDados.Controls.Add(this.cmbTurma);
            this.pnlDados.Controls.Add(this.lblTurma);
            this.pnlDados.Controls.Add(this.pctEscola);
            this.pnlDados.Controls.Add(this.pnlID);
            this.pnlDados.Controls.Add(this.dtgAlunos);
            this.pnlDados.Controls.Add(this.txtIdade);
            this.pnlDados.Controls.Add(this.txtNome);
            this.pnlDados.Controls.Add(this.grpSerie);
            this.pnlDados.Controls.Add(this.grpUnidade);
            this.pnlDados.Controls.Add(this.lblIdade);
            this.pnlDados.Controls.Add(this.lblNome);
            this.pnlDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDados.Location = new System.Drawing.Point(10, 9);
            this.pnlDados.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDados.Name = "pnlDados";
            this.pnlDados.Size = new System.Drawing.Size(738, 402);
            this.pnlDados.TabIndex = 14;
            // 
            // cmbTurma
            // 
            this.cmbTurma.FormattingEnabled = true;
            this.cmbTurma.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.cmbTurma.Location = new System.Drawing.Point(604, 93);
            this.cmbTurma.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTurma.Name = "cmbTurma";
            this.cmbTurma.Size = new System.Drawing.Size(121, 28);
            this.cmbTurma.TabIndex = 12;
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Location = new System.Drawing.Point(601, 65);
            this.lblTurma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(58, 20);
            this.lblTurma.TabIndex = 11;
            this.lblTurma.Text = "Turma:";
            // 
            // pctEscola
            // 
            this.pctEscola.Image = ((System.Drawing.Image)(resources.GetObject("pctEscola.Image")));
            this.pctEscola.Location = new System.Drawing.Point(10, 140);
            this.pctEscola.Margin = new System.Windows.Forms.Padding(2);
            this.pctEscola.Name = "pctEscola";
            this.pctEscola.Size = new System.Drawing.Size(230, 249);
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
            this.pnlID.Size = new System.Drawing.Size(230, 112);
            this.pnlID.TabIndex = 9;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.White;
            this.pnlMenu.Controls.Add(this.btnSair);
            this.pnlMenu.Controls.Add(this.btnPesquisar);
            this.pnlMenu.Controls.Add(this.btnExcluir);
            this.pnlMenu.Controls.Add(this.btnAlterar);
            this.pnlMenu.Controls.Add(this.btnCadastrar);
            this.pnlMenu.Location = new System.Drawing.Point(752, 7);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(167, 403);
            this.pnlMenu.TabIndex = 15;
            // 
            // frmAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(928, 428);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlDados);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD - Projeto ESCOLA - Gabriel Castro Inacio";
            this.Load += new System.EventHandler(this.frmAlunos_Load);
            this.grpUnidade.ResumeLayout(false);
            this.grpUnidade.PerformLayout();
            this.grpSerie.ResumeLayout(false);
            this.grpSerie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlunos)).EndInit();
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctEscola)).EndInit();
            this.pnlID.ResumeLayout(false);
            this.pnlID.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.GroupBox grpUnidade;
        private System.Windows.Forms.RadioButton rdbFloresta;
        private System.Windows.Forms.RadioButton rdbBarroca;
        private System.Windows.Forms.GroupBox grpSerie;
        private System.Windows.Forms.RadioButton rdb3Serie;
        private System.Windows.Forms.RadioButton rdb2Serie;
        private System.Windows.Forms.RadioButton rdb1Serie;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dtgAlunos;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel pnlDados;
        private System.Windows.Forms.Panel pnlID;
        private System.Windows.Forms.PictureBox pctEscola;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.ComboBox cmbTurma;
        private System.Windows.Forms.Label lblTurma;
    }
}

