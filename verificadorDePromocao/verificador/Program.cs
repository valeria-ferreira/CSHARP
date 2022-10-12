using System;

class Program {
  public static void Main (string[] args) {
    /*Construa um algoritmo que leia o preço de um produto (P) e apresente a mensagem: “Em promoção”, caso o preço seja maior ou igual a R$ 50,00 e menor ou igual a R$ 100,00.
    Caso contrário, deve apresentar a mensagem: “Preço Normal”.*/
    double preco;
    DateTime thisDay = DateTime.Today;

    Console.WriteLine("-------------------------------------");
    Console.WriteLine("                CAIXA");
    Console.WriteLine(thisDay.ToString(" dd/MM/yyyy"));
    Console.WriteLine("-------------------------------------\r\n");
    //informação
    Console.WriteLine("Qual o valor do produto? ");
    preco = double.Parse(Console.ReadLine());

    if ((preco >= 50.00 ) && (preco <= 100.00))
    {
    Console.WriteLine("Está em promoção.");
    }
    else
    Console.WriteLine("Preço normal.");
   }
}
