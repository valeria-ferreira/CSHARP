using System;

class Program {
  public static void Main (string[] args) {
    /*Construa um algoritmo para calcular o valor a ser pago pelo período de estacionamento do automóvel (PAG). O usuário entra com os seguintes dados: hora (HE) e minuto (ME) de entrada, hora (HS) e minuto (MS) de saída. Sabe-se que este estacionamento cobra hora cheia, ou seja, se passar um minuto ele cobra a hora inteira. O valor cobrado pelo estacionamento é:
    o R$ 4,00 para 1 hora de estacionamento
    o R$ 6,00 para 2 horas de estacionamento
    o R$ 1,00 por hora adicional (acima de 2 horas) */
    double hentrada, hsaida, mentrada, msaida, calculoh, calculom, total, totaltempo = 0, totaltempo1 = 0, totaltempo2;
    DateTime thisDay = DateTime.Today;

    Console.WriteLine("-------------------------------------------------");
    Console.WriteLine("                  ESTACIONAMENTO");
    Console.WriteLine(thisDay.ToString("     dd/MM/yyyy"));
    Console.WriteLine("-------------------------------------------------");
    //DADOS
    Console.Write("Por favor informe\r\nHora de entrada: ");
    hentrada = double.Parse(Console.ReadLine());
    Console.Write("Minuto da entrada: ");
    mentrada = double.Parse(Console.ReadLine());
    Console.Write("Hora da saída: ");
    hsaida = double.Parse(Console.ReadLine());
    Console.Write("Minutos da saida: ");
    msaida = double.Parse(Console.ReadLine());

    //Calculo 
    calculoh = (hsaida - hentrada)*60;
    calculom = (msaida - mentrada);

    total = (calculoh + calculom);

        if (total<=60)
        {
        totaltempo = (int)Math.Ceiling(total/60);
        totaltempo1 = totaltempo*4;
        Console.WriteLine("Obrigada por aguarda...\r\n O valor total é de: R$ {0:N}", totaltempo1);
        }
        else
        {
        if (total>=61)
        {
            totaltempo = (int)Math.Ceiling(total/60);
            totaltempo1 = totaltempo*3;
            Console.WriteLine("Obrigada por aguarda...\r\n O valor total é de: R$ {0:N}", totaltempo1);
        }
        else
        {
            if (total>=121)
            {
            totaltempo = (int)Math.Ceiling(total/60);
            totaltempo1 = totaltempo*1;
            totaltempo2 = 6+totaltempo1;
            Console.WriteLine("Obrigada por aguarda...\r\n O valor total é de: R$ {0:N}", totaltempo2);
            }
        }
      }
    }
}
