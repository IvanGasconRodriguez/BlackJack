import Controller.Baraja;

import java.util.ArrayList;
import java.util.List;

import static java.lang.System.in;

public class Carta
{
    private static List<Controller.Baraja> cartas;

    public static void main(String[] args)
    {

        String[] valores = {"AS", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"};
        String[] palos = {"Corazones", "Diamantes", "Treboles", "Picas"};

        cartas = new ArrayList<>();
        for (String palo: palos)
        {
            for (String valor: valores)
            {
                cartas.add(new Controller.Baraja(valor, palo));
                System.out.println(cartas);
            }
        }
    }
}