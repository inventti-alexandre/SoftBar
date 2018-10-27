using Frei.ProjetoIntegrador.LarDoceBar.DB.Base;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace Frei.ProjetoIntegrador.Academia.DB.EstoqueVenda
{
    class EstoqueVendaDatabase
    {
        public int CriarEstoque(EstoqueVendaDTO dto)
        {
            string script = @"INSERT tb_estoqueVenda(qnt_Produto, num_Est_Min, num_Est_Max, fk_Estoque_ProdutoVenda)
                                         VALUES(@qnt_Produto, @num_Est_Min, @num_Est_Max, @fk_Estoque_ProdutoVenda)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("qnt_Produto", dto.qnt_Produto));
            parms.Add(new MySqlParameter("num_Est_Min", dto.num_Est_Min));
            parms.Add(new MySqlParameter("num_Est_Max", dto.num_Est_Max));
            parms.Add(new MySqlParameter("fk_Estoque_ProdutoVenda", dto.fk_Estoque_ProdutoVenda));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public int AlterarEstoque(EstoqueVendaDTO dto)
        {
            string script = @"UPDATE tb_estoqueVenda SET qnt_Produto = @qnt_Produto,
                                                    num_Est_Min = @num_Est_Min,
                                                    num_Est_Max = @num_Est_Max

                                               WHERE id_Estoque = @id_Estoque";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_Estoque", dto.id_Estoque));
            parms.Add(new MySqlParameter("qnt_Produto", dto.qnt_Produto));
            parms.Add(new MySqlParameter("num_Est_Min", dto.num_Est_Min));
            parms.Add(new MySqlParameter("num_Est_Max", dto.num_Est_Max));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public int RemoverProdutos(EstoqueVendaDTO dto)
        {
            string script = @"UPDATE tb_estoqueVenda SET qnt_Produto = @qnt_Produto

                                               WHERE id_Estoque = @id_Estoque";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_Estoque", dto.id_Estoque));
            parms.Add(new MySqlParameter("qnt_Produto", dto.qnt_Produto));
            parms.Add(new MySqlParameter("fk_Estoque_ProdutoVenda", dto.fk_Estoque_ProdutoVenda));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public int ApagarEstoque(int idEstoque)
        {
            string script = $@"DELETE FROM tb_estoqueVenda WHERE id_Estoque = '{idEstoque}'";
            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public List<EstoqueVendaDTO> Consultar()
        {
            string script = @"SELECT * FROM tb_estoqueVenda";
            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<EstoqueVendaDTO> estoques = new List<EstoqueVendaDTO>();
            while (reader.Read())
            {
                EstoqueVendaDTO dto = new EstoqueVendaDTO();
                dto.id_Estoque = reader.GetInt32("id_Estoque");
                dto.qnt_Produto = reader.GetInt32("qnt_Produto");
                dto.num_Est_Min = reader.GetInt32("num_Est_Min");
                dto.num_Est_Max = reader.GetInt32("num_Est_Max");
                dto.fk_Estoque_ProdutoVenda = reader.GetInt32("fk_Estoque_ProdutoVenda");

                estoques.Add(dto);
            }

            reader.Close();
            return estoques;
        }

        public List<view_EstoqueVenda> ConsultarView()
        {
            string script = @"SELECT * FROM view_EstoqueVenda";
            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<view_EstoqueVenda> estoques = new List<view_EstoqueVenda>();
            while (reader.Read())
            {
                view_EstoqueVenda dto = new view_EstoqueVenda();
                dto.id_Estoque = reader.GetInt32("id_Estoque");
                dto.qnt_Produto = reader.GetInt32("qnt_Produto");
                dto.num_Est_Min = reader.GetInt32("num_Est_Min");
                dto.num_Est_Max = reader.GetInt32("num_Est_Max");
                dto.fk_Estoque_ProdutoVenda = reader.GetInt32("fk_Estoque_ProdutoVenda");
                dto.nm_Produto = reader.GetString("nm_Produto");
                dto.ds_Produto = reader.GetString("ds_Produto");

                estoques.Add(dto);
            }

            reader.Close();
            return estoques;
        }

        public List<view_EstoqueVenda> ConsultarViewPorNome(string nome)
        {
            string script = @"SELECT * FROM view_EstoqueVenda WHERE nm_Produto = @nm_Produto";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_Produto", nome));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<view_EstoqueVenda> estoques = new List<view_EstoqueVenda>();
            while (reader.Read())
            {
                view_EstoqueVenda dto = new view_EstoqueVenda();
                dto.id_Estoque = reader.GetInt32("id_Estoque");
                dto.qnt_Produto = reader.GetInt32("qnt_Produto");
                dto.num_Est_Min = reader.GetInt32("num_Est_Min");
                dto.num_Est_Max = reader.GetInt32("num_Est_Max");
                dto.fk_Estoque_ProdutoVenda = reader.GetInt32("fk_Estoque_ProdutoVenda");
                dto.nm_Produto = reader.GetString("nm_Produto");
                dto.ds_Produto = reader.GetString("ds_Produto");

                estoques.Add(dto);
            }

            reader.Close();
            return estoques;
        }
    }
}
