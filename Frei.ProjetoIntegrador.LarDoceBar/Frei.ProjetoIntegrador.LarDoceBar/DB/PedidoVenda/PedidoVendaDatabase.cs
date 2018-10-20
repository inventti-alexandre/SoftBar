using MySql.Data.MySqlClient;
using Nsf._2018.Modulo3.App.DB.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.PedidoVenda
{
    class PedidoVendaDatabase
    {
        public int RegistrarVenda(PedidoVendaDTO dto)
        {
            string script = @"INSERT tb_pedido_venda(dt_Pedido, fk_PedidoVenda_Usuario, fk_PedidoVenda_Cliente, fk_PedidoVenda_Filial)
                                              VALUES(@dt_Pedido, @fk_PedidoVenda_Usuario, @fk_PedidoVenda_Cliente, @fk_PedidoVenda_Filial)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("dt_Pedido", dto.dt_Pedido));
            parms.Add(new MySqlParameter("fk_PedidoVenda_Usuario", dto.fk_PedidoVenda_Usuario));
            parms.Add(new MySqlParameter("fk_PedidoVenda_Cliente", dto.fk_PedidoVenda_Cliente));
            parms.Add(new MySqlParameter("fk_PedidoVenda_Filial", dto.fk_PedidoVenda_Filial));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public int AlterarVenda(PedidoVendaDTO dto)
        {
            string script = @"UPDATE tb_pedido_venda SET dt_Pedido = dt_Pedido, 
                                            fk_PedidoVenda_Usuario = fk_PedidoVenda_Usuario, 
                                            fk_PedidoVenda_Cliente = fk_PedidoVenda_Cliente, 
                                             fk_PedidoVenda_Filial = fk_PedidoVenda_Filial  

                                             WHERE id_Pedido_Venda = @id_Pedido_Venda";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_Pedido_Venda", dto.id_Pedido_Venda));
            parms.Add(new MySqlParameter("dt_Pedido", dto.dt_Pedido));
            parms.Add(new MySqlParameter("fk_PedidoVenda_Usuario", dto.fk_PedidoVenda_Usuario));
            parms.Add(new MySqlParameter("fk_PedidoVenda_Cliente", dto.fk_PedidoVenda_Cliente));
            parms.Add(new MySqlParameter("fk_PedidoVenda_Filial", dto.fk_PedidoVenda_Filial));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public int RemoverVenda(int idVenda)
        {
            string script = @"DELETE FROM tb_pedido_venda WHERE id_Pedido_Venda = @id_Pedido_Venda";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_Pedido_Venda", idVenda));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public List<view_PedidoVenda> Consultar()
        {
            string script = @"SELECT * FROM view_PedidoVenda";
            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<view_PedidoVenda> pedidos = new List<view_PedidoVenda>();
            while (reader.Read())
            {
                view_PedidoVenda pedido = new view_PedidoVenda();
                pedido.id_Pedido_Venda = reader.GetInt32("id_Pedido_Venda");
                pedido.vl_Total = reader.GetDecimal("vl_Total");
                pedido.qnt_Produto = reader.GetInt32("qnt_Produto");
                pedido.dt_Pedido = reader.GetDateTime("dt_Pedido");

                pedidos.Add(pedido);
            }

            reader.Close();
            return pedidos;
        }
    
        public view_PedidoVenda ConsultarPorId(int idVenda)
        {
            string script = $@"SELECT * FROM view_PedidoVenda WHERE id_Pedido_Venda = '{idVenda}'";
            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            view_PedidoVenda pedido = new view_PedidoVenda();
            if (reader.Read())
            {
                pedido.id_Pedido_Venda = reader.GetInt32("id_Pedido_Venda");
                pedido.vl_Total = reader.GetDecimal("vl_Total");
                pedido.qnt_Produto = reader.GetInt32("qnt_Produto");
                pedido.dt_Pedido = reader.GetDateTime("dt_Pedido");
            }

            reader.Close();
            return pedido;
        }
    }
}
