using System;

class Program {
  public static void Main (string[] args) {
    /*Construa um algoritmo que tendo como dados de entrada o preço de um produto (PR) e seu código de origem (CO), apresente o preço e a sua procedência, de acordo com a tabela abaixo:
    Código de Origem (CO)      --    Procedência
        1                     --        Sul
        2                     --       Sudeste
        3                     --     Centro-Oeste
        4                     --         Norte
        5                     --       Nordeste */
    double produto;
    int codigo;
    DateTime thisDay = DateTime.Today;

    Console.WriteLine("-------------------------------------");
    Console.WriteLine("                CAIXA");
    Console.WriteLine(thisDay.ToString(" dd/MM/yyyy"));
    Console.WriteLine("-------------------------------------\r\n");
    //informação
    Console.WriteLine("Qual o valor do produto? ");
    produto = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o código da etiqueta '1', '2', '3', '4' ou '5': ");
    codigo = int.Parse(Console.ReadLine());
    
    switch(codigo)
    {
    case 1:
    Console.WriteLine("O Valor do produto é R$ {0:N}", produto);
    Console.WriteLine("Sua procedência é SUL.");
    break;
    case 2:
    Console.WriteLine("O Valor do produto é R$ {0:N}", produto);
    Console.WriteLine("Sua procedência é SUDESTE.");
    break;
    case 3:
    Console.WriteLine("O Valor do produto é R$ {0:N}", produto);
    Console.WriteLine("Sua procedência é CENTRO-OESTE.");
    break;
    case 4:
    Console.WriteLine("O Valor do produto é R$ {0:N}", produto);
    Console.WriteLine("Sua procedência é NORTE.");
    break;
    case 5:
    Console.WriteLine("O Valor do produto é R$ {0:N}", produto);
    Console.WriteLine("Sua procedência é NORDESTE.");
    break;
    }

  }
}
