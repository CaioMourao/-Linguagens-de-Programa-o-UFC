
# 🧠 Desafio 03 - Sintaxe e Semântica

Este desafio propõe a criação de uma **mini-gramática fictícia** para uma linguagem inventada, junto com exemplos de **análise léxica** e **sintática**. O objetivo é compreender os conceitos formais por trás das linguagens de programação: **tokens**, **gramática**, **análise léxica**, **parsing** e **semântica estrutural**.

---

## 🧪 Linguagem: **CT**

**CT** é uma linguagem fictícia criada com sintaxe simples, voltada para operações aritméticas básicas e controle condicional. A ideia é representar uma linguagem minimalista semelhante ao pseudocódigo, mas com regras formais.

---

## 🔤 Análise Léxica

A análise léxica consiste em **quebrar o código-fonte em tokens válidos**.

### 🧱 Tokens da Linguagem CT:

| Tipo       | Padrão (Regex simplificado) | Exemplos       |
|------------|-----------------------------|----------------|
| NUM        | `[0-9]+`                    | `42`           |
| ID         | `[a-zA-Z_][a-zA-Z0-9_]*`    | `x`, `total`   |
| OP_ARIT    | `[\+\-\*/]`              | `+`, `*`       |
| OP_REL     | `==|!=|>|<|>=|<=`           | `!=`, `<=`     |
| ATRIB      | `=`                         | `=`            |
| IF         | `if`                        | `if`           |
| THEN       | `then`                      | `then`         |
| END        | `end`                       | `end`          |
| PRINT      | `print`                     | `print`        |
| ( , )      | Parênteses                  | `(`, `)`       |
| ;          | Ponto e vírgula             | `;`            |

---

## 📚 Gramática em EBNF da Linguagem CT

A gramática a seguir define a estrutura sintática da linguagem **CT** em **EBNF (Extended Backus-Naur Form)**:

```ebnf
<programa>      ::= { <instrucao> }

<instrucao>     ::= <atribuicao> ";"
                  | <print_instr> ";"
                  | <condicional>

<atribuicao>    ::= ID "=" <expr>

<print_instr>   ::= "print" "(" <expr> ")"

<condicional>   ::= "if" <expr_rel> "then" { <instrucao> } "end"

<expr_rel>      ::= <expr> OP_REL <expr>

<expr>          ::= <termo> { ("+" | "-") <termo> }

<termo>         ::= <fator> { ("*" | "/") <fator> }

<fator>         ::= NUM
                  | ID
                  | "(" <expr> ")"
```

---

## 🧠 Semântica

### ✅ Semântica Estática

- Todas as variáveis armazenam valores numéricos (inteiros).
- Toda variável deve ser atribuída antes de ser usada.
- Operadores aritméticos e relacionais operam apenas sobre números.

### ⚙️ Semântica Dinâmica

- Atribuições atualizam o ambiente de variáveis.
- Expressões são avaliadas da esquerda para a direita.
- Condições em `if` são avaliadas para decidir a execução.
- `print(expr)` exibe o valor de uma expressão sem alterar variáveis.

---

## 🧾 Exemplo de Código em CT

```ct
// Inicializa a variável x com 10
x = 10;

// Calcula y como x + 5
y = x + 5;

// Verifica se y é maior que 10
if y > 10 then
    // Exibe y se a condição for verdadeira
    print(y);
end
```

---

## 🔍 Tokens Gerados pelo Lexer

```
ID("x"), ATRIB("="), NUM("10"), SEMI(";")
ID("y"), ATRIB("="), ID("x"), OP_ARIT("+"), NUM("5"), SEMI(";")
IF("if"), ID("y"), OP_REL(">"), NUM("10"), THEN("then")
PRINT("print"), LPAREN("("), ID("y"), RPAREN(")"), SEMI(";")
END("end")
```

---

## 🚀 Observações

Essa mini-linguagem foi criada apenas para fins educacionais, visando demonstrar os conceitos de análise léxica, gramática EBNF e semântica de linguagens de programação.
