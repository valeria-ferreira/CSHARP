using System;

class Program {
  public static void Main (string[] args) {
/* Construa um algoritmo que determine quanto será gasto para encher o tanque de um carro (VG), sabendo-se que o preço da gasolina é de R$ 1,80 e o preço do álcool é de R$ 1,00. O usuário fornecerá os seguintes dados: Tipo de carro (TC) (G – gasolina ou A – álcool) e Capacidade do tanque (CT), em litros. */
double gaso = 1.80, alc = 1.00, litro, preco = 0; 
string combustivel;
DateTime thisDay = DateTime.Today;

Console.WriteLine("-------------------------------------");
Console.WriteLine("          POSTO DE GASOLINA");
Console.WriteLine(thisDay.ToString(" dd/MM/yyyy"));
Console.WriteLine("-------------------------------------\r\n");
//informação
 Console.WriteLine("A Gasolina está R$1.80 e o álcool está 1.00. Informe qual tipo de combustivel  você gostaria de encher seu tanque sendo 'G' para Gasolina e 'A' para álcool: ");
 combustivel = Console.ReadLine().ToUpper();
 Console.WriteLine("Porfavor informe quantos litros: ");
 litro = double.Parse(Console.ReadLine()) ;
 //calculo
if (combustivel == "G")
{
  preco = litro*gaso;
  Console.WriteLine("O total é {0:N}", preco);
}
else
{
  if(combustivel == "A")
 preco = litro*alc;
 Console.WriteLine("O total é {0:N}", preco);
 }
  }
}
