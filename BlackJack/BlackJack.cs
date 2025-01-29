// See https://aka.ms/new-console-template for more information


if(jugador1.calcularValorCartas()>21){
    System.Console.WriteLine("Gana la Banca");
}else{
    if(jugador1.calcularValorCarta()>jugador2.calcularValorCarta()){
        System.Console.WriteLine("Gana Jugador 1");
    }else{
        System.Console.WriteLine("Gana la Banca");
    }
}