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
        public FormConfiguracoes()
        {
            InitializeComponent();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            string nomeCondominio = tbNomeCondominio.Text;
            DialogResult resposta = MessageBox.Show($"Está certo de que desejas criar o condomínio {tbNomeCondominio.Text}?\n" +
                $"Não será possível modificar o nome depois!","Confirmação", MessageBoxButtons.YesNo);
            if (resposta == DialogResult.Yes)
            {
                tbNomeCondominio.Enabled = false;
                
            }
        }
    }
}
