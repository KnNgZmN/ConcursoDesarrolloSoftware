// Sistema de Empleados (Polimorfismo)

using System;
class Empleado
{
    public string Nombre { get; set; }
    public double Salario { get; set; }

    public Empleado(string nombre, double salario)
    {
        Nombre = nombre;
        Salario = salario;
    }

    public virtual double CalcularSalario()
    {
        return Salario;
    }
}