using System;
using System.Collections.Generic;
using System.Text;

namespace Prova_poo_C_sharp
{
    class Pessoas 
    {
        public string Nome { get; set;}
        public int Idade { get; set; }
        public Pessoas(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public override string ToString()
        { 
            return $"Nome: {Nome} Idade: {Idade} ";
        }
    }
}
