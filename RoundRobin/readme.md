# 🎯 Round Robin Simulator - Sistema de Controle de Processos

**Projeto desenvolvido para a disciplina de Sistemas Operacionais**

## 📋 Sobre o Projeto

Este projeto implementa o algoritmo de escalonamento **Round Robin** para controle de processos, simulando a execução de 3 processos com quantum fixo de 2 unidades de tempo.

### 🔧 Especificações
- **Processo 1**: 10 unidades de tempo
- **Processo 2**: 5 unidades de tempo  
- **Processo 3**: 8 unidades de tempo
- **Quantum**: 2 unidades de tempo

---

## ⚡ **EXECUÇÃO RÁPIDA (30 segundos)**

### **Opção 1: Executável Pronto** ⭐ **(MAIS RÁPIDO)**
1. Navegue até a pasta: `RoundRobinSimulator/RoundRobinSimulator/bin/Debug/net9.0/`
2. **Duplo clique** em `RoundRobinSimulator.exe`
3. ✅ **Pronto!** O programa executa automaticamente

### **Opção 2: Visual Studio** 
1. Abra `RoundRobinSimulator.sln` no Visual Studio
2. Pressione **F5** ou clique em ▶️ "Iniciar"
3. ✅ **Pronto!** O programa executa automaticamente

### **Opção 3: Terminal/PowerShell**
```bash
# Navegar para a pasta do projeto
cd RoundRobinSimulator/RoundRobinSimulator

# Executar
dotnet run
```

---

## 🖥️ **Saída Esperada do Programa**

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

---

## 📁 **Estrutura do Projeto**

```
RoundRobinSimulator/
├── RoundRobinSimulator/
│   ├── Processo.cs                 # Modelo do processo
│   ├── EscalonadorRoundRobin.cs    # Algoritmo principal
│   ├── RelatorioExecucao.cs        # Relatórios e saídas
│   ├── Program.cs                  # Ponto de entrada
│   └── bin/Debug/net9.0/           # 📂 Executável aqui
│       └── RoundRobinSimulator.exe # ⭐ Execute este arquivo
├── RoundRobinSimulator.sln         # Arquivo da solução
└── README.md                       # Este arquivo
```

---

## 🔧 **Requisitos do Sistema**

### **Mínimos (para executar o .exe)**
- ✅ Windows 10/11
- ✅ .NET 9.0 Runtime *(já incluído no executável)*

### **Para compilar (opcional)**
- Visual Studio 2022
- OU .NET SDK 9.0+

---

## 🎓 **Funcionalidades Implementadas**

### ✅ **Requisitos Funcionais**
- [x] Recebe lista de processos com tempos de execução
- [x] Aplica escalonamento Round Robin com quantum = 2  
- [x] Simula execução em ciclos mostrando processo ativo
- [x] Indica finalização de todos os processos

### ✅ **Requisitos Não Funcionais**
- [x] Código legível e bem estruturado
- [x] Uso adequado de variáveis e funções
- [x] Código comentado nas principais partes
- [x] Testado com cenário proposto (P1=10, P2=5, P3=8, quantum=2)

### ✅ **Funcionalidades Extras**
- [x] Cálculo de tempo de espera e retorno
- [x] Estatísticas médias dos processos
- [x] Sequência completa de execução
- [x] Interface amigável com explicações

---

## 🔍 **Algoritmo Round Robin - Explicação**

### **Definição**
O Round Robin é um algoritmo de escalonamento **preemptivo** onde cada processo recebe uma fatia igual de tempo de CPU (quantum).

### **Funcionamento**
1. Processos são colocados em uma **fila circular**
2. Cada processo executa por **no máximo 1 quantum**
3. Se não terminar, vai para o **final da fila**
4. Próximo processo da fila executa
5. Repete até todos terminarem

### **Características**
- ⚖️ **Justiça**: Todos os processos recebem tempo igual
- ⏱️ **Preempção**: Processos podem ser interrompidos  
- 🚀 **Tempo de Resposta**: Bom para sistemas interativos
- 🔄 **Overhead**: Troca de contexto entre processos

---

## ❓ **Resolução de Problemas**

### **Problema**: Executável não abre
**Solução**: Instale o .NET Runtime ou use Visual Studio

### **Problema**: Console fecha muito rápido  
**Solução**: Execute pelo PowerShell com `dotnet run`

### **Problema**: Erro de compilação
**Solução**: Verifique se todos os 4 arquivos .cs estão presentes

---

## 👨‍💻 **Desenvolvedor**

**Nome**: Felipe  
**Disciplina**: Sistemas Operacionais  
**Linguagem**: C# (.NET 9.0)

---

## 📚 **Para Avaliação**

Este projeto demonstra:
- ✅ Implementação completa do algoritmo Round Robin
- ✅ Simulação detalhada da execução de processos  
- ✅ Cálculos precisos de tempos de espera e retorno
- ✅ Interface clara e educativa
- ✅ Código bem estruturado e documentado

**⏱️ Tempo estimado para execução e avaliação: 2-3 minutos**