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
    public partial class FormMorador : Form
    {
        private FormPainelDeControle formPainelDeControle;
        public FormMorador(FormPainelDeControle formPainelDeControle)
        {
            InitializeComponent();
            this.formPainelDeControle = formPainelDeControle;
        }

        private void FormMorador_Load(object sender, EventArgs e)
        {

        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            formPainelDeControle.Show();
            formPainelDeControle.Atualizar();
            this.Hide();
        }

        private void btAddMorador_Click(object sender, EventArgs e)
        {
            if (tbNome.Text.Length > 0 && tbCPF.Text.Length>0 && tbSenha.Text.Length >= Morador.TAM_MIN_SENHA)
            {
                string nome = tbNome.Text;
                string cpf = tbCPF.Text;
                string senha = tbSenha.Text;
                Morador m = new Morador(nome, cpf, senha);
                if (Condominio.Self.AddMorador(m))
                {
                    ListViewItem item = new ListViewItem(nome);
                    item.SubItems.Add(cpf);
                    item.SubItems.Add("Sim");
                    lvMoradores.Items.Add(item);
                    MessageBox.Show("Moradorr adicionado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao adicionar morador!");
                }
            }
            else
            {
                MessageBox.Show("Dados incompletos ou senha não comtém caracteres suficientes!");
            }
        }
    }
}
