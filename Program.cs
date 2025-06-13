﻿double salarioHora, horasTrabalhadas, horasExtras;

Console.Clear();

Console.WriteLine("--- Cálculo de Salário Mensal ---\n");


Console.Write("informe o salario por hora: ");
salarioHora = Convert.ToDouble(Console.ReadLine());

Console.Write("informe as horas trabalhadas: ");
horasTrabalhadas = Convert.ToDouble(Console.ReadLine());
        
Console.Write("informe a quantidade de horas Extras: ");
horasExtras = Convert.ToDouble(Console.ReadLine());


 double salario = Calcular(salarioHora, horasTrabalhadas, horasExtras);
        
 Console.WriteLine("Salário total: R$ " + salario.ToString("F2"));
    

static double Calcular(double salarioHora, double horasTrabalhadas, double horasExtras)
{
double salario = salarioHora * horasTrabalhadas;
double valorHorasExtra = salarioHora * 1.4;
double salarioHorasExtras = valorHorasExtra * horasExtras;

double salarioFinal = salario + salarioHorasExtras;
return salarioFinal;
        
}
