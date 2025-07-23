## Contexto

Vamos calcular a soma de todos os elementos de uma lista usando recursão. A função vai somar o primeiro elemento com a soma recursiva do restante da lista.

---

## Pilha de Chamadas

Imagine uma pilha de livros onde só é possível retirar ou adicionar o livro que está no topo. A pilha de chamadas funciona exatamente assim:

- Quando uma função é chamada, um novo "quadro" com todas as informações necessárias para essa função é colocado no topo da pilha.
- Esse quadro contém dados como:
  - Os valores dos argumentos que a função recebeu.
  - As variáveis locais criadas dentro da função.
  - Para onde o programa deve voltar depois que a função terminar.
- Enquanto a função está em execução, seu quadro permanece no topo da pilha.
- Quando a função termina, seu quadro é removido do topo da pilha, e o programa retoma a execução a partir do ponto onde a função foi chamada.

---

# Exemplo Prático: Recursão para Soma dos Elementos de uma Lista

A recursão é uma ótima forma de entender a pilha de chamadas em ação. Cada chamada recursiva cria um novo quadro na pilha, armazenando o estado atual da execução, até que uma condição de parada (o caso base) seja alcançada.

No exemplo da soma dos elementos de uma lista, a função SomaLista chama a si mesma com um índice incrementado, somando o elemento atual ao resultado da soma dos elementos restantes. Quando o índice ultrapassa o tamanho da lista, o caso base é acionado e as chamadas começam a retornar, desempilhando a pilha e somando os valores.

### Código em C#

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static int SomaLista(List<int> lista, int indice)
    {
        if (indice >= lista.Count)
            return 0; 

        return lista[indice] + SomaLista(lista, indice + 1); 
    }

    static void Main()
    {
        List<int> numeros = new List<int> { 2, 4, 6, 8 };
        int resultado = SomaLista(numeros, 0);
        Console.WriteLine($"Soma dos elementos: {resultado}");
    }
}
```

### Processo de empilhamento (chamadas recursivas):

1. A função inicia chamando SomaLista(lista, 0) e aguarda o resultado de SomaLista(lista, 1).
2. SomaLista(lista, 1) é chamada e aguarda o resultado de `SomaLista(lista, 2).
3. SomaLista(lista, 2) é chamada e aguarda o resultado de SomaLista(lista, 3).
4. SomaLista(lista, 3) é chamada e aguarda o resultado de SomaLista(lista, 4).
5. SomaLista(lista, 4) é chamada; como o índice 4 está além do fim da lista, atinge o caso base e retorna 0 imediatamente.

Assim, as chamadas vão se acumulando (empilhando) até o caso base ser alcançado, preparando o caminho para que as chamadas retornem seus resultados na ordem inversa.

### Processo de retorno (desempilhamento):

1. SomaLista(lista, 4) retorna 0 (caso base).
2. SomaLista(lista, 3) calcula lista[3] + 0 = 8 + 0 = 8` e retorna 8.
3. SomaLista(lista, 2) calcula lista[2] + 8 = 6 + 8 = 14` e retorna 14.
4. SomaLista(lista, 1) calcula lista[1] + 14 = 4 + 14 = 18` e retorna 18.
5. SomaLista(lista, 0) calcula lista[0] + 18 = 2 + 18 = 20 e retorna 20.

O resultado final é 20, que é a soma de todos os elementos da lista.

---

Essa ilustração mostra como as chamadas ficam empilhadas aguardando resultados e como elas são resolvidas quando o caso base é alcançado.
