// definimos el delegado a nivel de NameSpace
public delegate void MiDelegado(string m);

class Program
{
    public static void Main(string[] args)
    {
        // creamos un objeto del delegado y lo referenciamos a un metodo
        MiDelegado delegado = new MiDelegado(CRadio.MetodoRadio);
        delegado("HOLA MUNDO");

        // hacemos que apunte a otro metodo
        delegado = new MiDelegado(CPastel.MetodoPastel);
        delegado("FELIZ CUMPLEAÑOS");

        System.Console.ReadLine();
    }
}
