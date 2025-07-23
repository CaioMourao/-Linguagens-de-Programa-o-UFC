# Passagem de Parâmetros: Por Valor vs Por Referência

Esta parte do projeto apresenta exemplos de como diferentes linguagens de programação tratam a **passagem de parâmetros**, destacando a diferença entre **por valor** e **por referência**.

---

## 🔹 Python

Em Python, tipos imutáveis (como inteiros, strings) são passados **por valor aparente**, e objetos mutáveis (como listas, dicionários) se comportam como **por referência**.

- **Tipos imutáveis** (como int, float, str, tuple) se comportam como **passagem por valor aparente**. Isso significa que, ao passar uma variável para a função, o valor é copiado e alterações dentro da função **não afetam** o valor original.
- **Tipos mutáveis** (como list, dict, set) são passados como **referência**, e alterações feitas dentro da função **afetam o objeto original**.

### 🧪 Exemplo de Código:

```python
def alterar_valor(x):
    x = 100
    print("Dentro da função (x):", x)

def alterar_lista(lista):
    lista.append(4)
    print("Dentro da função (lista):", lista)

a = 10
alterar_valor(a)
print("Fora da função (a):", a)  

b = [1, 2, 3]
alterar_lista(b)
print("Fora da função (b):", b)  
```

### ✅ Explicação

- a = 10 é um valor inteiro (**imutável**).  
  A função alterar_valor(a) altera apenas a **cópia** da variável, e **não** o valor original.  
  Por isso, fora da função o valor de a continua sendo 10.

- b = [1, 2, 3] é uma lista (**mutável**).  
  A função alterar_lista(b) adiciona um valor **diretamente na lista original**, pois ela é passada **por referência**.  
  O valor de b fora da função torna-se [1, 2, 3, 4].
---

## 🔹 C#

Em C#, valores simples (como int, float) são passados por **valor** por padrão, mas você pode forçar a passagem por **referência** usando ref ou out.

- Quando um argumento é passado **por valor**, a função trabalha com uma **cópia** da variável.  
  Isso significa que qualquer modificação feita dentro da função **não afeta o valor original**.

- Quando se usa ref, a função opera diretamente sobre a **referência** da variável original.  
  Ou seja, qualquer alteração dentro da função será refletida fora dela também.

- O modificador out funciona de maneira semelhante ao ref, mas é usado quando você deseja **retornar múltiplos valores** de uma função. A principal diferença é que o parâmetro out **não precisa estar inicializado** antes da chamada da função.

### 🧪 Exemplo de Código:
```csharp
using System;

class Program {
    static void PorValor(int x) {
        x = 100;
        Console.WriteLine("Dentro da função (x): " + x);
    }

    static void PorReferencia(ref int x) {
        x = 100;
        Console.WriteLine("Dentro da função (x): " + x);
    }

    static void Main() {
        int a = 10;
        PorValor(a);
        Console.WriteLine("Fora da função (a): " + a);  

        int b = 10;
        PorReferencia(ref b);
        Console.WriteLine("Fora da função (b): " + b);  
    }
}
```

### ✅ Explicação

- PorValor(int x) recebe uma **cópia** da variável a, então qualquer alteração feita dentro da função **não afeta** o valor original.  
  Resultado: a continua com o valor 10 fora da função.

- PorReferencia(ref int x) recebe **uma referência direta** à variável b.  
  Como o parâmetro foi passado com ref, a função altera o valor original.  
  Resultado: b passa a valer 100 fora da função também.

> 🔎 Observação: Em C#, para passar por referência é necessário usar ref **tanto na definição da função quanto na chamada**.
---

## 🔹 JavaScript

Em JavaScript, tipos primitivos (number, string, boolean) são passados **por valor**, enquanto **objetos** e **arrays** são passados **por referência**.

### 🧪 Exemplo de Código:
```javascript
function alterarNumero(x) {
    x = 100;
    console.log("Dentro da função (x):", x);
}

function alterarArray(arr) {
    arr.push(4);
    console.log("Dentro da função (arr):", arr);
}

let a = 10;
alterarNumero(a);
console.log("Fora da função (a):", a); 

let b = [1, 2, 3];
alterarArray(b);
console.log("Fora da função (b):", b); 
```

### ✅ Explicação

- Na função alterarNumero(x), o parâmetro x é um tipo primitivo (número).  
  Ele é passado **por valor**, ou seja, a função recebe uma cópia do valor.  
  Portanto, a alteração dentro da função **não afeta** o valor original a.

- Na função alterarArray(arr), o parâmetro arr é um array, que é um objeto mutável.  
  Ele é passado **por referência**, ou seja, a função recebe uma referência ao mesmo objeto na memória.  
  Assim, qualquer alteração dentro da função **modifica o array original** b.
