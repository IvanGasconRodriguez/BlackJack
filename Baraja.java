package Controller;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class Baraja {   //creamos carta, constructor ,setter y toString
    class Carta {
        private String valor;
        private String palo;
        int valorNumerico;

        public Carta(String valor, String palo, int valorNumerico) {
            this.valor = valor;
            this.palo = palo;
            this.valorNumerico = valorNumerico;
        }

        @Override
        public String toString() {
            return valor + " de " + palo;
        }
    }

    private List<Carta> cartas;

    //Creamos la baraja y asignamos valores
    public Baraja() {
        cartas = new ArrayList<>();
        String[] valores = {"AS", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"};
        String[] palos = {"Corazones", "Diamantes", "Tréboles", "Picas"};

        for (String palo : palos) {
            for (int i = 0; i < valores.length; i++) {
                int valorNumerico = (i < 9) ? i + 1 : 10; // Asigna valores numéricos
                cartas.add(new Carta(valores[i], palo, valorNumerico));
            }
        }
    }

    //barajamos las cartas

    public void barajar() {
        Collections.shuffle(cartas);
    }

    public Carta repartirCarta() {
        return cartas.remove(0);
    }

    public void mostrarBaraja() {
        for (Carta carta : cartas) {
            System.out.println(carta);
        }
    }
}
