using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class Pessoa
    {
        private string _nome;

        public string Nome
        {

            get { return _nome; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Não reconhecido");
                }
                else
                {
                    _nome = value;
                }
            }
        }
    }
}
