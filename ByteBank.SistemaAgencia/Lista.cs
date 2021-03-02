using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class Lista<T>
    {
        private T[] _items;
        private int _nextItem;

        public int Length
        {
            get
            {
                return _nextItem;
            }
        }

        public Lista(int capacidadeInicial = 5)
        {
            _items = new T[capacidadeInicial];
            _nextItem = 0;
        }

        public void Adicionar(T item)
        {
            CheckCapacity(_nextItem + 1);
            Console.WriteLine($"Adding item int at the position {_nextItem}");
            _items[_nextItem] = item;
            _nextItem++;
        }

        internal void AdicionarVarios(params T[] items)
        {
            foreach (var conta in items)
                Adicionar(conta);
        }

        private void CheckCapacity(int capacity)
        {
            if (_items.Length >= capacity)
                return;

            T[] novoArray = new T[capacity];

            Console.WriteLine($"Aumentando capacidade do array");

            for (var i = 0; i <= _items.Length - 1; i++)
                novoArray[i] = _items[i];

            _items = novoArray;
        }

        public void EscreverListaNaTela()
        {
            for (var i = 0; i < _nextItem; i++)
            {
                T conta = _items[i];

                Console.WriteLine($"Conta no indice {i}: {conta.Numero} {conta.Agencia}");
            }
        }

        public T GetItemNoIndice(int index)
        {
            if (index < 0 || index >= _nextItem)
                throw new ArgumentOutOfRangeException(nameof(index));

            return _items[index];
        }

        public void Remover(T item)
        {
            var index = -1;
            for (var i = 0; i < _nextItem; i++)
            {
                var currentItem = _items[i];

                if (currentItem.Equals(item))
                {
                    index = i;
                    break;
                }
            }

            for (var i = index; i < _nextItem - 1; i++)
            {
                _items[i] = _items[i + 1];
            }

            _nextItem--;
        }

        public T this[int index]
        {
            get
            {
                return GetItemNoIndice(index);
            }
        }
    }
}