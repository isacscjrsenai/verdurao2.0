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
    public partial class ProdutoModificar : Form
    {
        public ProdutoModificar()
        {
            InitializeComponent();
            BindingSource bs = new BindingSource();
            bs.DataSource = Produto.produtos;
            nomeProdutoComboBox.DataSource = bs;
            nomeProdutoComboBox.DisplayMember = "Key";
            nomeProdutoComboBox.ValueMember = "Key";
        }

        private void nomeProdutoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var produto = (KeyValuePair<string, Produto>)nomeProdutoComboBox.SelectedItem;
            custoProdutoComboBox.Text = produto.Value.Custo.ToString();
            precoProdutoComboBox.Text = produto.Value.Preco.ToString();
            unidadeProdutoComboBox.Text = produto.Value.Unidade;
        }

        private void ModificarProdutoBtn_Click(object sender, EventArgs e)
        {
            var produto = (KeyValuePair<string, Produto>)nomeProdutoComboBox.SelectedItem;
            var custo = custoProdutoComboBox.Text;
            var preco = precoProdutoComboBox.Text;
            var unidade = unidadeProdutoComboBox.Text;
            bool custoIgual = double.Parse(custo) == produto.Value.Custo;
            bool precoIgual = double.Parse(preco) == produto.Value.Preco;
            bool unidadeIgual = unidade.Equals(produto.Value.Unidade);
            if (!custoIgual || !precoIgual || !unidadeIgual)
            {
                Produto.produtos[produto.Value.Nome].Preco = double.Parse(preco);
                Produto.produtos[produto.Value.Nome].Custo = double.Parse(custo);
                Produto.produtos[produto.Value.Nome].Unidade = unidade;
                MessageBox.Show("Produto Modificado");
            }
            else
            {
                MessageBox.Show("Para modificar mude o preço, custo ou unidade");
            }
        }
    }
}
