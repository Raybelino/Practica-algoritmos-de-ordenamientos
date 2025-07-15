public class OrdenamientoSeleccion : IOrdenamiento
{
    public int Comparaciones { get; private set; }
    public int Intercambios { get; private set; }

    public void Ordenar(int[] precios)
    {
        Comparaciones = 0;
        Intercambios = 0;

        int n = precios.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int indiceMin = i; // asumimos que el menor está en la posición actual

            // buscamos el menor en el resto del arreglo
            for (int j = i + 1; j < n; j++)
            {
                Comparaciones++;

                if (precios[j] < precios[indiceMin])
                {
                    indiceMin = j; // encontramos un nuevo menor
                }
            }

            Console.WriteLine($"Iteración {i + 1}: índice mínimo = {indiceMin}");

            // Si el índice del menor es diferente al actual, intercambiamos
            if (indiceMin != i)
            {
                int temp = precios[i];
                precios[i] = precios[indiceMin];
                precios[indiceMin] = temp;

                Intercambios++; // Registrar un intercambio
            }

            Console.WriteLine("Estado actual: " + string.Join(", ", precios));
            Console.WriteLine();
        }
    }
}
