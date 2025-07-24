# Organizador Automático de Arquivos por Tipo

## Contexto 

Linguagens de script, como Python, são ferramentas poderosas para automatizar tarefas repetitivas e rotineiras, facilitando o dia a dia do desenvolvedor e do usuário comum. Ao contrário de linguagens compiladas focadas em performance, as linguagens de script priorizam rapidez no desenvolvimento e integração com o sistema operacional.

Um problema frequente enfrentado por muitos usuários é a desordem acumulada na pasta de downloads, onde arquivos de vários tipos ficam misturados, dificultando encontrar documentos, imagens ou outros itens. Para solucionar isso, este projeto apresenta um script simples que organiza automaticamente os arquivos, separando-os em pastas de acordo com seu tipo.

## Organização Inteligente de Arquivos

O script examina uma pasta de origem, identifica o tipo de cada arquivo com base na extensão, e os transfere para subpastas categorizadas dentro de uma pasta de destino. Essa separação deixa o diretório organizado, facilitando o acesso aos arquivos.

### Funcionalidades Principais

- **Classificação por extensão:** Um dicionário relaciona as extensões de arquivos com nomes de pastas específicas (como "Imagens", "Documentos", "Vídeos"), permitindo uma categorização clara.

- **Criação dinâmica de pastas:** Antes de mover um arquivo, o script verifica se a pasta destino existe, criando-a automaticamente caso necessário.

- **Movimentação segura:** Com o uso do módulo shutil, os arquivos são movidos preservando a integridade dos dados.

- **Relatório detalhado:** Ao final do processo, o script informa quantos arquivos foram organizados em cada categoria e aponta arquivos que não foram classificados.

## Como usar

1. **Preparação das pastas:** O script cria automaticamente as pastas origem e destino no diretório onde está salvo, caso ainda não existam.

2. **Adicionar arquivos:** Coloque os arquivos que deseja organizar dentro da pasta origem.

3. **Executar o script:** No terminal, navegue até o diretório do script e execute:

