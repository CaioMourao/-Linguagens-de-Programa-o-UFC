# 🔐 Cenário Prático: Verificação de Senhas em Lote com Concorrência

## 🧩 Contexto
Em muitos sistemas, é comum validar se uma lista de senhas atende aos critérios de segurança (comprimento, uso de símbolos, números etc.). Quando temos centenas ou milhares de senhas para validar, uma abordagem sequencial pode se tornar lenta. Utilizar concorrência com System.Threading permite distribuir essa carga de trabalho e melhorar a performance.

---

## ❗ O Problema (Abordagem Sequencial)

Dada uma lista de 10.000 senhas para verificar, o sistema valida uma por uma, usando apenas um núcleo do processador.  
Se cada senha levar 2ms para ser verificada, o tempo total será de **~20 segundos**.

---

## ✅ A Solução (Abordagem Concorrente)

Criamos múltiplas **threads**, cada uma responsável por um grupo de senhas.  
Com 8 núcleos, podemos paralelizar a validação e reduzir significativamente o tempo total de execução.

---

## 💻 Implementação em C# (VerificadorDeSenhas.cs)

A implementação simula a validação de um lote de senhas, primeiro de forma **sequencial** e depois com **múltiplas threads**, comparando os tempos.

---

## ⚙️ Explicação da Implementação

### 🧠 Função de Trabalho: VerificarSenha

- Recebe uma string representando a senha.
- Simula verificação computacional com Thread.Sleep().
- Avalia se atende aos critérios mínimos:
  - Tamanho ≥ 8
  - Contém número
  - Contém letra
  - Contém símbolo

---

### 🔁 Execução Sequencial

- Um foreach tradicional percorre a lista e chama VerificarSenha.

---

### 🧵 Execução Concorrente

- Para cada grupo de senhas, uma nova Thread é criada.
- Todas as threads são iniciadas e armazenadas em uma lista.
- Join() é chamado para esperar a conclusão de todas.

---

### ⏱️ Medição de Performance

- Usamos System.Diagnostics.Stopwatch para medir com precisão o tempo de execução em ambas abordagens.

---

## 📊 Comparação

| Estratégia   | Núcleos Utilizados | Tempo Estimado  |
|--------------|--------------------|------------------|
| Sequencial   | 1                  | ~20 segundos     |
| Concorrente  | Até 8              | ~3 segundos      |

---

## ▶️ Como Usar

1. Crie um arquivo chamado VerificadorDeSenhas.cs.
2. Copie o código correspondente (fornecido separadamente).
3. Compile com:

```bash
csc VerificadorDeSenhas.cs
