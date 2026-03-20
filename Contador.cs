//Encapsulamiento basico y estado interno de una clase

class Contador
{
    private int Valor;

    public Contador()
    {
        Valor = 0;
    }

    public void Incrementar()
    {
        Valor++;
    }

    public void Decrementar()
    {
        Valor--;
    }
}