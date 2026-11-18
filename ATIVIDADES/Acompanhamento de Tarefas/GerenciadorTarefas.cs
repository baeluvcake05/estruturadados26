using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDeTarefas
{
    public class GerenciadorTarefas
    {
        private readonly List<Tarefa> tarefas = new List<Tarefa>();
        private readonly Stack<int> conclusoes = new Stack<int>();
        private int proximoId = 1;

        public bool EstaVazia => tarefas.Count == 0;
        public bool TemConclusaoParaDesfazer => conclusoes.Count > 0;

        public Tarefa Cadastrar(string descricao)
        {
            Tarefa nova = new Tarefa(proximoId++, descricao);
            tarefas.Add(nova);
            return nova;
        }

        public IReadOnlyList<Tarefa> Listar()
        {
            return tarefas;
        }

        public Tarefa? Buscar(int id)
        {
            foreach (Tarefa t in tarefas)
            {
                if (t.Id == id) return t;
            }
            return null;
        }

        // Retorna: 0 = concluída, 1 = não encontrada, 2 = já estava concluída
        public int Concluir(int id)
        {
            Tarefa? t = Buscar(id);
            if (t == null) return 1;
            if (t.Situacao == Situacao.Concluida) return 2;

            t.Situacao = Situacao.Concluida;
            conclusoes.Push(t.Id);
            return 0;
        }

        // Retorna a tarefa que voltou a ser pendente, ou null se a pilha estiver vazia
        public Tarefa? DesfazerUltimaConclusao()
        {
            if (conclusoes.Count == 0) return null;

            int id = conclusoes.Pop();
            Tarefa? t = Buscar(id);
            t?.Situacao = Situacao.Pendente;
            return t;
        }
    }
}
