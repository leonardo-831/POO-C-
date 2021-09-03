using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aprendendo POO!");

            //Criando um objeto de cada classe
            CartaoDeCredito cdc = new CartaoDeCredito();
            Cliente cliente = new Cliente();

            //Adicionando o nome do cliente
            cliente.Nome = "Leonardo belíssimo Muto";

            //Adicionando o numero e data de validade do cartao
            cdc.Numero = "3423523351134";
            cdc.DataDeValidade = "06/2007";
            cdc.Cliente = cliente;

            Console.WriteLine("O nome do cliente é: " + cliente.Nome);
            Console.WriteLine("O número do cartão é: " + cdc.Numero);
            Console.WriteLine("A data de validade do cartão é: " + cdc.DataDeValidade);
            Console.WriteLine("O nome do cliente agregado ao cartão é: " + cdc.Cliente.Nome);

            //Instância da Conta
            /*Conta conta = new Conta(123, 500);

            conta.Deposita(1500);

            //conta.AdicionarLimite(1000);

            bool saque = conta.Sacar(300);

            if (saque)
            {
                double saldo = conta.SaldoDisponivel();

                Console.WriteLine("Seu saldo é: " + saldo);
                Console.WriteLine("Seu limite é: " + conta.Limite);
                Console.WriteLine("O Número da sua conta é: " + conta.Numero);
            }*/
        }
    }
}
