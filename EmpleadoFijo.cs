class EmpleadoFijo : Empleado
{
    public EmpleadoFijo(string nombre, double salario) : base(nombre, salario)
    {
    }

    private double salarioFijo { get; set; }

    public override double CalcularSalario()
    {
        return Salario;
    }
}