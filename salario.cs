/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class Program {
  static void Main() {
    int numerofuncionario,horastrabalhadas;
    double valorporhoras, salario;
    Console.WriteLine("Digite o numerofuncionario");
    numerofuncionario = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a horastrabalhadas");
    horastrabalhadas = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o valorporhoras");
    valorporhoras = double.Parse(Console.ReadLine());
    
       salario = horastrabalhadas * valorporhoras;

        // Exibição do resultado
        Console.WriteLine($"NUMBER = {numerofuncionario}");
        Console.WriteLine($"SALARY = $ {salario})");
  }
}