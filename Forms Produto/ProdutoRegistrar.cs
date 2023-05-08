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
    public partial class ProdutoRegistrar : Form
    {
        public ProdutoRegistrar()
        {
            InitializeComponent();
        }


        private void RegistraProdutoBtn_Click(object sender, EventArgs e)
        {
            var nomeProduto = nomeProdutoTextBox.Text;
            double precoProduto, custoProduto;
            double.TryParse(precoProdutoTextBox.Text, out precoProduto);
            double.TryParse(custoProdutoTextBox.Text, out custoProduto);
            var unidadeProduto = unidadeProdutoComboBox.Text;
            bool temNome = !nomeProduto.Equals(string.Empty);
            bool temPreco = !double.IsNaN(precoProduto);
            bool temCusto = !double.IsNaN(custoProduto);
            bool precoInvalido = precoProduto <= custoProduto;
            bool jaExiste = Produto.produtos.ContainsKey(nomeProduto);
            string error = "";
            if (!temNome) error += "O produto precisa de um nome.\n";
            if (!temPreco) error += "O produto precisa de um preço.\n";
            if (!temCusto) error += "O produto precisa de um custo.\n";
            if (precoInvalido) error += " O produto não pode ter um preço inferior ou igual ao custo \n";
            if (jaExiste) error += $"O produto {nomeProduto} já foi registrado";
            if (error.Length > 0)
            {
                MessageBox.Show(error);
                if (!temNome) nomeProdutoTextBox.BackColor = Color.IndianRed;
                if (!temCusto) custoProdutoTextBox.BackColor = Color.IndianRed;
                if (!temPreco) precoProdutoTextBox.BackColor = Color.IndianRed;
                if (precoInvalido)
                {
                    custoProdutoTextBox.BackColor = Color.IndianRed;
                    precoProdutoTextBox.BackColor = Color.IndianRed;
                }
                if (jaExiste) nomeProdutoTextBox.BackColor = Color.IndianRed;
                return;
            }
            else
            {
                new Produto(nomeProduto, precoProduto, custoProduto, unidadeProduto);
                MessageBox.Show($"O produto {nomeProduto} foi cadastrado");
                nomeProdutoTextBox.Text = string.Empty;
                precoProdutoTextBox.Text = string.Empty;
                custoProdutoTextBox.Text = string.Empty;
                unidadeProdutoComboBox.Text = string.Empty;
            }
        }

        private void precoProdutoTextBox_TextChanged(object sender, EventArgs e)
        {
            precoProdutoTextBox.BackColor = Color.White;
        }

        private void custoProdutoTextBox_TextChanged(object sender, EventArgs e)
        {
            custoProdutoTextBox.BackColor = Color.White;
        }

        private void nomeProdutoTextBox_TextChanged(object sender, EventArgs e)
        {
            nomeProdutoTextBox.BackColor = Color.White;
        }
    }
}
