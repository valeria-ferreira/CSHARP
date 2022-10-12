using System;

class Program {
  public static void Main (string[] args) {
    /*Construa um algoritmo que leia dois números (A e B). Caso A seja igual a B, apresentar a soma dos dois. Caso um seja maior que o outro, apresentar a diferença entre os dois
    números (sempre lembrando que a diferença entre dois números é SEMPRE positiva). */
    int a, b, c;

    Console.WriteLine("-------------------------------------");

    //INFORMAÇÃO
    Console.WriteLine("Qual o primeiro número: ");
        a = int.Parse(Console.ReadLine());
    Console.WriteLine("Qual o segundo número: ");
        b = int.Parse(Console.ReadLine());

    //CALCULO
    if (a == b)
    {
        c = a + b;
        Console.WriteLine("O resultado é {0}", c);
    }
    else
    {
        if (a > b)
        {
        c = (b-a)*-1;
        Console.WriteLine("O resultado é {0}", c);
        }
            if (a < b)
            {
            c = (a-b)*-1;
            Console.WriteLine("O resultado é {0}", c);
            }
    }
    Console.WriteLine("-------------------------------------");  
    }
}
