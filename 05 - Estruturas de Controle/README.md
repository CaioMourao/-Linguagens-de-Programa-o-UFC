
# 5 – Estruturas de Controle

## Contexto 

No universo da programação, o domínio de estruturas de **seleção** e **repetição** é essencial para criar sistemas interativos e funcionais.  
Para este desafio, propomos um cenário de **organização de eventos sociais**, em que o programador deve implementar um **sistema de cadastro de convidados**. O sistema deve permitir o registro, listagem e controle de convidados em tempo real, simulando o funcionamento de um recepcionista virtual.

Este contexto visa reforçar o uso de estruturas if, while, listas e validações lógicas.

---

## Funcionalidades Principais

### Menu Interativo

O sistema exibe um menu com três opções:
1. Adicionar convidado
2. Listar convidados
3. Sair do sistema

### Cadastro com Verificação

- Solicita o nome do convidado.
- Impede a adição de nomes vazios.
- Impede convidados repetidos na lista.

### Listagem Formatada

- Mostra a lista numerada dos convidados.
- Caso não haja convidados cadastrados, exibe uma mensagem apropriada.

### Encerramento Seguro

- O sistema só encerra quando o usuário escolhe explicitamente a opção `3`.

---

## Exemplo de Execução

```plaintext
Bem-vindo ao sistema de cadastro de convidados!

Escolha uma opção:
1 - Adicionar convidado
2 - Listar convidados
3 - Sair
Digite o número da opção desejada: 1
Digite o nome do convidado: Alice
Alice adicionado(a) com sucesso!

Escolha uma opção:
1 - Adicionar convidado
2 - Listar convidados
3 - Sair
Digite o número da opção desejada: 2

Lista de convidados:
1. Alice
```

---

## Como Executar

1. Salve o código em anexo em um arquivo chamado cadastro_convidados.py.
3. No terminal, execute:

```bash
python cadastro_convidados.py
```

---

