using System;

class Program {
  public static void Main (string[] args) {
    /*Construa um algoritmo que calcule o novo salário (SAL_NOVO) de um funcionário. Considere que o funcionário deverá receber um reajuste de 15% caso seu salário (SAL) seja menor que 500. Se o salário for maior ou igual a 500, mas menor ou igual a 1000, o reajuste deve ser de 10%. Caso o salário seja maior que 1000, o reajuste deve ser de 5%. */
    double novo, total, salario;
    DateTime thisDay = DateTime.Today;

    Console.WriteLine("-------------------------------------");
    Console.WriteLine("       CALCULADORA DE SALÁRIO");
    Console.WriteLine(thisDay.ToString(" dd/MM/yyyy"));
    Console.WriteLine("-------------------------------------\r\n");
    //INFORMAÇÃO
    
    Console.WriteLine("Qual o valor do salario atual do funcionario? ");
    salario = double.Parse(Console.ReadLine());
        
        //CALCULO
        if (salario <= 500.00)
        {
            total = (salario*15)/100;
            novo = salario + total;
            Console.WriteLine("O novo salário é: {0:N}", novo);
        }
        else
        { 
            if ((salario >= 500.01) && (salario <= 1000.00))
            {
            total = (salario*10)/100;
            novo = salario + total;
            Console.WriteLine("O novo salário é: {0:N}", novo);
            }
            if (salario >= 1000.1)
            {
                total = (salario*5)/100;
                novo = salario + total;
                Console.WriteLine("O novo salário é: {0:N}", novo);
            }
        }
    }
}
