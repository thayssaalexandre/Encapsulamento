using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    internal class Carro
    {
        private int _VELOCIDADEATUAL = 60;

        public void Acelerar()
        {
            _VELOCIDADEATUAL += 10;
            Console.WriteLine($"Velocidade: {VelocidadeAtual} KM/H");
        }

        public void Frear()
        {
            if (_VELOCIDADEATUAL <= 0)
            {
                Console.WriteLine("Carro Parado");
            }
            else
            {
                _VELOCIDADEATUAL -= 10;
                Console.WriteLine($"Velocidade: {VelocidadeAtual} KM/H");
            }
        }
        public int VelocidadeAtual
        {
            get {  return _VELOCIDADEATUAL; }
        }
    }
}
