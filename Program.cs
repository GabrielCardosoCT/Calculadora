// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main()
{
    Console.WriteLine("Qual operação você deseja fazer?");

    Console.WriteLine("1 - Adição");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão \n");

    int operacao = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o seu primeiro numero: ");
    int num1 = int.Parse(Console.ReadLine());

    Console.Write("Digite o seu segundo numero: ");
    int num2 = int.Parse(Console.ReadLine());

    int resultado = 0;

    switch (operacao)
    {
        case 1:
        {
            resultado = Adicao(num1, num2);
            break;
        }
        case 2:
        {
            resultado = Subtracao(num1, num2);
            break;
        }
        case 3:
        {
            resultado = Multiplicacao(num1, num2);
            break;
        }
        case 4:
        {
            resultado = Divisao(num1, num2);
            break;
        }
        
            default:
            Console.WriteLine("Porfavor, digite novamente um número válido.");
            break;
    }
        Console.WriteLine($"Seu resultado é {resultado}.");
        
}
    public static int Adicao(int num1, int num2)
    {
        int resultado = num1 + num2;
        return resultado; 
    }

    public static int Subtracao(int num1, int num2)
    {
        int resultado = num1 - num2;
        return resultado; 
    }

    public static int Multiplicacao(int num1, int num2)
    {
        int resultado = num1 * num2;
        return resultado; 
    }

    public static int Divisao(int num1, int num2)
    {
        int resultado = num1 / num2;
        return resultado; 
    }

}

