using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerduraoDoJoao2._0
{
    public partial class VendaModificaItem : Form
    {
        public string novaQuantidade;
        public VendaModificaItem()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (quantidadeProdutoTextBox.Text.Length == 0)
            {
                modificaProdutoBtn.Enabled = false;
                return;
            }
            if (double.Parse(quantidadeProdutoTextBox.Text) > 0)
            {
                modificaProdutoBtn.Enabled = true;
            }
        }

        private void quantidadeProdutoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void modificaProdutoBtn_Click(object sender, EventArgs e)
        {
            novaQuantidade = quantidadeProdutoTextBox.Text;
            this.Close();
        }
    }
}
