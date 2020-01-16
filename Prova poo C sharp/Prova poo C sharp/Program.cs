using System;
using System.Collections.Generic;

namespace Prova_poo_C_sharp
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Pessoas p1 = new Pessoas("João", 15);
            Pessoas p2 = new Pessoas("Leandro", 21);
            Pessoas p3 = new Pessoas("Paulo", 17);
            Pessoas p4 = new Pessoas("Jessica", 18);
            List<Pessoas> pessoa = new List<Pessoas>();

            pessoa.Add(p1);
            pessoa.Add(p2);
            pessoa.Add(p3);
            pessoa.Add(p4);

            ListaDePessoas lista = new ListaDePessoas(pessoa);
            imprimirLista(lista);
            var maisVelho = lista.maisVelho();
            lista.quantidadeLista();
            Console.WriteLine($"\nA pessoa mais velho da lista {maisVelho.Nome} com a idade {maisVelho.Idade}");
            Console.WriteLine($"\nOs mais velhos da lista são ");
            listarMaisVelhos(lista);
            lista.excluirMenor();
            lista.quantidadeLista();
            lista.verJessica();
        }

        private static void listarMaisVelhos(ListaDePessoas lista)
        {

            foreach (var velho in lista.maiorDeIdade())
            {
                Console.WriteLine(velho);
            }
        }

        private static void imprimirLista(ListaDePessoas lista)
        {
            foreach (var pessoas in lista.Lista)
            {
                Console.WriteLine(pessoas);
            }
        }
    }
}
