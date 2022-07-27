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
    public partial class MenuUsuarios : Form
    {
        private Usuario _u;

        private int _idSelecionado;
        public MenuUsuarios(Usuario u)
        {
            InitializeComponent();
            _u = u;
            AtualizarDgv();
        }

            //Carregar dados do bd para o dgv:

            private void AtualizarDgv()
            {
                dgvUsuarios.DataSource = Banco.UsuarioDAO.ListarTudo();
            }

        

        private void MenuUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var u = new Usuario();
            var valida = txbNomeCad.Text.Length > 5 && txbEmailCad.Text.Length >= 6 && txbSenhaEdit.Text.Length >= 6;

            if (valida)
            {
                u.NomeCompleto = txbNomeCad.Text;
                u.Email = txbEmailCad.Text;
                u.Senha = txbUsuarioSenhaCad.Text;

                //Invocar o cadastrar:

                if (Banco.UsuarioDAO.Cadastrar(u)) 
                {
                    MessageBox.Show("Usuarío cadastrado!");
                    txbEmailCad.Clear();
                    txbNomeCad.Clear();
                    txbUsuarioSenhaCad.Clear();

                    //Atualizar
                    AtualizarDgv();
                }
                else
                {
                    MessageBox.Show("Houve um erro no cadastro! ");
                }
            }
            else
            {
                MessageBox.Show("Verifique as informações digitadas.");
            }

        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grbEditar.Enabled = true;

           int numerolinha = dgvUsuarios.CurrentCell.RowIndex;

           var linha = dgvUsuarios.Rows[numerolinha];

          //  MessageBox.Show(linha.Cells[1].Value.ToString());
          txbNomeEdit.Text = linha.Cells[1].Value.ToString();
          txbEmailEdit.Text = linha.Cells[2].Value.ToString();
            _idSelecionado = int.Parse(linha.Cells[0].Value.ToString());
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var u = new Usuario();
            u.NomeCompleto = txbNomeEdit.Text;
            u.Email = txbEmailEdit.Text;
            u.Senha = txbSenhaEdit.Text;
            u.Id = _idSelecionado;

            // Chamar o modificar:

           if( Banco.UsuarioDAO.Modificar(u))
            {
                MessageBox.Show("Usuário modificado com sucesso!");
                txbNomeEdit.Clear();
                txbSenhaEdit.Clear();
                txbEmailEdit.Clear();

                AtualizarDgv();
                grbEditar.Enabled =false;

            }
            else
            {
                MessageBox.Show("Verifique as informações digitadas.");

            }

          

            

        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void grbEditar_Enter(object sender, EventArgs e)
        {

        }
    }
}
