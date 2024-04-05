using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pessoa
{
    class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Altura { get; set; }
        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}, idade: {Idade}, altura: {Altura}.");

        }
    }
}
