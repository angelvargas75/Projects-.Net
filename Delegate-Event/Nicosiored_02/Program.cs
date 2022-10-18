class Program
{
    public static void Main(string[] args)
    {
        // creamos el refri
        CRefri miRefri = new CRefri(70, -20);
        Random rdm = new Random();

        // adicionamos los handlers
        miRefri.AdicionaMetodoReserva(new CRefri.DReservasBajas(InformeKilos));
        miRefri.AdicionaMetodoDescongelado(new CRefri.DDescongelado(InformeGrados));

        // el refri trabaja
        while (miRefri.Kilos > 0)
        {
            miRefri.Trabajar(rdm.Next(1, 5));
        }
    }

    public static void InformeKilos(int kilos)
    {
        System.Console.ForegroundColor = ConsoleColor.Yellow;
        System.Console.WriteLine("Reserva bajas de alimentos, estoy a nivel de main");
        System.Console.WriteLine("Quedan {0} kilos", kilos);
    }

    public static void InformeGrados(int grados)
    {
        System.Console.ForegroundColor = ConsoleColor.Red;
        System.Console.WriteLine("Se descongela el refri, estoy a nivel de main");
        System.Console.WriteLine("Esta a {0} grados", grados);
    }
}
