using Stonks_Adm.Communs;
using Stonks_Adm.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stonks.Communs;

namespace Stonks_Adm.Forms
{
    public partial class FormFornecedor : Form
    {
        List<Fornecedor> listafornecedor;
        string local2 = @"C:\temp\FornecedorJson.json";
        public FormFornecedor(List<Fornecedor> listafornecedor)
        {
            InitializeComponent();
            this.listafornecedor = listafornecedor;
            listar(listafornecedor);
            Inicio();
        }

        private Fornecedor GetFornecedor()
        {
            Fornecedor cadFornecedor = new Fornecedor();

            cadFornecedor.Id = AutoId(listafornecedor);
            cadFornecedor.Nome = tbxNome.Text;
            cadFornecedor.Telefone = mktbTelefone.Text;
            cadFornecedor.Email = mktbEmail.Text;
            cadFornecedor.Categoria = cboxCategoria.Text;
            cadFornecedor.Produto = tbxProduto.Text;
            cadFornecedor.Preco = tbxPreco.Text;

            return cadFornecedor;
        }


        private void listar(List<Fornecedor> lista)
        {
            dataGVListar.DataSource = null;
            dataGVListar.DataSource = lista;
        }

        private void LimpaCampo()
        {
            tbxNome.Clear();
            mktbTelefone.Clear();
            mktbTelefone.Clear();
            mktbEmail.Clear();
            cboxCategoria.SelectedIndex = -1;
            tbxProduto.Clear();
            tbxPreco.Clear();
        }

        private int AutoId(List<Fornecedor> lista)
        {
            int id;
            if (ContagemList(lista) == 0)
            {
                return id = 1;
            }
            else
            {
                Fornecedor[] fornecedorArray = lista.ToArray();
                Fornecedor fornecedor = fornecedorArray[fornecedorArray.Length - 1];
                id = fornecedor.Id;
                return id + 1;
            }
        }

        private int ContagemList(List<Fornecedor> lista)
        {
            int contagem = lista.Count();
            return contagem;
        }

        private void Inicio()
        {
            lblNome.Visible = false;
            lblCategoria.Visible = false;
            lblValorProduto.Visible = false;
            lblTelefone.Visible = false;
            lblProduto.Visible = false;
            tbxEmail.Visible = false;
            tbxNome.Visible = false;
            tbxPreco.Visible = false;
            tbxProduto.Visible = false;
            mktbEmail.Visible = false;
            mktbTelefone.Visible = false;
            cboxCategoria.Visible = false;
            btnID.Visible = false;
            lblID.Visible = false;
            tBoxID.Visible = false;
            btnInserir.Visible = false;
            btnRemover.Visible = false;
            btnEditar.Visible = false;
            btnMostarEdicao.Visible = false;
        }
        private void FormID()
        {
            lblNome.Visible = false;
            lblCategoria.Visible = false;
            lblValorProduto.Visible = false;
            lblTelefone.Visible = false;
            lblProduto.Visible = false;
            tbxEmail.Visible = false;
            tbxNome.Visible = false;
            tbxPreco.Visible = false;
            tbxProduto.Visible = false;
            mktbEmail.Visible = false;
            mktbTelefone.Visible = false;
            cboxCategoria.Visible = false;
            btnID.Visible = false;
            lblID.Visible = true;
            tBoxID.Visible = true;
            btnID.Visible = true;
            btnInserir.Visible = false;
            btnMostarEdicao.Visible = false;
        }

