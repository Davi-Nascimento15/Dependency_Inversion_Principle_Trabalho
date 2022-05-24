using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Cliente : IContato
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
    }
}
