using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    public class Conta
    {
        public Conta(int numero, double limite)
        {
            this.Numero = numero;
            this.Limite = limite;
        }
        private double Saldo { get; set; } //get diz que o atributo saldo é público e pode ser buscado e o set diz que você pode setar algum valor a Saldo
        public double Limite { get; private set; }
        public double Numero { get; private set; }

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }
        public bool Sacar(double valor)
        {
            double saldoDisponivel = this.SaldoDisponivel();

            if(valor > saldoDisponivel)
            {
                Console.WriteLine("Saque recusado(valor do saque maior do que o saldo disponível)");
                return false;
            }

            this.Saldo -= valor;
            return true;
        }

        public void AdicionarLimite(double valor)
        {
            this.Limite = valor;
        }

        public double SaldoDisponivel()
        {
            return this.Saldo + this.Limite;
        }
    }
}
