using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCSharpExemplos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (txtVerificar.Text.Equals("senac"))
            {
                MessageBox.Show("Verificado!!!");

                MessageBox.Show("Você digitou: \n\n"+txtVerificar.Text,
                    "Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show("Não Verificado!!!");
                txtVerificar.Focus();
                txtVerificar.Clear();
            }
        }

        private void btnCarregaLista_Click(object sender, EventArgs e)
        {

        }
    }
}
