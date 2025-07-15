// Esta clase se encarga de ejecutar el algoritmo que le pasemos
public class EjecutorOrdenamiento
{
    private readonly IOrdenamiento _estrategia;

    public EjecutorOrdenamiento(IOrdenamiento estrategia)
    {
        _estrategia = estrategia;
    }

    public void Ejecutar(int[] datos)
    {
        Console.WriteLine("Arreglo original: " + string.Join(", ", datos));
        _estrategia.Ordenar(datos); // Se ordena con la estrategia que le pasamos
        Console.WriteLine("Arreglo ordenado: " + string.Join(", ", datos));
        Console.WriteLine($"Comparaciones: {_estrategia.Comparaciones}, Intercambios: {_estrategia.Intercambios}");
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine();
    }
}