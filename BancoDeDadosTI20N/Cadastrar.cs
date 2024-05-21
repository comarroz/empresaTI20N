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
    public partial class Cadastrar : Form
       
    {
        Dao bd;

        public Cadastrar()
        {
            InitializeComponent();
            bd = new Dao();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }// fim do campo cpf

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }// fim do nome 

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }// fi do telefone

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }//Fim do endereço

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                long cpf = Convert.ToInt64(textBox1.Text);
                string nome = textBox2.Text;
                string telefone = textBox3.Text;
                string endereco = textBox4.Text;
                MessageBox.Show(bd.inserir(cpf, nome, telefone, endereco));//Insere dados no BD
                                                                           //Limpar a tela
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }catch(Exception ex)
            {
                MessageBox.Show("Algo deu errado!\n\n" + ex);
            }



        }//fim do cadastrar

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }//fim do cancelar
    }
}
