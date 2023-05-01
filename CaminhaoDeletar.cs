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
    public partial class CaminhaoDeletar : Form
    {
        public CaminhaoDeletar()
        {
            InitializeComponent();
            BindingSource bs = new BindingSource();
            bs.DataSource = Caminhao.caminhoes;
            placaComboBox.DataSource = bs;
            placaComboBox.DisplayMember = "Key";
            placaComboBox.ValueMember = "Key";
        }

        private void deletarBtn_Click(object sender, EventArgs e)
        {
            var placa = placaComboBox.Text;
            if (Caminhao.caminhoes.ContainsKey(placa))
            {
                avisoLabel.Text = "Caminhão Deletado";
                Caminhao.caminhoes.Remove(placa);
            }
            else
            {
                avisoLabel.Text = "Não Existe Registro do Caminhão";
            }
        }

        private void placaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var itemSelecionado = placaComboBox.SelectedItem.ToString();
            string placaSelecionada = itemSelecionado.Substring(1, itemSelecionado.IndexOf(',') - 1);
            var caminhao = Caminhao.caminhoes[placaSelecionada];
            idTextBox.Text = caminhao.Proprietario;
            fabricanteComboBox.Text = caminhao.Fabricante;
            corComboBox.Text = caminhao.Cor;
            modeloComboBox.Text = caminhao.Modelo;
            anoComboBox.Text = caminhao.AnoDeFabricacao.ToString();
            KmTextBox.Text = caminhao.KmRodado.ToString();
            renavamTextBox.Text = caminhao.Renavam.ToString();
        }
    }
}
