# 03 - Sintaxe e Semântica

Este desafio propõe a criação de uma **mini-gramática fictícia** para uma linguagem inventada, junto com exemplos de **análise léxica** e sintática. O objetivo é compreender os conceitos formais por trás das linguagens de programação: **tokens**, **gramática**, **análise léxica**, **parsing** e **semântica estrutural**.

---

## 🧪 Linguagem: **CT**

**CT** é uma linguagem fictícia criada com sintaxe simples, voltada para operações aritméticas básicas e controle condicional. A ideia é representar uma linguagem minimalista semelhante ao pseudocódigo, mas com regras formais.

---

## 🔤 Análise Léxica

A análise léxica consiste em **quebrar o código-fonte em tokens válidos**.

### 🧱 CT:

| Tipo           | Padrão (Regex simplificado)  | Exemplo      |
|----------------|-------------------------------|--------------|
| `NUM`          | `[0-9]+`                      | `42`         |
| `ID`           | `[a-zA-Z_][a-zA-Z0-9_]*`      | `x`, `total` |
| `OP_ARIT`      | `[\+|\-|\*|\/]`               | `+`, `*`     |
| `OP_REL`       | `(==|!=|>|<|>=|<=)`           | `!=`, `<=`   |
| `ATRIB`        | `=`                           | `=`          |
| `IF`           | `if`                          | `if`         |
| `THEN`         | `then`                        | `then`       |
| `END`          | `end`                         | `end`        |
| `PRINT`        | `print`                       | `print`      |
| `(`, `)`       | Parênteses                    | `(`, `)`     |
| `;`            | Ponto e vírgula               | `;`          |

---

## 🧾 Exemplo de código em CT

```CT
x = 10;
y = x + 5;
if y > 10 then
    print(y);
end
