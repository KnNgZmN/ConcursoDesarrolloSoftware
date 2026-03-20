using System;
class EmpleadoPorHoras : Empleado
{
    public EmpleadoPorHoras(string nombre, double salario) : base(nombre, salario)
    {
    }

    private double valorHora { get; set; }
    private double horas { get; set; }

    public override double CalcularSalario()
    {
        return valorHora * horas;
    }
}