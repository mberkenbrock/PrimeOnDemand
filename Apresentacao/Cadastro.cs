using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Dal;

namespace WindowsFormsApp1
{
    public partial class Cadastro : Form
    {

        public Cadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txSenha.Text == txSenhaConf.Text)
            {
                LoginDal loginDao = new LoginDal();
                loginDao.cadastrar(txusuario.Text,txEmail.Text,txSenha.Text);
                MessageBox.Show("Usuário Cadastrado com Sucesso", "Cadastro");
                Close();
            }
            else
            {
                MessageBox.Show("Senhas não conferem","Senha inválida");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
