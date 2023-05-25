//Herencia 1 PickUp
internal class Pickup : VehiculoBase
{
    public int CapacidadCarga { get; set; }
    public bool DobleCabina { get; set; }

    public Pickup(string marca, string modelo, string color, int anio, string placa, int capacidadCarga, bool dobleCabina)
        : base(marca, modelo, color, anio, placa, "Pickup", 180)
    {
        CapacidadCarga = capacidadCarga;
        DobleCabina = dobleCabina;
    }

    public void ActivarTraccion4x4()
    {
        Console.WriteLine("Tracción 4x4 activada");
    }
}
