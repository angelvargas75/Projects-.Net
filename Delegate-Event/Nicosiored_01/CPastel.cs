class CPastel
{
    // metodo que actuara como delegado
    public static void MetodoPastel(string mensaje)
    {
        System.Console.ForegroundColor = ConsoleColor.Red;
        System.Console.WriteLine("Estamos en la clase Pastel");
        System.Console.WriteLine("Este es tu mensaje: "+mensaje);
    }
}