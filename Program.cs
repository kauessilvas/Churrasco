Console.Clear();

Console.Write("Informe a quantidade de adultos que consomem bebidas alcoólicas: ");
int adultosComAlcool = int.Parse(Console.ReadLine()!);
Console.Write("Informe a quantidade de adultos que não consomem bebidas alcoólicas: ");
int adultosSemAlcool = int.Parse(Console.ReadLine()!);
Console.Write("Informe a quantidade de crianças: ");
int criancas = int.Parse(Console.ReadLine()!);

Churrasco newChurrasco = new Churrasco(adultosComAlcool, adultosSemAlcool, criancas);
newChurrasco.GerarRelatorio();

class Churrasco
{
    public int AdultosComAlcool { get; set; }
    public int AdultosSemAlcool { get; set; }
    public int Criancas { get; set; }
    public Churrasco(int adultosComAlcool, int adultosSemAlcool, int criancas)
    {
        AdultosComAlcool = adultosComAlcool;
        AdultosSemAlcool = adultosSemAlcool;
        Criancas = criancas;
    }
    public double CalcularCarneKg()
    {
        int totalGramas = (AdultosComAlcool + AdultosSemAlcool) * 400 + Criancas * 200;
        return totalGramas / 1000.0;
    }

    public double CalcularAcompanhamentosKg()
    {
        int totalGramas = (AdultosComAlcool + AdultosSemAlcool + Criancas) * 200;
        return totalGramas / 1000.0;
    }

    public double CalcularCervejaLitros()
    {
        return AdultosComAlcool * 2;
    }

    public double CalcularRefrigeranteLitros()
    {
        int totalMl = (AdultosSemAlcool + Criancas) * 500;
        return totalMl / 1000.0;
    }

    public double CalcularAguaLitros()
    {
        int totalMl = (AdultosComAlcool + AdultosSemAlcool + Criancas) * 400;
        return totalMl / 1000.0;
    }
    public void GerarRelatorio()
    {
        Console.WriteLine("\n--- Churrasco ---\n");
        Console.WriteLine($"Adultos (que consomem bebidas alcoólicas).......: {AdultosComAlcool}");
        Console.WriteLine($"Adultos (que não consomem bebidas alcoólicas)...: {AdultosSemAlcool}");
        Console.WriteLine($"Crianças........................................: {Criancas}\n");

        Console.WriteLine($"Carne.............: {CalcularCarneKg():0.0}kg");
        Console.WriteLine($"Acompanhamentos...: {CalcularAcompanhamentosKg():0.0}kg");
        Console.WriteLine($"Cerveja...........: {CalcularCervejaLitros():0.0}l");
        Console.WriteLine($"Refrigerante......: {CalcularRefrigeranteLitros():0.0}l");
        Console.WriteLine($"Água..............: {CalcularAguaLitros():0.0}l");
    }
}
