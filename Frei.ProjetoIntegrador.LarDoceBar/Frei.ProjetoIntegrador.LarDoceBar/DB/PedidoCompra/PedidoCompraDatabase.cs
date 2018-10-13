using MySql.Data.MySqlClient;
using Nsf._2018.Modulo3.App.DB.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.PedidoCompra
{
    class PedidoCompraDatabase
    {
        public int RegistrarCompra(PedidoCompraDTO dto)
        {
            string script = @"INSERT tb_pedido_compra(dt_Pedido, fk_PedidoCompra_Usuario, fk_PedidoCompra_Filial)
                                               VALUES(@dt_Pedido, @fk_PedidoCompra_Usuario, @fk_PedidoCompra_Filial)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("dt_Pedido", dto.dt_Pedido));
            parms.Add(new MySqlParameter("fk_PedidoCompra_Usuario", dto.fk_PedidoCompra_Usuario));
            parms.Add(new MySqlParameter("fk_PedidoCompra_Filial", dto.fk_PedidoCompra_Filial));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public int AlterarCompra(PedidoCompraDTO dto)
        {
            string script = @"UPDATE tb_pedido_compra SET dt_Pedido = @dt_Pedido,
                                            fk_PedidoCompra_Usuario = @fk_PedidoCompra_Usuario,
                                             fk_PedidoCompra_Filial = @fk_PedidoCompra_Filial

                                             WHERE id_Pedido_Compra = @id_Pedido_Compra";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_Pedido_Compra", dto.id_Pedido_Compra));
            parms.Add(new MySqlParameter("dt_Pedido", dto.dt_Pedido));
            parms.Add(new MySqlParameter("fk_PedidoCompra_Usuario", dto.fk_PedidoCompra_Usuario));
            parms.Add(new MySqlParameter("fk_PedidoCompra_Filial", dto.fk_PedidoCompra_Filial));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public int ApagarCompra(int idCompra)
        {
            string script = $"DELETE FROM tb_pedido_compra WHERE id_Pedido_Compra = '{idCompra}'";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            Database db = new Database();

            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public List<view_PedidoCompra> Consultar()
        {
            string script = @"SELECT * FROM view_PedidoCompra";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            Database db = new Database();

            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<view_PedidoCompra> pedidos = new List<view_PedidoCompra>();
            while (reader.Read())
            {
                view_PedidoCompra pedido = new view_PedidoCompra();
                pedido.id_Pedido_Compra = reader.GetInt32("id_Pedido_Compra");
                pedido.dt_Pedido = reader.GetDateTime("dt_Pedido");
                pedido.vl_Total = reader.GetInt32("vl_Total");
                pedido.qnt_Produto = reader.GetInt32("qnt_Produto");

                pedidos.Add(pedido);
            }

            reader.Close();
            return pedidos;
        }

        public List<view_PedidoCompra> ConsultarPorId(int idPedidoCompra)
        {
            string script = @"SELECT * FROM view_PedidoCompra";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            Database db = new Database();

            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<view_PedidoCompra> pedidos = new List<view_PedidoCompra>();
            while (reader.Read())
            {
                view_PedidoCompra pedido = new view_PedidoCompra();
                pedido.id_Pedido_Compra = reader.GetInt32("id_Pedido_Compra");
                pedido.dt_Pedido = reader.GetDateTime("dt_Pedido");
                pedido.vl_Total = reader.GetInt32("vl_Total");
                pedido.qnt_Produto = reader.GetInt32("qnt_Produto");

                pedidos.Add(pedido);
            }

            reader.Close();
            return pedidos;
        }
    }
}
