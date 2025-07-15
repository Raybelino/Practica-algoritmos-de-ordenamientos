# **Práctica de Algoritmos de Ordenamiento en C#**

Este proyecto contiene la implementación de tres algoritmos clásicos de ordenación: Bubble Sort, Selection Sort e Insertion Sort, aplicados a tres escenarios reales y desarrollados utilizando polimorfismo y los principios SOLID.

# **Objetivos**

- Implementar y comprender el comportamiento de distintos algoritmos de ordenamiento.
- Aplicar principios de diseño como SOLID y polimorfismo para una estructura escalable y mantenible.
- Evaluar la eficiencia, comparaciones e intercambios de cada algoritmo.
- Mostrar paso a paso cómo evoluciona cada arreglo durante el proceso de ordenamiento.

# **Escenarios prácticos**

## Ejercicio 1 – Bubble Sort: Ordenar calificaciones

- **Escenario**: Una profesora desea ordenar las calificaciones de sus estudiantes.
- **Datos de entrada**: `{85, 70, 90, 75, 60, 95, 88, 76, 100, 65}`
- **Salida esperada**: Muestra el arreglo paso a paso y el número de comparaciones e intercambios.

## Ejercicio 2 – Selection Sort: Ordenar precios de inventario

- **Escenario**: Un negocio necesita ordenar los precios de sus productos.
- **Datos de entrada**: `{250, 120, 75, 300, 100, 180, 90, 220}`
- **Salida esperada**: Muestra el índice mínimo en cada iteración y el estado del arreglo.

## Ejercicio 3 – Insertion Sort: Ordenar tiempos de llegada

- **Escenario**: Se deben ordenar los tiempos de llegada de corredores en una carrera.
- **Datos de entrada**: `{58, 54, 60, 52, 57, 56, 59}`
- **Salida esperada**: Muestra el proceso de inserción paso a paso y la evolución del arreglo.

# **Clases e interfaces utilizadas**

A continuación se describen las clases e interfaces que forman parte del proyecto. Cada una cumple una función específica dentro de la lógica de ordenamiento, respetando los principios SOLID.

| Clase / Archivo                     | Descripción                                                                 |
|------------------------------------|-----------------------------------------------------------------------------|
| `IOrdenamiento`                    | Interfaz que define el contrato que deben seguir todos los algoritmos de ordenamiento. Incluye el método `Ordenar()` y las propiedades `Comparaciones` e `Intercambios`. |
| `OrdenamientoBurbuja`             | Clase que implementa el algoritmo Bubble Sort. Compara elementos adyacentes y los intercambia si están en orden incorrecto. Muestra el arreglo en cada pasada. |
| `OrdenamientoSeleccion`           | Clase que implementa el algoritmo Selection Sort. En cada iteración busca el valor mínimo del resto del arreglo y lo coloca en la posición correcta. |
| `OrdenamientoInsercion`           | Clase que implementa el algoritmo Insertion Sort. Inserta cada elemento en su lugar correcto dentro del arreglo parcialmente ordenado. Ideal para datos que llegan progresivamente. |
| `EjecutorOrdenamiento`            | Clase que recibe cualquier estrategia de ordenamiento (que implemente `IOrdenamiento`) y la ejecuta, mostrando el arreglo paso a paso y contando comparaciones e intercambios. |
| `Programa`                         | Clase principal del proyecto (`Main`). Aquí se crean los arreglos de datos de cada ejercicio y se prueban los algoritmos uno por uno. |
