using System;


class Tabuada
{
    public static string GerarTabuada(int numero)
    {
        string tabuada = "";

        for (int i = 1; i <= 10; i++)
        {
            int resultado = numero * i;
            tabuada += $"{numero} x {i} = {resultado}\n";
        }

        return tabuada;
    }
}
