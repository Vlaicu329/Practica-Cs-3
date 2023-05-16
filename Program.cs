using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Este programa mediante dos numeros actua como una calculadora");
        Console.WriteLine("Ingrese un primer numero");
        var x = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese un segundo numero");
        var y = int,Parse(Console.ReadLine());

        var addition = x + y;
        var subtraction = x - y;
        var division = (double)x / y;
        var multiply = x * y;

        Console.WriteLine("La suma de " + x + " y " + y + " es: " + addition);
        Console.WriteLine("La resta de " + x + " y " + y + " es: " + subtraction);
        Console.WriteLine("La division de " + x + " y " + y + " es: " + division);
        Console.WriteLine("La multiplicacion de " + x + " y " + y + " es: " + multiply);
    }
}