class Gato : ISonido
{
    public string HacerSonido()
    {
        Console.WriteLine("El gato hace: Miau");
        return "Miau";
    }
}