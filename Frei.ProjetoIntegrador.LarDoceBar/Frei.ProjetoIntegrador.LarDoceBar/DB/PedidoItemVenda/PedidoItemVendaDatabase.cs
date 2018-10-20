using MySql.Data.MySqlClient;
using Nsf._2018.Modulo3.App.DB.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.PedidoItemVenda
{
    class PedidoItemVendaDatabase
    {
        public int AdicionarCarrinho(PedidoItemVendaDTO dto)
        {
            string script = @"INSERT tb_pedido_item_venda(qnt_Produto, fk_PedidoItemVenda_ProdutoVenda, fk_PedidoItemVenda_PedidoVenda)
                                                   VALUES(@qnt_Produto, @fk_PedidoItemVenda_ProdutoVenda, @fk_PedidoItemVenda_PedidoVenda)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("qnt_Produto", dto.qnt_Produto));
            parms.Add(new MySqlParameter("fk_PedidoItemVenda_ProdutoVenda", dto.fk_PedidoItemVenda_ProdutoVenda));
            parms.Add(new MySqlParameter("fk_PedidoItemVenda_PedidoVenda", dto.fk_PedidoItemVenda_PedidoVenda));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public int AlterarCarrinho(PedidoItemVendaDTO dto)
        {
            string script = @"UPDATE tb_pedido_item_venda SET qnt_Produto = @qnt_Produto,
                                           fk_PedidoItemVenda_ProdutoVenda = fk_PedidoItemVenda_ProdutoVenda,
                                           fk_PedidoItemVenda_PedidoVenda = fk_PedidoItemVenda_PedidoVenda

                                               WHERE id_Pedido_Item_Venda = @id_Pedido_Item_Venda";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_Pedido_Item_Venda", dto.id_Pedido_Item_Venda));
            parms.Add(new MySqlParameter("qnt_Produto", dto.qnt_Produto));
            parms.Add(new MySqlParameter("fk_PedidoItemVenda_ProdutoVenda", dto.fk_PedidoItemVenda_ProdutoVenda));
            parms.Add(new MySqlParameter("fk_PedidoItemVenda_PedidoVenda", dto.fk_PedidoItemVenda_PedidoVenda));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public int RemoverCarrinho(int idCarrinho)
        {
            string script = $@"DELETE FROM tb_pedido_item_venda WHERE id_Pedido_Item_Venda = '{idCarrinho}'";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_Pedido_Item_Venda", idCarrinho));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public List<PedidoItemVendaDTO> Consultar()
        {
            string script = @"SELECT * FROm tb_pedido_item_venda";
            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<PedidoItemVendaDTO> pedidos = new List<PedidoItemVendaDTO>();
            while (reader.Read())
            {
                PedidoItemVendaDTO pedido = new PedidoItemVendaDTO();
                pedido.id_Pedido_Item_Venda = reader.GetInt32("id_Pedido_Item_Venda");
                pedido.qnt_Produto = reader.GetInt32("qnt_Produto");
                pedido.fk_PedidoItemVenda_ProdutoVenda = reader.GetInt32("fk_PedidoItemVenda_ProdutoVenda");
                pedido.fk_PedidoItemVenda_PedidoVenda = reader.GetInt32("fk_PedidoItemVenda_PedidoVenda");

                pedidos.Add(pedido);
            }

            reader.Close();
            return pedidos;
        }

        public PedidoItemVendaDTO ConsultarPorId(int idCarrinho)
        {
            string script = $@"SELECT * FROm tb_pedido_item_venda WHERE id_Pedido_Item_Venda = '{idCarrinho}'";
            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            PedidoItemVendaDTO pedido = new PedidoItemVendaDTO();
            while (reader.Read())
            {
                pedido.id_Pedido_Item_Venda = reader.GetInt32("id_Pedido_Item_Venda");
                pedido.qnt_Produto = reader.GetInt32("qnt_Produto");
                pedido.fk_PedidoItemVenda_ProdutoVenda = reader.GetInt32("fk_PedidoItemVenda_ProdutoVenda");
                pedido.fk_PedidoItemVenda_PedidoVenda = reader.GetInt32("fk_PedidoItemVenda_PedidoVenda");
            }

            reader.Close();
            return pedido;
        }
    }
}
