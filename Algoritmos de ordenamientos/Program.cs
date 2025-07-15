class Programa
{
    static void Main()
    {
        //Valores para ordenar
        int[] calificaciones = { 85, 70, 90, 75, 60, 95, 88, 76, 100, 65 };
        int[] precios = { 250, 120, 75, 300, 100, 180, 90, 220 };
        int[] tiempos = { 58, 54, 60, 52, 57, 56, 59 };

        // Ejercicio 1 – Calificaciones
        Console.WriteLine("----- Ordenamiento Burbuja – Calificaciones: -----");

        EjecutorOrdenamiento Ejercicio_1 = new EjecutorOrdenamiento(new OrdenamientoBurbuja());
        Ejercicio_1.Ejecutar(calificaciones);

        // Ejercicio 2 – Precios de inventario
        Console.WriteLine("----- Ordenamiento por Selección – Precios: -----");

        EjecutorOrdenamiento Ejercicio_2 = new EjecutorOrdenamiento(new OrdenamientoSeleccion());
        Ejercicio_2.Ejecutar(precios);

        // Ejercicio 3 – Tiempos de llegada
        Console.WriteLine("----- Ordenamiento por Inserción – Tiempos de llegada: -----");

        EjecutorOrdenamiento Ejercicio_3 = new EjecutorOrdenamiento(new OrdenamientoInsercion());
        Ejercicio_3.Ejecutar(tiempos);
    }
}
