using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Condominio
{
    public partial class FormConfiguracoes : Form
    {
        private FormPainelDeControle _formAnterior;
        public FormConfiguracoes(FormPainelDeControle formAnterior)
        {
            InitializeComponent();
            this._formAnterior = formAnterior;
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            string nomeCondominio = tbNomeCondominio.Text;
            if (nomeCondominio.Length > 0)
            {
                DialogResult resposta = MessageBox.Show($"Está certo de que desejas criar o condomínio {tbNomeCondominio.Text}?\n" +
                    $"Não será possível modificar o nome depois!", "Confirmação", MessageBoxButtons.YesNo);
                if (resposta == DialogResult.Yes)
                {
                    tbNomeCondominio.Enabled = false;
                    Condominio c = new Condominio(nomeCondominio);
                    Condominio.Self = c;
                    this._formAnterior.Show();
                    this._formAnterior.Atualizar();
                    this.Hide();
                }
                else
                {
                    this._formAnterior.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Insira o nome do condomínio!");
                tbNomeCondominio.Focus();
            }
        }
    }
}
