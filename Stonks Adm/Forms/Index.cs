using Stonks_Adm.Communs;
using Stonks_Adm.Entity;
using Stonks_Adm.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stonks_Adm
{
    public partial class Index : Form
    {
        List<Entity.Produto> listaProdutos;
        List<Entity.Fornecedor> listaFornecedor;
        public Index()
        {
            InitializeComponent();
            listaProdutos = new List<Entity.Produto>();
            listaFornecedor = new List<Entity.Fornecedor>();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Forms.FormProdutos formularioProdutos = new Forms.FormProdutos(listaProdutos);
            formularioProdutos.Show();
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            Forms.FormFornecedor formularioFornecedor = new Forms.FormFornecedor(listaFornecedor);
            formularioFornecedor.Show();
        }
    }
}
