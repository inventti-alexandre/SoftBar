using Frei.ProjetoIntegrador.Academia.Validacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.Clientes
{
    class ClientesBusiness
    {
        public int CadastrarCliente(ClientesDTO dto)
        {
            if (dto.ds_Bairro == string.Empty)
                throw new ArgumentException("Bairro não pode estar vazio.");

            if (dto.ds_Logradouro == string.Empty)
                throw new ArgumentException("Logradouro não pode estar vazio.");

            if (dto.ds_UF == string.Empty)
                throw new ArgumentException("UF não pode estar vazio.");

            if (dto.ds_CEP == string.Empty)
                throw new ArgumentException("CEP não pode estar vazio.");

            exReg regex = new exReg();
            regex.ValidarNome(dto.nm_Nome);
            regex.ValidarEmail(dto.ds_Email);
            regex.ValidarTelefoneCelular(dto.num_Celular);
            regex.ValidarTelefoneFixo(dto.num_Telefone);

            CPF validar = new CPF();
            validar.ValidarCPF(dto.ds_CPF);

            ClientesDatabase db = new ClientesDatabase();
            return db.CadastrarCliente(dto);
        }

        public int AlterarCliente(ClientesDTO dto)
        {
            if (dto.ds_Bairro == string.Empty)
                throw new ArgumentException("Bairro não pode estar vazio.");

            if (dto.ds_Logradouro == string.Empty)
                throw new ArgumentException("Logradouro não pode estar vazio.");

            if (dto.ds_UF == string.Empty)
                throw new ArgumentException("UF não pode estar vazio.");

            if (dto.ds_CEP == string.Empty)
                throw new ArgumentException("CEP não pode estar vazio.");

            if (dto.ds_Complemento == string.Empty)
                throw new ArgumentException("Complemento não pode estar vazio.");

            exReg regex = new exReg();
            regex.ValidarNome(dto.nm_Nome);
            regex.ValidarEmail(dto.ds_Email);
            regex.ValidarTelefoneCelular(dto.num_Celular);
            regex.ValidarTelefoneFixo(dto.num_Telefone);

            CPF validar = new CPF();
            validar.ValidarCPF(dto.ds_CPF);

            ClientesDatabase db = new ClientesDatabase();
            return db.AlterarCliente(dto);
        }

        public int RemoverCliente(int idCliente)
        {
            ClientesDatabase db = new ClientesDatabase();
            return db.RemoverCliente(idCliente);
        }

        public List<ClientesDTO> Consultar()
        {
            ClientesDatabase db = new ClientesDatabase();
            return db.Consultar();
        }

        public ClientesDTO ConsultarPorId(int idCliente)
        {
            ClientesDatabase db = new ClientesDatabase();
            return db.ConsultarPorId(idCliente);
        }
    }
}
