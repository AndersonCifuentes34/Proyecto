//Program
internal class Program
{
    private static int opcion;

    public static void Main(string[] args)
    {
        Console.WriteLine("Elige un Vehiculo:");
        Console.WriteLine("1. PickUp");
        Console.WriteLine("2. Sedan");
        Console.WriteLine("3. SUV");
        Console.Write("Opción: ");

        int opcion = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        switch (opcion)
        {
            case 1:
                var pickup = new Pickup("Ford", "Ranger", "Rojo", 2022, "ABC123", 1000, true);
                pickup.Encender();
                Console.WriteLine($"Velocidad Actual: {0} Km/h");
                pickup.Acelerar(50);
                Console.WriteLine($"Velocidad al Acelerar: {pickup.VelocidadActual} Km/h");
                pickup.Frenar(20);
                Console.WriteLine($"Velocidad del pickup después de frenar: {pickup.VelocidadActual} Km/h");
                pickup.Bocina();
                pickup.ActivarTraccion4x4();
                pickup.Apagar();
                Console.WriteLine();
                break;

            case 2:
                var sedan = new Sedan("Honda", "Civic", "Azul", 2022, "DEF456", 4, false);
                sedan.Encender();
                Console.WriteLine($"Velocidad Actual: {0} Km/h");
                sedan.Acelerar(30);
                Console.WriteLine($"Velocidad al Acelerar: {sedan.VelocidadActual} Km/h");
                sedan.Frenar(10);
                Console.WriteLine($"Velocidad del sedan después de frenar: {sedan.VelocidadActual} Km/h");
                sedan.Bocina();
                sedan.ReproducirMusica();
                sedan.Apagar();
                Console.WriteLine();
                break;

            case 3:
                var suv = new SUV("Toyota", "RAV4", "Negro", 2022, "GHI789", 5, true);
                suv.Encender();
                Console.WriteLine($"Velocidad Actual: {0} Km/h");
                suv.Acelerar(40);
                Console.WriteLine($"Velocidad al Acelerar: {suv.VelocidadActual} Km/h");
                suv.Frenar(15);
                Console.WriteLine($"Velocidad del SUV después de frenar: {suv.VelocidadActual} Km/h");
                suv.Bocina();
                suv.ActivarModoOffRoad();
                suv.Apagar();
                Console.WriteLine();
                break;

            default:
                Console.WriteLine("Opción no valida");
            break;
        }

    }
}