package Controller;

import java.util.ArrayList;
import java.util.List;

public class Jugador
    {
        public String nombre;
        public List<Baraja.Carta> reparto;

        public Jugador(String nombre) {
            this.nombre = nombre;
            this.reparto = new ArrayList<>();
        }

        public void recibirCarta(Baraja.Carta carta)
        {
            reparto.add(carta);

        }

        public void mostrarCartas()
        {
            System.out.print(nombre + ": ");
            for (Baraja.Carta carta : reparto) {
                System.out.print(carta + " ");
            }
            System.out.println();
        }
        public int calcularValorCartas() {
            int valorTotal = 0;
            for (Baraja.Carta carta : reparto) {
                valorTotal += carta.valorNumerico;
            }
            return valorTotal;
        }
    }
