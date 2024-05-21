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
    public partial class Excluir : Form
    {
        Dao bd;
        public Excluir()
        {
            InitializeComponent();
            bd = new Dao();  
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                long cpf = Convert.ToInt64(textBox1.Text);// Coletando o cpf
                MessageBox.Show(bd.Excluir(cpf, "pessoa"));
            }catch(Exception ex)
            {
                MessageBox.Show("Algo deu errado\n\n" + ex);
            }


        }// fim do botão excluir

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }// fim do botão Cancelar
    }//fim da classe
}// fim do projeto
