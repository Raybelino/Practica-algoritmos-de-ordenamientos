public class OrdenamientoBurbuja : IOrdenamiento
{
    public int Comparaciones { get; private set; }
    public int Intercambios { get; private set; }

    public void Ordenar(int[] datos)
    {
        Comparaciones = 0;
        Intercambios = 0;

        int n = datos.Length;

        // Recorremos varias veces el arreglo
        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine($"Pasada {i + 1}:");

            // Comparamos cada elemento con el siguiente
            for (int j = 0; j < n - i - 1; j++)
            {
                Comparaciones++;

                if (datos[j] > datos[j + 1])
                {
                    // Intercambiamos si están en el orden incorrecto
                    int temp = datos[j];
                    datos[j] = datos[j + 1];
                    datos[j + 1] = temp;

                    Intercambios++;
                }

                // Mostramos el arreglo en cada comparación
                Console.WriteLine(string.Join(", ", datos));
            }

            Console.WriteLine("Estado actual: " + string.Join(", ", datos));
            Console.WriteLine();
        }
    }
}

