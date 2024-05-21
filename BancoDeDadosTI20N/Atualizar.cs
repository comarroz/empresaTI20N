using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoDeDadosTI20N
{
    public partial class Atualizar : Form

    {
        Dao bd;
        public Atualizar()
            
        {
            InitializeComponent();
            bd = new Dao();
        }

        private void Atualizar_Load(object sender, EventArgs e)
        {
           
  

        }//Fim do botão atualizar

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }// fim do campo cpf

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }// fim do espaço campo

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }// fim do espaço dado

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                long cpf = Convert.ToInt64(textBox3.Text);
                string campo = textBox1.Text;
                string dado = textBox2.Text;
                //Atualizar os daos
                MessageBox.Show(bd.Atualizar(cpf, "pessoa", campo, dado));
                //Limpar os dados

                textBox3.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
            }catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado\n\n" + ex);
            }
        }// fim do atualizar

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }// fim do cancelar
    }
}
