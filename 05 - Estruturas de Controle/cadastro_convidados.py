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
