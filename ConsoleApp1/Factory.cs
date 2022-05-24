using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class  Factory
    {
        public static Cliente GetCliente()
        {
            return new Cliente();
        }

        public static Email GetEmail()
        {
            return new Email();
        }

        public static SMS GetMensagemCelular()
        {
            return new SMS();
        }
    }
}
