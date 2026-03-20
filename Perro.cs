class perro : ISonido
{
    public string HacerSonido()
    {
        Console.WriteLine("El perro hace: Guau");
        return "Guau";
    }
}