using System;
using System.Collections.Generic;
using System.Collections.Immutable;
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
    public partial class Venda : Form
    {
        static Dictionary<string, ProdutoVendido> listaDeCompra = new Dictionary<string, ProdutoVendido>();
        public Venda()
        {
            InitializeComponent();
            BindingSource bsCaminhao = new BindingSource();
            bsCaminhao.DataSource = Caminhao.caminhoes;
            placaComboBox.DataSource = bsCaminhao;
            placaComboBox.DisplayMember = "Key";
            placaComboBox.ValueMember = "Key";
            BindingSource bsProduto = new BindingSource();
            bsProduto.DataSource = Produto.produtos;
            nomeProdutoComboBox.DataSource = bsProduto;
            nomeProdutoComboBox.DisplayMember = "Key";
            nomeProdutoComboBox.ValueMember = "Key";

        }

        private void placaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var caminhao = (KeyValuePair<object, Caminhao>)placaComboBox.SelectedItem;
        }

        private void nomeProdutoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var produto = (KeyValuePair<string, Produto>)nomeProdutoComboBox.SelectedItem;
            unidadeLabel.Text = produto.Value.Unidade;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var produto = (KeyValuePair<string, Produto>)nomeProdutoComboBox.SelectedItem;
            var caminhao = (KeyValuePair<object, Caminhao>)placaComboBox.SelectedItem;
            var quantidade = double.Parse(quantidadeProdutoTextBox.Text);
            int diaDaSemanaInt = (int)DateTime.Now.DayOfWeek;
            int diaDaSemanaIntSegunda = ((diaDaSemanaInt - 1 + 7) % 7) + 1;
            int diaDaSemana = diaDaSemanaIntSegunda;
            if (!listaDeCompra.TryAdd(produto.Value.Nome, new ProdutoVendido(produto.Value, quantidade, diaDaSemana)))
            {
                var novaQuantidade = listaDeCompra[produto.Value.Nome].QuantVendida + quantidade;
                listaDeCompra[produto.Value.Nome] = new ProdutoVendido(produto.Value, novaQuantidade, diaDaSemana);
            }
            atualizaListaDeCompras();
            MessageBox.Show("Produto Adicionado");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            modificaItemBtn.Enabled = true;
            deletaItemBtn.Enabled = true;
        }

        private void modificaItemBtn_Click(object sender, EventArgs e)
        {
            var index = listaDeComprasListBox.SelectedIndex;
            var produto = listaDeComprasListBox.Items[index].ToString();
            produto = produto.Substring(0, 20).Trim();
            listaDeCompra.Remove(produto);
            atualizaListaDeCompras();
            MessageBox.Show("Produto Removido");
        }
        private void atualizaListaDeCompras()
        {
            listaDeComprasListBox.Items.Clear();
            foreach (KeyValuePair<string, ProdutoVendido> item in listaDeCompra)
            {
                var nomeProduto = item.Key;
                var quantidadeProduto = item.Value.QuantVendida.ToString();
                var precoProduto = item.Value.PrecoPraticado.ToString();
                var promocaoProduto = item.Value.DescPromocao;
                var totalProduto = item.Value.ValorVendido.ToString();
                nomeProduto = nomeProduto.PadRight(20, ' ');
                quantidadeProduto = quantidadeProduto.PadLeft(10, ' ');
                precoProduto = precoProduto.PadLeft(6, ' ');
                promocaoProduto = promocaoProduto.PadLeft(12, ' ');
                totalProduto = totalProduto.PadLeft(8, ' ');
                listaDeComprasListBox.Items.Add($"{nomeProduto} - {quantidadeProduto} - R$ {precoProduto} - {promocaoProduto} - R$ {totalProduto}");
            }
        }
    }
}
