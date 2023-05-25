//Herencia 3 SUV
internal class SUV : VehiculoBase
{
    public int CapacidadPasajeros { get; set; }
    public bool TerceraFilaAsientos { get; set; }

    public SUV(string marca, string modelo, string color, int anio, string placa, int capacidadPasajeros, bool terceraFilaAsientos)
        : base(marca, modelo, color, anio, placa, "SUV", 180)
    {
        CapacidadPasajeros = capacidadPasajeros;
        TerceraFilaAsientos = terceraFilaAsientos;
    }

    public void ActivarModoOffRoad()
    {
        Console.WriteLine("Modo off-road activado");
    }
}