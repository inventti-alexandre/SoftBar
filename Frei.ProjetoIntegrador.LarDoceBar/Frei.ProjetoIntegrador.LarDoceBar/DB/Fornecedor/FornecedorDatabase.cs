using Frei.ProjetoIntegrador.LarDoceBar.DB.Base;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.LarDoceBar.DB.Fornecedor
{
    class FornecedorDatabase
    {
        public int CadastrarFornecedor(FornecedorDTO dto)
        {
            string script = @"INSERT tb_fornecedor(nm_Fornecedor, num_Telefone, ds_CEP, ds_Logradouro, ds_Bairro, ds_UF, ds_Complemento, ds_CNPJ, ds_Email, dt_Cadastro, ds_Situacao, fk_Fornecedor_Filial)
                                            VALUES(@nm_Fornecedor, @num_Telefone, @ds_CEP, @ds_Logradouro, @ds_Bairro, @ds_UF, @ds_Complemento, @ds_CNPJ, @ds_Email, @dt_Cadastro, @ds_Situacao, @fk_Fornecedor_Filial)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_Fornecedor", dto.nm_Fornecedor));
            parms.Add(new MySqlParameter("num_Telefone", dto.num_Telefone));
            parms.Add(new MySqlParameter("ds_CEP", dto.ds_CEP));
            parms.Add(new MySqlParameter("ds_Bairro", dto.ds_Bairro));
            parms.Add(new MySqlParameter("ds_UF", dto.ds_UF));
            parms.Add(new MySqlParameter("ds_Complemento", dto.ds_Complemento));
            parms.Add(new MySqlParameter("ds_CNPJ", dto.ds_CNPJ));
            parms.Add(new MySqlParameter("ds_Email", dto.ds_Email));
            parms.Add(new MySqlParameter("dt_Cadastro", dto.dt_Cadastro));
            parms.Add(new MySqlParameter("ds_Situacao", dto.ds_Situacao));
            parms.Add(new MySqlParameter("fk_Fornecedor_Filial", dto.fk_Fornecedor_Filial));
            parms.Add(new MySqlParameter("ds_Logradouro", dto.ds_Logradouro));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public int AlterarFornecedor(FornecedorDTO dto)
        {
            string script = @"UPDATE tb_fornecedor SET nm_Fornecedor = @nm_Fornecedor,
                                                        num_Telefone = @num_Telefone,
                                                              ds_CEP = @ds_CEP,
                                                       ds_Logradouro = @ds_Logradouro,
                                                           ds_Bairro = @ds_Bairro,
                                                               ds_UF = @ds_UF,
                                                      ds_Complemento = @ds_Complemento,
                                                             ds_CNPJ = @ds_CNPJ,
                                                            ds_Email = @ds_Email,
                                                         dt_Cadastro = @dt_Cadastro,
                                                         ds_Situacao = @ds_Situacao

                                                 WHERE id_Fornecedor = @id_Fornecedor";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_Fornecedor", dto.id_Fornecedor));
            parms.Add(new MySqlParameter("nm_Fornecedor", dto.nm_Fornecedor));
            parms.Add(new MySqlParameter("num_Telefone", dto.num_Telefone));
            parms.Add(new MySqlParameter("ds_CEP", dto.ds_CEP));
            parms.Add(new MySqlParameter("ds_Bairro", dto.ds_Bairro));
            parms.Add(new MySqlParameter("ds_UF", dto.ds_UF));
            parms.Add(new MySqlParameter("ds_Complemento", dto.ds_Complemento));
            parms.Add(new MySqlParameter("ds_CNPJ", dto.ds_CNPJ));
            parms.Add(new MySqlParameter("ds_Email", dto.ds_Email));
            parms.Add(new MySqlParameter("dt_Cadastro", dto.dt_Cadastro));
            parms.Add(new MySqlParameter("ds_Situacao", dto.ds_Situacao));
            parms.Add(new MySqlParameter("ds_Logradouro", dto.ds_Logradouro));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public int RemoverFornecedor(int idFornecedor)
        {
            string script = @"DELETE FROM tb_fornecedor WHERE id_Fornecedor = @id_Fornecedor";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_Fornecedor", idFornecedor));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public List<FornecedorDTO> Consultar()
        {
            string script = @"SELECT * FROM tb_fornecedor";
            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<FornecedorDTO> fornecedores = new List<FornecedorDTO>();
            while (reader.Read())
            {
                FornecedorDTO fornecedor = new FornecedorDTO();
                fornecedor.id_Fornecedor = reader.GetInt32("id_Fornecedor");
                fornecedor.nm_Fornecedor = reader.GetString("nm_Fornecedor");
                fornecedor.num_Telefone = reader.GetString("num_Telefone");
                fornecedor.ds_CEP = reader.GetString("ds_CEP");
                fornecedor.ds_Bairro = reader.GetString("ds_Bairro");
                fornecedor.ds_UF = reader.GetString("ds_UF");
                fornecedor.ds_Complemento = reader.GetString("ds_Complemento");
                fornecedor.ds_CNPJ = reader.GetString("ds_CNPJ");
                fornecedor.ds_Email = reader.GetString("ds_Email");
                fornecedor.dt_Cadastro = reader.GetDateTime("dt_Cadastro");
                fornecedor.ds_Situacao = reader.GetBoolean("ds_Situacao");
                fornecedor.fk_Fornecedor_Filial = reader.GetInt32("fk_Fornecedor_Filial");
                fornecedor.ds_Logradouro = reader.GetString("ds_Logradouro");

                fornecedores.Add(fornecedor);
            }

            reader.Close();
            return fornecedores;
        }

        public List<FornecedorDTO> ConsultarPorNome(string nome)
        {
            string script = $@"SELECT * FROM tb_fornecedor WHERE nm_Fornecedor LIKE '%{nome}%'";
            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<FornecedorDTO> fornecedores = new List<FornecedorDTO>();
            while (reader.Read())
            {
                FornecedorDTO fornecedor = new FornecedorDTO();
                fornecedor.id_Fornecedor = reader.GetInt32("id_Fornecedor");
                fornecedor.nm_Fornecedor = reader.GetString("nm_Fornecedor");
                fornecedor.num_Telefone = reader.GetString("num_Telefone");
                fornecedor.ds_CEP = reader.GetString("ds_CEP");
                fornecedor.ds_Bairro = reader.GetString("ds_Bairro");
                fornecedor.ds_UF = reader.GetString("ds_UF");
                fornecedor.ds_Complemento = reader.GetString("ds_Complemento");
                fornecedor.ds_CNPJ = reader.GetString("ds_CNPJ");
                fornecedor.ds_Email = reader.GetString("ds_Email");
                fornecedor.dt_Cadastro = reader.GetDateTime("dt_Cadastro");
                fornecedor.ds_Situacao = reader.GetBoolean("ds_Situacao");
                fornecedor.fk_Fornecedor_Filial = reader.GetInt32("fk_Fornecedor_Filial");
                fornecedor.ds_Logradouro = reader.GetString("ds_Logradouro");

                fornecedores.Add(fornecedor);
            }

            reader.Close();
            return fornecedores;
        }

        public List<FornecedorDTO> ConsultarPorSituacao(bool situacao)
        {
            string script = $@"SELECT * FROM tb_fornecedor WHERE ds_Situacao = '{situacao}'";
            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<FornecedorDTO> fornecedores = new List<FornecedorDTO>();
            while (reader.Read())
            {
                FornecedorDTO fornecedor = new FornecedorDTO();
                fornecedor.id_Fornecedor = reader.GetInt32("id_Fornecedor");
                fornecedor.nm_Fornecedor = reader.GetString("nm_Fornecedor");
                fornecedor.num_Telefone = reader.GetString("num_Telefone");
                fornecedor.ds_CEP = reader.GetString("ds_CEP");
                fornecedor.ds_Bairro = reader.GetString("ds_Bairro");
                fornecedor.ds_UF = reader.GetString("ds_UF");
                fornecedor.ds_Complemento = reader.GetString("ds_Complemento");
                fornecedor.ds_CNPJ = reader.GetString("ds_CNPJ");
                fornecedor.ds_Email = reader.GetString("ds_Email");
                fornecedor.dt_Cadastro = reader.GetDateTime("dt_Cadastro");
                fornecedor.ds_Situacao = reader.GetBoolean("ds_Situacao");
                fornecedor.fk_Fornecedor_Filial = reader.GetInt32("fk_Fornecedor_Filial");
                fornecedor.ds_Logradouro = reader.GetString("ds_Logradouro");

                fornecedores.Add(fornecedor);
            }

            reader.Close();
            return fornecedores;
        }

        public List<FornecedorDTO> ConsultarPorNome_Situacao(string nome, bool situacao)
        {
            string script = $@"SELECT * FROM tb_fornecedor WHERE nm_Fornecedor LIKE '%{nome}%' AND ds_Situacao = '{situacao}'";
            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<FornecedorDTO> fornecedores = new List<FornecedorDTO>();
            while (reader.Read())
            {
                FornecedorDTO fornecedor = new FornecedorDTO();
                fornecedor.id_Fornecedor = reader.GetInt32("id_Fornecedor");
                fornecedor.nm_Fornecedor = reader.GetString("nm_Fornecedor");
                fornecedor.num_Telefone = reader.GetString("num_Telefone");
                fornecedor.ds_CEP = reader.GetString("ds_CEP");
                fornecedor.ds_Bairro = reader.GetString("ds_Bairro");
                fornecedor.ds_UF = reader.GetString("ds_UF");
                fornecedor.ds_Complemento = reader.GetString("ds_Complemento");
                fornecedor.ds_CNPJ = reader.GetString("ds_CNPJ");
                fornecedor.ds_Email = reader.GetString("ds_Email");
                fornecedor.dt_Cadastro = reader.GetDateTime("dt_Cadastro");
                fornecedor.ds_Situacao = reader.GetBoolean("ds_Situacao");
                fornecedor.fk_Fornecedor_Filial = reader.GetInt32("fk_Fornecedor_Filial");
                fornecedor.ds_Logradouro = reader.GetString("ds_Logradouro");

                fornecedores.Add(fornecedor);
            }

            reader.Close();
            return fornecedores;
        }

        public List<FornecedorDTO> ConsultarPorFilial(int idFilial)
        {
            string script = $@"SELECT * FROM tb_fornecedor WHERE fk_Fornecedor_Filial = '{idFilial}'";
            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<FornecedorDTO> fornecedores = new List<FornecedorDTO>();
            while (reader.Read())
            {
                FornecedorDTO fornecedor = new FornecedorDTO();
                fornecedor.id_Fornecedor = reader.GetInt32("id_Fornecedor");
                fornecedor.nm_Fornecedor = reader.GetString("nm_Fornecedor");
                fornecedor.num_Telefone = reader.GetString("num_Telefone");
                fornecedor.ds_CEP = reader.GetString("ds_CEP");
                fornecedor.ds_Bairro = reader.GetString("ds_Bairro");
                fornecedor.ds_UF = reader.GetString("ds_UF");
                fornecedor.ds_Complemento = reader.GetString("ds_Complemento");
                fornecedor.ds_CNPJ = reader.GetString("ds_CNPJ");
                fornecedor.ds_Email = reader.GetString("ds_Email");
                fornecedor.dt_Cadastro = reader.GetDateTime("dt_Cadastro");
                fornecedor.ds_Situacao = reader.GetBoolean("ds_Situacao");
                fornecedor.fk_Fornecedor_Filial = reader.GetInt32("fk_Fornecedor_Filial");
                fornecedor.ds_Logradouro = reader.GetString("ds_Logradouro");

                fornecedores.Add(fornecedor);
            }

            reader.Close();
            return fornecedores;
        }

        public FornecedorDTO ConsultarPorId(int idFornecedor)
        {
            string script = $@"SELECT * FROM tb_fornecedor WHERE id_Fornecedor = '{idFornecedor}'";
            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            FornecedorDTO fornecedor = new FornecedorDTO();
            if (reader.Read())
            {
                fornecedor.id_Fornecedor = reader.GetInt32("id_Fornecedor");
                fornecedor.nm_Fornecedor = reader.GetString("nm_Fornecedor");
                fornecedor.num_Telefone = reader.GetString("num_Telefone");
                fornecedor.ds_CEP = reader.GetString("ds_CEP");
                fornecedor.ds_Bairro = reader.GetString("ds_Bairro");
                fornecedor.ds_UF = reader.GetString("ds_UF");
                fornecedor.ds_Complemento = reader.GetString("ds_Complemento");
                fornecedor.ds_CNPJ = reader.GetString("ds_CNPJ");
                fornecedor.ds_Email = reader.GetString("ds_Email");
                fornecedor.dt_Cadastro = reader.GetDateTime("dt_Cadastro");
                fornecedor.ds_Situacao = reader.GetBoolean("ds_Situacao");
                fornecedor.fk_Fornecedor_Filial = reader.GetInt32("fk_Fornecedor_Filial");
                fornecedor.ds_Logradouro = reader.GetString("ds_Logradouro");
            }

            reader.Close();
            return fornecedor;
        }
    }
}
