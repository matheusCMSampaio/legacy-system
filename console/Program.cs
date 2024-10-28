using System;
using System.Collections.Generic;
using System.IO;

namespace LegacySystem
{
    class MainSistema
    {
        static void Main(string[] args)
        {
            SistemaCliente cliente = new SistemaCliente();
            cliente.AddCliente(1, "Joao", "joao@email.com");
            cliente.AddCliente(2, "Maria", "maria@email.com");

            SistemaTransacoes transacao = new SistemaTransacoes();
            transacao.AdicionarTransacao(1, 100.50m, "Compra de Produto");
            transacao.AdicionarTransacao(2, 200.00m, "Compra de Serviço");
            transacao.AdicionarTransacao(3, 300.75m, "Compra de Software");

            cliente.ExibirTodosOsClientes();
            transacao.ExibirTransacoes();

            cliente.removerCliente(1);
            cliente.ExibirTodosOsClientes();

            cliente.AtualizarNomeCliente(2, "Maria Silva");

            string nomeEmpresa = "Empresa Teste";
            string descricaoTransacao = "Compra de Insumo";

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Nome da Empresa: " + nomeEmpresa + " Descrição: " + descricaoTransacao);
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Nome da Empresa: " + nomeEmpresa + " Descrição: " + descricaoTransacao);
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Nome da Empresa: " + nomeEmpresa + " Descrição: " + descricaoTransacao);
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Nome da Empresa: " + nomeEmpresa + " Descrição: " + descricaoTransacao);
            }

            Relatorio relatorio = new Relatorio();
            relatorio.GerarRelatorioCliente(cliente.clientes);

            int soma = 0;
            for (int i = 0; i < 10; i++)
            {
                //Soma mais 1
                soma += i;
            }

            Console.WriteLine("Soma total: " + soma);

            int somaDuplicada = 0;
            for (int i = 0; i < 10; i++)
            {
                //Soma Duplicada
                somaDuplicada += i;
            }
        }
    }
}