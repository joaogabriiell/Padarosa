using LibPadarosa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padarosa.Formularios
{
    public partial class MenuPrincipal : Form
    {
        private Usuario _u;
        private Produto _p;
        public MenuPrincipal(Usuario u)
        {
            InitializeComponent();
            _u = u;
            lblNome1.Text = "Olá " + u.NomeCompleto + "! Escolha uma opção abaixo: ";
        }

        private void btnComandas_Click(object sender, EventArgs e)
        {

        }

        private void Usuaríos_Click(object sender, EventArgs e)
        {
            var menuusuarios = new MenuUsuarios(_u);
            menuusuarios.ShowDialog();

            //Ocultar o botão de usuaríos de todos (tirando o adm):

            if (_u.Id != 1)
            {
                btnUsuario.Visible = false;
            }
        }

        // Produto:

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            var menuprodutos = new MenuProdutos(_u);
            menuprodutos.ShowDialog();

          

        }
    }
}
