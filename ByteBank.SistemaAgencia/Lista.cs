using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class Lista<T>
    {
        private T[] _itens;
        private int _proximaPosicao;
        public int tamanho { get { return _proximaPosicao; } }

        public Lista(int capacidadeInicial = 5)
        {
            _itens = new T[5];
            _proximaPosicao = 0;
        }

        public void Adicionar(T item)
        {
            VerificarCapacidade(_proximaPosicao + 1);
            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
            //Console.WriteLine($"Adicionando no índice {_proximaPosicao} conta {item.Agencia}/{item.Numero}");
        }

        public void AdicionarVarios(params T[] itens)
        {
            foreach (T conta in itens)
            {
                Adicionar(conta);
            }
        }

        public void Remover(T item)
        {
            int indiceItem = -1;

            for (int i = 0; i < _proximaPosicao; i++)
            {
                T itemAtual = _itens[i];
                if (itemAtual.Equals(item))
                {
                    indiceItem = i;
                    break;
                }
            }
            for (int i = indiceItem; i < _proximaPosicao - 1; i++)
            {
                _itens[i] = _itens[i + 1];
            }
            _proximaPosicao--;
            //_itens[_proximaPosicao] = null;


        }

        public void EscreverListaNaTela()
        {
            for (int i = 0; i < _proximaPosicao; i++)
            {
                T conta = _itens[i];
                Console.WriteLine($"Conta no índice {i}: numero {conta}");
            }
        }

        public T GetItemNoIndice(int indice)
        {
            if (indice < 0 || indice >= _proximaPosicao)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }

            return _itens[indice];
        }

        private void VerificarCapacidade(int tamanhoNecessario)
        {
            if (_itens.Length >= tamanhoNecessario)
            {
                return;
            }

            int novoTamanho = _itens.Length * 2;
            Console.WriteLine("Aumentando capacidade da lista!");

            if (novoTamanho < tamanhoNecessario)
            {
                novoTamanho = tamanhoNecessario;
            }
            T[] novoArray = new T[novoTamanho];

            for (int indice = 0; indice < _itens.Length; indice++)
            {
                novoArray[indice] = _itens[indice];
            }
            _itens = novoArray;

        }

        public T this[int indice]
        {
            get { return GetItemNoIndice(indice); }
        }
    }
}
