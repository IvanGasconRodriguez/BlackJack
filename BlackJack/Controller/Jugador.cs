
public class Jugador
    {
        public string nombre;
        public List<Baraja.Carta> reparto;

        public Jugador(string nombre) {
            this.nombre = nombre;
            this.reparto = new ArrayList<>();
        }

        public void recibirCarta(Baraja.Carta carta)
        {
            reparto.Add(carta);

        }

        public void mostrarCartas()
        {
            System.Console.WriteLine(nombre + ": ");
            foreach (Baraja.Carta carta in reparto) {
                System.Console.Write(carta + " ");
            }
            System.Console.WriteLine();
        }
        public int calcularValorCartas() {
            int valorTotal = 0;
            foreach (Baraja.Carta carta in reparto) {
                valorTotal += carta.valorNumerico;
            }
            return valorTotal;
        }
    }