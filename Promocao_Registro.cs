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
    public partial class Promocao_Registro : Form
    {
        public List<CheckBox> dias;
        public Promocao_Registro()
        {
            InitializeComponent();
            dias = new List<CheckBox>() { segundaCheckBox, tercaCheckBox, quartaCheckBox, QuintaCheckBox, SextaCheckBox };
        }

        private void descontoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (descontoTextBox.Text.Length == 0)
            {
                incluiItemBtn.Enabled = false;
                condicoesCheckedListBox.Enabled = false;
                return;
            }
            if (double.Parse(descontoTextBox.Text) > 0)
            {
                incluiItemBtn.Enabled = true;
                condicoesCheckedListBox.Enabled = true;
            }
        }

        private void descontoTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void diaDaSemanaCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nomeDaPromocaoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (nomeDaPromocaoTextBox.Text.Length == 0)
            {
                incluiItemBtn.Enabled = false;
                diasGroupBox.Enabled = false;
                modificaItemBtn.Enabled = false;
                registraPromocaoBtn.Enabled = false;
                nomeProdutoComboBox.Enabled = false;
                descontoTextBox.Enabled = false;

                condicaoValorItemLabel.Visible = false;
                condicaoValorTotalLabel.Visible = false;
                condicaoQuantidadeLabel.Visible = false;

                condicaoValorTotalTextBox.Visible = false;
                condicaoQuantidadeTextBox.Visible = false;
                condicaoValorItemTextBox.Visible = false;
                return;
            }
            if (nomeDaPromocaoTextBox.Text.Length > 0)
            {
                diasGroupBox.Enabled = true;
            }
        }

        private void diaUtilCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            habilitaDias(dias, sender);
        }
        private void habilitaDias(List<CheckBox> dias, object sender)
        {
            foreach (CheckBox chk in dias)
            {
                chk.Checked = ((CheckBox)sender).Checked;
                chk.Enabled = !((CheckBox)sender).Checked;
            }
        }

        private void fimDeSemanaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var fimDeSemana = new List<CheckBox>() { sabadoCheckBox, domingoCheckBox };
            habilitaDias(fimDeSemana, sender);
            HabilitaNomeProduto();
        }

        private void nomeProdutoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            descontoTextBox.Enabled = true;
        }

        private void segundaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            HabilitaNomeProduto();
        }

        private void tercaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            HabilitaNomeProduto();
        }

        private void quartaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            HabilitaNomeProduto();
        }

        private void QuintaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            HabilitaNomeProduto();
        }

        private void SextaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            HabilitaNomeProduto();
        }

        private void sabadoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            HabilitaNomeProduto();
        }

        private void domingoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            HabilitaNomeProduto();
        }

        private void feriadoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            HabilitaNomeProduto();
        }
        private void HabilitaNomeProduto()
        {
            var checkboxes = new List<CheckBox>() { segundaCheckBox, tercaCheckBox, quartaCheckBox, QuintaCheckBox, SextaCheckBox, sabadoCheckBox, domingoCheckBox, feriadoCheckBox };
            bool algumDiaMarcado =false;
            foreach (var checkbox in checkboxes)
            {
                if (checkbox.Checked)
                {
                    algumDiaMarcado = true;
                    break;
                }
            }
            nomeProdutoComboBox.Enabled = algumDiaMarcado;
        }

        private void incluiItemBtn_Click(object sender, EventArgs e)
        {
            modificaItemBtn.Enabled = true;
            registraPromocaoBtn.Enabled = true;
        }

        private void condicaoTextBox_TextChanged(object sender, EventArgs e)
        {
            habiltaIncluirItem();
        }
        private void habiltaIncluirItem()
        {
            var textboxes = new List<TextBox>() { condicaoQuantidadeTextBox, condicaoValorItemTextBox, condicaoValorTotalTextBox };
            bool algumAtivoEPreenchido = false;
            foreach (var textbox in textboxes)
            {
                if (textbox.Enabled && textbox.Text.Length > 0)
                {
                    algumAtivoEPreenchido = true;
                }
            }
            incluiItemBtn.Enabled = algumAtivoEPreenchido;
        }

        private void condicaoTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void condicoesCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var itensChecados = condicoesCheckedListBox.CheckedIndices;
            foreach(var item in itensChecados)
            {
                switch(item)
                {
                    case 0:condicaoValorTotalLabel.Visible = true;
                           condicaoValorTotalTextBox.Visible = true;
                            break;
                    case 1:condicaoValorItemLabel.Visible = true;
                           condicaoValorItemTextBox.Visible = true;
                           break;
                    case 2:condicaoQuantidadeLabel.Visible = true;
                           condicaoQuantidadeTextBox.Visible = true;
                           break;
                }
            }
            
        }

        private void condicaoValorItemTextBox_TextChanged(object sender, EventArgs e)
        {
            habiltaIncluirItem();
        }

        private void condicaoQuantidadeTextBox_TextChanged(object sender, EventArgs e)
        {
            habiltaIncluirItem();
        }
    }
}
