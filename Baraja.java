package Controller;

import java.util.ArrayList;
import java.util.List;

public class Baraja
{
    private String valor;
    private String palo;

    public Baraja(String valor, String palo)
    {
        this.valor = valor;
        this.palo = palo;
    }

    public String getValor()
    {
        return valor;
    }

    public String getPalo()
    {
        return palo;
    }

    @Override
    public String toString()
    {
        return valor + " de " + palo;
    }
}