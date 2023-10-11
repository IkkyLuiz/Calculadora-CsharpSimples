using System;

class Calculadora
{
    static void Main(string[] args)
    {
        // Declaração das variáveis
        int x, y;
        string operador;

        // Solicita os valores
        Console.WriteLine("Insira o primeiro número:");
        x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Insira o segundo número:");
        y = Convert.ToInt32(Console.ReadLine());

        // Solicita o operador
        Console.WriteLine("Insira o operador (+, -, *, /):");
        operador = Console.ReadLine();

        // Realiza o cálculo
        switch (operador)
        {
            case "+":
                Console.WriteLine("O resultado é: " + (x + y));
                break;
            case "-":
                Console.WriteLine("O resultado é: " + (x - y));
                break;
            case "*":
                Console.WriteLine("O resultado é: " + (x * y));
                break;
            case "/":
                Console.WriteLine("O resultado é: " + (x / y));
                break;
            default:
                Console.WriteLine("Operador inválido");
                break;
        }
    }
}

