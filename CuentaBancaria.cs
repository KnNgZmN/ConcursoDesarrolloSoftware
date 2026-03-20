// Cuenta Bancaria (Encapsulamiento)
using System;
class CuentaBancaria
{
    private double Saldo;

    public CuentaBancaria(double saldoInicial)
    {
        Saldo = saldoInicial;
    }

    public double Depositar(double cantidad)
    {
        if (cantidad > 0)
        {
            Saldo += cantidad;
            Console.WriteLine($"Depositado: {cantidad}. Nuevo saldo: {Saldo}");
        }
        else
        {
            Console.WriteLine("Cantidad a depositar debe ser mayor a 0.");
        }
        return Saldo;
    }
    public bool Retirar(double cantidad)
    {
        if (cantidad > 0 && cantidad <= Saldo)
        {
            Saldo -= cantidad;
            Console.WriteLine($"Retirado: {cantidad}. Nuevo saldo: {Saldo}");
            return true;
        }
        else
        {
            Console.WriteLine("Cantidad a retirar debe ser mayor a 0 y no exceder el saldo disponible");
            return false;
        }
    }
    public double ObtenerSaldo()
    {
        return Saldo;
    }
}