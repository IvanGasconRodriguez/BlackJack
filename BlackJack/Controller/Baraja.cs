
public class Baraja {   //creamos carta, constructor ,setter y toString
    class Carta {
        public String valor;
        public String palo;
        int valorNumerico;

        public Carta(String valor, String palo, int valorNumerico) {
            this.valor = valor;
            this.palo = palo;
            this.valorNumerico = valorNumerico;
        }

        //@Override(mirar)
        public string toString() {
            return valor + " de " + palo;
        }
    }

    public List<Carta> cartas;
    //Cambio a public por error 

    //Creamos la baraja y asignamos valores
    public Baraja() {
        cartas = new ArrayList<>();
        string[] valores = {"AS", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"};
        string[] palos = {"Corazones", "Diamantes", "Tréboles", "Picas"};

        foreach (string palo in palos) {
            for (int i = 0; i < valores.Length; i++) {
                int valorNumerico = (i < 9) ? i + 1 : 10; // Asigna valores numéricos
                cartas.Add(new Carta(valores[i], palo, valorNumerico));
            }
        }
    }

    //barajamos las cartas

    public void barajar() {
        Collections.shuffle(cartas);
    }

    public Carta repartirCarta() {
        return cartas.Remove(0);
    }

    public void mostrarBaraja() {
        foreach (object carta in cartas) {
            System.Console.WriteLine(carta);
        }
    }
}