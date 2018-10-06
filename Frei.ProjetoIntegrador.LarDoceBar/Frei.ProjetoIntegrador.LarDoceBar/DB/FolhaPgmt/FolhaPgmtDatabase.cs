using MySql.Data.MySqlClient;
using Nsf._2018.Modulo3.App.DB.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.FolhaPgmt
{
    class FolhaPgmtDatabase
    {
        public int SalvarFolha(FolhaPgmtDTO dto)
        {
            string script = @"INSERT tb_folha_pgmt(dt_Registro, vl_SalarioBruto, ds_DiasTrabalhados, ds_Cargo, ds_HoraE50, ds_HoraE100, ds_Mensagem, fk_FolhaPgmt_Func)
                                            VALUES(@dt_Registro, @vl_SalarioBruto, @ds_DiasTrabalhados, @ds_Cargo, @ds_HoraE50, @ds_HoraE100, @ds_Mensagem, @fk_FolhaPgmt_Func)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("dt_Registro", dto.dt_Registro));
            parms.Add(new MySqlParameter("vl_SalarioBruto", dto.vl_SalarioBruto));
            parms.Add(new MySqlParameter("ds_DiasTrabalhados", dto.ds_DiasTrabalhados));
            parms.Add(new MySqlParameter("ds_Cargo", dto.ds_Cargo));
            parms.Add(new MySqlParameter("ds_HoraE50", dto.ds_HoraE50));
            parms.Add(new MySqlParameter("ds_HoraE100", dto.ds_HoraE100));
            parms.Add(new MySqlParameter("ds_Mensagem", dto.ds_Mensagem));
            parms.Add(new MySqlParameter("fk_FolhaPgmt_Func", dto.fk_FolhaPgmt_Func));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public int AlterarFolha(FolhaPgmtDTO dto)
        {
            string script = @"UPDATE tb_folha_pgmt SET dt_Registro = @dt_Registro,
                                                   vl_SalarioBruto = @vl_SalarioBruto, 
                                                ds_DiasTrabalhados = @ds_DiasTrabalhados, 
                                                          ds_Cargo = @ds_Cargo,
                                                        ds_HoraE50 = @ds_HoraE50, 
                                                       ds_HoraE100 = @ds_HoraE100,
                                                       ds_Mensagem = @ds_Mensagem
    
                                               WHERE id_Folha_Pgmt = @id_Folha_Pgmt";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_Folha_Pgmt", dto.id_Folha_Pgmt));
            parms.Add(new MySqlParameter("dt_Registro", dto.dt_Registro));
            parms.Add(new MySqlParameter("vl_SalarioBruto", dto.vl_SalarioBruto));
            parms.Add(new MySqlParameter("ds_DiasTrabalhados", dto.ds_DiasTrabalhados));
            parms.Add(new MySqlParameter("ds_Cargo", dto.ds_Cargo));
            parms.Add(new MySqlParameter("ds_HoraE50", dto.ds_HoraE50));
            parms.Add(new MySqlParameter("ds_HoraE100", dto.ds_HoraE100));
            parms.Add(new MySqlParameter("ds_Mensagem", dto.ds_Mensagem));
            parms.Add(new MySqlParameter("fk_FolhaPgmt_Func", dto.fk_FolhaPgmt_Func));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public int RemoverFolha(int idFolha)
        {
            string script = @"DELETE FROM tb_folha_pgmt WHERE id_Folha_Pgmt = @id_Folha_Pgmt";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_Folha_Pgmt", idFolha));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public List<view_func_folha> Consultar()
        {
            string script = @"SELECT * FROM view_func_folha";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<view_func_folha> folhas = new List<view_func_folha>();
            while (reader.Read())
            {
                view_func_folha folha = new view_func_folha();
                folha.id_Folha_Pgmt = reader.GetInt32("id_Folha_Pgmt");
                folha.dt_Registro = reader.GetDateTime("dt_Registro");
                folha.vl_SalarioBruto = reader.GetDecimal("vl_SalarioBruto");
                folha.ds_DiasTrabalhados = reader.GetInt32("ds_DiasTrabalhados");
                folha.ds_Cargo = reader.GetString("ds_Cargo");
                folha.ds_HoraE50 = reader.GetInt32("ds_HoraE50");
                folha.ds_HoraE100 = reader.GetInt32("ds_HoraE100");
                folha.ds_Mensagem = reader.GetString("ds_Mensagem");
                folha.fk_FolhaPgmt_Func = reader.GetInt32("fk_FolhaPgmt_Func");
                folha.nm_NomeFunc = reader.GetString("nm_NomeFunc");
                folha.ds_CPF = reader.GetString("ds_CPF");

                folhas.Add(folha);
            }
            reader.Close();
            return folhas;
        }

        public List<view_func_folha> ConsultarPorFilial(string filial)
        {
            string script = $"SELECT * FROM view_func_folha WHERE nm_Nome LIKE '%{filial}%'";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<view_func_folha> folhas = new List<view_func_folha>();
            while (reader.Read())
            {
                view_func_folha folha = new view_func_folha();
                folha.id_Folha_Pgmt = reader.GetInt32("id_Folha_Pgmt");
                folha.dt_Registro = reader.GetDateTime("dt_Registro");
                folha.vl_SalarioBruto = reader.GetDecimal("vl_SalarioBruto");
                folha.ds_DiasTrabalhados = reader.GetInt32("ds_DiasTrabalhados");
                folha.ds_Cargo = reader.GetString("ds_Cargo");
                folha.ds_HoraE50 = reader.GetInt32("ds_HoraE50");
                folha.ds_HoraE100 = reader.GetInt32("ds_HoraE100");
                folha.ds_Mensagem = reader.GetString("ds_Mensagem");
                folha.fk_FolhaPgmt_Func = reader.GetInt32("fk_FolhaPgmt_Func");
                folha.nm_NomeFunc = reader.GetString("nm_NomeFunc");
                folha.ds_CPF = reader.GetString("ds_CPF");

                folhas.Add(folha);
            }
            reader.Close();
            return folhas;
        }

        public view_func_folha ConsultarPorCPF(string CPF)
        {
            string script = $"SELECT * FROM view_func_folha WHERE ds_CPF = '{CPF}'";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            view_func_folha folha = new view_func_folha();
            if (reader.Read())
            {
                folha.id_Folha_Pgmt = reader.GetInt32("id_Folha_Pgmt");
                folha.dt_Registro = reader.GetDateTime("dt_Registro");
                folha.vl_SalarioBruto = reader.GetDecimal("vl_SalarioBruto");
                folha.ds_DiasTrabalhados = reader.GetInt32("ds_DiasTrabalhados");
                folha.ds_Cargo = reader.GetString("ds_Cargo");
                folha.ds_HoraE50 = reader.GetInt32("ds_HoraE50");
                folha.ds_HoraE100 = reader.GetInt32("ds_HoraE100");
                folha.ds_Mensagem = reader.GetString("ds_Mensagem");
                folha.fk_FolhaPgmt_Func = reader.GetInt32("fk_FolhaPgmt_Func");
                folha.nm_NomeFunc = reader.GetString("nm_NomeFunc");
                folha.ds_CPF = reader.GetString("ds_CPF");
            }
            reader.Close();
            return folha;
        }

        public view_func_folha ConsultarPorId(string id)
        {
            string script = $"SELECT * FROM view_func_folha WHERE id_Folha_Pgmt = '{id}'";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            view_func_folha folha = new view_func_folha();
            if (reader.Read())
            {   
                folha.id_Folha_Pgmt = reader.GetInt32("id_Folha_Pgmt");
                folha.dt_Registro = reader.GetDateTime("dt_Registro");
                folha.vl_SalarioBruto = reader.GetDecimal("vl_SalarioBruto");
                folha.ds_DiasTrabalhados = reader.GetInt32("ds_DiasTrabalhados");
                folha.ds_Cargo = reader.GetString("ds_Cargo");
                folha.ds_HoraE50 = reader.GetInt32("ds_HoraE50");
                folha.ds_HoraE100 = reader.GetInt32("ds_HoraE100");
                folha.ds_Mensagem = reader.GetString("ds_Mensagem");
                folha.fk_FolhaPgmt_Func = reader.GetInt32("fk_FolhaPgmt_Func");
                folha.nm_NomeFunc = reader.GetString("nm_NomeFunc");
                folha.ds_CPF = reader.GetString("ds_CPF");
            }
            reader.Close();
            return folha;
        }

        public decimal TaxaIR(decimal SalarioBase)
        {
            string script = $@"Select ds_Aliquota FROM tb_IR 
                                                 WHERE ds_Salario <= '{SalarioBase}'
                                              ORDER BY ds_Salario 
                                            DESC LIMIT 1";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            if (reader.Read())
            {
                decimal taxa = reader.GetDecimal("ds_Aliquota");
                return taxa;
            }
            else
                return 0;
        }

        public decimal DeducaoIR(decimal SalarioBase)
        {
            string script = $@"Select ds_Deduzir FROM tb_IR 
                                                 WHERE ds_Salario <= '{SalarioBase}'
                                              ORDER BY ds_Salario 
                                            DESC LIMIT 1";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            if (reader.Read())
            {
                decimal taxa = reader.GetDecimal("ds_Deduzir");
                return taxa;
            }
            else
                return 0;
        }

        public decimal TaxaINSS(decimal SalarioBase)
        {
            string script = $@"Select ds_Aliquota FROM tb_INSS 
                                                 WHERE ds_Salario <= '{SalarioBase}'
                                              ORDER BY ds_Salario 
                                            DESC LIMIT 1";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            if (reader.Read())
            {
                decimal taxa = reader.GetDecimal("ds_Aliquota");
                return taxa;
            }
            else
                return 0;
        }

        public List<Descontos_DTO> Descontos()
        {
            string script = @"SELECT * FROM tb_Descontos";
            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<Descontos_DTO> descontos = new List<Descontos_DTO>();
            while (reader.Read())
            {
                Descontos_DTO desconto = new Descontos_DTO();
                desconto.id_Descontos = reader.GetInt32("id_Descontos");
                desconto.ds_Tipo = reader.GetString("ds_Tipo");
                desconto.ds_Porcentagem = reader.GetDecimal("ds_Porcentagem");

                descontos.Add(desconto);
            }
            reader.Close();
            return descontos;
        }
    }
}
