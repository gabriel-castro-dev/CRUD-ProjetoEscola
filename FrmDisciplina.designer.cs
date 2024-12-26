namespace ProjetoEscola
{
    partial class FrmDisciplina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDisciplina));
            this.pctEscola = new System.Windows.Forms.PictureBox();
            this.pnlID = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtCargaHoraria = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCargaHoraria = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.pnlDados = new System.Windows.Forms.Panel();
            this.dtgDisciplina = new System.Windows.Forms.DataGridView();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctEscola)).BeginInit();
            this.pnlID.SuspendLayout();
            this.pnlDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDisciplina)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pctEscola
            // 
            this.pctEscola.Image = ((System.Drawing.Image)(resources.GetObject("pctEscola.Image")));
            this.pctEscola.Location = new System.Drawing.Point(10, 92);
            this.pctEscola.Margin = new System.Windows.Forms.Padding(2);
            this.pctEscola.Name = "pctEscola";
            this.pctEscola.Size = new System.Drawing.Size(230, 219);
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
            this.pnlID.Size = new System.Drawing.Size(230, 77);
            this.pnlID.TabIndex = 9;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(7, 11);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(26, 20);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(10, 34);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(209, 26);
            this.txtID.TabIndex = 7;
            // 
            // txtCargaHoraria
            // 
            this.txtCargaHoraria.Location = new System.Drawing.Point(604, 46);
            this.txtCargaHoraria.Margin = new System.Windows.Forms.Padding(2);
            this.txtCargaHoraria.Name = "txtCargaHoraria";
            this.txtCargaHoraria.Size = new System.Drawing.Size(121, 26);
            this.txtCargaHoraria.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(253, 46);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(339, 26);
            this.txtNome.TabIndex = 0;
            // 
            // lblCargaHoraria
            // 
            this.lblCargaHoraria.AutoSize = true;
            this.lblCargaHoraria.Location = new System.Drawing.Point(601, 23);
            this.lblCargaHoraria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCargaHoraria.Name = "lblCargaHoraria";
            this.lblCargaHoraria.Size = new System.Drawing.Size(109, 20);
            this.lblCargaHoraria.TabIndex = 2;
            this.lblCargaHoraria.Text = "Carga horária:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(249, 23);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(145, 20);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome da disciplina:";
            // 
            // pnlDados
            // 
            this.pnlDados.BackColor = System.Drawing.Color.White;
            this.pnlDados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDados.Controls.Add(this.pctEscola);
            this.pnlDados.Controls.Add(this.pnlID);
            this.pnlDados.Controls.Add(this.dtgDisciplina);
            this.pnlDados.Controls.Add(this.txtCargaHoraria);
            this.pnlDados.Controls.Add(this.txtNome);
            this.pnlDados.Controls.Add(this.lblCargaHoraria);
            this.pnlDados.Controls.Add(this.lblNome);
            this.pnlDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDados.Location = new System.Drawing.Point(7, 19);
            this.pnlDados.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDados.Name = "pnlDados";
            this.pnlDados.Size = new System.Drawing.Size(739, 322);
            this.pnlDados.TabIndex = 20;
            // 
            // dtgDisciplina
            // 
            this.dtgDisciplina.BackgroundColor = System.Drawing.Color.White;
            this.dtgDisciplina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDisciplina.Location = new System.Drawing.Point(253, 92);
            this.dtgDisciplina.Margin = new System.Windows.Forms.Padding(2);
            this.dtgDisciplina.Name = "dtgDisciplina";
            this.dtgDisciplina.RowHeadersWidth = 51;
            this.dtgDisciplina.RowTemplate.Height = 24;
            this.dtgDisciplina.Size = new System.Drawing.Size(472, 219);
            this.dtgDisciplina.TabIndex = 2;
            this.dtgDisciplina.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDisciplina_CellClick);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.White;
            this.pnlMenu.Controls.Add(this.btnSair);
            this.pnlMenu.Controls.Add(this.btnPesquisar);
            this.pnlMenu.Controls.Add(this.btnExcluir);
            this.pnlMenu.Controls.Add(this.btnAlterar);
            this.pnlMenu.Controls.Add(this.btnCadastrar);
            this.pnlMenu.Location = new System.Drawing.Point(752, 19);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(167, 322);
            this.pnlMenu.TabIndex = 21;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(8, 263);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(149, 49);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(8, 202);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(2);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(149, 49);
            this.btnPesquisar.TabIndex = 6;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.DarkCyan;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(8, 136);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(149, 49);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(8, 71);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(149, 49);
            this.btnAlterar.TabIndex = 4;
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
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // FrmDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(928, 353);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlDados);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmDisciplina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Disciplinas - Gabriel Castro Inacio";
            this.Load += new System.EventHandler(this.FrmDisciplina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctEscola)).EndInit();
            this.pnlID.ResumeLayout(false);
            this.pnlID.PerformLayout();
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDisciplina)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctEscola;
        private System.Windows.Forms.Panel pnlID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtCargaHoraria;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCargaHoraria;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Panel pnlDados;
        private System.Windows.Forms.DataGridView dtgDisciplina;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
    }
}