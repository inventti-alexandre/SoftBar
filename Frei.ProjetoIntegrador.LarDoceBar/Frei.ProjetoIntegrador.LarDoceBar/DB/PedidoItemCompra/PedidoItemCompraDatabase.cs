using MySql.Data.MySqlClient;
using Nsf._2018.Modulo3.App.DB.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.PedidoItemCompra
{
    class PedidoItemCompraDatabase
    {
        public int RegistrarProduto(PedidoItemCompraDTO dto)
        {
            string script = @"INSERT tb_pedido_item_compra(fk_PedidoItemCompra_Produto, qnt_Produto, fk_PedidoItemCompra_PedidoCompra) 
                                                    VALUES(@fk_PedidoItemCompra_Produto, @qnt_Produto, @fk_PedidoItemCompra_PedidoCompra)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("fk_PedidoItemCompra_Produto", dto.fk_PedidoItemCompra_Produto));
            parms.Add(new MySqlParameter("qnt_Produto", dto.qnt_Produto));
            parms.Add(new MySqlParameter("fk_PedidoItemCompra_PedidoCompra", dto.fk_PedidoItemCompra_PedidoCompra));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public int AlterarProdutoLista(PedidoItemCompraDTO dto)
        {
            string script = @"UPDATE tb_pedido_item_compra SET fk_PedidoItemCompra_Produto = @fk_PedidoItemCompra_Produto, 
                                                                               qnt_Produto = @qnt_Produto

                                                               WHERE fk_PedidoItemCompra_PedidoCompra = @fk_PedidoItemCompra_PedidoCompra";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("fk_PedidoItemCompra_Produto", dto.fk_PedidoItemCompra_Produto));
            parms.Add(new MySqlParameter("qnt_Produto", dto.qnt_Produto));
            parms.Add(new MySqlParameter("fk_PedidoItemCompra_PedidoCompra", dto.fk_PedidoItemCompra_PedidoCompra));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public int RemoverProdutoLista(int idProduto)
        {
            string script = $"DELETE FROM tb_pedido_item_compra WHERE id_Pedido_Item_Compra = {idProduto}";
            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }
    }
}
