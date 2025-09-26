using RoundRobinSimulator;

internal class Program
{
    public static void Main(string[] args)
    {
            Console.WriteLine("SISTEMA DE CONTROLE DE PROCESSOS - ROUND ROBIN");
            Console.WriteLine("Desenvolvido para a disciplina de Sistemas Operacionais\n");

            EscalonadorRoundRobin escalonador = new EscalonadorRoundRobin(2);

            Processo p1 = new Processo(1, 10);
            Processo p2 = new Processo(2, 5);
            Processo p3 = new Processo(3, 8);

            escalonador.AdicionarProcesso(p1);
            escalonador.AdicionarProcesso(p2);
            escalonador.AdicionarProcesso(p3);

            Console.WriteLine("Processos adicionados:");
            Console.WriteLine("P1: 10 unidades de tempo");
            Console.WriteLine("P2: 5 unidades de tempo");
            Console.WriteLine("P3: 8 unidades de tempo");
            Console.WriteLine();

            escalonador.ExecutarEscalonamento();

            RelatorioExecucao relatorio = new RelatorioExecucao();
            relatorio.ExibirExplicacaoAlgoritmo();

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
