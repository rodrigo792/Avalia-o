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
        // Solicitar a frase ao usuário
        Console.WriteLine("Digite uma frase:");
        string frase = Console.ReadLine();

        // Verificar se a frase não está vazia
        if (!string.IsNullOrWhiteSpace(frase))
        {
            // Dividir a frase em palavras usando espaços como separador
            string[] palavras = frase.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Contar o número de palavras
            int numeroPalavras = palavras.Length;

            // Exibir o resultado
            Console.WriteLine($"A frase contém {numeroPalavras} palavras.");
        }
        else
        {
            Console.WriteLine("A frase digitada está vazia. Tente novamente.");
        }
    }
}
