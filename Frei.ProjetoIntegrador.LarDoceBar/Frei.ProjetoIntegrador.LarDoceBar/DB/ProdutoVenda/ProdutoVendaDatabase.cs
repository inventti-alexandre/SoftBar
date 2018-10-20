using MySql.Data.MySqlClient;
using Nsf._2018.Modulo3.App.DB.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.ProdutoVenda
{
    class ProdutoVendaDatabase
    {
        public int CadastrarProduto(ProdutoVendaDTO dto)
        {
            string script = @"INSERT tb_produtoVenda(nm_Produto, ds_Produto, vl_Venda, dt_Validade, fk_ProdutoVenda_Filial)
                                              VALUES(@nm_Produto, @ds_Produto, @vl_Venda, @dt_Validade, @fk_ProdutoVenda_Filial)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_Produto", dto.nm_Produto));
            parms.Add(new MySqlParameter("ds_Produto", dto.ds_Produto));
            parms.Add(new MySqlParameter("vl_Venda", dto.vl_Venda));
            parms.Add(new MySqlParameter("dt_Validade", dto.dt_Validade));
            parms.Add(new MySqlParameter("fk_ProdutoVenda_Filial", dto.fk_ProdutoVenda_Filial));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public int AlterarProduto(ProdutoVendaDTO dto)
        {
            string script = @"UPDATE tb_produtoVenda SET nm_Produto = @nm_Produto,
                                                         ds_Produto = ds_Produto, 
                                                           vl_Venda = vl_Venda, 
                                                        dt_Validade = dt_Validade, 
                                             fk_ProdutoVenda_Filial = fk_ProdutoVenda_Filial

                                              WHERE id_produtoVenda = @id_produtoVenda";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_produtoVenda", dto.id_produtoVenda));
            parms.Add(new MySqlParameter("nm_Produto", dto.nm_Produto));
            parms.Add(new MySqlParameter("ds_Produto", dto.ds_Produto));
            parms.Add(new MySqlParameter("vl_Venda", dto.vl_Venda));
            parms.Add(new MySqlParameter("dt_Validade", dto.dt_Validade));
            parms.Add(new MySqlParameter("fk_ProdutoVenda_Filial", dto.fk_ProdutoVenda_Filial));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public int RemoverProduto(int idProduto)
        {
            string script = $"DELETE FROM tb_produtoVenda WHERE id_produtoVenda = '{idProduto}'";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public List<ProdutoVendaDTO> Consultar()
        {
            string script = @"SELECT * FROM tb_produtoVenda";
            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<ProdutoVendaDTO> produtos = new List<ProdutoVendaDTO>();
            while (reader.Read())
            {
                ProdutoVendaDTO produto = new ProdutoVendaDTO();
                produto.id_produtoVenda = reader.GetInt32("id_produtoVenda");
                produto.nm_Produto = reader.GetString("nm_Produto");
                produto.ds_Produto = reader.GetString("ds_Produto");
                produto.vl_Venda = reader.GetDecimal("vl_Venda");
                produto.dt_Validade = reader.GetDateTime("dt_Validade");
                produto.fk_ProdutoVenda_Filial = reader.GetInt32("fk_ProdutoVenda_Filial");

                produtos.Add(produto);
            }
            
            reader.Close();
            return produtos;
        }

        public ProdutoVendaDTO ConsultarPorId(int idProduto)
        {
            string script = @"SELECT * FROM tb_produtoVenda WHERE id_produtoVenda = @id_produtoVenda";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_produtoVenda", idProduto));


            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            ProdutoVendaDTO produto = new ProdutoVendaDTO();
            if (reader.Read())
            {
                produto.id_produtoVenda = reader.GetInt32("id_produtoVenda");
                produto.nm_Produto = reader.GetString("nm_Produto");
                produto.ds_Produto = reader.GetString("ds_Produto");
                produto.vl_Venda = reader.GetDecimal("vl_Venda");
                produto.dt_Validade = reader.GetDateTime("dt_Validade");
                produto.fk_ProdutoVenda_Filial = reader.GetInt32("fk_ProdutoVenda_Filial");
            }

            reader.Close();
            return produto;
        }

        public view_Produto ConsultarFilialPorId(int idFilial)
        {
            string script = @"SELECT * FROM view_Produto WHERE fk_ProdutoVenda_Filial = @fk_ProdutoVenda_Filial";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("fk_ProdutoVenda_Filial", idFilial));


            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            view_Produto produto = new view_Produto();
            if (reader.Read())
            {
                produto.nm_Nome = reader.GetString("nm_Nome");
            }

            reader.Close();
            return produto;
        }
    }
}
