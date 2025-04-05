using System;
public class Carro
{
    // Campos da classe
    public string cor;
    public string marca;
    public string modelo;

    // Método da classe
    public void Ligar()
    {
        Console.WriteLine("O carro está ligado");
    }
}

public class Program
{
    public static void Main()
    {
        // Instanciando um objeto da classe Carro
        Carro minhaMaquina = new Carro();
        minhaMaquina.cor = "Cinza claro";
        minhaMaquina.marca = "Porsche";
        minhaMaquina.modelo = "911 Carrera 85";

        Console.WriteLine($"Detalhes do carro: \nCor: {minhaMaquina.cor} \nMarca: {minhaMaquina.marca} \nModelo: {minhaMaquina.modelo}");

        minhaMaquina.Ligar();
    }
}