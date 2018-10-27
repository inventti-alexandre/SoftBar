using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.FluxoDeCaixa
{
    class FluxoDeCaixaBusiness
    {
        public FluxoDeCaixaDTO PuxarDados(string date)
        {
            FluxoDeCaixaDatabase db = new FluxoDeCaixaDatabase();
            FluxoDeCaixaDTO dto = new FluxoDeCaixaDTO();
            dto.vlVendas = db.Ganho(date);
            dto.vlCompras = db.DespesaCompra(date);
            dto.vlFollha = db.DespesaFolha(date);
            dto.vlGerais = db.DespesaGerais(date);

            return dto;
        }
    }
}
