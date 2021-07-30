using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP._02_Estado_e_Comportamento
{
    public class Pessoa
    {
        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public int CalcularIdade()
        {
            DateTime dataAtual = DateTime.Now;
            int idade = dataAtual.Year - DataNascimento.Year;

            if (dataAtual < DataNascimento.AddYears(idade)) idade--;

            return idade;
        }
    }
}