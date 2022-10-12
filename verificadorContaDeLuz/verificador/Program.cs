using System;

class Program {
  public static void Main (string[] args) {
    /* Construa um algoritmo que leia o valor de uma conta de luz (CL) e, caso o valor seja maior que R$ 50,00 apresente a mensagem: “Você está gastando muito”. Caso contrário exiba a mensagem: “Seu gasto foi normal”. */
    double valor;
    DateTime thisDay = DateTime.Today;
    Console.WriteLine("-------------------------------------");
    Console.WriteLine("  Verificador de conta de LUZ.");
    Console.WriteLine(thisDay.ToString(" dd/MM/yyyy"));
    Console.WriteLine("-------------------------------------");
    //informação
    Console.Write(" Qual o valor da sua conta de luz? ");
    valor = double.Parse(Console.ReadLine());
    //resultado  
    if (valor > 50.00){
      Console.WriteLine(" Você está gastando muito.");
    }
    else
      Console.WriteLine(" Seu gasto foi normal.");

  }
}
