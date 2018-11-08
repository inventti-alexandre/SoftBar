using Blibioteca.Developers.Validacao.ER;
using Frei.ProjetoIntegrador.Academia.Criptografia;
using Frei.ProjetoIntegrador.Academia.Validacoes;
using Frei.ProjetoIntegrador.LarDoceBar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.Usuario
{
    class UsuarioBusiness
    {
        public int CadastrarUsuario(UsuarioDTO dto)
        {
            ValidarNumero regex = new ValidarNumero();
            regex.ValidarSenha(dto.ds_Senha);

            DESCripto cripto = new DESCripto();
            dto.ds_Senha = cripto.Criptografar(Program.chave, dto.ds_Senha);

            UsuarioDatabase db = new UsuarioDatabase();
            return db.CadastrarUsuario(dto);
        }

        public int AlterarUsuario(UsuarioDTO dto)
        {
            ValidarNumero regex = new ValidarNumero();
            regex.ValidarSenha(dto.ds_Senha);

            DESCripto cripto = new DESCripto();
            dto.ds_Senha = cripto.Criptografar(Program.chave, dto.ds_Senha);

            UsuarioDatabase db = new UsuarioDatabase();
            return db.AlterarUsuario(dto);
        }

        public int RemoverUsuario(int id)
        {
            UsuarioDatabase db = new UsuarioDatabase();
            return db.RemoverUsuario(id);
        }

        public List<view_Usuario_Filial> Consultar()
        {
            UsuarioDatabase db = new UsuarioDatabase();
            List<view_Usuario_Filial> usuario = db.Consultar();

            if (usuario.Count != 0)
            {
                List<view_Usuario_Filial> userDescripto = new List<view_Usuario_Filial>();
                DESCripto cripto = new DESCripto();
                foreach (view_Usuario_Filial user in usuario)
                {
                    user.ds_Senha = cripto.Descriptografar(Program.chave, user.ds_Senha);

                    userDescripto.Add(user);
                }

                return userDescripto;
            }
            else
                return usuario;
        }

        public List<view_Usuario_Filial> ConsultarPorNome(string nome)
        {
            UsuarioDatabase db = new UsuarioDatabase();
            List<view_Usuario_Filial> usuario = db.ConsultarPorNome(nome);

            if (usuario.Count != 0)
            {
                List<view_Usuario_Filial> userDescripto = new List<view_Usuario_Filial>();
                DESCripto cripto = new DESCripto();
                foreach (view_Usuario_Filial user in usuario)
                {
                    user.ds_Senha = cripto.Descriptografar(Program.chave, user.ds_Senha);

                    userDescripto.Add(user);
                }

                return userDescripto;
            }
            else
                return usuario;
        }

        public view_Usuario_Filial ConsultarPorId(string id)
        {
            UsuarioDatabase db = new UsuarioDatabase();
            view_Usuario_Filial usuario = db.ConsultarPorId(id);

            if (usuario.id_Usuario != 0)
            {
                DESCripto cripto = new DESCripto();
                usuario.ds_Senha = cripto.Descriptografar(Program.chave, usuario.ds_Senha);

                return usuario;
            }
            else
                return usuario;
        }

        public List<view_Usuario_Filial> ConsultarPorNome_Filial(string nome, int filial)
        {
            UsuarioDatabase db = new UsuarioDatabase();
            List<view_Usuario_Filial> usuario = db.ConsultarPorNome_Filial(nome, filial);

            if (usuario.Count != 0)
            {
                List<view_Usuario_Filial> userDescripto = new List<view_Usuario_Filial>();
                DESCripto cripto = new DESCripto();
                foreach (view_Usuario_Filial user in usuario)
                {
                    user.ds_Senha = cripto.Descriptografar(Program.chave, user.ds_Senha);

                    userDescripto.Add(user);
                }

                return userDescripto;
            }
            else
                return usuario;
        }
    }
}
