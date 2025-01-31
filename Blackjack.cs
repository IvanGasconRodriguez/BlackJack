using System;
using System.Collections.Generic;
using System.Linq;

public class Blackjack
{
    public static void Main(string[] args)
    {
        Baraja baraja = new Baraja();
        baraja.MostrarBaraja();

        baraja.Barajar();
        Console.WriteLine("\nBaraja barajada:");
        baraja.MostrarBaraja();

        Jugador jugador1 = new Jugador("Jugador 1");
        Jugador jugador2 = new Jugador("Jugador 2");
        Jugador banca = new Jugador("Banca");

        // Repartición de 2 cartas a cada jugador
        for (int i = 0; i < 2; i++)
        {
            jugador1.RecibirCarta(baraja.RepartirCarta());
            jugador2.RecibirCarta(baraja.RepartirCarta());
            banca.RecibirCarta(baraja.RepartirCarta());
        }

        // Mostrar las cartas de los jugadores
        jugador1.MostrarCartas();
        jugador2.MostrarCartas();
        banca.MostrarCartas();

        // Repartimos cartas adicionales si el valor de las cartas es < 17
        while (jugador1.CalcularValorCartas() < 17)
        {
            jugador1.RecibirCarta(baraja.RepartirCarta());
        }
        while (jugador2.CalcularValorCartas() < 17)
        {
            jugador2.RecibirCarta(baraja.RepartirCarta());
        }
        while (banca.CalcularValorCartas() < 17)
        {
            banca.RecibirCarta(baraja.RepartirCarta());
        }

        // Mostramos las cartas finales de cada jugador
        Console.WriteLine("\nCartas finales:");
        Console.WriteLine(jugador1.Nombre + ": " + string.Join(" ", jugador1.Reparto) + " (Valor: " + jugador1.CalcularValorCartas() + ")");
        Console.WriteLine(jugador2.Nombre + ": " + string.Join(" ", jugador2.Reparto) + " (Valor: " + jugador2.CalcularValorCartas() + ")");
        Console.WriteLine(banca.Nombre + ": " + string.Join(" ", banca.Reparto) + " (Valor: " + banca.CalcularValorCartas() + ")");

        // Determinamos quien gana
        Jugador ganador = DeterminarGanador(jugador1, jugador2, banca);

        Console.WriteLine("\n¡El ganador es: " + ganador.Nombre + "!");
    }

    static Jugador DeterminarGanador(Jugador jugador1, Jugador jugador2, Jugador banca)
    {
        // Función para calcular la mejor puntuación (la más cercana a 21 sin pasarse)
        Func<Jugador, int> calcularMejorPuntuacion = jugador =>
        {
            int puntuacion = jugador.CalcularValorCartas();
            return puntuacion > 21 ? 0 : puntuacion; // 0 si se pasa de 21
        };

        int puntuacionJugador1 = calcularMejorPuntuacion(jugador1);
        int puntuacionJugador2 = calcularMejorPuntuacion(jugador2);
        int puntuacionBanca = calcularMejorPuntuacion(banca);

        // Encontrar la puntuación máxima
        int maxPuntuacion = Math.Max(puntuacionJugador1, Math.Max(puntuacionJugador2, puntuacionBanca));

        // Si nadie tiene una puntuación válida, no hay ganador
        if (maxPuntuacion == 0)
        {
            Console.WriteLine("¡Nadie gana! Todos se han pasado de 21.");
            return null; // O puedes devolver un jugador "virtual" sin nombre
        }

        // Encontrar al jugador con la puntuación máxima
        if (puntuacionJugador1 == maxPuntuacion) return jugador1;
        if (puntuacionJugador2 == maxPuntuacion) return jugador2;
        return banca;
    
    }
}