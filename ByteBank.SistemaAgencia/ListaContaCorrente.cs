using System;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{
    public class ListaContaCorrente 
    {
        private ContaCorrente[] _items;
        private int _nextItem;

        public ListaContaCorrente()
        {
            _items = new ContaCorrente[5];
            _nextItem = 0;
        }

        public void Adicionar(ContaCorrente item)
        {
            Console.WriteLine($"Adding item int at the position {_nextItem}");
            _items[_nextItem] = item;
            _nextItem++;
        }

        private void CheckCapacity(int capacity)
        {
            if (_items.Length >= capacity)
                return;


            ContaCorrente[] novoArray = new ContaCorrente[capacity];

            Console.WriteLine($"Aumentando capacidade do array");

            for (var i = 0; i <= _items.Length - 1; i++)
            {
                novoArray[i] = _items[i];
            }

            _items = novoArray;

        }
    }
}