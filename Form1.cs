using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padarosa
{
    public partial class LoginPadarosa : Form
    {
        public LoginPadarosa()
        {
            InitializeComponent();
        }

        private void lblSenha_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (txbEmail.Text.Length <= 3 && txbSenha.Text.Length <= 3)
            {
                MessageBox.Show("Verifique as informações digitadas!");
            }
            else
            {
                var u = new LibPadarosa.Usuario();
                u.Email =txbEmail.Text;
                u.Senha =txbSenha.Text;

                var resultado = Banco.UsuarioDAO.Logar(u);
                
                if (resultado.Rows.Count == 0)
                {

                    MessageBox.Show("Usuário e/ou senha incorreto.");


                }
                else
                {
                    //O programa continua.

                    u.NomeCompleto = resultado.Rows[0]["nome_completo"].ToString();
                    u.Id = int.Parse(resultado.Rows[0]["id"].ToString());

                    var menuprincipal = new Formularios.MenuPrincipal(u);
                    //Esconder a janela atual e apresentar a nova:
                    Hide();
                    menuprincipal.ShowDialog();
                    //Ao sair da anterior, mostrar novamente
                    Show();
                    //Limpar os campos de email e senha:
                    txbEmail.Clear();
                    txbSenha.Clear();

                }
            }
        }
    }
}
