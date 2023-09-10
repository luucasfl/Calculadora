using System;
using System.Collections;
using System.Collections.Generic;

namespace Calculadora
{
    public class Calculadora
    {
        public void verificaPendencias(Queue<Operacoes> filaOperacoes)
        {
            Console.WriteLine("{0} caso(s) a ser(em) processad(s): ", filaOperacoes.Count); 
            foreach (Operacoes operacao in filaOperacoes)
                Console.WriteLine("{0} {1} {2}", operacao.valorA, operacao.operador, operacao.valorB);
            Console.WriteLine();
        }

        public Operacoes calcular(Operacoes operacao)
        {
            switch(operacao.operador)
            {
                case '+': operacao.resultado= soma(operacao);break;
                case '-': operacao.resultado = subtracao(operacao);break;
                case '*': operacao.resultado = multiplicacao(operacao);break;
                case '/': operacao.resultado = divisao(operacao); break; //implementado
                default: operacao.resultado = 0; break;
            }
            return operacao;
        }
        public decimal soma(Operacoes operacao)
        {
            return operacao.valorA + operacao.valorB;
        }
        public decimal subtracao(Operacoes operacao)
        {
            return operacao.valorA - operacao.valorB;
        }
        public decimal multiplicacao(Operacoes operacao)
        {
            return operacao.valorA * operacao.valorB;
        }
        public decimal divisao(Operacoes operacao)
        {
            return operacao.valorA / operacao.valorB;
        }
    }
}
