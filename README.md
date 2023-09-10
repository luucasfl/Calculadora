# Calculadora
Case para Engenharia de Software JR

Você precisa corrigir os seguintes problemas no codigo:
  1. Aplicação só está processando o primeiro item da fila infinitamente.
	R: Aplicação não decrementava a fila.

  2. Implemente a funcionalidade de divisão.
	R: Implementado método "divisao".

  3. Aplicação não está calculando a penultima operação corretamente.
     
     	Saída esperada no console:
     
     		14 - 8 = 6
     
     		5 * 6 = 30
     
     		2147483647 + 2 = 2147483649
     
     		18 / 3 = 6

	R: Penúltima operação não é calculada corretamente pois o maior valor numérico do tipo int32 é 2.147.483.647, variáveis numéricas do objeto foram alteradas para o tipo decimal.

  5. Implemente uma funcionalidade para imprimir toda a lista de operações a ser processada após cada calculo realizado.
	R: Método "verificaPendencias" adicionado.

  6. Crie uma nova pilha (Stack) para guardar o resultado de cada calculo efetuado e imprima a pilha ao final
	R: Pilha chamada "resultados" implementada.

Não existe resposta certa ou errada, o objetivo do case é avaliar a linha de raciocínio de cada candidato.
Você é livre para fazer na linguagem de sua preferência, desde que aplique as mesmas funcionalidades e tarefas deste case.
Dica: Utilize Visual Code ou Visual Studio Community para realizar as tarefas.
