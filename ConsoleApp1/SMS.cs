using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SMS : IMensagemCelular
    {
        public void EnviarMensagem(IContato cliente, string mensagem)
        {
            Console.WriteLine($"SMS enviado para {cliente.Celular}: '{mensagem}'");
        }
    }
}
