namespace Sistema_Condominio
{
    partial class FormMorador
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
            this.lbNome = new System.Windows.Forms.Label();
            this.lbSenha = new System.Windows.Forms.Label();
            this.lbCPF = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbCPF = new System.Windows.Forms.TextBox();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.btAddMorador = new System.Windows.Forms.Button();
            this.btAtivarMorador = new System.Windows.Forms.Button();
            this.lvMoradores = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btMudarSenha = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(66, 55);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(49, 17);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome:";
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Location = new System.Drawing.Point(66, 141);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(53, 17);
            this.lbSenha.TabIndex = 1;
            this.lbSenha.Text = "Senha:";
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.Location = new System.Drawing.Point(66, 100);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(38, 17);
            this.lbCPF.TabIndex = 2;
            this.lbCPF.Text = "CPF:";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(134, 55);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(290, 22);
            this.tbNome.TabIndex = 3;
            // 
            // tbCPF
            // 
            this.tbCPF.Location = new System.Drawing.Point(134, 95);
            this.tbCPF.Name = "tbCPF";
            this.tbCPF.Size = new System.Drawing.Size(290, 22);
            this.tbCPF.TabIndex = 4;
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(134, 136);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(290, 22);
            this.tbSenha.TabIndex = 5;
            // 
            // btAddMorador
            // 
            this.btAddMorador.Location = new System.Drawing.Point(464, 131);
            this.btAddMorador.Name = "btAddMorador";
            this.btAddMorador.Size = new System.Drawing.Size(148, 27);
            this.btAddMorador.TabIndex = 6;
            this.btAddMorador.Text = "Adicionar Morador";
            this.btAddMorador.UseVisualStyleBackColor = true;
            this.btAddMorador.Click += new System.EventHandler(this.btAddMorador_Click);
            // 
            // btAtivarMorador
            // 
            this.btAtivarMorador.Location = new System.Drawing.Point(464, 411);
            this.btAtivarMorador.Name = "btAtivarMorador";
            this.btAtivarMorador.Size = new System.Drawing.Size(148, 27);
            this.btAtivarMorador.TabIndex = 7;
            this.btAtivarMorador.Text = "Ativar/Desativar Morador";
            this.btAtivarMorador.UseVisualStyleBackColor = true;
            // 
            // lvMoradores
            // 
            this.lvMoradores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvMoradores.FullRowSelect = true;
            this.lvMoradores.GridLines = true;
            this.lvMoradores.HideSelection = false;
            this.lvMoradores.Location = new System.Drawing.Point(69, 180);
            this.lvMoradores.Name = "lvMoradores";
            this.lvMoradores.Size = new System.Drawing.Size(543, 209);
            this.lvMoradores.TabIndex = 8;
            this.lvMoradores.UseCompatibleStateImageBehavior = false;
            this.lvMoradores.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome";
            this.columnHeader1.Width = 339;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "CPF";
            this.columnHeader2.Width = 199;
            // 
            // btMudarSenha
            // 
            this.btMudarSenha.Location = new System.Drawing.Point(298, 411);
            this.btMudarSenha.Name = "btMudarSenha";
            this.btMudarSenha.Size = new System.Drawing.Size(148, 27);
            this.btMudarSenha.TabIndex = 9;
            this.btMudarSenha.Text = "Mudar Senha";
            this.btMudarSenha.UseVisualStyleBackColor = true;
            // 
            // btVoltar
            // 
            this.btVoltar.Location = new System.Drawing.Point(37, 411);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(90, 27);
            this.btVoltar.TabIndex = 10;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ativo";
            // 
            // FormMorador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.btMudarSenha);
            this.Controls.Add(this.lvMoradores);
            this.Controls.Add(this.btAtivarMorador);
            this.Controls.Add(this.btAddMorador);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.tbCPF);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lbCPF);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.lbNome);
            this.Name = "FormMorador";
            this.Text = "FormMorador";
            this.Load += new System.EventHandler(this.FormMorador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbCPF;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.Button btAddMorador;
        private System.Windows.Forms.Button btAtivarMorador;
        private System.Windows.Forms.ListView lvMoradores;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btMudarSenha;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}