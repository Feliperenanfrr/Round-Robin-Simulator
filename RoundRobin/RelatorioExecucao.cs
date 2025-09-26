namespace RoundRobinSimulator;

public class RelatorioExecucao
{
 public void ExibirCabecalho(int quantum)
        {
            Console.WriteLine("=== SIMULAÇÃO DO ALGORITMO ROUND ROBIN ===");
            Console.WriteLine($"Quantum definido: {quantum} unidades de tempo\n");
        }

        public void ExibirInicioExecucao(Processo processo, int tempoAtual)
        {
            Console.WriteLine($"Tempo {tempoAtual}: Executando {processo}");
        }

        public void ExibirProcessoFinalizado(int id, int tempoAtual)
        {
            Console.WriteLine($"  *** P{id} FINALIZADO no tempo {tempoAtual} ***");
        }

        public void ExibirProcessoRetornaFila(int id, int tempoRestante)
        {
            Console.WriteLine($"  P{id} retorna à fila (restante: {tempoRestante})");
        }

        public void ExibirResultadosFinais(List<string> sequencia, int tempoTotal, List<Processo> processosFinalizados)
        {
            Console.WriteLine("=== RESULTADOS DA SIMULAÇÃO ===");
            Console.WriteLine($"Sequência de execução: {string.Join(" → ", sequencia)}");
            Console.WriteLine($"Tempo total de execução: {tempoTotal} unidades");
            Console.WriteLine();

            Console.WriteLine("Detalhes dos processos:");
            Console.WriteLine("Processo | Tempo Total | Tempo de Espera | Tempo de Retorno");
            Console.WriteLine("---------|-------------|-----------------|------------------");

            double somaEspera = 0, somaRetorno = 0;

            foreach (var processo in processosFinalizados.OrderBy(p => p.Id))
            {
                somaEspera += processo.TempoEspera;
                somaRetorno += processo.TempoRetorno;
                Console.WriteLine($"   P{processo.Id}    |      {processo.TempoTotal}      |        {processo.TempoEspera}        |        {processo.TempoRetorno}");
            }

            Console.WriteLine();
            Console.WriteLine($"Tempo médio de espera: {somaEspera / processosFinalizados.Count:F2}");
            Console.WriteLine($"Tempo médio de retorno: {somaRetorno / processosFinalizados.Count:F2}");
        }

        public void ExibirExplicacaoAlgoritmo()
        {
            Console.WriteLine("\n=== EXPLICAÇÃO DO ALGORITMO ROUND ROBIN ===");
            Console.WriteLine("• Algoritmo preemptivo que usa quantum (fatia de tempo)");
            Console.WriteLine("• Cada processo executa por no máximo 1 quantum");
            Console.WriteLine("• Se não terminar, vai para o final da fila");
            Console.WriteLine("• Garante justiça: todos os processos recebem tempo de CPU");
            Console.WriteLine("• Bom tempo de resposta para processos interativos");
        }
}
