﻿using System;

namespace Calculadora
{
    class Program
    {

        static float RealizarOperacao(float primeiroNumero, float segundoNumero, string operador)
        {
            switch (operador)
            {
                case "+": return primeiroNumero + segundoNumero;
                case "-": return primeiroNumero - segundoNumero;
                case "*": return primeiroNumero * segundoNumero;
                case "/": return primeiroNumero / segundoNumero;
                case "%": return primeiroNumero % segundoNumero;
                default: return 0f;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o primeiro número");
            var primeiroNumeroString = Console.ReadLine();
            float primeiroNumero;

            bool isPrimeiroNumeroValido = float.TryParse(primeiroNumeroString, out primeiroNumero);
            if (!isPrimeiroNumeroValido)
            {
                Console.WriteLine("Primeiro número inválido");
                return;
            }

            Console.WriteLine("Informe o segundo número");
            var segundoNumeroString = Console.ReadLine();
            float segundoNumero;

            bool issegundoNumeroValido = float.TryParse(segundoNumeroString, out segundoNumero);
            if (!issegundoNumeroValido)
            {
                Console.WriteLine("Segundo número inválido");
                return;
            }

            Console.WriteLine("Informe o operador matemático");
            var operador = Console.ReadLine();

            float resultado = RealizarOperacao(primeiroNumero, segundoNumero, operador);
            Console.WriteLine("O Resultado da sua operação foi:" + resultado);

        }
    }
}
