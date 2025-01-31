
 class Jugador
{
    private string nombre;
    public static List<object> reparto;
    
    public Jugador(string nombre)
    {
        this.nombre=nombre;
    }

    public void recibirCarta()
    {
        Random rnd = new Random();
        int random = rnd.Next(0, Baraja.cartas.Count);
        object carta = Baraja.cartas.ElementAt(random);
        reparto.Add(carta);
        Baraja.cartas.RemoveAt(random);
    }

    public void mostrarCartas()
    {
        foreach (object carta in reparto)
        {
            System.Console.WriteLine(carta);
        }
    }
    //Aqui es donde no me acepta valor numerico
    public static int calcularValorCartas() {
            int valorTotal = 0;
            foreach (object carta in reparto) 
            {
              valorTotal += carta.valorNumerico;
            }
            return valorTotal;
    }
}