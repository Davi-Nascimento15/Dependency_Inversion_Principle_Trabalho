using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //Regras do Dependency Inversion Principle:
        //Módulo de alto nível, não devem depender de modulos de baixo nível, ambos devem depender de abstrações
        //Abstrações não devem depender de detalhes, porem detalhes devem depender de abstrações

        static void Main(string[] args)
        {
            IContato cliente = new Cliente {Nome="Davi",Email="davi@gmail.com",Celular="(35)99881-1355" };
            
            IEmail email = new Email();
            email.EnviarEmail(cliente, "Seu saldo é de R$ 100,00", "Seu saldo esta baixo");

            IMensagemCelular sms = new SMS();
            sms.EnviarMensagem(cliente, "Seu saldo esta baixo");

            Console.ReadLine();

        }
    }
}
