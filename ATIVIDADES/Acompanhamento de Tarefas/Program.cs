using System;

namespace GerenciadorDeTarefas
{
    class Program
    {
        static readonly GerenciadorTarefas gerenciador = new GerenciadorTarefas();

        static void Main()
        {
            int opcao;
            do
            {
                ExibirMenu();
                opcao = int.TryParse(Console.ReadLine(), out int o) ? o : -1;

                switch (opcao)
                {
                    case 1: CadastrarTarefa(); break;
                    case 2: ListarTarefas(); break;
                    case 3: BuscarTarefa(); break;
                    case 4: ConcluirTarefa(); break;
                    case 5: DesfazerUltimaConclusao(); break;
                    case 0: Console.WriteLine("Encerrando a aplicação..."); break;
                    default: Console.WriteLine("Opção inválida! Escolha uma opção do menu."); break;
                }

                if (opcao != 0)
                {
                    Console.WriteLine("\nPressione ENTER para continuar...");
                    Console.ReadLine();
                }
            } while (opcao != 0);
        }

        static void ExibirMenu()
        {
            Console.Clear();
            Console.WriteLine("===== GERENCIADOR DE TAREFAS =====");
            Console.WriteLine("1 - Cadastrar tarefa");
            Console.WriteLine("2 - Listar tarefas");
            Console.WriteLine("3 - Buscar tarefa");
            Console.WriteLine("4 - Concluir tarefa");
            Console.WriteLine("5 - Desfazer a última conclusão");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
        }

        static bool LerId(out int id)
        {
            Console.Write("Informe o identificador da tarefa: ");
            if (int.TryParse(Console.ReadLine(), out id))
                return true;

            Console.WriteLine("Identificador inválido! Digite um número inteiro.");
            return false;
        }

        static void CadastrarTarefa()
        {
            Console.Write("Descrição da tarefa: ");
            string descricao = (Console.ReadLine() ?? "").Trim();

            if (descricao.Length == 0)
            {
                Console.WriteLine("A descrição não pode ser vazia.");
                return;
            }

            Tarefa nova = gerenciador.Cadastrar(descricao);
            Console.WriteLine($"Tarefa cadastrada com sucesso! Identificador gerado: {nova.Id}");
        }

        static void ListarTarefas()
        {
            if (gerenciador.EstaVazia)
            {
                Console.WriteLine("Nenhuma tarefa cadastrada.");
                return;
            }

            Console.WriteLine("--- Tarefas cadastradas ---");
            foreach (Tarefa t in gerenciador.Listar())
                Console.WriteLine(t);
        }

        static void BuscarTarefa()
        {
            if (gerenciador.EstaVazia)
            {
                Console.WriteLine("Nenhuma tarefa cadastrada.");
                return;
            }

            if (!LerId(out int id)) return;

            Tarefa? t = gerenciador.Buscar(id);
            if (t == null)
                Console.WriteLine($"Nenhuma tarefa encontrada com o identificador {id}.");
            else
                Console.WriteLine(t);
        }

        static void ConcluirTarefa()
        {
            if (gerenciador.EstaVazia)
            {
                Console.WriteLine("Nenhuma tarefa cadastrada.");
                return;
            }

            if (!LerId(out int id)) return;

            switch (gerenciador.Concluir(id))
            {
                case 0: Console.WriteLine($"Tarefa {id} concluída com sucesso!"); break;
                case 1: Console.WriteLine($"Nenhuma tarefa encontrada com o identificador {id}."); break;
                case 2: Console.WriteLine("Esta tarefa já está concluída."); break;
            }
        }

        static void DesfazerUltimaConclusao()
        {
            Tarefa? t = gerenciador.DesfazerUltimaConclusao();
            if (t == null)
                Console.WriteLine("Não há conclusão para desfazer.");
            else
                Console.WriteLine($"Conclusão desfeita. A tarefa {t.Id} voltou a ficar pendente.");
        }
    }
}
