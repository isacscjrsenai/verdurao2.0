using VerduraoDoJao.Melanciometro;

namespace VerduraoDoJoao2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rEgistraCaminhãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lucroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void vendaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (Caminhao.caminhoes.Count == 0)
            {
                MessageBox.Show("Não existe caminhão registrado ainda\nRegistre um caminhão no menu caminhão", "Verdurão do João", MessageBoxButtons.OK);

            }
            else
            {
                Venda formVenda = new Venda();
                formVenda.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProdutoRegistrar formRegistraProduto = new ProdutoRegistrar();
            formRegistraProduto.Show();
        }

        private void registrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Caminhao1 formCaminhao = new Caminhao1();
            formCaminhao.Show();
        }

        private void deletarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Caminhao.caminhoes.Count == 0)
            {
                MessageBox.Show("Não há caminhão registrado ainda\nPara registra um caminhão acesso o menu Caminhão - Registrar", "Verdurão do João");
                return;
            }
            CaminhaoDeletar formCaminhaDeletar = new CaminhaoDeletar();
            formCaminhaDeletar.Show();
        }

        private void porPlacaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Caminhao.caminhoes.Count == 0)
            {
                MessageBox.Show("Não há caminhão registrado ainda\nPara registra um caminhão acesso o menu Caminhão - Registrar", "Verdurão do João");
                return;
            }
            CaminhaoProcuraPorPlaca formCaminhaoPorPlaca = new CaminhaoProcuraPorPlaca();
            formCaminhaoPorPlaca.Show();
        }

        private void peloProprietárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Caminhao.caminhoes.Count == 0)
            {
                MessageBox.Show("Não há caminhão registrado ainda\nPara registra um caminhão acesso o menu Caminhão - Registrar", "Verdurão do João");
                return;
            }
            CaminhaoProcuraPorId formCaminhaoPorId = new CaminhaoProcuraPorId();
            formCaminhaoPorId.Show();
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProdutoDeletar formProdutoDeletar = new ProdutoDeletar();
            formProdutoDeletar.Show();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProdutoModificar formProdutoModificar = new ProdutoModificar();
            formProdutoModificar.Show();
        }

        private void registraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Promocao_Registro formPromocaoRegistro = new Promocao_Registro();
            formPromocaoRegistro.Show();
        }
    }
}