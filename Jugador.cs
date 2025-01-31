using System;
using System.Collections.Generic;
using System.Linq;

public class Jugador
{
    public string Nombre { get; set; }
    public List<Baraja.Carta> Reparto { get; set; }

    public Jugador(string nombre)
    {
        Nombre = nombre;
        Reparto = new List<Baraja.Carta>();
    }

    public void RecibirCarta(Baraja.Carta carta)
    {
        Reparto.Add(carta);
    }

    public void MostrarCartas()
    {
        Console.Write(Nombre + ": ");
        foreach (Baraja.Carta carta in Reparto)
        {
            Console.Write(carta + " ");
        }
        Console.WriteLine();
    }

    public int CalcularValorCartas()
    {
        int valorTotal = 0;
        foreach (Baraja.Carta carta in Reparto)
        {
            valorTotal += carta.ValorNumerico;
        }
        return valorTotal;
    }
}