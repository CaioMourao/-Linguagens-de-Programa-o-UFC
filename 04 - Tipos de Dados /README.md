# Comparação de Tipagem entre Três Linguagens de Programação

Este documento apresenta uma comparação simples entre os sistemas de tipagem de três linguagens populares: **Python**, **C#** e **JavaScript**. A ideia é mostrar como cada linguagem trata tipos de dados, com exemplos breves e comentários explicativos.

---

## 1. Python (Tipagem Dinâmica e Forte)

- **Tipagem Dinâmica**: Você não declara o tipo da variável, o Python infere durante a execução.
- **Tipagem Forte**: Tipos não são automaticamente convertidos em operações que não façam sentido.

```python
x = 10         # x é um inteiro
print(type(x)) # <class 'int'>

x = "texto"    # agora x é uma string
print(type(x)) # <class 'str'>

# Tentativa de operação inválida gera erro
y = 5 + "3"    # TypeError: unsupported operand types for +: 'int' and 'str'
```

---

## 2. C# (Tipagem Estática e Forte)

**Tipagem Estática:**  
Os tipos devem ser declarados e são verificados em tempo de compilação.

**Tipagem Forte:**  
Conversões implícitas são limitadas e explícitas quando necessário.

```csharp
int x = 10;        // declaração explícita do tipo int
// x = "texto";    // Erro de compilação: não pode atribuir string a int

string s = "texto"; 
// int y = s;      // Erro de compilação: tipos incompatíveis

int a = 5;
int b = 3;
int c = a + b;     // soma válida entre inteiros
```

**Comentários:**

- Erros de tipo são detectados antes da execução.
- Segurança maior em relação a tipos.

---

## 3. JavaScript (Tipagem Dinâmica e Fraca)

- **Tipagem Dinâmica**: Você não declara o tipo da variável, ele é determinado em tempo de execução.
- **Tipagem Fraca**: Conversões automáticas entre tipos podem acontecer, o que pode levar a resultados inesperados.

```javascript
let x = 10;      // x é um número
x = "texto";     // agora x é uma string

let y = 5 + "3"; // resultado: "53" (concatenação devido à tipagem fraca)

let z = 5 - "3"; // resultado: 2 (conversão automática para número)
```

**Comentários:**

- Conversões implícitas podem causar bugs difíceis de detectar.
- Flexibilidade maior, mas menos segurança em tipos.
