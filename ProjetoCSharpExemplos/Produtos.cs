using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCSharpExemplos
{
    class Produtos
    {
        private string nome;
        private double valor;
        private string dataEntrada;

        public Produtos()
        {

        }

        public Produtos(string nome, double valor, string dataEntrada)
        {
            this.Nome = nome;
            this.Valor = valor;
            this.DataEntrada = dataEntrada;
        }

        public string Nome { get => nome; set => nome = value; }
        public double Valor { get => valor; set => valor = value; }
        public string DataEntrada { get => dataEntrada; set => dataEntrada = value; }
    }
}
