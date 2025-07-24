# Modelagem de Árvore Genealógica com Programação Lógica em Prolog

## Contexto

A programação lógica representa uma abordagem única e declarativa para resolução de problemas. Ao invés de escrever passos detalhados para executar tarefas, descrevemos fatos e relações que definem o domínio do problema, deixando que o sistema de inferência descubra as respostas. Prolog é a linguagem mais reconhecida nesse paradigma, permitindo modelar conhecimento e fazer consultas inteligentes.

Neste projeto, escolhemos representar uma árvore genealógica simples para ilustrar os conceitos básicos da programação lógica. Esse tipo de problema é clássico e ideal para demonstrar como podemos definir relações familiares complexas a partir de informações básicas.

## Programação Lógica e Prolog

Em Prolog, o programa é uma coleção de **fatos** e **regras** que formam a base de conhecimento:

- **Fatos**: São declarações elementares que definem informações absolutas, como "joão é pai de maria".

- **Regras**: São inferências que descrevem como novos conhecimentos podem ser deduzidos a partir dos fatos existentes, por exemplo, definir que alguém é avô se for pai de um pai.

- **Consultas**: Perguntas feitas ao sistema para recuperar informações que satisfaçam os critérios definidos pela base de conhecimento.

Não há uma sequência de comandos; o Prolog explora automaticamente as relações para encontrar respostas.

## Estrutura do Código

O arquivo principal contém duas partes essenciais:

1. **Base de Fatos**: Define os elementos do domínio, como quem é pai ou mãe de quem.

2. **Base de Regras**: Estabelece as relações derivadas, como avô, irmão e outros, usando os fatos como base para inferência.

Essa organização facilita a manutenção e ampliação do conhecimento, tornando o código claro e modular.

## Exemplos de Consultas

- **pai(joao, ana).**  
  Verifica se João é pai de Ana.

- **avo(fernando, maria).**  
  Consulta se Fernando é avô de Maria.

- **irmao(pedro, X).**  
  Busca todos os irmãos de Pedro, retornando valores para `X`.

Essas consultas exemplificam como perguntas podem ser formuladas e respondidas sem programar explicitamente a busca.

