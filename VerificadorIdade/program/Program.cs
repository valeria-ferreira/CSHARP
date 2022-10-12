
class Program {
  public static void Main (string[] args) {
    /*Construa um algoritmo que leia o ano de nascimento de uma pessoa (AN) e mostre a sua idade e, também verifique e mostre se essa pessoa já tem idade para votar (16 anos ou
    mais) e se já pode conseguir a sua carteira de habilitação (18 anos ou mais). */
    int dtnascimento, ano, idade;

    Console.WriteLine("-------------------------------------");
    Console.WriteLine("         CALCULADORA DE IDADE");
    Console.WriteLine("-------------------------------------\r\n");
    //informação
    Console.WriteLine("Em que ano estamos? ");
    ano = int.Parse(Console.ReadLine());
    Console.WriteLine("Em que ano você nasceu? ");
    dtnascimento = int.Parse(Console.ReadLine());

    //calculo
    idade = ano - dtnascimento;

    if (idade <= 15)
    Console.WriteLine("Sua idade é de {0} anos", idade);
    else
    {
    if ((idade >=16) && (idade <=17))
    {
    Console.WriteLine("Sua idade é de {0} anos", idade);
    Console.WriteLine("Você já pode votar.");
    }
        if (idade > 18)
        {
        Console.WriteLine("Sua idade é de {0} anos", idade);
        Console.WriteLine("Você já pode votar e tirar sua carteira de motorista.");
        }
    }

  }
}
