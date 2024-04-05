using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            pessoa1.Nome = "João";
            pessoa1.Idade = 64;
            pessoa1.Altura = 1.62;
            pessoa1.Apresentar();
        }
    }
}
