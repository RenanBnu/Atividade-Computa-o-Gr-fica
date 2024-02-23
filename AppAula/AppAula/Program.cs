public class AppAula
{
    public static void Main()
    {
        //determinaBissexto();
        //fibonaci();
        validaTemperatura();
    }

    public static void determinaBissexto()
    {
        Console.WriteLine("Por gentileza, informe o ano: ");
        var ano = Int32.Parse(Console.ReadLine());

        if (DateTime.IsLeapYear(ano))
            Console.WriteLine("Ano bissexto");

    }

    public static void fibonaci()
    {
        int numeroAnterior = 0;
        int numeroAtual = 1;
        int novoNumero;
        int fibonacci;

        Console.WriteLine("Informe a quantidade de vezes: ");
        var qtt = Int32.Parse(Console.ReadLine());

        for (int i = 0; i < qtt; i++)
        {
            fibonacci = numeroAnterior + numeroAtual;
            Console.WriteLine(fibonacci);
            numeroAnterior = numeroAtual;
            numeroAtual = fibonacci;
        }
    }

    public static void validaTemperatura()
    {
        Console.WriteLine("Informe a temperatura: ");
        var temperatura = Console.ReadLine();

        if (Convert.ToDecimal(temperatura) > 35)
        {
            Console.WriteLine("Precisa usar protetor solar");
        }
        else
            Console.WriteLine("Não precisa de protetor");
    }
}