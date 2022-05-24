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
            Cliente cliente = new Cliente {Nome="Davi",Email="davi@gmail.com",Celular="(35)99881-1355" };
            
            Email email = new Email();
            email.EnviarEmail(cliente, "Seu saldo é de R$ 100,00", "Seu saldo esta baixo");

            SMS sms = new SMS();
            sms.EnviarSMS(cliente, "Seu saldo esta baixo");

            Console.ReadLine();

        }
    }
}
