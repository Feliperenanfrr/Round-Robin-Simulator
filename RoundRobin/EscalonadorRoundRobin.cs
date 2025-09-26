namespace RoundRobinSimulator;

public class EscalonadorRoundRobin
{
private Queue<Processo> filaProcessos;
        private List<Processo> processosFinalizados;
        private RelatorioExecucao relatorio;
        private int quantum;
        private int tempoAtual;

        public EscalonadorRoundRobin(int quantum)
        {
            this.quantum = quantum;
            this.filaProcessos = new Queue<Processo>();
            this.processosFinalizados = new List<Processo>();
            this.relatorio = new RelatorioExecucao();
            this.tempoAtual = 0;
        }

        public void AdicionarProcesso(Processo processo)
        {
            filaProcessos.Enqueue(processo);
        }

        public void ExecutarEscalonamento()
        {
            relatorio.ExibirCabecalho(quantum);
            List<string> sequenciaExecucao = new List<string>();

            while (filaProcessos.Count > 0)
            {
                Processo processoAtual = filaProcessos.Dequeue();
                relatorio.ExibirInicioExecucao(processoAtual, tempoAtual);

                int tempoExecucao = Math.Min(quantum, processoAtual.TempoRestante);
                
                for (int i = 0; i < tempoExecucao; i++)
                {
                    Console.WriteLine($"  Tempo {tempoAtual}: P{processoAtual.Id} em execução...");
                    tempoAtual++;
                    processoAtual.TempoRestante--;
                    
                    foreach (Processo p in filaProcessos)
                    {
                        p.TempoEspera++;
                    }
                }

                sequenciaExecucao.Add($"P{processoAtual.Id}");

                if (processoAtual.TempoRestante == 0)
                {
                    processoAtual.Finalizado = true;
                    processoAtual.TempoRetorno = tempoAtual;
                    processosFinalizados.Add(processoAtual);
                    relatorio.ExibirProcessoFinalizado(processoAtual.Id, tempoAtual);
                }
                else
                {
                    filaProcessos.Enqueue(processoAtual);
                    relatorio.ExibirProcessoRetornaFila(processoAtual.Id, processoAtual.TempoRestante);
                }

                Console.WriteLine();
            }

            relatorio.ExibirResultadosFinais(sequenciaExecucao, tempoAtual, processosFinalizados);
        }
}
