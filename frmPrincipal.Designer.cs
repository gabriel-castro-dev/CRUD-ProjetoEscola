namespace ProjetoEscola
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.armazenamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAlunos = new System.Windows.Forms.ToolStripMenuItem();
            this.dISCIPLINAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROFESSORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.armazenamentoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // armazenamentoToolStripMenuItem
            // 
            this.armazenamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAlunos,
            this.dISCIPLINAToolStripMenuItem,
            this.pROFESSORToolStripMenuItem});
            this.armazenamentoToolStripMenuItem.Name = "armazenamentoToolStripMenuItem";
            this.armazenamentoToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.armazenamentoToolStripMenuItem.Text = "DADOS";
            // 
            // mnuAlunos
            // 
            this.mnuAlunos.Name = "mnuAlunos";
            this.mnuAlunos.Size = new System.Drawing.Size(180, 22);
            this.mnuAlunos.Text = "ALUNO";
            this.mnuAlunos.Click += new System.EventHandler(this.mnuAlunos_Click);
            // 
            // dISCIPLINAToolStripMenuItem
            // 
            this.dISCIPLINAToolStripMenuItem.Name = "dISCIPLINAToolStripMenuItem";
            this.dISCIPLINAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dISCIPLINAToolStripMenuItem.Text = "DISCIPLINA";
            this.dISCIPLINAToolStripMenuItem.Click += new System.EventHandler(this.dISCIPLINAToolStripMenuItem_Click);
            // 
            // pROFESSORToolStripMenuItem
            // 
            this.pROFESSORToolStripMenuItem.Name = "pROFESSORToolStripMenuItem";
            this.pROFESSORToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pROFESSORToolStripMenuItem.Text = "PROFESSOR";
            this.pROFESSORToolStripMenuItem.Click += new System.EventHandler(this.pROFESSORToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projeto ESCOLA - Gabriel Castro Inacio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem armazenamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAlunos;
        private System.Windows.Forms.ToolStripMenuItem dISCIPLINAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pROFESSORToolStripMenuItem;
    }
}