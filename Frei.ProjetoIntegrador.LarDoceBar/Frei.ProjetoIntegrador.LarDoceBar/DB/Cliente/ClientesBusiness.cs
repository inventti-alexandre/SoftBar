using Blibioteca.Developers.Validacao.ER;
using Frei.ProjetoIntegrador.Academia.Criptografia;
using Frei.ProjetoIntegrador.Academia.Validacoes;
using Frei.ProjetoIntegrador.LarDoceBar;
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

            ValidarNumero regexNum = new ValidarNumero();
            ValidarTexto regexTxt = new ValidarTexto();
            regexTxt.ValidarEmail(dto.ds_Email);
            regexTxt.ValidarNome(dto.nm_Nome);
            regexNum.ValidarTelefoneFixo(dto.num_Telefone);
            regexNum.ValidarTelefoneCelular(dto.num_Celular);

            CPF validar = new CPF();
            validar.ValidarCPF(dto.ds_CPF);

            DESCripto cripto = new DESCripto();
            dto.nm_Nome = cripto.Criptografar(Program.chave, dto.nm_Nome);
            dto.ds_CPF = cripto.Criptografar(Program.chave, dto.ds_CPF);
            dto.num_Celular = cripto.Criptografar(Program.chave, dto.num_Celular);
            dto.num_Telefone = cripto.Criptografar(Program.chave, dto.num_Telefone);
            dto.ds_Email = cripto.Criptografar(Program.chave, dto.ds_Email);

            ClientesDatabase db = new ClientesDatabase();
            int idCliente = db.CadastrarCliente(dto);

            if (idCliente == 0)
                throw new ArgumentException("O cliente não foi cadastrado com sucesso!");

            return idCliente;
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

            ValidarNumero regexNum = new ValidarNumero();
            ValidarTexto regexTxt = new ValidarTexto();
            regexTxt.ValidarEmail(dto.ds_Email);
            regexTxt.ValidarNome(dto.nm_Nome);
            regexNum.ValidarTelefoneFixo(dto.num_Telefone);
            regexNum.ValidarTelefoneCelular(dto.num_Celular);

            CPF validar = new CPF();
            validar.ValidarCPF(dto.ds_CPF);

            DESCripto cripto = new DESCripto();
            dto.nm_Nome = cripto.Criptografar(Program.chave, dto.nm_Nome);
            dto.ds_CPF = cripto.Criptografar(Program.chave, dto.ds_CPF);
            dto.num_Celular = cripto.Criptografar(Program.chave, dto.num_Celular);
            dto.num_Telefone = cripto.Criptografar(Program.chave, dto.num_Telefone);
            dto.ds_Email = cripto.Criptografar(Program.chave, dto.ds_Email);

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
            List<ClientesDTO> cliente = db.Consultar();

            if (cliente.Count != 0)
            {
                List<ClientesDTO> cliDescripto = new List<ClientesDTO>();
                DESCripto cripto = new DESCripto();
                foreach (ClientesDTO cli in cliente)
                {
                    cli.nm_Nome = cripto.Descriptografar(Program.chave, cli.nm_Nome);
                    cli.ds_CPF = cripto.Descriptografar(Program.chave, cli.ds_CPF);
                    cli.num_Celular = cripto.Descriptografar(Program.chave, cli.num_Celular);
                    cli.num_Telefone = cripto.Descriptografar(Program.chave, cli.num_Telefone);
                    cli.ds_Email = cripto.Descriptografar(Program.chave, cli.ds_Email);

                    cliDescripto.Add(cli);
                }

                return cliDescripto;
            }
            else
                return cliente;
        }

        public ClientesDTO ConsultarPorId(int idCliente)
        {
            ClientesDatabase db = new ClientesDatabase();
            ClientesDTO cliente = db.ConsultarPorId(idCliente);

            if (cliente.id_Cliente != 0)
            {
                DESCripto cripto = new DESCripto();
                cliente.nm_Nome = cripto.Descriptografar(Program.chave, cliente.nm_Nome);
                cliente.ds_CPF = cripto.Descriptografar(Program.chave, cliente.ds_CPF);
                cliente.num_Celular = cripto.Descriptografar(Program.chave, cliente.num_Celular);
                cliente.num_Telefone = cripto.Descriptografar(Program.chave, cliente.num_Telefone);
                cliente.ds_Email = cripto.Descriptografar(Program.chave, cliente.ds_Email);

                return cliente;
            }
            else
                return cliente;
        }
    }
}
