/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class Program {
  static void Main() {
      int dias, meses, anos, diasRestantes;
    Console.WriteLine("Digite o numero de dias");
    dias = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o numero de meses");
    meses = int.Parse(Console.ReadLine());
     Console.WriteLine("Digite os anos");
    anos = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite os diasRestantes");
    diasRestantes = int.Parse(Console.ReadLine());
    
    // Cálculo de anos, meses e dias restantes
         anos = totalDias / 365;
        diasRestantes = totalDias % 365;
          meses = diasRestantes / 30;
         dias = diasRestantes % 30;

        // Exibição do resultado
        Console.WriteLine($"Anos: {anos}, Meses: {meses}, Dias: {dias}");
  }
}