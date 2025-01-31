using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

public class Blackjack
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("******************************");
        System.Console.WriteLine("Bienvenido al juego de BlackJack de Ivan, Monica y Jose");
        System.Console.WriteLine("******************************");
        bool stopJuego = false;
        
        System.Console.WriteLine("Creando una nueva baraja");
        Baraja baraja = new Baraja();
        System.Console.WriteLine("¿Quieres ver la baraja?");
        System.Console.WriteLine("S/N");
        char siNo = Console.ReadKey().KeyChar;
        System.Console.WriteLine();
        if(siNo=='S')
        {
            baraja.MostrarBaraja();
        }
        System.Console.WriteLine("Introduce tu nombre para comenzar");
        string nombre = Console.ReadLine();
        Jugador jugador1 = new Jugador(nombre);
        while(!stopJuego)
        {
        System.Console.WriteLine("Pulsa enter para barajar");
        if(Console.ReadKey().Key==ConsoleKey.Enter)
        {
            System.Console.WriteLine("Barajando");
            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine(".");
            }
           baraja.Barajar(); 
        }
        Console.WriteLine("\nBaraja barajada");
        System.Console.WriteLine("Quieres ver como queda la baraja?");
        System.Console.WriteLine("S/N");
        char siNo2 = Console.ReadKey().KeyChar;
        System.Console.WriteLine();
        if(siNo2=='S')
        {
            baraja.MostrarBaraja();
        }
        Jugador banca = new Jugador("Banca");
        System.Console.WriteLine("Vamos a repartir las cartas");

        // Repartición de 2 cartas a cada jugador
        for (int i = 0; i < 2; i++)
        {
            jugador1.RecibirCarta(baraja.RepartirCarta());
            banca.RecibirCarta(baraja.RepartirCarta());
        }
        System.Console.WriteLine("Tus cartas son:");

        // Mostrar las cartas de los jugadores
        jugador1.MostrarCartas();
        bool parar = false;
        System.Console.WriteLine("¿Te plantas?\n"+
                                                          "S/N");
            char siNo3 = Console.ReadKey().KeyChar;
            System.Console.WriteLine();    
            if(siNo3=='N'){
                while (!parar) 
        {
            
            jugador1.RecibirCarta(baraja.RepartirCarta());
            jugador1.MostrarCartas();
            System.Console.WriteLine("¿Te plantas?\n"+
                                                          "S/N");
            char siNo4 = Console.ReadKey().KeyChar;
            System.Console.WriteLine();    
            if(siNo4=='S'){
                parar=true;
            }

        }
            }
        
        // Repartimos cartas adicionales si el valor de las cartas es < 17
        
        while (banca.CalcularValorCartas() < 17)
        {
            banca.RecibirCarta(baraja.RepartirCarta());
        }
        System.Console.WriteLine("Levantamos cartas");

        // Mostramos las cartas finales de cada jugador
        Console.WriteLine("\nCartas finales:");
        Console.WriteLine(jugador1.Nombre + ": " + string.Join(" ", jugador1.Reparto) + " (Valor: " + jugador1.CalcularValorCartas() + ")");
        Console.WriteLine(banca.Nombre + ": " + string.Join(" ", banca.Reparto) + " (Valor: " + banca.CalcularValorCartas() + ")");

        // Determinamos quien gana
        Jugador ganador = DeterminarGanador(jugador1, banca);
        
        System.Console.WriteLine("******************************");
        Console.WriteLine("\n¡El ganador es: " + ganador.Nombre + "!");
        System.Console.WriteLine("******************************");
        System.Console.WriteLine("¿Otra partida?");
        System.Console.WriteLine("S/N");
        char siNo5 = Console.ReadKey().KeyChar;
        System.Console.WriteLine();
            if(siNo5=='N')
            {
                stopJuego=true;
            }
        }   
    }

    static Jugador DeterminarGanador(Jugador jugador1, Jugador banca)
    {
        // Función para calcular la mejor puntuación (la más cercana a 21 sin pasarse)
        Func<Jugador, int> calcularMejorPuntuacion = jugador =>
        {
            int puntuacion = jugador.CalcularValorCartas();
            return puntuacion > 21 ? 0 : puntuacion; // 0 si se pasa de 21
        };

        int puntuacionJugador1 = calcularMejorPuntuacion(jugador1);
        int puntuacionBanca = calcularMejorPuntuacion(banca);

        // Encontrar la puntuación máxima
        int maxPuntuacion = Math.Max(puntuacionJugador1, puntuacionBanca);

        // Si nadie tiene una puntuación válida, no hay ganador
        if (maxPuntuacion == 0)
        {
            Console.WriteLine("¡Nadie gana! Todos se han pasado de 21.");
            return null; // O puedes devolver un jugador "virtual" sin nombre
        }

        // Encontrar al jugador con la puntuación máxima
        if (puntuacionJugador1 == maxPuntuacion) return jugador1;
        return banca;
    
    }
}