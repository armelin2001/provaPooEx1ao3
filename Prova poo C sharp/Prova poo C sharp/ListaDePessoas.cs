using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prova_poo_C_sharp
{
    class ListaDePessoas
    {
        public List<Pessoas> Lista = new List<Pessoas>();
        public void setListaPessoas(List<Pessoas> pessoas)
        {
            Lista = pessoas;
        }
        public List<Pessoas> getPessoas()
        {
            return Lista;
        }
        public void quantidadeLista()
        {
            int qtd = Lista.Count;
            Console.WriteLine($"\nQuantidade de pessoas na lista {qtd}");
        }
        public ListaDePessoas(List<Pessoas> pessoas)
        {
            Lista = pessoas;
        }
        public Pessoas maisVelho()
        {
            return Lista.OrderByDescending(x => x.Idade).FirstOrDefault();
        }
        public void excluirMenor()
        {
            do
            {
                int aonde = Lista.FindIndex(p => p.Idade < 18);
                Lista.RemoveAt(aonde);
            } while (Lista.Exists(p => p.Idade < 18));
        }
        public void verJessica()
        {
            Pessoas jessica = Lista.Find(p => p.Nome == "Jessica");
            var jessica2 = Lista.FirstOrDefault(p => p.Nome == "Jessica");
            if(jessica != null)
            {
                Console.WriteLine($"Jesica exixste na lista e sua idade é de {jessica.Idade}");
            }
            else
            {
                Console.WriteLine($"Jessica nao existe");
            }
        }
        public List<Pessoas> maiorDeIdade()
        {
            return Lista.Where(x => x.Idade >= 18).ToList();
        }
    }
}
