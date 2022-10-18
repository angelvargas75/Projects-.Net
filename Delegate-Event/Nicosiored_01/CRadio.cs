class CRadio
{
    // metodo que actuara como delegado
    public static void MetodoRadio(string mensaje)
    {
        System.Console.ForegroundColor = ConsoleColor.Yellow;
        System.Console.WriteLine("Estamos en la clase Radio");
        System.Console.WriteLine("Este es tu mensaje: "+mensaje);
    }
}