        private void FormCadastro()
        {
            lblNome.Visible = true;
            lblCategoria.Visible = true;
            lblValorProduto.Visible = true;
            lblTelefone.Visible = true;
            lblProduto.Visible = true;
            tbxEmail.Visible = true;
            tbxNome.Visible = true;
            tbxPreco.Visible = true;
            tbxProduto.Visible = true;
            mktbEmail.Visible = true;
            mktbTelefone.Visible = true;
            cboxCategoria.Visible = true;
            lblID.Visible = false;
            tBoxID.Visible = false;
            btnInserir.Visible = true;
            btnID.Visible = false;
            btnMostarEdicao.Visible = false;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Remover(listafornecedor);
            listar(listafornecedor);
        }
        private bool Remover(List<Fornecedor> listaFornecedor)
        {
            if (ContagemList(listaFornecedor) == 0)
            {
                MessageBox.Show("Nenhuma Fornecedor Cadastrado!");
            }
            else
            {
                foreach (var cadastros in listaFornecedor)
                {
                    if (cadastros.Id == Convercao.ConvertInt(tBoxID.Text))
                    {
                        if (MessageBox.Show("Deseja Realmente Remover?", "Confirmação!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            MessageBox.Show("Cadastro Removido com Sucesso!");
                            listaFornecedor.Remove(cadastros);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Cadastro Não Removido!");
                            return false;
                        }
                    }
                }
                MessageBox.Show("Favor Inserir um Nome Válido!");
            }
            return false;
        }

        private bool EditarFornecedor(List<Fornecedor> listafornecedor)
        {
            if (ContagemList(listafornecedor) == 0)
            {
                MessageBox.Show("Nenhuma Fornecedor Cadastrado!");
            }
            else
            {
                foreach (var cadastros in listafornecedor)
                {
                    if (cadastros.Id == Convercao.ConvertInt(tBoxID.Text))
                    {
                        cadastros.Nome = tbxNome.Text;
                        cadastros.Telefone = mktbTelefone.Text;
                        cadastros.Email = mktbEmail.Text;
                        cadastros.Categoria = cboxCategoria.Text;
                        cadastros.Produto = tbxProduto.Text;
                        cadastros.Preco = tbxPreco.Text;
                        MessageBox.Show("Edição Realizada!");
                        return true;
                    }
                }
                MessageBox.Show("Favor Inserir um Nome Válido!");
            }
            return false;
        }

        private void btnPagCadastro_Click(object sender, EventArgs e)
        {
            FormCadastro();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Fornecedor cadFornecedor = GetFornecedor();
            listafornecedor.Add(cadFornecedor);
            Json.salvaProdutoJSON(local2, listafornecedor);
            listar(listafornecedor);
            LimpaCampo();
            MessageBox.Show("Produto Inserido com Sucesso!");

        }

        private void btnPagRemover_Click(object sender, EventArgs e)
        {
            FormID();
        }

        private void btnID_Click(object sender, EventArgs e)
        {
            try
            {
                MostrarDados(listafornecedor);
                FormRemover();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Favor Inserir um Valor Válido!");
            }
        }
        private bool MostrarDados(List<Fornecedor> listafornecedor)
        {
            if (ContagemList(listafornecedor) == 0)
            {
                MessageBox.Show("Nenhum Dados para Mostrar!");
            }
            else
            {
                foreach (var cadFornecedor in listafornecedor)
                {
                    if (cadFornecedor.Id == Convercao.ConvertInt(tBoxID.Text))
                    {
                        tbxNome.Text = cadFornecedor.Nome;
                        mktbTelefone.Text = cadFornecedor.Telefone;
                        mktbEmail.Text = cadFornecedor.Email;
                        cboxCategoria.Text = cadFornecedor.Categoria;
                        tbxProduto.Text = cadFornecedor.Produto;
                        tbxPreco.Text = cadFornecedor.Preco;
                        return true;
                    }
                }
                MessageBox.Show("Favor Inserir um Nome Válido!");
            }
            return false;
        }
        private void FormRemover()
        {
            lblNome.Visible = true;
            tbxNome.Visible = true;
            lblTelefone.Visible = true;
            mktbTelefone.Visible = true;
            tbxEmail.Visible = true;
            mktbEmail.Visible = true;
            lblCategoria.Visible = true;
            cboxCategoria.Visible = true;
            lblProduto.Visible = true;
            tbxProduto.Visible = true;
            lblValorProduto.Visible = true;
            tbxProduto.Visible = true;
            tbxPreco.Visible = true;
            btnRemover.Visible = true;
            btnMostarEdicao.Visible = true;
        }

        private void btnRemover_Click_1(object sender, EventArgs e)
        {
            FormID();
            Remover(listafornecedor);
            listar(listafornecedor);
            btnID.Visible = true;
        }

        private void btnPagEditar_Click(object sender, EventArgs e)
        {
            FormID2();
            listar(listafornecedor);
        }
        private void FormID2()
        {
            lblNome.Visible = false;
            lblCategoria.Visible = false;
            lblValorProduto.Visible = false;
            lblTelefone.Visible = false;
            lblProduto.Visible = false;
            tbxEmail.Visible = false;
            tbxNome.Visible = false;
            tbxPreco.Visible = false;
            tbxProduto.Visible = false;
            mktbEmail.Visible = false;
            mktbTelefone.Visible = false;
            cboxCategoria.Visible = false;
            btnID.Visible = false;
            lblID.Visible = true;
            tBoxID.Visible = true;
            btnID.Visible = true;
            btnInserir.Visible = false;
            btnRemover.Visible = false;
            btnEditar.Visible = false;
            btnMostarEdicao.Visible = true;
            btnID.Visible = false;

        }

        private void btnMostarEdicao_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    MostrarDados(listafornecedor);
                    FormVerificar();
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Favor Inserir um Valor Válido!");
                }
            }
        }
        private void FormVerificar()
        {
            lblNome.Visible = true;
            tbxNome.Visible = true;
            lblTelefone.Visible = true;
            mktbTelefone.Visible = true;
            tbxEmail.Visible = true;
            mktbEmail.Visible = true;
            lblCategoria.Visible = true;
            cboxCategoria.Visible = true;
            lblProduto.Visible = true;
            tbxProduto.Visible = true;
            lblValorProduto.Visible = true;
            tbxProduto.Visible = true;
            tbxPreco.Visible = true;
            btnRemover.Visible = false;
            btnMostarEdicao.Visible = true;
            btnEditar.Visible = true;
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {  
                EditarFornecedor(listafornecedor);
                listar(listafornecedor);
        }
    }

}

