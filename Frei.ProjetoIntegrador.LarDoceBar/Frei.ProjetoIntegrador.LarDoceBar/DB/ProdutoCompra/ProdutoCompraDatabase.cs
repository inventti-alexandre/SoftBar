using MySql.Data.MySqlClient;
using Nsf._2018.Modulo3.App.DB.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.ProdutoCompra
{
    class ProdutoCompraDatabase
    {
        public int CadatrarProduto(ProdutoCompraDTO dto)
        {
            string script = @"INSERT tb_produtoCompra(nm_Produto, vl_Compra, ds_Produto, dt_Validade, fk_ProdutoCompra_Fornecedor, fk_produtoCompra_Filial)
                                               VALUES(@nm_Produto, @vl_Compra, @ds_Produto, @dt_Validade, @fk_ProdutoCompra_Fornecedor, @fk_produtoCompra_Filial)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_Produto", dto.nm_Produto));
            parms.Add(new MySqlParameter("vl_Compra", dto.vl_Compra));
            parms.Add(new MySqlParameter("ds_Produto", dto.ds_Produto));
            parms.Add(new MySqlParameter("dt_Validade", dto.dt_Validade));
            parms.Add(new MySqlParameter("fk_ProdutoCompra_Fornecedor", dto.fk_ProdutoCompra_Fornecedor));
            parms.Add(new MySqlParameter("fk_produtoCompra_Filial", dto.fk_produtoCompra_Filial));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public int AlterarProduto(ProdutoCompraDTO dto)
        {
            string script = @"UPDATE tb_produtoCompra SET nm_Produto = @nm_Produto,
                                                           vl_Compra = @vl_Compra, 
                                                          ds_Produto = @ds_Produto, 
                                                         dt_Validade = @dt_Validade, 
                                         fk_ProdutoCompra_Fornecedor = @fk_ProdutoCompra_Fornecedor
                                                    
                                                    WHERE id_Produto = @id_Produto";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_Produto", dto.nm_Produto));
            parms.Add(new MySqlParameter("vl_Compra", dto.vl_Compra));
            parms.Add(new MySqlParameter("ds_Produto", dto.ds_Produto));
            parms.Add(new MySqlParameter("dt_Validade", dto.dt_Validade));
            parms.Add(new MySqlParameter("fk_ProdutoCompra_Fornecedor", dto.fk_ProdutoCompra_Fornecedor));
            parms.Add(new MySqlParameter("id_Produto", dto.id_Produto));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public int RemoverProduto(int idProduto)
        {
            string script = @"DELETE FROM tb_produtoCompra WHERE id_Produto = @id_Produto";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_Produto", idProduto));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public List<view_produtoCompra_Forn_Filial> Consultar()
        {
            string script = @"SELECT * FROM view_produtoCompra_Forn_Filial";
            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<view_produtoCompra_Forn_Filial> produtos = new List<view_produtoCompra_Forn_Filial>();
            while (reader.Read())
            {
                view_produtoCompra_Forn_Filial produto = new view_produtoCompra_Forn_Filial();
                produto.id_Produto = reader.GetInt32("id_Produto");
                produto.nm_Produto = reader.GetString("nm_Produto");
                produto.vl_Compra = reader.GetDecimal("vl_Compra");
                produto.ds_Produto = reader.GetString("ds_Produto");
                produto.dt_Validade = reader.GetDateTime("dt_Validade");
                produto.fk_ProdutoCompra_Fornecedor = reader.GetInt32("fk_ProdutoCompra_Fornecedor");
                produto.fk_produtoCompra_Filial = reader.GetInt32("fk_produtoCompra_Filial");
                produto.nm_Fornecedor = reader.GetString("nm_Fornecedor");
                produto.num_Telefone = reader.GetString("num_Telefone");
                produto.ds_Email = reader.GetString("ds_Email");
                produto.nm_Nome = reader.GetString("nm_Nome");

                produtos.Add(produto);
            }

            reader.Close();
            return produtos;
        }

        public view_produtoCompra_Forn_Filial ConsultarPorId(int idProduto)
        {
            string script = $@"SELECT * FROM view_produtoCompra_Forn_Filial WHERE id_Produto = {idProduto}";
            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            view_produtoCompra_Forn_Filial produto = new view_produtoCompra_Forn_Filial();
            while (reader.Read())
            {
                produto.id_Produto = reader.GetInt32("id_Produto");
                produto.nm_Produto = reader.GetString("nm_Produto");
                produto.vl_Compra = reader.GetDecimal("vl_Compra");
                produto.ds_Produto = reader.GetString("ds_Produto");
                produto.dt_Validade = reader.GetDateTime("dt_Validade");
                produto.fk_ProdutoCompra_Fornecedor = reader.GetInt32("fk_ProdutoCompra_Fornecedor");
                produto.fk_produtoCompra_Filial = reader.GetInt32("fk_produtoCompra_Filial");
                produto.nm_Fornecedor = reader.GetString("nm_Fornecedor");
                produto.num_Telefone = reader.GetString("num_Telefone");
                produto.ds_Email = reader.GetString("ds_Email");
                produto.nm_Nome = reader.GetString("nm_Nome");
            }

            reader.Close();
            return produto;
        }

        public List<view_produtoCompra_Forn_Filial> ConsultarPorNome(string nmProduto)
        {
            string script = $@"SELECT * FROM view_produtoCompra_Forn_Filial WHERE nm_Produto LIKE '%{nmProduto}%'";
            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<view_produtoCompra_Forn_Filial> produtos = new List<view_produtoCompra_Forn_Filial>();
            while (reader.Read())
            {
                view_produtoCompra_Forn_Filial produto = new view_produtoCompra_Forn_Filial();
                produto.id_Produto = reader.GetInt32("id_Produto");
                produto.nm_Produto = reader.GetString("nm_Produto");
                produto.vl_Compra = reader.GetDecimal("vl_Compra");
                produto.ds_Produto = reader.GetString("ds_Produto");
                produto.dt_Validade = reader.GetDateTime("dt_Validade");
                produto.fk_ProdutoCompra_Fornecedor = reader.GetInt32("fk_ProdutoCompra_Fornecedor");
                produto.fk_produtoCompra_Filial = reader.GetInt32("fk_produtoCompra_Filial");
                produto.nm_Fornecedor = reader.GetString("nm_Fornecedor");
                produto.num_Telefone = reader.GetString("num_Telefone");
                produto.ds_Email = reader.GetString("ds_Email");
                produto.nm_Nome = reader.GetString("nm_Nome");

                produtos.Add(produto);
            }

            reader.Close();
            return produtos;
        }

        public List<view_produtoCompra_Forn_Filial> ConsultarPorFornecedor(string nmFornecedor)
        {
            string script = $@"SELECT * FROM view_produtoCompra_Forn_Filial WHERE nm_Fornecedor LIKE '%{nmFornecedor}%'";
            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<view_produtoCompra_Forn_Filial> produtos = new List<view_produtoCompra_Forn_Filial>();
            while (reader.Read())
            {
                view_produtoCompra_Forn_Filial produto = new view_produtoCompra_Forn_Filial();
                produto.id_Produto = reader.GetInt32("id_Produto");
                produto.nm_Produto = reader.GetString("nm_Produto");
                produto.vl_Compra = reader.GetDecimal("vl_Compra");
                produto.ds_Produto = reader.GetString("ds_Produto");
                produto.dt_Validade = reader.GetDateTime("dt_Validade");
                produto.fk_ProdutoCompra_Fornecedor = reader.GetInt32("fk_ProdutoCompra_Fornecedor");
                produto.fk_produtoCompra_Filial = reader.GetInt32("fk_produtoCompra_Filial");
                produto.nm_Fornecedor = reader.GetString("nm_Fornecedor");
                produto.num_Telefone = reader.GetString("num_Telefone");
                produto.ds_Email = reader.GetString("ds_Email");
                produto.nm_Nome = reader.GetString("nm_Nome");

                produtos.Add(produto);
            }

            reader.Close();
            return produtos;
        }

        public List<view_produtoCompra_Forn_Filial> ConsultarPorFilial(string nmFilial)
        {
            string script = $@"SELECT * FROM view_produtoCompra_Forn_Filial WHERE nm_Nome LIKE '%{nmFilial}%'";
            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<view_produtoCompra_Forn_Filial> produtos = new List<view_produtoCompra_Forn_Filial>();
            while (reader.Read())
            {
                view_produtoCompra_Forn_Filial produto = new view_produtoCompra_Forn_Filial();
                produto.id_Produto = reader.GetInt32("id_Produto");
                produto.nm_Produto = reader.GetString("nm_Produto");
                produto.vl_Compra = reader.GetDecimal("vl_Compra");
                produto.ds_Produto = reader.GetString("ds_Produto");
                produto.dt_Validade = reader.GetDateTime("dt_Validade");
                produto.fk_ProdutoCompra_Fornecedor = reader.GetInt32("fk_ProdutoCompra_Fornecedor");
                produto.fk_produtoCompra_Filial = reader.GetInt32("fk_produtoCompra_Filial");
                produto.nm_Fornecedor = reader.GetString("nm_Fornecedor");
                produto.num_Telefone = reader.GetString("num_Telefone");
                produto.ds_Email = reader.GetString("ds_Email");
                produto.nm_Nome = reader.GetString("nm_Nome");

                produtos.Add(produto);
            }

            reader.Close();
            return produtos;
        }

        public List<view_produtoCompra_Forn_Filial> ConsultarPorNome_Fornecedor(string nmProduto, string nmFornecedor)
        {
            string script = $@"SELECT * FROM view_produtoCompra_Forn_Filial
                                       WHERE nm_Fornecedor 
                                        LIKE '%{nmFornecedor}%' 
                                         AND nm_Produto 
                                        LIKE '%{nmProduto}%'";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<view_produtoCompra_Forn_Filial> produtos = new List<view_produtoCompra_Forn_Filial>();
            while (reader.Read())
            {
                view_produtoCompra_Forn_Filial produto = new view_produtoCompra_Forn_Filial();
                produto.id_Produto = reader.GetInt32("id_Produto");
                produto.nm_Produto = reader.GetString("nm_Produto");
                produto.vl_Compra = reader.GetDecimal("vl_Compra");
                produto.ds_Produto = reader.GetString("ds_Produto");
                produto.dt_Validade = reader.GetDateTime("dt_Validade");
                produto.fk_ProdutoCompra_Fornecedor = reader.GetInt32("fk_ProdutoCompra_Fornecedor");
                produto.fk_produtoCompra_Filial = reader.GetInt32("fk_produtoCompra_Filial");
                produto.nm_Fornecedor = reader.GetString("nm_Fornecedor");
                produto.num_Telefone = reader.GetString("num_Telefone");
                produto.ds_Email = reader.GetString("ds_Email");
                produto.nm_Nome = reader.GetString("nm_Nome");

                produtos.Add(produto);
            }

            reader.Close();
            return produtos;
        }
    }
}
