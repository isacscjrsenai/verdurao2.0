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
        BindingSource bsCaminhao = new BindingSource();
        BindingSource bsProduto = new BindingSource();
        BindingSource bsListaDeCompras = new BindingSource();
        public Venda()
        {
            InitializeComponent();
            bsCaminhao.DataSource = Caminhao.caminhoes;
            placaComboBox.DataSource = bsCaminhao;
            placaComboBox.DisplayMember = "Key";
            placaComboBox.ValueMember = "Key";
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
            var itensVendidos = atualizaListaDeCompras();
            listaDeComprasListBox.ValueMember = "id";
            listaDeComprasListBox.DisplayMember = "name";
            listaDeComprasListBox.DataSource = itensVendidos;
            listaDeComprasListBox.Refresh();

            MessageBox.Show("Produto Adicionado");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            modificaItemBtn.Enabled = true;
            deletaItemBtn.Enabled = true;
        }

        private void modificaItemBtn_Click(object sender, EventArgs e)
        {
            var formModificaItem = new VendaModificaItem();
            formModificaItem.ShowDialog();
            var index = listaDeComprasListBox.SelectedIndex;
            var produto = listaDeComprasListBox.Items[index].ToString();
            produto = produto.Substring(0, 26).Trim();
            listaDeCompra[produto].QuantVendida = double.Parse(formModificaItem.novaQuantidade);
            var itensVendidos = atualizaListaDeCompras();
            listaDeComprasListBox.ValueMember = "id";
            listaDeComprasListBox.DisplayMember = "name";
            listaDeComprasListBox.DataSource = itensVendidos;
            listaDeComprasListBox.Refresh();
            MessageBox.Show("Quantidade modificada", "Verdurão do João");

        }
        private List<string> atualizaListaDeCompras()
        {
            //listaDeComprasListBox.Items.Clear();
            List<string> itensVendidos = new List<string>();
            foreach (KeyValuePair<string, ProdutoVendido> item in listaDeCompra)
            {
                var nomeProduto = item.Key;
                var quantidadeProduto = Math.Round(item.Value.QuantVendida, 2).ToString();
                var precoProduto = Math.Round(item.Value.PrecoPraticado, 2).ToString();
                var promocaoProduto = item.Value.DescPromocao;
                var totalProduto = Math.Round(item.Value.ValorVendido, 2).ToString();
                nomeProduto = nomeProduto.PadRight(26, ' ');
                quantidadeProduto = quantidadeProduto.PadLeft(20, ' ');
                precoProduto = precoProduto.PadLeft(8, ' ');
                promocaoProduto = promocaoProduto.PadLeft(13, ' ');
                totalProduto = totalProduto.PadLeft(14, ' ');
                itensVendidos.Add($"{nomeProduto} - {quantidadeProduto} - R$ {precoProduto} - {promocaoProduto} - R$ {totalProduto}");
            }
            return itensVendidos;

        }

        private void quantidadeProdutoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (quantidadeProdutoTextBox.Text.Length == 0)
            {
                adicionarProdutoBtn.Enabled = false;
                return;
            }
            if (double.Parse(quantidadeProdutoTextBox.Text) > 0)
            {
                adicionarProdutoBtn.Enabled = true;
            }
        }

        private void quantidadeProdutoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void deletaItemBtn_Click(object sender, EventArgs e)
        {
            var index = listaDeComprasListBox.SelectedIndex;
            var produto = listaDeComprasListBox.Items[index].ToString();
            produto = produto.Substring(0, 26).Trim();
            listaDeCompra.Remove(produto);
            var itensVendidos = atualizaListaDeCompras();
            listaDeComprasListBox.ValueMember = "id";
            listaDeComprasListBox.DisplayMember = "name";
            listaDeComprasListBox.DataSource = itensVendidos;
            listaDeComprasListBox.Refresh();
            if (listaDeCompra.Count == 0)
            {
                modificaItemBtn.Enabled = false;
                deletaItemBtn.Enabled = false;
            }
            MessageBox.Show("Produto Removido","Verdurão do João");
        }
    }
}
