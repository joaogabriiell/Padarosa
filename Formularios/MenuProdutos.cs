using LibPadarosa;
using System;
using System.Collections;
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
    public partial class MenuProdutos : Form

    {
        // Objetos globais:
        private Usuario _u;
        private int _idSelecionado;
        public MenuProdutos(Usuario u)
        {
            InitializeComponent();
            _u = u;

            // Salvar o resultado da listagem de categorias em um objeto:
            var r = Banco.CategoriaDAO.ListarTudo();
            ArrayList rows = new ArrayList();
            // Converter este objeto para o array:
            foreach (DataRow dataRow in r.Rows)
            {
                rows.Add(string.Join(" - ", dataRow.ItemArray.Select(item => item.ToString())));
            }
            // Atribuir os valores nos cmbs:
            cmbCadastrar.DataSource = rows;
            cmbEditar.DataSource = rows.Clone();
            // Atribuir a tabela de produtos no dgv:
            dgvProdutos.DataSource = Banco.ProdutoDAO.ListarProdutosTudo();
        }
        // Função para extrair o número do combobox selecionado:
        private int obterIDdaString(string texto)
        {
            return int.Parse(texto.Split(' ')[0]);
        }
        private void AtualizarDgv()
        {
            dgvProdutos.DataSource = Banco.ProdutoDAO.ListarProdutosTudo();
        }


        //

        private void btnCadastrarPro_Click(object sender, EventArgs e)
        {
            var p = new Produto();

            p.Nome = txbNomeProCad.Text;
            p.Preco = double.Parse(txbPrecoCad.Text);
            p.Idcategoria = obterIDdaString(cmbCadastrar.Text);
            p.IdRespCadastro = _u.Id;


            // Chamar o modificar:

            if (Banco.ProdutoDAO.Cadastrar(p))
            {
                MessageBox.Show("Produto cadastrado!");
                txbNomeProEdit.Clear();
                txbPrecoCad.Clear();


                //Atualizar
                AtualizarDgv();

            }
            else
            {
                MessageBox.Show("Houve um erro no cadastro! ");
            }



        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            grbEditar.Enabled = true;

            int numerolinha = dgvProdutos.CurrentCell.RowIndex;

            var linha = dgvProdutos.Rows[numerolinha];

            //  MessageBox.Show(linha.Cells[1].Value.ToString());

            txbNomeProEdit.Text = linha.Cells[1].Value.ToString();
            txbPrecoEdit.Text = linha.Cells[2].Value.ToString();
            cmbCadastrar.Text = linha.Cells[3].Value.ToString();
            _idSelecionado = int.Parse(linha.Cells[0].Value.ToString());

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            {
                var p = new Produto();
                p.Nome = txbNomeProEdit.Text;
                p.Preco = double.Parse(txbPrecoEdit.Text);
                p.Idcategoria = obterIDdaString(cmbEditar.Text);
                p.Id = _idSelecionado;
                p.IdRespCadastro = _u.Id;

                // Chamar o modificar:

                if (Banco.ProdutoDAO.Modificar(p))
                {
                    MessageBox.Show("Produto modificado com sucesso!");
                    txbNomeProEdit.Clear();
                    txbPrecoEdit.Clear();


                    AtualizarDgv();
                    grbEditar.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Verifique as informações digitadas.");

                }
            }
        }
    }
}








    









