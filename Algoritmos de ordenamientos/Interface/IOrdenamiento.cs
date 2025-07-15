public interface IOrdenamiento
{
    void Ordenar(int[] datos); // Método para ordenar los datos
    int Comparaciones { get; } // Propiedad para saber cuántas comparaciones se hicieron
    int Intercambios { get; }  // Propiedad para saber cuántos intercambios se hicieron
}

