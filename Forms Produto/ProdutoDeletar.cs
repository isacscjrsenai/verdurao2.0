using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VerduraoDoJao.Melanciometro;

namespace VerduraoDoJoao2._0
{
    public partial class ProdutoDeletar : Form
    {
        public ProdutoDeletar()
        {
            InitializeComponent();
            BindingSource bs = new BindingSource();
            bs.DataSource = Produto.produtos;
            nomeProdutoComboBox.DataSource = bs;
            nomeProdutoComboBox.DisplayMember = "Key";
            nomeProdutoComboBox.ValueMember = "Key";
            precoProdutoComboBox.Enabled = false;
            custoProdutoComboBox.Enabled = false;
            unidadeProdutoComboBox.Enabled = false;
        }

        private void DeletarProdutoBtn_Click(object sender, EventArgs e)
        {

            var produto = (Produto)nomeProdutoComboBox.SelectedItem;
            if (produto != null)
            {
                Produto.produtos.Remove(produto.Nome);
                MessageBox.Show($"Produto {produto.Nome} deletado");
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            var produto = (KeyValuePair<string, Produto>)nomeProdutoComboBox.SelectedItem;
            custoProdutoComboBox.Text = produto.Value.Custo.ToString();
            precoProdutoComboBox.Text = produto.Value.Preco.ToString();
            unidadeProdutoComboBox.Text = produto.Value.Unidade;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
