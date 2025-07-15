public class OrdenamientoInsercion : IOrdenamiento
{
    public int Comparaciones { get; private set; }
    public int Intercambios { get; private set; }

    public void Ordenar(int[] tiempos)
    {
        Comparaciones = 0;
        Intercambios = 0;

        int n = tiempos.Length;

        for (int i = 1; i < n; i++)
        {
            int actual = tiempos[i]; // número que queremos insertar
            int j = i - 1;

            // movemos elementos que sean mayores que el actual
            while (j >= 0 && tiempos[j] > actual)
            {
                Comparaciones++;
                tiempos[j + 1] = tiempos[j];
                Intercambios++;
                j--;
            }

            Comparaciones++; // la comparación que falló
            tiempos[j + 1] = actual; // insertamos el número en su lugar

            // Mostramos cómo va el arreglo
            Console.WriteLine($"Después de insertar {actual}: " + string.Join(", ", tiempos));
            Console.WriteLine();
        }
    }
}
