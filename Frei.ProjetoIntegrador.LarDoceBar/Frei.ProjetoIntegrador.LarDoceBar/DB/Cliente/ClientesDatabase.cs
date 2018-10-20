using MySql.Data.MySqlClient;
using Nsf._2018.Modulo3.App.DB.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.Clientes
{
    class ClientesDatabase
    {
        public int CadastrarCliente(ClientesDTO dto)
        {
            string script = @"INSERT tb_clientes(nm_Nome, ds_CPF, ds_CEP, ds_Logradouro, ds_Bairro, ds_UF, ds_Complemento, ds_Situacao, num_Telefone, num_Celular, ds_Email, dt_Cadastro, fk_Cliente_Filial)
                                          VALUES(@nm_Nome, @ds_CPF, @ds_CEP, @ds_Logradouro, @ds_Bairro, @ds_UF, @ds_Complemento, @ds_Situacao, @num_Telefone, @num_Celular, @ds_Email, @dt_Cadastro, @fk_Cliente_Filial)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_Nome", dto.nm_Nome));
            parms.Add(new MySqlParameter("ds_CPF", dto.ds_CPF));
            parms.Add(new MySqlParameter("ds_CEP", dto.ds_CEP));
            parms.Add(new MySqlParameter("ds_Logradouro", dto.ds_Logradouro));
            parms.Add(new MySqlParameter("ds_Bairro", dto.ds_Bairro));
            parms.Add(new MySqlParameter("ds_UF", dto.ds_UF));
            parms.Add(new MySqlParameter("ds_Complemento", dto.ds_Complemento));
            parms.Add(new MySqlParameter("ds_Situacao", true));
            parms.Add(new MySqlParameter("num_Telefone", dto.num_Telefone));
            parms.Add(new MySqlParameter("num_Celular", dto.num_Celular));
            parms.Add(new MySqlParameter("ds_Email", dto.ds_Email));
            parms.Add(new MySqlParameter("dt_Cadastro", dto.dt_Cadastro));
            parms.Add(new MySqlParameter("fk_Cliente_Filial", dto.fk_Cliente_Filial));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public int AlterarCliente(ClientesDTO dto)
        {
            string script = @"UPDATE tb_clientes SET nm_Nome = @nm_Nome,
                                                      ds_CPF = @ds_CPF, 
                                                      ds_CEP = @ds_CEP, 
                                               ds_Logradouro = @ds_Logradouro, 
                                                   ds_Bairro = @ds_Bairro, 
                                                       ds_UF = @ds_UF, 
                                              ds_Complemento = @ds_Complemento, 
                                                 ds_Situacao = @ds_Situacao, 
                                                num_Telefone = @num_Telefone, 
                                                 num_Celular = @num_Celular, 
                                                    ds_Email = @ds_Email, 
                                                 dt_Cadastro = @dt_Cadastro, 
                                           fk_Cliente_Filial = @fk_Cliente_Filial

                                            WHERE id_Cliente = @id_Cliente";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_Cliente", dto.id_Cliente));
            parms.Add(new MySqlParameter("nm_Nome", dto.nm_Nome));
            parms.Add(new MySqlParameter("ds_CPF", dto.ds_CPF));
            parms.Add(new MySqlParameter("ds_CEP", dto.ds_CEP));
            parms.Add(new MySqlParameter("ds_Logradouro", dto.ds_Logradouro));
            parms.Add(new MySqlParameter("ds_Bairro", dto.ds_Bairro));
            parms.Add(new MySqlParameter("ds_UF", dto.ds_UF));
            parms.Add(new MySqlParameter("ds_Complemento", dto.ds_Complemento));
            parms.Add(new MySqlParameter("ds_Situacao", dto.ds_Situacao));
            parms.Add(new MySqlParameter("num_Telefone", dto.num_Telefone));
            parms.Add(new MySqlParameter("num_Celular", dto.num_Celular));
            parms.Add(new MySqlParameter("ds_Email", dto.ds_Email));
            parms.Add(new MySqlParameter("dt_Cadastro", dto.dt_Cadastro));
            parms.Add(new MySqlParameter("fk_Cliente_Filial", dto.fk_Cliente_Filial));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public int RemoverCliente(int idCliente)
        {
            string script = "DELETE FROM tb_clientes WHERE id_Cliente = @id_Cliente";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_Cliente", idCliente));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public List<ClientesDTO> Consultar()
        {
            string script = @"SELECT * FROM tb_clientes";
            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<ClientesDTO> clientes = new List<ClientesDTO>();
            while (reader.Read())
            {
                ClientesDTO cliente = new ClientesDTO();
                cliente.id_Cliente = reader.GetInt32("id_Cliente");
                cliente.nm_Nome = reader.GetString("nm_Nome");
                cliente.ds_CPF = reader.GetString("ds_CPF");
                cliente.ds_CEP = reader.GetString("ds_CEP");
                cliente.ds_Logradouro = reader.GetString("ds_Logradouro");
                cliente.ds_Bairro = reader.GetString("ds_Bairro");
                cliente.ds_UF = reader.GetString("ds_UF");
                cliente.ds_Complemento = reader.GetString("ds_Complemento");
                cliente.ds_Situacao = reader.GetString("ds_Situacao");
                cliente.num_Telefone = reader.GetString("num_Telefone");
                cliente.num_Celular = reader.GetString("num_Celular");
                cliente.ds_Email = reader.GetString("ds_Email");
                cliente.dt_Cadastro = reader.GetDateTime("dt_Cadastro");
                cliente.fk_Cliente_Filial = reader.GetInt32("fk_Cliente_Filial");

                clientes.Add(cliente);
            }

            reader.Close();
            return clientes;
        }

        public ClientesDTO ConsultarPorId(int idCliente)
        {
            string script = $"SELECT * FROM tb_clientes WHERE id_Cliente = '{idCliente}'";
            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            ClientesDTO cliente = new ClientesDTO();
            if (reader.Read())
            {
                cliente.id_Cliente = reader.GetInt32("id_Cliente");
                cliente.nm_Nome = reader.GetString("nm_Nome");
                cliente.ds_CPF = reader.GetString("ds_CPF");
                cliente.ds_CEP = reader.GetString("ds_CEP");
                cliente.ds_Logradouro = reader.GetString("ds_Logradouro");
                cliente.ds_Bairro = reader.GetString("ds_Bairro");
                cliente.ds_UF = reader.GetString("ds_UF");
                cliente.ds_Complemento = reader.GetString("ds_Complemento");
                cliente.ds_Situacao = reader.GetString("ds_Situacao");
                cliente.num_Telefone = reader.GetString("num_Telefone");
                cliente.num_Celular = reader.GetString("num_Celular");
                cliente.ds_Email = reader.GetString("ds_Email");
                cliente.dt_Cadastro = reader.GetDateTime("dt_Cadastro");
                cliente.fk_Cliente_Filial = reader.GetInt32("fk_Cliente_Filial");
            }

            reader.Close();
            return cliente;
        }
    }
}
