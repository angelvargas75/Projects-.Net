class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Pidiendo una pizza de pepperoni con mi amigo");
        Console.WriteLine("============================================");
        Console.WriteLine();

        Task t1 = PrimeraEspera();
        t1.Wait();

        Task t2 = EsperandoLaPizza();
        t2.Wait();
        Console.WriteLine("BUEN PROVECHO!");
        Console.WriteLine();
        HablandoDeFutbol();
        Console.WriteLine("Pulse cualquier tecla para finalizar...");
        Console.ReadKey(true);
    }

    private static async void HablandoDeFutbol()
    {
        Console.WriteLine("...hablando de futbol...");
        Console.WriteLine("Bla bla bla....");
        Console.WriteLine();
    }

    private static async Task<Pizza> EsperandoLaPizza()
    {
        Pizzeria dominos = new Pizzeria();
        var task = dominos.ServirPizza("Pepperoni");
        task.Start();
        HablandoDeFutbol();

        // Llego el empleado, hacemos el pedido y nos quedamos esperando
        var miPizza = await task;
        await Task.Delay(10000);
        System
            .Console
            .WriteLine("Nos traen la pizza de {0} a las {1}",
            miPizza.Tipo,
            DateTime.Now.ToString("T"));

        return miPizza;
    }

    private static async Task PrimeraEspera()
    {
        Pizza miPizza = new Pizza("Pepperoni");
        System
            .Console
            .WriteLine("Llegamos a la pizzeria a las {0} y esperamos para hacer el pedido...",
            DateTime.Now.ToString("T"));
        HablandoDeFutbol();
        await Task.Delay(10000);
        System
            .Console
            .WriteLine("Pedimos un pizza de {0} a las {1}",
            miPizza.Tipo,
            DateTime.Now.ToString("T"));
    }
}
