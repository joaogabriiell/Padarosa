using LibPadarosa;
using MySqlConnector;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padarosa.Banco
{
    internal class ProdutoDAO
    {

        public static bool Cadastrar(Produto _p)
        {
            string comando;
            comando = "INSERT INTO produtos (nome, preco, id_categoria, id_respcadastro) VALUES (@nome, @preco, @categoria, @id_resp)";



            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();

            // Instanciar o objeto do tipo "MySQL"

            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@nome", _p.Nome);
            cmd.Parameters.AddWithValue("@preco", _p.Preco);
            cmd.Parameters.AddWithValue("@categoria", _p.Idcategoria);
            cmd.Parameters.AddWithValue("@id_resp",_p.IdRespCadastro);

            cmd.Prepare();
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;

                }

                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static DataTable ListarProdutosTudo()
        {
            {
                DataTable tabela = new DataTable();
                string comando;
                comando = "SELECT * FROM view_produto";
                ConexaoBD conexaoBD = new ConexaoBD();
                MySqlConnection con = conexaoBD.ObterConexao();
                MySqlCommand cmd = new MySqlCommand(comando, con);


                cmd.Prepare();
                tabela.Load(cmd.ExecuteReader());
                conexaoBD.Desconectar(con);
                return tabela;
            }
        }

        public static bool Modificar(Produto _p)
        {
            string comando;

            comando = "UPDATE produtos SET nome = @nome, preco = @preco,  id_categoria = @categoria WHERE id = @id";



            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();

            // Instanciar o objeto do tipo "MySQL"

            MySqlCommand cmd = new MySqlCommand(comando, con);


            cmd.Parameters.AddWithValue("@id", _p.Id);
            cmd.Parameters.AddWithValue("@nome", _p.Nome);
            cmd.Parameters.AddWithValue("@preco", _p.Preco);
            cmd.Parameters.AddWithValue("@categoria", _p.Idcategoria);
            //cmd.Parameters.AddWithValue("@id_resp", _p.IdRespCadastro);

            cmd.Prepare();

            if (cmd.ExecuteNonQuery() == 0)
            {
                conexaoBD.Desconectar(con);
                return false;

            }

            else
            {
                conexaoBD.Desconectar(con);
                return true;
            }

            //try
            //{
              
            //}
            //catch
            //{
            //    return false;
            //}
        }
    }

}
    
            



    

