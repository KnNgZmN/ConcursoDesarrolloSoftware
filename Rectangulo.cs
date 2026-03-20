class Rectangulo : Figura
{
    private double Base { get; set; }
    private double Altura { get; set; }

    public Rectangulo(double baseRectangulo, double altura)
    {
        Base = baseRectangulo;
        Altura = altura;
    }

    public override double CalcularArea()
    {
        return Base * Altura;
    }
}