using System;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{
    public class ListaContaCorrente 
    {
        private ContaCorrente[] _items;
        private int _nextItem;

        public int Length { 
            get 
            { 
                return _nextItem; 
            } 
        }

        public ListaContaCorrente()
        {
            _items = new ContaCorrente[5];
            _nextItem = 0;
        }

        public void Adicionar(ContaCorrente item)
        {
            CheckCapacity(_nextItem + 1);
            Console.WriteLine($"Adding item int at the position {_nextItem}");
            _items[_nextItem] = item;
            _nextItem++;
        }

        internal void AdicionarVarios(params ContaCorrente[] items)
        {
            foreach (var conta in items)
                Adicionar(conta);
        }

        private void CheckCapacity(int capacity)
        {
            if (_items.Length >= capacity)
                return;


            ContaCorrente[] novoArray = new ContaCorrente[capacity];

            Console.WriteLine($"Aumentando capacidade do array");

            for (var i = 0; i <= _items.Length - 1; i++)
                novoArray[i] = _items[i];

            _items = novoArray;

        }

        public void EscreverListaNaTela()
        {
            for (var i = 0; i < _nextItem; i++)
            {
                ContaCorrente conta = _items[i];

                Console.WriteLine($"Conta no indice {i}: {conta.Numero} {conta.Agencia}");
            }
        }

        public ContaCorrente GetItemNoIndice(int index)
        {

            if (index < 0 || index >= _nextItem)
                throw new ArgumentOutOfRangeException(nameof(index));

            return _items[index];
        }

        public void Remover(ContaCorrente item)
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
            _items[_nextItem] = null;
        }

        public ContaCorrente this[int index]
        {
            get
            {
                return GetItemNoIndice(index);
            }
        }
    }
}