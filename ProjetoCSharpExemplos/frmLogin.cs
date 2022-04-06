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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtItemLista.Enabled = false;

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lstListas.Items.Add("Morango");
            lstListas.Items.Add("Salgadinho");
            lstListas.Items.Add("Pera");
            lstListas.Items.Add("Refrigerante");
            lstListas.Items.Add("Carne");
        }

        private void lstListas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Item da lista" + lstListas.SelectedIndex.ToString());
            MessageBox.Show(lstListas.SelectedItem.ToString());
        }

        private void btnCarrega_Click(object sender, EventArgs e)
        {
            lblItemEscolhido.Text = lstListas.SelectedItem.ToString();

            Produtos pr = new Produtos();

            pr.Nome = "Banana";
            pr.Valor = 10.00;
            pr.DataEntrada = "06/04/2022";

            pr.Nome = "Morango";
            pr.Valor = 15.00;
            pr.DataEntrada = "05/04/2022";



        }

        private void btnInserirItem_Click(object sender, EventArgs e)
        {
            string itemLista = lstListas.SelectedItem.ToString();
            txtItemLista.Text = itemLista;

            //lstItensLista.Items.Clear();

            lstItensLista.Items.Add(txtItemLista.Text.ToString());

        }

        private void btnLimparLista_Click(object sender, EventArgs e)
        {
            lstItensLista.Items.Clear();
            txtItemLista.Clear();
            lstListas.SelectedIndex = 0;
        }
    }
}
