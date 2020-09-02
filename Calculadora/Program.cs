using System;

namespace Calculadora
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            string primeiraLinha = "Calculadora Frateschi LTDA.";
            string spaco = " ";
            string comentarioPrimeiroValor = "Digite o Primeiro Valor: ";
            int primeiroValor = 0;

            string comentarioCalculo = "Digite qual operacao deseja fazer ex: +, -, *, /";
            string operador = null;

            string comentarioSegundoValor = "Digite o Segundo Valor: ";
            int segundoValor = 0;

            string result = "Resultado igual: ";
            string valorResult = null;
            string caculoresult = null;


            Console.WriteLine(primeiraLinha);
            Console.WriteLine(comentarioPrimeiroValor);
            primeiroValor = int.Parse(Console.ReadLine());

            Console.WriteLine(comentarioCalculo);
            operador = Console.ReadLine();

            if (operador != "+" && operador != "-" && operador != "*" && operador != "/") 
            {
                Console.Clear();
                Console.WriteLine("-----------------");
                Console.WriteLine("Operador invalido");
                Console.WriteLine("-----------------");
            }
            
            Console.WriteLine(comentarioSegundoValor);
            segundoValor = int.Parse(Console.ReadLine());

            if (operador == "+")
            {
                double soma = primeiroValor + segundoValor;
                Console.WriteLine(result);
                Console.WriteLine(soma);
            }
            else
                if(operador == "-")
            {
                double subtracao = primeiroValor - segundoValor;
                Console.WriteLine(result);
                Console.WriteLine(subtracao);

            }
            else
                if(operador == "*")
            {
                double multiplicacao = primeiroValor * segundoValor;
                Console.WriteLine(result);
                Console.WriteLine(multiplicacao);

            }
            else
                if(operador =="/")
            {
                double divisao = primeiroValor / segundoValor;
                Console.WriteLine(result);
                Console.WriteLine(divisao);

            };


        }
    }
}
