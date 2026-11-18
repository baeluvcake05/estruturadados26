using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDeTarefas
{
    public class Tarefa
    {
        public int Id { get; }
        public string Descricao { get; }
        public Situacao Situacao { get; set; }

        public Tarefa(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
            Situacao = Situacao.Pendente;
        }

        public override string ToString()
        {
            string situacaoTexto = Situacao == Situacao.Pendente ? "Pendente" : "Concluída";
            return $"ID: {Id} | Descrição: {Descricao} | Situação: {situacaoTexto}";
        }
    }
}
