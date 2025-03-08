using System;

public class DiferencaDatas
{
    public static void Main(string[] args)
    {
        Console.Write("Digite a primeira data (dd/mm/aaaa): ");
        DateTime data1 = DateTime.Parse(Console.ReadLine());

        Console.Write("Digite a segunda data (dd/mm/aaaa): ");
        DateTime data2 = DateTime.Parse(Console.ReadLine());

        TimeSpan diferenca = data2 - data1;

        int anos = (int)(diferenca.TotalDays / 365.25);
        int meses = (int)((diferenca.TotalDays % 365.25) / 30.4375);
        int dias = (int)((diferenca.TotalDays % 365.25) % 30.4375);

        Console.WriteLine($"A diferença entre as datas é: {anos} anos, {meses} meses e {dias} dias.");
    }
}