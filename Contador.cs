//Encapsulamiento basico y estado interno de una clase

class Contador
{
    private int Valor;

    public int Contador()
    {
        Valor = 0;
    }

    public int Incrementar()
    {
        Valor++;
        return Valor;
    }

    public int  Decrementar()
    {
        Valor--;
        return Valor;
    }
}