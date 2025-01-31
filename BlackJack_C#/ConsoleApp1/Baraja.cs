using System;
using System.Collections.Generic;
using System.Linq;

public class Baraja
{
    public class Carta
    {
        public string Valor { get; set; }
        public string Palo { get; set; }
        //public int ValorNumerico { get; set; }

        public Carta(string valor, string palo)
        {
            this.Valor = valor;
            this.Palo = palo;
            //this.ValorNumerico = valorNumerico;
        }

        public override string ToString()
        {
            return $"{Valor} de {Palo}";
        }
    }

    private List<Carta> cartas;

    public Baraja()
    {
        cartas = new List<Carta>();
        string[] valores = { "AS", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
        string[] palos = { "Corazones", "Diamantes", "Tréboles", "Picas" };

        foreach (string palo in palos)
        {
            for (int i = 0; i < valores.Length; i++)
            {
                //int valorNumerico = (i < 9) ? i + 1 : 10;
                cartas.Add(new Carta(valores[i], palo));
            }
        }
    }

    public void Barajar()
    {
        Random rng = new Random();
        cartas = cartas.OrderBy(a => rng.Next()).ToList();
    }

    public Carta RepartirCarta()
    {
        Carta carta = cartas[0];
        cartas.RemoveAt(0);
        return carta;
    }

    public void MostrarBaraja()
    {
        foreach (Carta carta in cartas)
        {
            Console.WriteLine(carta);
        }
    }
}