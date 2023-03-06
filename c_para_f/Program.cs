internal class Program
{
    static double ConverterParaFahrenheit(double temperaturaC)
    {
        return ((temperaturaC * 9) / 5) + 32;
    }

    private static void Main(string[] args)
    {
        double tc, tf;

        Console.WriteLine("Informe a temperatura: ");
        tc = double.Parse(Console.ReadLine());

        tf = ConverterParaFahrenheit(tc);

        Console.WriteLine($"A temperatura {tc} em gruas Celsius, é {tf.ToString("F2")} em graus Fahrenheit!");
    }
}