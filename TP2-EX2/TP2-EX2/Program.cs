using System;

public class CalcularIdade
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite sua data de nascimento neste formato (dd/mm/aaaa): ");
        DateTime dataNascimento = DateTime.Parse(Console.ReadLine());

        DateTime dataAtual = DateTime.Now;

        DateTime proximoAniversario = new DateTime(dataAtual.Year, dataNascimento.Month, dataNascimento.Day);

        if (proximoAniversario < dataAtual)
        {
            proximoAniversario = proximoAniversario.AddYears(1);
        }

        TimeSpan diferenca = proximoAniversario - dataAtual;

        Console.WriteLine($"Faltam {diferenca.Days} dias para o seu próximo aniversário.");
    } 
}