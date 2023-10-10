## Enunciado
Escreva um programa em C# que gere e exiba os primeiros N termos da sequência de Fibonacci, onde N é especificado pelo usuário.

## Resolução
- Declaração da váriaveis
- Pedido de entrada com tryparse + while para não aceitar não inteiros
- Tratei as duas primeiras saídas separadamente, para tamanho 1 ou 2
- Do tamanho 3 em diante repete em uma estrutura for, que a cada repetição as variáveis de último e penúltimo são atualizadas para a próxima soma.