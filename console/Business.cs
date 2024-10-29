using System;
using System.Collections.Generic;

namespace LegacySystem
{
    // Classe Cliente
    class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime Cadastro { get; set; }

        public Cliente(int id, string nome, string email)
        {
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
            this.Cadastro = DateTime.Now;
        }

        public void MudarNome(string novoNome)
        {
            if (!string.IsNullOrWhiteSpace(novoNome))
            {
                Nome = novoNome;
            }
        }

        public void AtualizarEmail(string novoEmail)
        {
            if (!string.IsNullOrWhiteSpace(novoEmail) && novoEmail.Contains("@"))
            {
                Email = novoEmail;
            }
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Id: {Id} Nome: {Nome} Email: {Email} Cadastro: {Cadastro}");
        }
    }

    // Classe Transacoes
    class Transacao
    {
        public int Id { get; private set; }
        public decimal Valor { get; private set; }
        public DateTime Data { get; private set; }
        public string Descricao { get; private set; }

        public Transacao(int id, decimal valor, string descricao)
        {
            this.Id = id;
            this.Valor = valor;
            this.Descricao = descricao;
            this.Data = DateTime.Now;
        }

        public void ExibirTransacao()
        {
            Console.WriteLine($"Id: {Id} Valor: {Valor} Descricao: {Descricao} Data: {Data}");
        }
    }

    // Classe SistemaTransacoes
    class SistemaTransacoes
    {
        private List<Transacao> _listaDeTransacoes = new List<Transacao>();

        public void AdicionarTransacao(int id, decimal valor, string descricao)
        {
            Transacao transacao = new Transacao(id, valor, descricao);
            _listaDeTransacoes.Add(transacao);
        }

        public void ExibirTransacoes()
        {
            foreach (var transacao in _listaDeTransacoes)
            {
                transacao.ExibirTransacao();
            }
        }
    }

    // Classe SistemaCliente
    class SistemaCliente
    {
        private List<Cliente> _clientes = new List<Cliente>();

        public void AdicionarCliente(int id, string nome, string email)
        {
            _clientes.Add(new Cliente(id, nome, email));
        }

        public List<Cliente> ObterTodosOsClientes()
        {
            return _clientes.ToList(); 
        }

        public void RemoverCliente(int id)
        {
            Cliente cliente = _clientes.Find(c => c.Id == id);
            if (cliente != null)
            {
                _clientes.Remove(cliente);
            }
        }

        public void ExibirTodosOsClientes()
        {
            foreach (Cliente cliente in _clientes)
            {
                cliente.ExibirDados();
            }
        }

        public void AtualizarNomeCliente(int id, string novoNome)
        {
            Cliente cliente = _clientes.Find(c => c.Id == id);
            cliente?.MudarNome(novoNome);
        }
    }

    // Classe Relatorio
    class Relatorio
    {
        public void GerarRelatorioClientes(List<Cliente> clientes)
        {
            foreach (var cliente in clientes)
            {
                Console.WriteLine($"Cliente: {cliente.Nome} | Email: {cliente.Email}");
            }
        }
    }
}
