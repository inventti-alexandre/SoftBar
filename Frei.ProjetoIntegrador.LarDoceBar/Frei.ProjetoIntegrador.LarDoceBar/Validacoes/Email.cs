using Blibioteca.Developers.APIs.Email;
using Frei.ProjetoIntegrador.LarDoceBar.Modulos;
using System;

namespace Frei.ProjetoIntegrador.Academia.Validacoes
{
    class Email
    {
        public void Validar(string e_mail, string nome)
        {
            EmailDTO email = new EmailDTO();
            email.DestinatarioEmail = e_mail;
            email.DestinatarioNome = nome;

            EmailSend send = new EmailSend();
            int cod = send.CodEmailVerificar(email);

            frmVerificarEmail frm = new frmVerificarEmail();
            frm.Codigo(cod);
            frm.ShowDialog();

            if (frm.Verificado == false)
                throw new ArgumentException("O email não foi verificado!");
        }
    }
}
