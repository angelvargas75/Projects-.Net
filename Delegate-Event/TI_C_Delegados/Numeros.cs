using System;
class Numeros
{
    public List<int> GetNumber(int max)
    {
        List<int> lista = new List<int>();
        MostraMensajeDelegado delegado1;
        //MostrarMensajeDelegado2 delegado2;
        for (int i = 1; i < max; i++)
        {
            delegado1 = ImprimirMensaje;
            System.Console.WriteLine(delegado1(i));
            //delegado2 = ImprimirMensaje;
            //delegado2(i);
            if (i % 2 == 0)
            {
                lista.Add (i);
                System.Threading.Thread.Sleep(1000);
            }
        }
        return lista;
    }

    public delegate string MostraMensajeDelegado(int num);
    //Func<int, string> MostrarMensajeDelegado2;

    public string ImprimirMensaje(int n){
        string res = $"Procesando {n}...";
        return res;
    }
}
