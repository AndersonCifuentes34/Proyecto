//Vehiculo Base
using ProyectoFinalP1.Clases;

internal class VehiculoBase : IVehiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public string Color { get; set; }
    public int Anio { get; set; }
    public string Placa { get; set; }
    public string Tipo { get; set; }
    public int VelocidadMaxima { get; private set; }
    public int VelocidadActual { get; private set; }

    public VehiculoBase(string marca, string modelo, string color, int anio, string placa, string tipo, int velocidadMaxima)
    {
        Marca = marca;
        Modelo = modelo;
        Color = color;
        Anio = anio;
        Placa = placa;
        Tipo = tipo;
        VelocidadMaxima = velocidadMaxima;
        VelocidadActual = 0;
    }

    public void Bocina()
    {
        Console.WriteLine("BEEP BEEP");
    }

    public void Acelerar(int cuanto)
    {
        if (cuanto < 0)
        {
            throw new ArgumentException();
        }

        if (VelocidadActual + cuanto > VelocidadMaxima)
        {
            VelocidadActual = VelocidadMaxima;
        }
        else
        {
            VelocidadActual += cuanto;
        }
    }

    public void Encender()
    {
        Console.WriteLine("Encendiendo el vehículo");
    }

    public void Apagar()
    {
        Console.WriteLine("Apagando el vehículo");
    }

    public void Frenar(int cuanto)
    {
        if (cuanto < 0)
        {
            throw new ArgumentException();
        }

        if (VelocidadActual - cuanto < 0)
        {
            VelocidadActual = 0;
        }
        else
        {
            VelocidadActual -= cuanto;
        }
    }
}