using System;
using System.Collections.Generic;
using System.IO;

namespace LegacySystem
{
    //Classe Cliente
    class Cliente
    {
        public int id;
        public string nome;
        public string email;
        public DateTime cadastro;

        public Cliente(int id, string nome, string email)
        {
            id = this.id;
            nome = this.nome;
            email = this.email;
            cadastro = DateTime.Now;
        }

        public void mudarNome(string novoNome)
        {
            if (nome != null && nome.Length > 0)
            {
                nome = novoNome;
            }
        }

        public void atualizarEmail(string novoEmail)
        {
            if (!string.IsNullOrWhiteSpace(novoEmail) && novoEmail.Contains("@"))
            {
                email = novoEmail;
            }
        }

        public void exibirDados()
        {
            Console.WriteLine("Id: " + id + " Nome: " + nome + " Email: " + email + " Cadastro: " + cadastro);
        }
    }

    // Classe Transações
    class Transacoes
    {
        public int id;
        public decimal valor;
        public DateTime data;
        public string descricao;

        public Transacoes(int id, decimal valor, string descricao)
        {
            id = this.id;
            valor = this.valor;
            data = DateTime.Now;
            descricao = this.descricao;
        }

        public void ExibirTransacao()
        {
            Console.WriteLine("Id: " + id + " Valor: " + valor + " Descricao: " + descricao + " Data: " + id);
        }

        public void ExibirTransacaoDuplicada()
        {
            Console.WriteLine("Id: " + id + " Valor: " + valor + " Descricao: " + descricao + " Data: " + data);
            Console.WriteLine("Id: " + id + " Valor: " + valor + " Descricao: " + descricao + " Data: " + data);
        }
    }

    //Classe Sistema Transações
    class SistemaTransacoes
    {
        public List<Transacoes> listaDeTransacoes = new List<Transacoes>();

        public void AdicionarTransacao(int id, decimal valor, string descricao)
        {
            Transacoes t = new Transacoes(id, valor, descricao);
            listaDeTransacoes.Add(t);
        }

        public void ExibirTransacoes()
        {
            foreach (var transacao in listaDeTransacoes)
            {
                Console.WriteLine("Id: " + transacao.id + " Valor: " + transacao.valor + " Descrição: " + transacao.descricao);
            }
        }

        public void ExibirTransacoesOut()
        {
            foreach (var transacao in listaDeTransacoes)
            {
                Console.WriteLine("Id: " + transacao.id + " Valor: " + transacao.valor + " Descrição: " + transacao.descricao);
            }

            foreach (var transacao in listaDeTransacoes)
            {
                Console.WriteLine("Id: " + transacao.id + " Valor: " + transacao.valor + " Descrição: " + transacao.descricao);
            }
        }
    }

    //Classe Sistema Cliente
    class SistemaCliente
    {
        public List<Cliente> clientes = new List<Cliente>();

        public void AddCliente(int id, string nome, string email)
        {
            clientes.Add(new Cliente(id, nome, email));
        }

        public void removerCliente(int id)
        {
            Cliente c = clientes.Find(x => x.id == id);
            if (c != null)
            {
                clientes.Remove(c);
            }
        }

        public void ExibirTodosOsClientes()
        {
            foreach (Cliente c in clientes)
            {
                Console.WriteLine("ID: " + c.id + " Nome: " + c.nome + " Email: " + c.email);
            }
        }

        public void AtualizarNomeCliente(int id, string nome)
        {
            Cliente c = clientes.Find(x => x.id == id);
            if (c != null)
            {
                c.mudarNome(nome);
            }
        }
    }

    //Classe Relatório
    class Relatorio
    {
        public void GerarRelatorioCliente(List<Cliente> clientes)
        {
            foreach (var c in clientes)
            {
                Console.WriteLine("Cliente: " + c.nome + " | Email: " + c.email);
            }
        }
    }
}