using System;

public class CalcularIdade
{
    public static void Main(string[] args)
    {
        try
        {
            Console.Write("Digite sua data de nascimento neste formato (dd/mm/aaaa): ");
            DateTime dataNascimento = DateTime.Parse(Console.ReadLine());

            DateTime dataAtual = DateTime.Now;

            int anos = dataAtual.Year - dataNascimento.Year;
            int meses = dataAtual.Month - dataNascimento.Month;
            int dias = dataAtual.Day - dataNascimento.Day;

            if (dias < 0)
            {
                meses--;
                dias += DateTime.DaysInMonth(dataNascimento.Year, dataNascimento.Month);
            }

            if (meses < 0)
            {
                anos--;
                meses += 12;
            }

            Console.WriteLine($"Sua idade é: {anos} anos, {meses} meses e {dias} dias.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Formato de data inválido. Use dd/mm/aaaa.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro: {ex.Message}");
        }
    }
}
