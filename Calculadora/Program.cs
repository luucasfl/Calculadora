using System;
using System.Collections;
using System.Collections.Generic;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Operacoes> filaOperacoes = new Queue<Operacoes>();
            filaOperacoes.Enqueue(new Operacoes { valorA = 2, valorB = 3, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 14, valorB = 8, operador = '-' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 5, valorB = 6, operador = '*' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 2147483647, valorB = 2, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 18, valorB = 3, operador = '/' }); //Implementado método divisao

            Calculadora calculadora = new Calculadora();
            Stack<Operacoes> resultados = new Stack<Operacoes>(); //instancia pilha de resultados

            while (filaOperacoes.Count > 0)
            {
                Operacoes operacao = filaOperacoes.Peek();
                calculadora.verificaPendencias(filaOperacoes);  //metodo para verificar e imprimir operacoes a serem processadas
                calculadora.calcular(operacao);

                Console.WriteLine("Processamento realizado: {0} {1} {2} = {3} \n", operacao.valorA, operacao.operador, operacao.valorB, operacao.resultado);

                resultados.Push(operacao);  //salva operacao com resultado na pilha
                filaOperacoes.Dequeue();    //decrementa operacao da fila
            }

            Console.WriteLine("Cálculos efetuados:");

            foreach (Operacoes operacao in resultados)
                Console.WriteLine("{0} {1} {2} = {3}", operacao.valorA, operacao.operador, operacao.valorB, operacao.resultado);    //imprime operacoes com resultados
            
            Console.ReadKey(); //console aguarda clique para ser encerrado
        }
    }
}
