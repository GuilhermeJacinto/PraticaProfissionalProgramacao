using Stonks_Adm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace Stonks_Adm.Communs
{
    public class Json
    {

        static public void salvaPessoaJSON(String local, List<Produto> lista)
        {
            StreamWriter file = new StreamWriter(local); 
            lista.ForEach(produto =>
            {
                string output = JsonConvert.SerializeObject(produto);
                file.WriteLine(output);
               // MessageBox.Show("deu boa 2");
            });
            file.Close();
        }

        static public void salvaProdutoJSON(String local2, List<Fornecedor> lista2)
        {
            StreamWriter file = new StreamWriter(local2);
            lista2.ForEach(Fornecedor =>
            {
                string output = JsonConvert.SerializeObject(Fornecedor);
                file.WriteLine(output);
               // MessageBox.Show("deu boa 2");
            });
            file.Close();
        }


        static public List<Produto> lerArquivoPessoasJSON(String local)
        {
            List<Produto> listaAuxProduto = new List<Produto>();

            if (!File.Exists(local))
            {
                StreamWriter documento;
                documento = File.AppendText(local);
              //  MessageBox.Show("deu boa 1");
                return listaAuxProduto;
            }
            else
            {
                string linha;

                StreamReader file = new StreamReader(local);
                while ((linha = file.ReadLine()) != null)
                {
                    Produto produto = JsonConvert.DeserializeObject<Produto>(linha);
                    listaAuxProduto.Add(produto);
                }

                file.Close();
                return listaAuxProduto;
            }
        }

        static public List<Fornecedor> lerArquivoFornecedorJSON(String local2)
        {
            List<Fornecedor> listaAuxFornecedor = new List<Fornecedor>();

            if (!File.Exists(local2))
            {
                StreamWriter documento;
                documento = File.AppendText(local2);
              //  MessageBox.Show("deu boa 1");
                return listaAuxFornecedor;
            }
            else
            {
                string linha;

                StreamReader file = new StreamReader(local2);
                while ((linha = file.ReadLine()) != null)
                {
                    Fornecedor Fornecedor = JsonConvert.DeserializeObject<Fornecedor>(linha);
                    listaAuxFornecedor.Add(Fornecedor);
                }

                file.Close();
                return listaAuxFornecedor;
            }
        }



    }
}
