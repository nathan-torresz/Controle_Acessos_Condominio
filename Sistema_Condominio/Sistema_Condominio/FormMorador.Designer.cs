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
            this.lvMoradores = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCPF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btAddMorador = new System.Windows.Forms.Button();
            this.btAtivarMorador = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btMudarSenha = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.lvMoradores.Location = new System.Drawing.Point(42, 152);
            this.lvMoradores.Name = "lvMoradores";
            this.lvMoradores.Size = new System.Drawing.Size(558, 243);
            this.lvMoradores.TabIndex = 0;
            this.lvMoradores.UseCompatibleStateImageBehavior = false;
            this.lvMoradores.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(91, 53);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(312, 22);
            this.tbNome.TabIndex = 2;
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(91, 109);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(312, 22);
            this.tbSenha.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha:";
            // 
            // tbCPF
            // 
            this.tbCPF.Location = new System.Drawing.Point(91, 81);
            this.tbCPF.Name = "tbCPF";
            this.tbCPF.Size = new System.Drawing.Size(312, 22);
            this.tbCPF.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "CPF:";
            // 
            // btAddMorador
            // 
            this.btAddMorador.Location = new System.Drawing.Point(438, 108);
            this.btAddMorador.Name = "btAddMorador";
            this.btAddMorador.Size = new System.Drawing.Size(162, 28);
            this.btAddMorador.TabIndex = 7;
            this.btAddMorador.Text = "Adicionar Morador";
            this.btAddMorador.UseVisualStyleBackColor = true;
            this.btAddMorador.Click += new System.EventHandler(this.btAddMorador_Click);
            // 
            // btAtivarMorador
            // 
            this.btAtivarMorador.Location = new System.Drawing.Point(438, 410);
            this.btAtivarMorador.Name = "btAtivarMorador";
            this.btAtivarMorador.Size = new System.Drawing.Size(162, 28);
            this.btAtivarMorador.TabIndex = 8;
            this.btAtivarMorador.Text = "Ativar/Desativar Morador";
            this.btAtivarMorador.UseVisualStyleBackColor = true;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome";
            this.columnHeader1.Width = 267;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "CPF";
            this.columnHeader2.Width = 195;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ativo";
            this.columnHeader3.Width = 91;
            // 
            // btMudarSenha
            // 
            this.btMudarSenha.Location = new System.Drawing.Point(260, 410);
            this.btMudarSenha.Name = "btMudarSenha";
            this.btMudarSenha.Size = new System.Drawing.Size(162, 28);
            this.btMudarSenha.TabIndex = 9;
            this.btMudarSenha.Text = "Mudar Senha";
            this.btMudarSenha.UseVisualStyleBackColor = true;
            // 
            // btVoltar
            // 
            this.btVoltar.Location = new System.Drawing.Point(41, 410);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(77, 28);
            this.btVoltar.TabIndex = 10;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // FormMorador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 450);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.btMudarSenha);
            this.Controls.Add(this.btAtivarMorador);
            this.Controls.Add(this.btAddMorador);
            this.Controls.Add(this.tbCPF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvMoradores);
            this.Name = "FormMorador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMorador";
            this.Load += new System.EventHandler(this.FormMorador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvMoradores;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCPF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btAddMorador;
        private System.Windows.Forms.Button btAtivarMorador;
        private System.Windows.Forms.Button btMudarSenha;
        private System.Windows.Forms.Button btVoltar;
    }
}