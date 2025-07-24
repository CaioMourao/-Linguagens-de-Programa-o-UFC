from typing import List, Dict, Callable

Tarefa = Dict[str, any]

def calcular_tempo_total(tarefas: List[Tarefa], filtro: Callable[[Tarefa], bool]) -> int:
    """
    Calcula o tempo total das tarefas que satisfazem o filtro.

    :param tarefas: lista de tarefas (cada tarefa é um dict)
    :param filtro: função que recebe uma tarefa e retorna True se incluir na soma
    :return: soma dos tempos das tarefas filtradas
    """
    if not tarefas:
        return 0

    cabeça, *cauda = tarefas

    if filtro(cabeça):
        return cabeça["tempo"] + calcular_tempo_total(cauda, filtro)
    else:
        return calcular_tempo_total(cauda, filtro)


if __name__ == "__main__":
    tarefas = [
        {"nome": "Estudar", "tempo": 120, "prioridade": 2},
        {"nome": "Exercícios", "tempo": 45, "prioridade": 3},
        {"nome": "Ler emails", "tempo": 15, "prioridade": 1},
        {"nome": "Reunião", "tempo": 60, "prioridade": 1},
    ]

    filtro = lambda tarefa: tarefa["tempo"] > 30

    total = calcular_tempo_total(tarefas, filtro)

    print(f"Tempo total das tarefas filtradas: {total} minutos")
