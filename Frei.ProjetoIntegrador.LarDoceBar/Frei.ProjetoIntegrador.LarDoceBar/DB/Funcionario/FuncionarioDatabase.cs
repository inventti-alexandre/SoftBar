using MySql.Data.MySqlClient;
using Nsf._2018.Modulo3.App.DB.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.Funcionario
{
    class FuncionarioDatabase
    {
        public int CadastrarFuncionario(FuncionarioDTO dto)
        {
            string script = @"INSERT tb_funcionario(nm_NomeFunc, ds_Sexo, ds_CPF, ds_CEPFunc, ds_Bairro, ds_Logradouro, ds_UF, ds_Complemento, num_Celular, num_Telefone, num_Residencia, ds_Email, dt_Admissao, dt_Demissao, dt_Nasc, fk_Func_Usuario, fk_Func_Filial)
                                             VALUES(@nm_NomeFunc, @ds_Sexo, @ds_CPF, @ds_CEPFunc, @ds_Bairro, @ds_Logradouro, @ds_UF, @ds_Complemento, @num_Celular, @num_Telefone, @num_Residencia, @ds_Email, @dt_Admissao, @dt_Demissao, @dt_Nasc, @fk_Func_Usuario, @fk_Func_Filial)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_NomeFunc", dto.nm_NomeFunc));
            parms.Add(new MySqlParameter("ds_Sexo", dto.ds_Sexo));
            parms.Add(new MySqlParameter("ds_CPF", dto.ds_CPF));
            parms.Add(new MySqlParameter("ds_CEPFunc", dto.ds_CEPFunc));
            parms.Add(new MySqlParameter("ds_Bairro", dto.ds_Bairro));
            parms.Add(new MySqlParameter("ds_Logradouro", dto.ds_Logradouro));
            parms.Add(new MySqlParameter("ds_UF", dto.ds_UF));
            parms.Add(new MySqlParameter("ds_Complemento", dto.ds_Complemento));
            parms.Add(new MySqlParameter("num_Celular", dto.num_Celular));
            parms.Add(new MySqlParameter("num_Telefone", dto.num_Telefone));
            parms.Add(new MySqlParameter("num_Residencia", dto.num_Residencia));
            parms.Add(new MySqlParameter("ds_Email", dto.ds_Email));
            parms.Add(new MySqlParameter("dt_Admissao", dto.dt_Admissao));
            parms.Add(new MySqlParameter("dt_Demissao", "1900-01-01"));
            parms.Add(new MySqlParameter("dt_Nasc", dto.dt_Nasc));
            parms.Add(new MySqlParameter("fk_Func_Usuario", dto.fk_Func_Usuario));
            parms.Add(new MySqlParameter("fk_Func_Filial", dto.fk_Func_Filial));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public int AlterarFuncionario(FuncionarioDTO dto)
        {
            string script = @"UPDATE tb_funcionario SET nm_NomeFunc = @nm_NomeFunc,
                                                        ds_Sexo = @ds_Sexo, 
                                                         ds_CPF = @ds_CPF, 
                                                         ds_CEPFunc = @ds_CEPFunc, 
                                                      ds_Bairro = @ds_Bairro, 
                                                  ds_Logradouro = @ds_Logradouro, 
                                                          ds_UF = @ds_UF, 
                                                 ds_Complemento = @ds_Complemento, 
                                                    num_Celular = @num_Celular, 
                                                   num_Telefone = @num_Telefone, 
                                                 num_Residencia = @num_Residencia, 
                                                       ds_Email = @ds_Email, 
                                                    dt_Admissao = @dt_Admissao, 
                                                    dt_Demissao = @dt_Demissao, 
                                                        dt_Nasc = @dt_Nasc, 
                                                fk_Func_Usuario = @fk_Func_Usuario

                                           WHERE id_Funcionario = @id_Funcionario";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_Funcionario", dto.id_Funcionario));
            parms.Add(new MySqlParameter("nm_NomeFunc", dto.nm_NomeFunc));
            parms.Add(new MySqlParameter("ds_Sexo", dto.ds_Sexo));
            parms.Add(new MySqlParameter("ds_CPF", dto.ds_CPF));
            parms.Add(new MySqlParameter("ds_CEPFunc", dto.ds_CEPFunc));
            parms.Add(new MySqlParameter("ds_Bairro", dto.ds_Bairro));
            parms.Add(new MySqlParameter("ds_Logradouro", dto.ds_Logradouro));
            parms.Add(new MySqlParameter("ds_UF", dto.ds_UF));
            parms.Add(new MySqlParameter("ds_Complemento", dto.ds_Complemento));
            parms.Add(new MySqlParameter("num_Celular", dto.num_Celular));
            parms.Add(new MySqlParameter("num_Telefone", dto.num_Telefone));
            parms.Add(new MySqlParameter("num_Residencia", dto.num_Residencia));
            parms.Add(new MySqlParameter("ds_Email", dto.ds_Email));
            parms.Add(new MySqlParameter("dt_Admissao", dto.dt_Admissao));
            parms.Add(new MySqlParameter("dt_Demissao", dto.dt_Demissao));
            parms.Add(new MySqlParameter("dt_Nasc", dto.dt_Nasc));
            parms.Add(new MySqlParameter("fk_Func_Usuario", dto.fk_Func_Usuario));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public int RemoverFuncionario(int idFuncionario)
        {
            string script = @"DELETE FROM tb_funcionario WHERE id_Funcionario = @id_Funcionario";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_Funcionario", idFuncionario));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public List<view_Func_Usua_Filial> Consultar()
        {
            string script = @"SELECT * FROM slc_Func_Usua_Filial";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<view_Func_Usua_Filial> funcionarios = new List<view_Func_Usua_Filial>();
            while (reader.Read())
            {
                view_Func_Usua_Filial funcionario = new view_Func_Usua_Filial();
                funcionario.id_Funcionario = reader.GetInt32("id_Funcionario");
                funcionario.nm_NomeFunc = reader.GetString("nm_NomeFunc");
                funcionario.ds_CPF = reader.GetString("ds_CPF");
                funcionario.ds_Sexo = reader.GetString("ds_Sexo");
                funcionario.ds_CEPFunc = reader.GetString("ds_CEPFunc");
                funcionario.ds_Logradouro = reader.GetString("ds_Logradouro");
                funcionario.ds_Bairro = reader.GetString("ds_Bairro");
                funcionario.ds_UF = reader.GetString("ds_UF");
                funcionario.ds_Complemento = reader.GetString("ds_Complemento");
                funcionario.num_Residencia = reader.GetString("num_Residencia");
                funcionario.num_Celular = reader.GetString("num_Celular");
                funcionario.num_Telefone = reader.GetString("num_Telefone");
                funcionario.ds_Email = reader.GetString("ds_Email");
                funcionario.dt_Admissao = reader.GetDateTime("dt_Admissao");
                funcionario.dt_Demissao = reader.GetDateTime("dt_Demissao");
                funcionario.dt_Nasc = reader.GetDateTime("dt_Nasc");
                funcionario.fk_Func_Usuario = reader.GetInt32("fk_Func_Usuario");
                funcionario.fk_Func_Filial = reader.GetInt32("fk_Func_Filial");
                funcionario.nm_Usuario = reader.GetString("nm_Usuario");
                funcionario.ds_Situacao = reader.GetBoolean("ds_Situacao");
                funcionario.nm_Nome = reader.GetString("nm_Nome");
                funcionario.ds_CEP = reader.GetString("ds_CEP");

                funcionarios.Add(funcionario);
            }

            reader.Close();
            return funcionarios;
        }

        public List<view_Func_Usua_Filial> ConsultarPorNome(string nome)
        {
            string script = $@"SELECT `tb_funcionario`.*,
		                             `tb_usuario`.nm_Usuario,
		                             `tb_usuario`.ds_Situacao,
                                     `tb_Filial`.nm_Nome,
                                     `tb_Filial`.ds_CEP
                                FROM `tb_funcionario`
                                JOIN `tb_Filial` 
                                ON fk_Func_Filial = id_Filial 
                                JOIN `tb_usuario` 
                                ON fk_Func_Usuario = id_Usuario

                                WHERE nm_NomeFunc LIKE '%{nome}%'";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<view_Func_Usua_Filial> funcionarios = new List<view_Func_Usua_Filial>();
            while (reader.Read())
            {
                view_Func_Usua_Filial funcionario = new view_Func_Usua_Filial();
                funcionario.id_Funcionario = reader.GetInt32("id_Funcionario");
                funcionario.nm_NomeFunc = reader.GetString("nm_NomeFunc");
                funcionario.ds_CPF = reader.GetString("ds_CPF");
                funcionario.ds_Sexo = reader.GetString("ds_Sexo");
                funcionario.ds_CEPFunc = reader.GetString("ds_CEPFunc");
                funcionario.ds_Logradouro = reader.GetString("ds_Logradouro");
                funcionario.ds_Bairro = reader.GetString("ds_Bairro");
                funcionario.ds_UF = reader.GetString("ds_UF");
                funcionario.ds_Complemento = reader.GetString("ds_Complemento");
                funcionario.num_Residencia = reader.GetString("num_Residencia");
                funcionario.num_Celular = reader.GetString("num_Celular");
                funcionario.num_Telefone = reader.GetString("num_Telefone");
                funcionario.ds_Email = reader.GetString("ds_Email");
                funcionario.dt_Admissao = reader.GetDateTime("dt_Admissao");
                funcionario.dt_Demissao = reader.GetDateTime("dt_Demissao");
                funcionario.dt_Nasc = reader.GetDateTime("dt_Nasc");
                funcionario.fk_Func_Usuario = reader.GetInt32("fk_Func_Usuario");
                funcionario.fk_Func_Filial = reader.GetInt32("fk_Func_Filial");
                funcionario.nm_Usuario = reader.GetString("nm_Usuario");
                funcionario.ds_Situacao = reader.GetBoolean("ds_Situacao");
                funcionario.nm_Nome = reader.GetString("nm_Nome");
                funcionario.ds_CEP = reader.GetString("ds_CEP");

                funcionarios.Add(funcionario);
            }

            reader.Close();
            return funcionarios;
        }

        public view_Func_Usua_Filial ConsultarPorId(int id)
        {
            string script = $@"SELECT `tb_funcionario`.*,
		                             `tb_usuario`.nm_Usuario,
		                             `tb_usuario`.ds_Situacao,
                                     `tb_Filial`.nm_Nome,
                                     `tb_Filial`.ds_CEP
                                FROM `tb_funcionario`
                                JOIN `tb_Filial` 
                                ON fk_Func_Filial = id_Filial 
                                JOIN `tb_usuario` 
                                ON fk_Func_Usuario = id_Usuario

                                WHERE id_Funcionario = '{id}'";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            view_Func_Usua_Filial funcionario = new view_Func_Usua_Filial();
            if (reader.Read())
            {
                funcionario.id_Funcionario = reader.GetInt32("id_Funcionario");
                funcionario.nm_NomeFunc = reader.GetString("nm_NomeFunc");
                funcionario.ds_CPF = reader.GetString("ds_CPF");
                funcionario.ds_Sexo = reader.GetString("ds_Sexo");
                funcionario.ds_CEPFunc = reader.GetString("ds_CEPFunc");
                funcionario.ds_Logradouro = reader.GetString("ds_Logradouro");
                funcionario.ds_Bairro = reader.GetString("ds_Bairro");
                funcionario.ds_UF = reader.GetString("ds_UF");
                funcionario.ds_Complemento = reader.GetString("ds_Complemento");
                funcionario.num_Residencia = reader.GetString("num_Residencia");
                funcionario.num_Celular = reader.GetString("num_Celular");
                funcionario.num_Telefone = reader.GetString("num_Telefone");
                funcionario.ds_Email = reader.GetString("ds_Email");
                funcionario.dt_Admissao = reader.GetDateTime("dt_Admissao");
                funcionario.dt_Demissao = reader.GetDateTime("dt_Demissao");
                funcionario.dt_Nasc = reader.GetDateTime("dt_Nasc");
                funcionario.fk_Func_Usuario = reader.GetInt32("fk_Func_Usuario");
                funcionario.fk_Func_Filial = reader.GetInt32("fk_Func_Filial");
                funcionario.nm_Usuario = reader.GetString("nm_Usuario");
                funcionario.ds_Situacao = reader.GetBoolean("ds_Situacao");
                funcionario.nm_Nome = reader.GetString("nm_Nome");
                funcionario.ds_CEP = reader.GetString("ds_CEP");
            }

            reader.Close();
            return funcionario;
        }

        public List<view_Func_Usua_Filial> ConsultarPorCPF(string cpf)
        {
            string script = @"SELECT `tb_funcionario`.*,
		                             `tb_usuario`.nm_Usuario,
		                             `tb_usuario`.ds_Situacao,
                                     `tb_Filial`.nm_Nome,
                                     `tb_Filial`.ds_CEP
                                FROM `tb_funcionario`
                                JOIN `tb_Filial` 
                                ON fk_Func_Filial = id_Filial 
                                JOIN `tb_usuario` 
                                ON fk_Func_Usuario = id_Usuario

                                WHERE ds_CPF = @ds_CPF";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("ds_CPF", cpf));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<view_Func_Usua_Filial> funcionarios = new List<view_Func_Usua_Filial>();
            while (reader.Read())
            {
                view_Func_Usua_Filial funcionario = new view_Func_Usua_Filial();
                funcionario.id_Funcionario = reader.GetInt32("id_Funcionario");
                funcionario.nm_NomeFunc = reader.GetString("nm_NomeFunc");
                funcionario.ds_CPF = reader.GetString("ds_CPF");
                funcionario.ds_Sexo = reader.GetString("ds_Sexo");
                funcionario.ds_CEPFunc = reader.GetString("ds_CEPFunc");
                funcionario.ds_Logradouro = reader.GetString("ds_Logradouro");
                funcionario.ds_Bairro = reader.GetString("ds_Bairro");
                funcionario.ds_UF = reader.GetString("ds_UF");
                funcionario.ds_Complemento = reader.GetString("ds_Complemento");
                funcionario.num_Residencia = reader.GetString("num_Residencia");
                funcionario.num_Celular = reader.GetString("num_Celular");
                funcionario.num_Telefone = reader.GetString("num_Telefone");
                funcionario.ds_Email = reader.GetString("ds_Email");
                funcionario.dt_Admissao = reader.GetDateTime("dt_Admissao");
                funcionario.dt_Demissao = reader.GetDateTime("dt_Demissao");
                funcionario.dt_Nasc = reader.GetDateTime("dt_Nasc");
                funcionario.fk_Func_Usuario = reader.GetInt32("fk_Func_Usuario");
                funcionario.fk_Func_Filial = reader.GetInt32("fk_Func_Filial");
                funcionario.nm_Usuario = reader.GetString("nm_Usuario");
                funcionario.ds_Situacao = reader.GetBoolean("ds_Situacao");
                funcionario.nm_Nome = reader.GetString("nm_Nome");
                funcionario.ds_CEP = reader.GetString("ds_CEP");

                funcionarios.Add(funcionario);
            }

            reader.Close();
            return funcionarios;
        }

        public List<view_Func_Usua_Filial> ConsultarPorFilial(int idFilial)
        {
            string script = @"SELECT `tb_funcionario`.*,
		                             `tb_usuario`.nm_Usuario,
		                             `tb_usuario`.ds_Situacao,
                                     `tb_Filial`.nm_Nome,
                                     `tb_Filial`.ds_CEP
                                FROM `tb_funcionario`
                                JOIN `tb_Filial` 
                                ON fk_Func_Filial = id_Filial 
                                JOIN `tb_usuario` 
                                ON fk_Func_Usuario = id_Usuario

                                WHERE fk_Func_Filial = @fk_Func_Filial";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("fk_Func_Filial", idFilial));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<view_Func_Usua_Filial> funcionarios = new List<view_Func_Usua_Filial>();
            while (reader.Read())
            {
                view_Func_Usua_Filial funcionario = new view_Func_Usua_Filial();
                funcionario.id_Funcionario = reader.GetInt32("id_Funcionario");
                funcionario.nm_NomeFunc = reader.GetString("nm_NomeFunc");
                funcionario.ds_CPF = reader.GetString("ds_CPF");
                funcionario.ds_Sexo = reader.GetString("ds_Sexo");
                funcionario.ds_CEPFunc = reader.GetString("ds_CEPFunc");
                funcionario.ds_Logradouro = reader.GetString("ds_Logradouro");
                funcionario.ds_Bairro = reader.GetString("ds_Bairro");
                funcionario.ds_UF = reader.GetString("ds_UF");
                funcionario.ds_Complemento = reader.GetString("ds_Complemento");
                funcionario.num_Residencia = reader.GetString("num_Residencia");
                funcionario.num_Celular = reader.GetString("num_Celular");
                funcionario.num_Telefone = reader.GetString("num_Telefone");
                funcionario.ds_Email = reader.GetString("ds_Email");
                funcionario.dt_Admissao = reader.GetDateTime("dt_Admissao");
                funcionario.dt_Demissao = reader.GetDateTime("dt_Demissao");
                funcionario.dt_Nasc = reader.GetDateTime("dt_Nasc");
                funcionario.fk_Func_Usuario = reader.GetInt32("fk_Func_Usuario");
                funcionario.fk_Func_Filial = reader.GetInt32("fk_Func_Filial");
                funcionario.nm_Usuario = reader.GetString("nm_Usuario");
                funcionario.ds_Situacao = reader.GetBoolean("ds_Situacao");
                funcionario.nm_Nome = reader.GetString("nm_Nome");
                funcionario.ds_CEP = reader.GetString("ds_CEP");

                funcionarios.Add(funcionario);
            }

            reader.Close();
            return funcionarios;
        }

        public List<view_Func_Usua_Filial> ConsultarPorNome_Filial(int idFilial, string nome)
        {
            string script = $@"SELECT `tb_funcionario`.*,
		                             `tb_usuario`.nm_Usuario,
		                             `tb_usuario`.ds_Situacao,
                                     `tb_Filial`.nm_Nome,
                                     `tb_Filial`.ds_CEP
                                FROM `tb_funcionario`
                                JOIN `tb_Filial` 
                                ON fk_Func_Filial = id_Filial 
                                JOIN `tb_usuario` 
                                ON fk_Func_Usuario = id_Usuario

                                WHERE fk_Func_Filial = @fk_Func_Filial%
                                  AND nm_NomeFunc LIKE '%{nome}%";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
            parms.Add(new MySqlParameter("fk_Func_Filial", idFilial));

            List<view_Func_Usua_Filial> funcionarios = new List<view_Func_Usua_Filial>();
            while (reader.Read())
            {
                view_Func_Usua_Filial funcionario = new view_Func_Usua_Filial();
                funcionario.id_Funcionario = reader.GetInt32("id_Funcionario");
                funcionario.nm_NomeFunc = reader.GetString("nm_NomeFunc");
                funcionario.ds_CPF = reader.GetString("ds_CPF");
                funcionario.ds_Sexo = reader.GetString("ds_Sexo");
                funcionario.ds_CEPFunc = reader.GetString("ds_CEPFunc");
                funcionario.ds_Logradouro = reader.GetString("ds_Logradouro");
                funcionario.ds_Bairro = reader.GetString("ds_Bairro");
                funcionario.ds_UF = reader.GetString("ds_UF");
                funcionario.ds_Complemento = reader.GetString("ds_Complemento");
                funcionario.num_Residencia = reader.GetString("num_Residencia");
                funcionario.num_Celular = reader.GetString("num_Celular");
                funcionario.num_Telefone = reader.GetString("num_Telefone");
                funcionario.ds_Email = reader.GetString("ds_Email");
                funcionario.dt_Admissao = reader.GetDateTime("dt_Admissao");
                funcionario.dt_Demissao = reader.GetDateTime("dt_Demissao");
                funcionario.dt_Nasc = reader.GetDateTime("dt_Nasc");
                funcionario.fk_Func_Usuario = reader.GetInt32("fk_Func_Usuario");
                funcionario.fk_Func_Filial = reader.GetInt32("fk_Func_Filial");
                funcionario.nm_Usuario = reader.GetString("nm_Usuario");
                funcionario.ds_Situacao = reader.GetBoolean("ds_Situacao");
                funcionario.nm_Nome = reader.GetString("nm_Nome");
                funcionario.ds_CEP = reader.GetString("ds_CEP");

                funcionarios.Add(funcionario);
            }

            reader.Close();
            return funcionarios;
        }
    }
}
