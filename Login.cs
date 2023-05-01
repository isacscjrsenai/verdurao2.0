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
    public partial class Login : Form
    {
        int tentativas;
        string usuario = "João", senha = "123", usuarioLogin, senhaLogin;
        public bool Valido { private set; get; }
        public Login()
        {
            Valido = false;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            maskedTextBox1.BackColor = Color.White;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string tentativaUsuario = textBox1.Text;
            string tentativaSenha = maskedTextBox1.Text;
            if (!tentativaUsuario.Equals(usuarioLogin) || !tentativaSenha.Equals(senhaLogin))
            {
                usuarioLogin = tentativaUsuario;
                senhaLogin = tentativaSenha;
                //se o digitado for igual ao esperado 
                //passa valido para true e fecha o formulario Login
                if (usuarioLogin == usuario && senhaLogin == senha)
                {
                    Valido = true;
                    this.Close();
                }
                else
                {
                    tentativas++;
                    timer1.Enabled = true;
                    timer1.Start();
                    timer2.Enabled = true;
                    timer2.Start();
                    maskedTextBox1.BackColor = Color.IndianRed;
                    textBox1.BackColor = Color.IndianRed;
                }
            }
            if (tentativas >= 3)
            {
                Environment.Exit(0);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var X = groupBox1.Location.X;
            var Y = groupBox1.Location.Y;
            bool ReachLeft = false, ReachRight = false;
            if (X >= 260)
            {
                ReachRight = true;
                ReachLeft = false;
            }
            if (X <= 240)
            {
                ReachLeft = true;
                ReachRight = false;
            } 

            if (!ReachRight)
            {
                groupBox1.Location = new Point(X+ 5, Y);
            }
            if (ReachRight && !ReachLeft)
            {
                groupBox1.Location = new Point(X- 5, Y);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer1.Stop();
            timer2.Enabled = false;
            timer2.Stop();
        }
    }
}
