# Programa Simples com Estruturas de Seleção, Repetição e Controle de Fluxo

Este documento apresenta um exemplo de programa simples que utiliza as principais estruturas de controle de fluxo em Python: seleção, repetição e controle de fluxo. O programa criado tem um contexto original para facilitar o entendimento e aplicação prática desses conceitos.

---

## Contexto do Programa

Um sistema simples de cadastro de convidados para uma festa. O programa permite adicionar convidados, listar os convidados cadastrados e finalizar o cadastro. Ele utiliza:

- Estruturas de seleção para validar entradas e opções do usuário.
- Estruturas de repetição para manter o programa ativo até que o usuário decida sair.
- Controle de fluxo para ignorar entradas inválidas e encerrar o programa quando desejado.

---

## Código do Programa (Python)
```python
def main():
    convidados = []

    print("Bem-vindo ao sistema de cadastro de convidados!")

    while True:
        print("\nEscolha uma opção:")
        print("1 - Adicionar convidado")
        print("2 - Listar convidados")
        print("3 - Sair")

        escolha = input("Digite o número da opção desejada: ")

        if escolha == "1":
            nome = input("Digite o nome do convidado: ").strip()
            if not nome:
                print("Nome inválido! Tente novamente.")
                continue  
                
            if nome in convidados:
                print(f"{nome} já está na lista de convidados.")
            else:
                convidados.append(nome)
                print(f"{nome} adicionado(a) com sucesso!")

        elif escolha == "2":
            if convidados:
                print("\nLista de convidados:")
                for i, convidado in enumerate(convidados, start=1):
                    print(f"{i}. {convidado}")
            else:
                print("Nenhum convidado cadastrado ainda.")

        elif escolha == "3":
            print("Encerrando o sistema. Até mais!")
            break 

        else:
            print("Opção inválida! Por favor, escolha uma opção válida.")

if __name__ == "__main__":
    main()
```

## Explicação

- **Estruturas de seleção (if/elif/else)**  
  São usadas para decidir qual ação executar de acordo com a opção escolhida pelo usuário no menu.

- **Estrutura de repetição (while True)**  
  Mantém o programa em execução contínua até que o usuário escolha a opção de sair.

- **Controle de fluxo (continue e break)**  
  - continue: ignora uma iteração atual (por exemplo, quando a entrada é inválida) e volta ao início do loop.  
  - break: finaliza o loop e encerra o programa quando o usuário escolhe sair.

