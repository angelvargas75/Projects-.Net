 // delegados
    public delegate void DReservasBajas(int kilos);
    public delegate void DDescongelado(int grados);

class CRefri
{
    private int kilosAlimentos = 0;
    private int grados = 0;

    // variables que usaremos para invocar
    private DReservasBajas delReservas;
    private DDescongelado delDescongelado;

    public CRefri(int pKilos, int pGrados)
    {
        kilosAlimentos = pKilos;
        grados = pGrados;
    }

    // Estos metodos permiten referenciar las variables
    public void AdicionaMetodoReserva(DReservasBajas metodo)
    {
        delReservas += metodo;
    }

    public void EliminaMetodoReserva(DReservasBajas metodo)
    {
        delDescongelado -= metodo;
    }

    public void AdicionaMetodoDescongelado(DDescongelado metodo)
    {
        delDescongelado += metodo;
    }

    // propiedades
    public int Kilos
    {
        get
        {
            return kilosAlimentos;
        }
        set
        {
            kilosAlimentos = value;
        }
    }

    public int Grados
    {
        get
        {
            return grados;
        }
        set
        {
            grados = value;
        }
    }

    public void Trabajar(int consumo)
    {
        // actualizamos los kilos del refri
        kilosAlimentos -= consumo;

        // subimos la temperatura
        grados += 1;

        System.Console.ForegroundColor = ConsoleColor.Gray;
        System.Console.WriteLine("{0} kilos, {1} grados", kilosAlimentos, grados);

        // hay que verificar si se cumple la condicion para invocar a los handlers del evento
        // condicion del evento para kilos
        if (kilosAlimentos < 10) 
            delReservas(kilosAlimentos);

        // condicion del evento para temperatura
        if (grados > 0) 
            delDescongelado(grados);
    }
}
