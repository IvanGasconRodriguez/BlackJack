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
            Console.Write(carta + ", ");
        }
        Console.WriteLine(" (Valor: " + CalcularValorCartas() + ")");
    }

   
    public int CalcularValorCartas()
    {
        int valorTotal = 0;
        foreach (Baraja.Carta carta in Reparto)
        {
            
            switch(carta.Valor)
            {
                case "AS":
                valorTotal++;
                break;
                case "2":
                valorTotal+=2;
                break;
                case "3":
                valorTotal+=3;
                break;
                case "4":
                valorTotal+=4;
                break;
                case "5":
                valorTotal+=5;
                break;
                case "6":
                valorTotal+=6;
                break;
                case "7":
                valorTotal+=7;
                break;
                case "8":
                valorTotal+=8;
                break;
                case "9":
                valorTotal+=9;
                break;
                case "10":
                valorTotal+=10;
                break;
                case "J":
                valorTotal+=10;
                break;
                case "Q":
                valorTotal+=10;
                break;
                case "K":
                valorTotal+=10;
                break;
                

            


            }
        }
        return valorTotal;
    }
    
}