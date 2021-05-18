namespace Sistema_Condominio
{
    partial class FormPainelDeControle
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsConfiguracoes = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMorador = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarMoradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ativarDesativarMoradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsVisitante = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarVisitanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAcesso = new System.Windows.Forms.ToolStripMenuItem();
            this.verificaçãoDeAcessoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btConfig = new System.Windows.Forms.Button();
            this.btVerificacaodeAcesso = new System.Windows.Forms.Button();
            this.btAddVisitante = new System.Windows.Forms.Button();
            this.btAtivarDesatMorador = new System.Windows.Forms.Button();
            this.btAddMorador = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsConfiguracoes,
            this.tsMorador,
            this.tsVisitante,
            this.tsAcesso});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Configurações";
            // 
            // tsConfiguracoes
            // 
            this.tsConfiguracoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cToolStripMenuItem});
            this.tsConfiguracoes.Name = "tsConfiguracoes";
            this.tsConfiguracoes.Size = new System.Drawing.Size(118, 24);
            this.tsConfiguracoes.Text = "Configurações";
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(295, 26);
            this.cToolStripMenuItem.Text = "Configurações do Condominio";
            this.cToolStripMenuItem.Click += new System.EventHandler(this.btConfig_Click);
            // 
            // tsMorador
            // 
            this.tsMorador.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarMoradorToolStripMenuItem,
            this.ativarDesativarMoradorToolStripMenuItem});
            this.tsMorador.Enabled = false;
            this.tsMorador.Name = "tsMorador";
            this.tsMorador.Size = new System.Drawing.Size(81, 24);
            this.tsMorador.Text = "Morador";
            // 
            // adicionarMoradorToolStripMenuItem
            // 
            this.adicionarMoradorToolStripMenuItem.Name = "adicionarMoradorToolStripMenuItem";
            this.adicionarMoradorToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.adicionarMoradorToolStripMenuItem.Text = "Adicionar Morador";
            this.adicionarMoradorToolStripMenuItem.Click += new System.EventHandler(this.btAddMorador_Click);
            // 
            // ativarDesativarMoradorToolStripMenuItem
            // 
            this.ativarDesativarMoradorToolStripMenuItem.Name = "ativarDesativarMoradorToolStripMenuItem";
            this.ativarDesativarMoradorToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.ativarDesativarMoradorToolStripMenuItem.Text = "Ativar/Desativar Morador";
            this.ativarDesativarMoradorToolStripMenuItem.Click += new System.EventHandler(this.btAddMorador_Click);
            // 
            // tsVisitante
            // 
            this.tsVisitante.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarVisitanteToolStripMenuItem});
            this.tsVisitante.Enabled = false;
            this.tsVisitante.Name = "tsVisitante";
            this.tsVisitante.Size = new System.Drawing.Size(80, 24);
            this.tsVisitante.Text = "Visitante";
            // 
            // adicionarVisitanteToolStripMenuItem
            // 
            this.adicionarVisitanteToolStripMenuItem.Name = "adicionarVisitanteToolStripMenuItem";
            this.adicionarVisitanteToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.adicionarVisitanteToolStripMenuItem.Text = "Adicionar Visitante";
            // 
            // tsAcesso
            // 
            this.tsAcesso.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verificaçãoDeAcessoToolStripMenuItem});
            this.tsAcesso.Enabled = false;
            this.tsAcesso.Name = "tsAcesso";
            this.tsAcesso.Size = new System.Drawing.Size(69, 24);
            this.tsAcesso.Text = "Acesso";
            // 
            // verificaçãoDeAcessoToolStripMenuItem
            // 
            this.verificaçãoDeAcessoToolStripMenuItem.Name = "verificaçãoDeAcessoToolStripMenuItem";
            this.verificaçãoDeAcessoToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.verificaçãoDeAcessoToolStripMenuItem.Text = "Verificação de Acesso";
            // 
            // btConfig
            // 
            this.btConfig.Location = new System.Drawing.Point(12, 47);
            this.btConfig.Name = "btConfig";
            this.btConfig.Size = new System.Drawing.Size(360, 36);
            this.btConfig.TabIndex = 1;
            this.btConfig.Text = "Configurações";
            this.btConfig.UseVisualStyleBackColor = true;
            this.btConfig.Click += new System.EventHandler(this.btConfig_Click);
            // 
            // btVerificacaodeAcesso
            // 
            this.btVerificacaodeAcesso.Enabled = false;
            this.btVerificacaodeAcesso.Location = new System.Drawing.Point(12, 280);
            this.btVerificacaodeAcesso.Name = "btVerificacaodeAcesso";
            this.btVerificacaodeAcesso.Size = new System.Drawing.Size(360, 139);
            this.btVerificacaodeAcesso.TabIndex = 2;
            this.btVerificacaodeAcesso.Text = "Verificação de Acesso";
            this.btVerificacaodeAcesso.UseVisualStyleBackColor = true;
            // 
            // btAddVisitante
            // 
            this.btAddVisitante.Enabled = false;
            this.btAddVisitante.Location = new System.Drawing.Point(12, 216);
            this.btAddVisitante.Name = "btAddVisitante";
            this.btAddVisitante.Size = new System.Drawing.Size(360, 36);
            this.btAddVisitante.TabIndex = 3;
            this.btAddVisitante.Text = "Adicionar Visitante";
            this.btAddVisitante.UseVisualStyleBackColor = true;
            // 
            // btAtivarDesatMorador
            // 
            this.btAtivarDesatMorador.Enabled = false;
            this.btAtivarDesatMorador.Location = new System.Drawing.Point(12, 159);
            this.btAtivarDesatMorador.Name = "btAtivarDesatMorador";
            this.btAtivarDesatMorador.Size = new System.Drawing.Size(360, 36);
            this.btAtivarDesatMorador.TabIndex = 4;
            this.btAtivarDesatMorador.Text = "Ativar/Desativar Morador";
            this.btAtivarDesatMorador.UseVisualStyleBackColor = true;
            this.btAtivarDesatMorador.Click += new System.EventHandler(this.btAddMorador_Click);
            // 
            // btAddMorador
            // 
            this.btAddMorador.Enabled = false;
            this.btAddMorador.Location = new System.Drawing.Point(12, 103);
            this.btAddMorador.Name = "btAddMorador";
            this.btAddMorador.Size = new System.Drawing.Size(360, 36);
            this.btAddMorador.TabIndex = 5;
            this.btAddMorador.Text = "Adicionar Morador";
            this.btAddMorador.UseVisualStyleBackColor = true;
            this.btAddMorador.Click += new System.EventHandler(this.btAddMorador_Click);
            // 
            // FormPainelDeControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 429);
            this.Controls.Add(this.btAddMorador);
            this.Controls.Add(this.btAtivarDesatMorador);
            this.Controls.Add(this.btAddVisitante);
            this.Controls.Add(this.btVerificacaodeAcesso);
            this.Controls.Add(this.btConfig);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPainelDeControle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPainelDeControle_Shown);
            this.Shown += new System.EventHandler(this.FormPainelDeControle_Shown);
            this.Enter += new System.EventHandler(this.FormPainelDeControle_Enter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsConfiguracoes;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsMorador;
        private System.Windows.Forms.ToolStripMenuItem adicionarMoradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ativarDesativarMoradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsVisitante;
        private System.Windows.Forms.ToolStripMenuItem adicionarVisitanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsAcesso;
        private System.Windows.Forms.ToolStripMenuItem verificaçãoDeAcessoToolStripMenuItem;
        private System.Windows.Forms.Button btConfig;
        private System.Windows.Forms.Button btVerificacaodeAcesso;
        private System.Windows.Forms.Button btAddVisitante;
        private System.Windows.Forms.Button btAtivarDesatMorador;
        private System.Windows.Forms.Button btAddMorador;
    }
}

