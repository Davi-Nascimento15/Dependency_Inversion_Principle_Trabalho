using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Email : IEmail
    {
        public void EnviarEmail(IContato cliente, string assunto, string mensagem)
        {
            Console.WriteLine($"Email enviado para {cliente.Email} : Assunto: '{assunto}' Mensagem: '{mensagem}'");
        }
    }
}
