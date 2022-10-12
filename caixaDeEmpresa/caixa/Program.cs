using System;

class Program {
  public static void Main (string[] args) {
    /*Construa um algoritmo que leia a quantidade de dinheiro existente no caixa de uma empresa (CAIXA), a quantidade de produtos a ser comprada (QTD) e o preço de cada unidade (PR). Caso o valor total da compra seja superior a 80% do valor em caixa, a compra deve ser feita a prazo (3x), com juros de 10% sobre o valor total. Caso contrário, a compra deverá ser realizada a vista, onde a empresa receberá 5% de desconto. Apresentar a forma de pagamento escolhida e o valor a ser pago (total a vista ou total a prazo), dependendo da escolha realizada pelo programa. */
    double caixa, qtd, preco, total, porcentagem, valor, total2, conta;
    DateTime thisDay = DateTime.Today;

    Console.WriteLine("-------------------------------------");
    Console.WriteLine("                CAIXA");
    Console.WriteLine(thisDay.ToString(" dd/MM/yyyy"));
    Console.WriteLine("-------------------------------------\r\n");
    //informação
    
    Console.WriteLine("Qual o valor total no caixa? ");
    caixa = double.Parse(Console.ReadLine());
    Console.WriteLine("Qual a quantidade de produto a ser comprada? ");
    qtd = double.Parse(Console.ReadLine());
    Console.WriteLine("Qual o valor do produto? ");
    preco = double.Parse(Console.ReadLine());

    //CALCULO   
    total = qtd*preco;
    porcentagem = (caixa*20)/100;
    valor = caixa - porcentagem;
    
    
    if (total > valor)
    {
    conta = (total*10)/100;
    total2 = (total+conta)/3;
    Console.WriteLine("O valor total a pagar é R$ {0:N}", total);
    Console.WriteLine("Valor pago em 3x com juros de 10%: R$ {0:N}", total2);
    }
    else
    {
    conta = (total*5)/100;
    total2 = total-conta;
    Console.WriteLine("O valor total a pagar é R$ {0:N}", total);
    Console.WriteLine("a vista por R$ {0:N}", total2);
    }
    

  }
}