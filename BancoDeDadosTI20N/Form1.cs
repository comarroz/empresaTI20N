using Google.Protobuf.WellKnownTypes;
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
    public partial class Form1 : Form

    {
        Cadastrar cad;
        Consultar con;
        Atualizar atu;
        Excluir exc;
        public Form1()
        {
            InitializeComponent();

            cad = new Cadastrar();
            con = new Consultar();
            atu = new Atualizar();
            exc = new Excluir();
        }//Construtor na tela

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            cad.ShowDialog();

        }//Fim do botão cadastrar

        private void Consultar_Click(object sender, EventArgs e)
        {
            con = new Consultar(); //Consultar Atualizadas!!
            con.ShowDialog();

        }// fim do botão Consultar

        private void Atualizar_Click(object sender, EventArgs e)
        {
            atu.ShowDialog();
        }//FIm fdo atualizar

        private void Excluir_Click(object sender, EventArgs e)
        {
            exc.ShowDialog();

        }//Fim do excluir
    }//fim fo projeto
}
