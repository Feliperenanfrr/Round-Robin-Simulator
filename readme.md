# Round Robin Simulator - Sistema de Controle de Processos

Projeto desenvolvido para a disciplina de Sistemas Operacionais

## Sobre o Projeto

Este projeto implementa o algoritmo de escalonamento Round Robin para controle de processos, simulando a execução de 3 processos com quantum fixo de 2 unidades de tempo.

## Especificações

- **Processo 1:** 10 unidades de tempo
- **Processo 2:** 5 unidades de tempo
- **Processo 3:** 8 unidades de tempo
- **Quantum:** 2 unidades de tempo

## Como Executar

### Pré-requisitos
- .NET SDK 9.0 ou superior instalado

### Instruções para Execução

1. **Clone o repositório** (se ainda não tiver feito)
2. **Navegue para a pasta do projeto:**
   ```bash
   cd RoundRobinSimulator/RoundRobinSimulator
   ```
3. **Execute o projeto:**
   ```bash
   dotnet run
   ```

O programa será compilado automaticamente e executado, exibindo a simulação completa do algoritmo Round Robin.

### Alternativa usando Visual Studio
Se preferir, também é possível:
1. Abrir `RoundRobinSimulator.sln` no Visual Studio
2. Pressionar F5 ou clicar em "Iniciar"

## Saída do Programa

```
SISTEMA DE CONTROLE DE PROCESSOS - ROUND ROBIN
Desenvolvido para a disciplina de Sistemas Operacionais

Processos adicionados:
P1: 10 unidades de tempo
P2: 5 unidades de tempo
P3: 8 unidades de tempo

=== SIMULAÇÃO DO ALGORITMO ROUND ROBIN ===
Quantum definido: 2 unidades de tempo

Tempo 0: Executando P1 (Total: 10, Restante: 10)
  Tempo 0: P1 em execução...
  Tempo 1: P1 em execução...
  P1 retorna à fila (restante: 8)

Tempo 2: Executando P2 (Total: 5, Restante: 5)
  Tempo 2: P2 em execução...
  Tempo 3: P2 em execução...
  P2 retorna à fila (restante: 3)

[...simulação continua...]

=== RESULTADOS DA SIMULAÇÃO ===
Sequência de execução: P1 → P2 → P3 → P1 → P2 → P3 → P1 → P2 → P3 → P1 → P3 → P1
Tempo total de execução: 23 unidades

Detalhes dos processos:
Processo | Tempo Total | Tempo de Espera | Tempo de Retorno
---------|-------------|-----------------|------------------
   P1    |      10     |        13       |        23
   P2    |      5      |        8        |        13
   P3    |      8      |        10       |        18

Tempo médio de espera: 10.33
Tempo médio de retorno: 18.00

=== EXPLICAÇÃO DO ALGORITMO ROUND ROBIN ===
• Algoritmo preemptivo que usa quantum (fatia de tempo)
• Cada processo executa por no máximo 1 quantum
• Se não terminar, vai para o final da fila
• Garante justiça: todos os processos recebem tempo de CPU
• Bom tempo de resposta para processos interativos
```

## Estrutura do Projeto

```
RoundRobinSimulator/
├── RoundRobinSimulator/
│   ├── Processo.cs                 # Modelo do processo
│   ├── EscalonadorRoundRobin.cs    # Algoritmo principal
│   ├── RelatorioExecucao.cs        # Relatórios e saídas
│   ├── Program.cs                  # Ponto de entrada
│   └── RoundRobinSimulator.csproj  # Configuração do projeto
├── RoundRobinSimulator.sln         # Arquivo da solução
└── README.md                       # Este arquivo
```

## Requisitos do Sistema

- **Sistema Operacional:** Windows, Linux ou macOS
- **.NET SDK 9.0+** para compilação e execução
- **Terminal/PowerShell** para execução via linha de comando

## Funcionalidades Implementadas

### Requisitos Funcionais
- Recebe lista de processos com tempos de execução
- Aplica escalonamento Round Robin com quantum = 2
- Simula execução em ciclos mostrando processo ativo
- Indica finalização de todos os processos

### Funcionalidades Extras
- Cálculo de tempo de espera e retorno
- Estatísticas médias dos processos
- Sequência completa de execução
- Interface detalhada com explicações

## Algoritmo Round Robin

### Definição
O Round Robin é um algoritmo de escalonamento preemptivo onde cada processo recebe uma fatia igual de tempo de CPU (quantum).

### Como Funciona
1. Processos são organizados em uma fila circular
2. Cada processo executa por no máximo 1 quantum
3. Se não terminar, retorna ao final da fila
4. Próximo processo da fila executa
5. Processo continua até todos terminarem

### Características
- **Justiça:** Todos os processos recebem tempo igual de CPU
- **Preempção:** Processos podem ser interrompidos
- **Tempo de Resposta:** Adequado para sistemas interativos
- **Overhead:** Existe custo na troca de contexto entre processos

## Resolução de Problemas

- **Erro "dotnet não é reconhecido":** Instale o .NET SDK 9.0 ou superior
- **Console fecha rapidamente:** Use o terminal e execute `dotnet run`
- **Erro de compilação:** Verifique se todos os 4 arquivos .cs estão presentes na pasta

## Informações do Projeto

- **Equipe:** Felipe Renan, Jéssica Vitória, Mateus Patrício, Evelyn Júlia e Tiago Sousa
- **Disciplina:** Sistemas Operacionais
- **Linguagem:** C# (.NET 9.0)

Este projeto demonstra a implementação completa do algoritmo Round Robin com simulação detalhada da execução de processos, cálculos precisos de tempos de espera e retorno, e interface educativa.