using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.PedidoVenda
{
    class PedidoVendaBusiness
    {
        public int RegistrarVenda(PedidoVendaDTO dto)
        {
            PedidoVendaDatabase db = new PedidoVendaDatabase();
            return db.RegistrarVenda(dto);
        }

        public int AlterarVenda(PedidoVendaDTO dto)
        {
            PedidoVendaDatabase db = new PedidoVendaDatabase();
            return db.AlterarVenda(dto);
        }

        public int RemoverVenda(int idVenda)
        {
            PedidoVendaDatabase db = new PedidoVendaDatabase();
            return db.RemoverVenda(idVenda);
        }

        public List<view_PedidoVenda> Consultar()
        {
            PedidoVendaDatabase db = new PedidoVendaDatabase();
            return db.Consultar();
        }

        public view_PedidoVenda ConsultarPorId(int idVenda)
        {
            PedidoVendaDatabase db = new PedidoVendaDatabase();
            return db.ConsultarPorId(idVenda);
        }        
    }
}
