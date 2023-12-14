using System.Collections.Generic;

namespace TestesUnitarios.Desafio.Console.Services
{
    public class ValidacoesLista
    {
        public List<int> RemoverNumerosNegativos(List<int> lista)
        {
            // Lógica para remover números negativos da lista
            return lista.FindAll(x => x >= 0);
        }

        public bool ListaContemDeterminadoNumero(List<int> lista, int numero)
        {
            // Verifica se a lista contém um número específico
            return lista.Contains(numero);
        }

        public List<int> DeveMultiplicarOsElementosDaListaPor2(List<int> lista)
        {
            // Multiplica todos os elementos da lista por 2
            List<int> novaLista = new List<int>();
            foreach (var item in lista)
            {
                novaLista.Add(item * 2);
            }
            return novaLista;
        }

        public int RetornarMaiorNumeroLista(List<int> lista)
        {
            // Retorna o maior número da lista
            int max = lista[0];
            foreach (var item in lista)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;
        }

        public int RetornarMenorNumeroLista(List<int> lista)
        {
            // Retorna o menor número da lista
            int min = lista[0];
            foreach (var item in lista)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            return min;
        }
    }
}
