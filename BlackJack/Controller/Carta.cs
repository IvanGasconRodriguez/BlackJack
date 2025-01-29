public class Carta
{
    public static List<Controller.Baraja> cartas;

    public static void main(string[] args)
    {

        string[] valores = {"AS", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"};
        string[] palos = {"Corazones", "Diamantes", "Treboles", "Picas"};

        cartas = new ArrayList<>();
        foreach (string palo in palos)
        {
            foreach (string valor in valores)
            {
                cartas.Add(new Controller.Baraja(valor, palo));
                System.Console.WriteLine(cartas);
            }
        }
    }
}