## 🧠 Contexto 

A Programação Orientada a Objetos (POO) é uma abordagem poderosa que facilita a construção de sistemas complexos ao se basear em elementos do mundo real. Neste desafio, foi criado um sistema voltado para o gerenciamento de serviços de entrega de encomendas, um cenário comum e prático que permite aplicar, de forma clara e objetiva, os principais conceitos da POO
---

## ⚙️ POO

Este projeto foi cuidadosamente estruturado para ilustrar os quatro pilares fundamentais da Programação Orientada a Objetos:

### 🔹 Abstração
A classe Servico foi definida como **abstrata**.  
Ela estabelece o **contrato mínimo** que qualquer tipo de serviço deve seguir (neste caso, o método RealizarServico()), sem permitir a criação direta de uma instância genérica.

### 🔹 Herança
A classe Entrega herda de Servico, e serve como base para outras especializações.  
A partir dela, criamos:

- EntregaExpresso: para entregas rápidas com tempo estimado.
- EntregaEconomica: para entregas mais baratas com prazos maiores.

Cada subclasse herda atributos e métodos da classe Entrega, e adiciona comportamentos específicos.

### 🔹 Encapsulamento
As propriedades internas, como Status, estão protegidas por modificadores como protected set, garantindo que não possam ser alteradas fora das classes apropriadas.  
Isso mantém a **integridade dos dados** e evita acessos indevidos.

### 🔹 Polimorfismo
O método RealizarServico() é definido como **abstrato** na classe Servico, e cada tipo de entrega implementa sua própria versão.  
Isso permite usar **polimorfismo** no programa principal, com chamadas uniformes:

```csharp
foreach (var entrega in listaDeEntregas)
{
    entrega.RealizarServico(); 
}
```

## 🗂️ Estrutura do Projeto

O sistema foi organizado de forma modular, com cada classe definida em seu próprio arquivo para facilitar a leitura, manutenção e reutilização do código. Abaixo estão os principais arquivos que compõem a aplicação:

- **Servico.cs**  
  Contém a **classe abstrata Servico**, que serve como base para qualquer tipo de serviço no sistema. Define o contrato mínimo com a propriedade Nome e o método abstrato RealizarServico().

- **Entrega.cs**  
  Implementa a **classe Entrega**, uma versão concreta e genérica de um serviço de entrega. Esta classe herda de Servico e introduz os atributos EnderecoOrigem, EnderecoDestino e Status.

- **EntregaExpresso.cs**  
  Define a **classe EntregaExpresso**, uma especialização de Entrega com foco em entregas rápidas. Adiciona a propriedade TempoEstimadoHoras e sobrescreve o método RealizarServico() com comportamento específico.

- **EntregaEconomica.cs**  
  Implementa a **classe EntregaEconomica**, uma entrega com menor custo e prazo estendido. Também sobrescreve o método RealizarServico() com uma lógica própria.

- **Program.cs**  
  Arquivo principal do programa. Contém a função Main(), onde as instâncias dos diferentes tipos de entrega são criadas e executadas, demonstrando o uso do polimorfismo e os demais conceitos da POO na prática.
