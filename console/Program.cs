using System;
using System.Collections.Generic;

namespace LegacySystem
{
    class MainSistema
    {
        static void Main(string[] args)
        {
            SistemaCliente sistemaCliente = new SistemaCliente();
            sistemaCliente.AdicionarCliente(1, "Joao", "joao@email.com");
            sistemaCliente.AdicionarCliente(2, "Maria", "maria@email.com");

            SistemaTransacoes sistemaTransacoes = new SistemaTransacoes();
            sistemaTransacoes.AdicionarTransacao(1, 100.50m, "Compra de Produto");
            sistemaTransacoes.AdicionarTransacao(2, 200.00m, "Compra de Serviço");
            sistemaTransacoes.AdicionarTransacao(3, 300.75m, "Compra de Software");

            sistemaCliente.ExibirTodosOsClientes();
            sistemaTransacoes.ExibirTransacoes();

            sistemaCliente.RemoverCliente(1);
            sistemaCliente.ExibirTodosOsClientes();

            sistemaCliente.AtualizarNomeCliente(2, "Maria Silva");

            string nomeEmpresa = "Empresa Teste";
            string descricaoTransacao = "Compra de Insumo";

            ExibirInformacoesEmpresa(nomeEmpresa, descricaoTransacao, 5);

            Relatorio relatorio = new Relatorio();
            relatorio.GerarRelatorioClientes(sistemaCliente.ObterTodosOsClientes()); 

            int soma = 0;
            for (int i = 0; i < 10; i++)
            {
                soma += i;
            }
            Console.WriteLine("Soma total: " + soma);
        }

        static void ExibirInformacoesEmpresa(string nomeEmpresa, string descricao, int repeticoes)
        {
            for (int i = 0; i < repeticoes; i++)
            {
                Console.WriteLine($"Nome da Empresa: {nomeEmpresa} Descrição: {descricao}");
            }
        }
    }
}
