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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VerduraoDoJoao2._0
{
    public partial class Caminhao1 : Form
    {
        public Caminhao1()
        {
            InitializeComponent();
            BindingSource bs = new BindingSource();
            bs.DataSource = Caminhao.modelos;
            fabricanteComboBox.DataSource = bs;
            fabricanteComboBox.DisplayMember = "Key";
            fabricanteComboBox.ValueMember = "Key";
            modeloComboBox.DataSource = bs;
            modeloComboBox.DisplayMember = "Value";
            modeloComboBox.ValueMember = "Key";
            modeloComboBox.Enabled = false;
        }

        private void registrarBtn_Click(object sender, EventArgs e)
        {
            var campoInvalido = false;
            Dictionary<string, string> args = new Dictionary<string, string>();
            var placa = placaTextBox.Text;
            if (!Caminhao.IsValidPlate(placa))
            {
                placaTextBox.BackColor = Color.IndianRed;
                campoInvalido = true;
            }
            else args.Add("Placa", placa);

            var id = idTextBox.Text;
            if (!Cliente.IsValidCnpj(id) && !Cliente.IsValidCpf(id))
            {
                idTextBox.BackColor = Color.IndianRed;
                campoInvalido = true;
            }
            else args.Add("Id", id);

            var renavam = renavamTextBox.Text;
            if (!Caminhao.IsValidRenavam(renavam) && renavam.Length > 0)
            {
                renavamTextBox.BackColor = Color.IndianRed;
                campoInvalido = true;
            }
            else args.Add("Renavam", renavam);

            var fabricante = fabricanteComboBox.Text;
            if (fabricante.Length > 0)
            {
                args.Add("Fabricante", fabricante);
            }

            var modelo = modeloComboBox.Text;
            if (modelo.Length > 0)
            {
                args.Add("Modelo", modelo);
            }

            var cor = corComboBox.Text;
            if (cor.Length > 0)
            {
                args.Add("Cor", cor);
            }

            var ano = anoComboBox.Text;
            if (ano.Length > 0)
            {
                args.Add("Ano", ano);
            }

            var kmRodado = KmTextBox.Text;
            if (kmRodado.Length > 0)
            {
                args.Add("Km Rodado", kmRodado);
            }
            if (!campoInvalido)
            {
                new Caminhao(args);
                LimpaFormulario();
            }
        }
        private void LimpaFormulario()
        {
            placaTextBox.Text = string.Empty;
            idTextBox.Text = string.Empty;
            renavamTextBox.Text = string.Empty;
            KmTextBox.Text = string.Empty;
            fabricanteComboBox.Text = string.Empty;
            modeloComboBox.Text = string.Empty;
            corComboBox.Text = string.Empty;
            anoComboBox.Text = string.Empty;
        }

        private void placaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            modeloComboBox.Enabled = true;

            var itemSelecionado = fabricanteComboBox.SelectedItem.ToString();
            string fabricanteSelecionado = itemSelecionado.Substring(1, itemSelecionado.IndexOf(',') - 1);
            if (fabricanteSelecionado.Length > 0)
            {
                List<string> modelos = new List<string>(Caminhao.modelos[fabricanteSelecionado]);
                modelos.Sort();
                modeloComboBox.DataSource = modelos;
            }
            else modeloComboBox.DataSource = Caminhao.modelos["Volvo"];

        }

        private void modeloComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
