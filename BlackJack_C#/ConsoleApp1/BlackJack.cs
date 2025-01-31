
public class BlackJack
{
    public static void Main(string[]args)
    {
        Baraja baraja = new Baraja();
        baraja.mostrarBaraja();

        //baraja.barajar();
        //baraja.mostrarBaraja();

        System.Console.WriteLine("Introduce tu nombre");
        string nombre = Console.ReadLine();
        Jugador jugador1 = new Jugador(nombre);
        Jugador jugador2 = new Jugador("Banca");

        jugador1.recibirCarta();
        jugador2.recibirCarta();

        System.Console.WriteLine("Tus cartas son:");
        jugador1.mostrarCartas();
        jugador2.mostrarCartas();

        bool parar = false;
        while (!parar) {
            jugador1.recibirCarta();
            System.Console.WriteLine("¿Quieres seguir jugando?\n"+
                                                          "S/N");
            char siNo = Console.ReadKey().KeyChar;    
            if(siNo=='N'){
                parar=true;
            }                                      


        }
        //Comento esta parte porque da muchos errores por valorNumerico
        //(en principio deberia funcionar cuando se arregle valorNumerico)

       /* while (.calcularValorCartas() < 17) {
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
        } */




        


    }
}
