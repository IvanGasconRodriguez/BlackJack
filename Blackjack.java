import Controller.Baraja;
import Controller.Jugador;


import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class Blackjack
{
    public static void main(String[] args)
    {
       Baraja baraja = new Baraja();
       baraja.mostrarBaraja();

        baraja.barajar();
        System.out.println("\nBaraja barajada:");
        baraja.mostrarBaraja();

        Jugador jugador1 = new Jugador("Jugador 1");
        Jugador jugador2 = new Jugador("Jugador 2");
        Jugador jugador3 = new Jugador("Jugador 3");

        // Repartición de 2 cartas a cada jugador
        for (int i = 0; i < 2; i++)
        {
            jugador1.recibirCarta(baraja.repartirCarta());
            jugador2.recibirCarta(baraja.repartirCarta());
            jugador3.recibirCarta(baraja.repartirCarta());
        }

        // Mostrar las cartas de los jugadores
        jugador1.mostrarCartas();
        jugador2.mostrarCartas();
        jugador3.mostrarCartas();

        // Repartimos cartas adicionales si el valor de las cartas es < 17
        while (jugador1.calcularValorCartas() < 17) {
            jugador1.recibirCarta(baraja.repartirCarta());

        }
        while (jugador2.calcularValorCartas() < 17) {
            jugador2.recibirCarta(baraja.repartirCarta());
        }
        while (jugador3.calcularValorCartas() < 17) {
            jugador3.recibirCarta(baraja.repartirCarta());
        }

        // Mostrar las cartas finales de cada jugador
        System.out.println("\nCartas finales:");
        System.out.println(jugador1.nombre + ": " + jugador1.reparto + " (Valor: " + jugador1.calcularValorCartas() + ")");
        System.out.println(jugador2.nombre + ": " + jugador2.reparto + " (Valor: " + jugador2.calcularValorCartas() + ")");
        System.out.println(jugador3.nombre + ": " + jugador3.reparto + " (Valor: " + jugador3.calcularValorCartas() + ")");

        //Quién gana??
    }

}
