namespace VerduraoDoJoao2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rEgistraCaminh„oToolStripMenuItem_Click(object sender, EventArgs e)
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

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void registrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Caminhao1 formCaminhao = new Caminhao1();
            formCaminhao.Show();
        }

        private void deletarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CaminhaoDeletar formCaminhaDeletar = new CaminhaoDeletar();
            formCaminhaDeletar.Show();
        }

        private void porPlacaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CaminhaoProcuraPorPlaca formCaminhaoPorPlaca = new CaminhaoProcuraPorPlaca();
            formCaminhaoPorPlaca.Show();
        }
    }
}