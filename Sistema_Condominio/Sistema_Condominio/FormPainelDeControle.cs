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
    public partial class FormPainelDeControle : Form
    {
        private FormConfiguracoes formConfiguracoes;
        private FormMorador formMorador;
        //private FormVisitante formVisitante;
        //private FormAcesso formAcesso;

        public FormPainelDeControle()
        {
            InitializeComponent();
            formConfiguracoes = new FormConfiguracoes(this);
            formMorador = new FormMorador(this);
        }

        private void btConfig_Click(object sender, EventArgs e)
        {


            this.formConfiguracoes.Show();
            this.Hide();
            
        }

        private void FormPainelDeControle_Enter(object sender, EventArgs e)
        {
            
        }

        private void FormPainelDeControle_Shown(object sender, EventArgs e)
        {
            
        }

        public void Atualizar()
        {
            if (Condominio.Self != null)
            {
                btConfig.Enabled = false;
                tsConfiguracoes.Enabled = false;
                btAddMorador.Enabled = true;
                tsMorador.Enabled = true;
                btAtivarDesatMorador.Enabled = true;

                btAddVisitante.Enabled = (Condominio.NumeroMoradoresAtivos > 0);
                tsVisitante.Enabled = (Condominio.NumeroMoradoresAtivos > 0);
                tsAcesso.Enabled = (Condominio.NumeroMoradoresAtivos > 0);
                btVerificacaodeAcesso.Enabled = (Condominio.NumeroMoradoresAtivos > 0);
            }
        }
    }
}
