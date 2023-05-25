//Herencia 2 Sedan
internal class Sedan : VehiculoBase
{
    public int NumeroPuertas { get; set; }
    public bool EsDeportivo { get; set; }

    public Sedan(string marca, string modelo, string color, int anio, string placa, int numeroPuertas, bool esDeportivo)
        : base(marca, modelo, color, anio, placa, "Sedan", 200)
    {
        NumeroPuertas = numeroPuertas;
        EsDeportivo = esDeportivo;
    }

    public void ReproducirMusica()
    {
        Console.WriteLine("Reproduciendo música en el sedan");
    }
}