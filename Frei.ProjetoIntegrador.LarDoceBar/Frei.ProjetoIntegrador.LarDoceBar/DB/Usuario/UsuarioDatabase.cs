using MySql.Data.MySqlClient;
using Nsf._2018.Modulo3.App.DB.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.Usuario
{
    class UsuarioDatabase
    {
        public int CadastrarUsuario(UsuarioDTO dto)
        {
            string script = @"INSERT tb_usuario(nm_Usuario, ds_Senha, Cod_Perm, ds_Situacao, fk_Usuario_Filial)
                                         VALUES(@nm_Usuario, @ds_Senha, @Cod_Perm, @ds_Situacao, @fk_Usuario_Filial)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_Usuario", dto.nm_Usuario));
            parms.Add(new MySqlParameter("ds_Senha", dto.ds_Senha));
            parms.Add(new MySqlParameter("Cod_Perm", dto.Cod_Perm));
            parms.Add(new MySqlParameter("ds_Situacao", dto.ds_Situacao));
            parms.Add(new MySqlParameter("fk_Usuario_Filial", Program.id_Filial));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public int AlterarUsuario(UsuarioDTO dto)
        {
            string script = @"UPDATE tb_usuario SET nm_Usuario = @nm_Usuario,
                                                      ds_Senha = @ds_Senha,
                                                      Cod_Perm = @Cod_Perm,
                                                   ds_Situacao = @ds_Situacao

                                              WHERE id_Usuario = @id_Usuario";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_Usuario", dto.id_Usuario));
            parms.Add(new MySqlParameter("nm_Usuario", dto.nm_Usuario));
            parms.Add(new MySqlParameter("ds_Senha", dto.ds_Senha));
            parms.Add(new MySqlParameter("Cod_Perm", dto.Cod_Perm));
            parms.Add(new MySqlParameter("ds_Situacao", dto.ds_Situacao));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public int RemoverUsuario(int id)
        {
            string script = @"DELETE FROM tb_usuario WHERE id_Usuario = @id_Usuario";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_Usuario", id));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public List<view_Usuario_Filial> Consultar()
        {
            string script = @"SELECT * FROM view_Usuario_Filial";
            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<view_Usuario_Filial> usuarios = new List<view_Usuario_Filial>();
            while (reader.Read())
            {
                view_Usuario_Filial user = new view_Usuario_Filial();
                user.id_Usuario = reader.GetInt32("id_Usuario");
                user.nm_Nome = reader.GetString("nm_Nome");
                user.nm_Usuario = reader.GetString("nm_Usuario");
                user.fk_Usuario_Filial = reader.GetInt32("fk_Usuario_Filial");
                user.ds_Situacao = reader.GetBoolean("ds_Situacao");
                user.ds_Senha = reader.GetString("ds_Senha");
                user.ds_CEP = reader.GetString("ds_CEP");
                user.Cod_Perm = reader.GetString("Cod_Perm");

                usuarios.Add(user);
            }

            reader.Close();
            return usuarios;
        }

        public List<view_Usuario_Filial> ConsultarPorNome(string nome)
        {
            string script = $@"SELECT `tb_usuario`.*,
                                      `tb_Filial`.nm_Nome,
                                      `tb_Filial`.ds_CEP
                                 FROM `tb_usuario` 
                                 JOIN `tb_Filial` 
                                   ON fk_Usuario_Filial = id_Filial
    
                                WHERE nm_Usuario LIKE '%{nome}%'";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<view_Usuario_Filial> usuarios = new List<view_Usuario_Filial>();
            while (reader.Read())
            {
                view_Usuario_Filial user = new view_Usuario_Filial();
                user.id_Usuario = reader.GetInt32("id_Usuario");
                user.nm_Nome = reader.GetString("nm_Nome");
                user.nm_Usuario = reader.GetString("nm_Usuario");
                user.fk_Usuario_Filial = reader.GetInt32("fk_Usuario_Filial");
                user.ds_Situacao = reader.GetBoolean("ds_Situacao");
                user.ds_Senha = reader.GetString("ds_Senha");
                user.ds_CEP = reader.GetString("ds_CEP");
                user.Cod_Perm = reader.GetString("Cod_Perm");

                usuarios.Add(user);
            }

            reader.Close();
            return usuarios;
        }

        public view_Usuario_Filial ConsultarPorId(string id)
        {
            string script = $@"SELECT `tb_usuario`.*,
                                      `tb_Filial`.nm_Nome,
                                      `tb_Filial`.ds_CEP
                                 FROM `tb_usuario` 
                                 JOIN `tb_Filial` 
                                   ON fk_Usuario_Filial = id_Filial
    
                                WHERE id_Usuario LIKE '%{id}%'";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            view_Usuario_Filial user = new view_Usuario_Filial();
            while (reader.Read())
            {
                user.id_Usuario = reader.GetInt32("id_Usuario");
                user.nm_Nome = reader.GetString("nm_Nome");
                user.nm_Usuario = reader.GetString("nm_Usuario");
                user.fk_Usuario_Filial = reader.GetInt32("fk_Usuario_Filial");
                user.ds_Situacao = reader.GetBoolean("ds_Situacao");
                user.ds_Senha = reader.GetString("ds_Senha");
                user.ds_CEP = reader.GetString("ds_CEP");
                user.Cod_Perm = reader.GetString("Cod_Perm");
            }

            reader.Close();
            return user;
        }

        public List<view_Usuario_Filial> ConsultarPorNome_Filial(string nome, int filial)
        {
            string script = $@"SELECT `tb_usuario`.*,
                                      `tb_Filial`.nm_Nome,
                                      `tb_Filial`.ds_CEP
                                 FROM `tb_usuario` 
                                 JOIN `tb_Filial` 
                                   ON fk_Usuario_Filial = id_Filial
    
                                WHERE nm_Usuario LIKE '%{nome}%'
                                  AND fk_Usuario_Filial = {filial}";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<view_Usuario_Filial> usuarios = new List<view_Usuario_Filial>();
            while (reader.Read())
            {
                view_Usuario_Filial user = new view_Usuario_Filial();
                user.id_Usuario = reader.GetInt32("id_Usuario");
                user.nm_Nome = reader.GetString("nm_Nome");
                user.nm_Usuario = reader.GetString("nm_Usuario");
                user.fk_Usuario_Filial = reader.GetInt32("fk_Usuario_Filial");
                user.ds_Situacao = reader.GetBoolean("ds_Situacao");
                user.ds_Senha = reader.GetString("ds_Senha");
                user.ds_CEP = reader.GetString("ds_CEP");
                user.Cod_Perm = reader.GetString("Cod_Perm");

                usuarios.Add(user);
            }

            reader.Close();
            return usuarios;
        }
    }
}
