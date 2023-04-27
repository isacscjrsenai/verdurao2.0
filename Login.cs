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
                    textBox1.BackColor = Color.IndianRed;
                    maskedTextBox1.BackColor = Color.IndianRed;
                    
                    for(var i=0; i<15; i++)
                    {
                        groupBox1.Location.Offset(-10, 0);
                        Thread.Sleep(20);
                        groupBox1.Location.Offset(10, 0);
                        groupBox1.Update();
                        Thread.Sleep(20);
                        groupBox1.Location.Offset(10, 0);
                        groupBox1.Update();
                        Thread.Sleep(20);
                        groupBox1.Location.Offset(-10, 0);
                        groupBox1.Update();
                        Thread.Sleep(20);
                    }
                }
            }
            if (tentativas >= 3)
            {
                Environment.Exit(0);
            }
        }

    }
}
