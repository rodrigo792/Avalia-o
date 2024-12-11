/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;

class Program
{
    static void Main()
    {
        // Solicitar a primeira data
        Console.WriteLine("Digite a primeira data (dd/MM/yyyy): ");
        DateTime data1 = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

        // Solicitar a segunda data
        Console.WriteLine("Digite a segunda data (dd/MM/yyyy): ");
        DateTime data2 = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

        // Calcular a diferença em dias entre as duas datas
        TimeSpan diferenca = data2 - data1;
        int diasDiferenca = Math.Abs(diferenca.Days);

        // Exibir o resultado
        Console.WriteLine($"A diferença entre as datas é de {diasDiferenca} dias.");
    }
}
