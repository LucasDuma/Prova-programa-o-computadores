using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programação_computadores
{
    class Pessoa
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }
        public DateTime Data { get; set; }
        public float Dinheiro { get; set; }

        public Pessoa(string nome, string telefone, string cpf, DateTime data, float dinheiro)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.Cpf = cpf;
            this.Data = data;
            this.Dinheiro = dinheiro;
        }
    }
}
