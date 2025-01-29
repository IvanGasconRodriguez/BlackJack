// See https://aka.ms/new-console-template for more information

public class Blackjack
{
    public static void Main(String[] args)
    {
       Baraja baraja = new Baraja();
       baraja.mostrarBaraja();

        baraja.barajar();
        System.Console.WriteLine("\nBaraja barajada:");
        baraja.mostrarBaraja();

        Jugador jugador1 = new Jugador("Jugador 1");
        Jugador banca = new Jugador("Banca");
        Jugador jugador3 = new Jugador("Jugador 3");

        // Repartición de 2 cartas a cada jugador
        for (int i = 0; i < 2; i++)
        {
            jugador1.recibirCarta(baraja.repartirCarta());
            banca.recibirCarta(baraja.repartirCarta());
            jugador3.recibirCarta(baraja.repartirCarta());
        }

        // Mostrar las cartas de los jugadores
        jugador1.mostrarCartas();
        banca.mostrarCartas();
        jugador3.mostrarCartas();

        // Repartimos cartas adicionales si el valor de las cartas es < 17
        bool parar = false;
        while (!parar) {
            jugador1.recibirCarta(baraja.repartirCarta());
            System.Console.WriteLine("¿Quieres seguir jugando?\n"+
                                                          "S/N");
            char siNo = Console.ReadKey().KeyChar;    
            if(siNo=='N'){
                parar=true;
            }                                      


        }
        while (banca.calcularValorCartas() < 17) {
            banca.recibirCarta(baraja.repartirCarta());
        }
        while (jugador3.calcularValorCartas() < 17) {
            jugador3.recibirCarta(baraja.repartirCarta());
        }

        // Mostrar las cartas finales de cada jugador
        System.Console.WriteLine("\nCartas finales:");
        System.Console.WriteLine(jugador1.nombre + ": " + jugador1.reparto + " (Valor: " + jugador1.calcularValorCartas() + ")");
        System.Console.WriteLine(banca.nombre + ": " + banca.reparto + " (Valor: " + banca.calcularValorCartas() + ")");
        System.Console.WriteLine(jugador3.nombre + ": " + jugador3.reparto + " (Valor: " + jugador3.calcularValorCartas() + ")");

        //Quién gana??
        if(jugador1.calcularValorCartas()>21){
            System.Console.WriteLine("Gana la Banca");
        }else{
            if(jugador1.calcularValorCartas()>banca.calcularValorCartas()){
               System.Console.WriteLine("Gana Jugador 1");
            }else{
               System.Console.WriteLine("Gana la Banca");
            }
        } 
    }

}

