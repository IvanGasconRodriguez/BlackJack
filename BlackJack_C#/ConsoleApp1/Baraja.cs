using System.Collections;
using System.Runtime.CompilerServices;

public class Baraja 
{
    class Carta
    {
        private string valor;
        private string palo;
        public int valorNumerico;


        public Carta(){}
        public Carta ( string valor, string palo, int valorNumerico)
        {
            this.valor = valor;
            this.palo=palo;
            this.valorNumerico=valorNumerico;
        } 
    }
    public Baraja()
    {
        
        string [] valores = {"AS", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"};
        string [] palos = {"Corazones", "Diamantes", "Tréboles", "Picas"};

        foreach (string palo in palos)
        {
            for (int i = 0; i < valores.Length; i++)
            {
              int valorNumerico = (i < 9) ? i + 1 : 10;
              cartas.Add(new Carta(valores[i], palo, valorNumerico));  
            }

        }
        
    }
    public static List<object> cartas = new List<object>();
    public static void Barajar()
    {
          var rnd = new Random();
          var result = cartas.OrderBy(item => rnd.Next());

    }

    public   void RepartirCarta()//NO SE YO.....
    {
        Random rnd = new Random();
        int random = rnd.Next(0, cartas.Count);
        cartas.RemoveAt(random);

    }

    public void mostrarBaraja()
    {
        foreach (object carta in cartas)
        {
           System.Console.WriteLine(carta); 
        }
    }

    internal void mostrarBaraja(object cartas)
    {
        throw new NotImplementedException();
    }
}