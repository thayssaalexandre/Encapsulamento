using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    internal class Produto
    {
        private double _Preco;

        public double Preco
        {
            get { return _Preco; }

            set
            {
                if (Preco <= 0)
                {
                    Console.WriteLine("Preço: R$0,00");
                }
                else
                {
                    _Preco = value;
                }
            }
        }
    }
}
