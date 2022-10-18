class Program
{
    public static void Main(string[] args)
    {
        Numeros n = new Numeros();
        var listNumeros = n.GetNumber(10);

        foreach (var item in listNumeros)
        {
            System.Console.WriteLine (item);
        }
    }
}
