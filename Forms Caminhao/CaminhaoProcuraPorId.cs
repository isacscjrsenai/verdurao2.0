using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using VerduraoDoJao.Melanciometro;

namespace VerduraoDoJoao2._0
{
    public partial class CaminhaoProcuraPorId : Form
    {
        public CaminhaoProcuraPorId()
        {
            InitializeComponent();
        }

        private void idComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var itemSelecionado = idComboBox.SelectedItem.ToString();
            string idSelecionada = itemSelecionado.Substring(1, itemSelecionado.IndexOf(",") - 1);
            var caminhoes = Caminhao.caminhoes.Where(k => k.Value.Proprietario.Equals(idSelecionada));
            placaComboBox.Items.Clear();
            fabricanteComboBox.Items.Clear();
            foreach (var item in caminhoes)
            {
                placaComboBox.Items.Add(item.Value.Placa);
                fabricanteComboBox.Items.Add(item.Value.Fabricante);
                corComboBox.Items.Add(item.Value.Cor);
                modeloComboBox.Items.Add(item.Value.Modelo);
                anoComboBox.Items.Add(item.Value.AnoDeFabricacao);
                kmComboBox.Items.Add(item.Value.KmRodado);
                renavamComboBox.Items.Add(item.Value.KmRodado);
            }
            placaComboBox.Enabled = true;
            renavamComboBox.Enabled = true;
        }

        private void idComboBox_TextChanged(object sender, EventArgs e)
        {
            idComboBox.Items.Clear();
            var idProcurada = idComboBox.Text;
            var listaIds = Caminhao.caminhoes.Keys.Where(k => k.ToString().StartsWith(idProcurada));
            if (listaIds.Count() > 0)
            {
                var idsAchadas = listaIds.ToArray();
                idComboBox.Items.AddRange(idsAchadas);
            }

        }

        private void placaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var itemSelecionado = idComboBox.SelectedItem.ToString();
            string placaSelecionada = itemSelecionado.Substring(1, itemSelecionado.IndexOf(",") - 1);
            fabricanteComboBox.Items.Clear();
            corComboBox.Items.Clear();
            modeloComboBox.Items.Clear();
            anoComboBox.Items.Clear();
            kmComboBox.Items.Clear();
            renavamComboBox.Items.Clear();
            fabricanteComboBox.Text = Caminhao.caminhoes[placaSelecionada].Fabricante;
            corComboBox.Text = Caminhao.caminhoes[placaSelecionada].Cor;
            modeloComboBox.Text = Caminhao.caminhoes[placaSelecionada].Modelo;
            anoComboBox.Text = Caminhao.caminhoes[placaSelecionada].AnoDeFabricacao.ToString();
            kmComboBox.Text = Caminhao.caminhoes[placaSelecionada].KmRodado.ToString();
            renavamComboBox.Text = Caminhao.caminhoes[placaSelecionada].Renavam;

        }

        private void renavamComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var itemSelecionado = idComboBox.SelectedItem.ToString();
            string revanamSelecionado = itemSelecionado.Substring(1, itemSelecionado.IndexOf(",") - 1);
            fabricanteComboBox.Items.Clear();
            corComboBox.Items.Clear();
            modeloComboBox.Items.Clear();
            anoComboBox.Items.Clear();
            kmComboBox.Items.Clear();
            placaComboBox.Items.Clear();
            var caminhao = Caminhao.caminhoes.Values.First(c => c.Renavam.Equals(revanamSelecionado));
            fabricanteComboBox.Text = caminhao.Fabricante;
            corComboBox.Text = caminhao.Cor;
            modeloComboBox.Text = caminhao.Modelo;
            anoComboBox.Text = caminhao.ToString();
            kmComboBox.Text = caminhao.KmRodado.ToString();
            renavamComboBox.Text = caminhao.Renavam;
        }
    }
}
