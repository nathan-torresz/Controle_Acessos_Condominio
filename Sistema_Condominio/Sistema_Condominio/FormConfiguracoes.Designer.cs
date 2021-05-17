namespace Sistema_Condominio
{
    partial class FormConfiguracoes
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNomeCondominio = new System.Windows.Forms.TextBox();
            this.btOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Condomínio:";
            // 
            // tbNomeCondominio
            // 
            this.tbNomeCondominio.Location = new System.Drawing.Point(165, 59);
            this.tbNomeCondominio.Name = "tbNomeCondominio";
            this.tbNomeCondominio.Size = new System.Drawing.Size(311, 22);
            this.tbNomeCondominio.TabIndex = 1;
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(274, 87);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(74, 28);
            this.btOK.TabIndex = 2;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // FormConfiguracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 219);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.tbNomeCondominio);
            this.Controls.Add(this.label1);
            this.Name = "FormConfiguracoes";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNomeCondominio;
        private System.Windows.Forms.Button btOK;
    }
}