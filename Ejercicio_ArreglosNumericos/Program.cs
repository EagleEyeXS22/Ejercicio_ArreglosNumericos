/* Mezclar 2 arreglos que ya esten ordenados de menor a mayor, y que el arreglo resultante este ordenado:
[1,2,5,7,15,21] y[3, 6, 50] */

int[] arregloNumerico1 = { 1, 2, 5, 7, 15, 21 };
int[] arregloNumerico2 = { 3, 6, 50 };

//1.Extraer valores arreglosNumericos 
for (int i = 0; i < arregloNumerico1.Length; i++)
{
    Console.WriteLine(arregloNumerico1[i]);
}

for (int i = 0; i < arregloNumerico2.Length; i++)
{
    Console.WriteLine(arregloNumerico2[i]);
}

//2. Ordenar de mayor a menor los valores numericos.
int[] result = new int[arregloNumerico1.Length + arregloNumerico2.Length];
for (int i = 0; i < arregloNumerico1.Length; i++)
{
    result[i] = arregloNumerico1[i];
}
for (int i = 0; i < arregloNumerico2.Length; i++)
{
    result[arregloNumerico1.Length + i] = arregloNumerico2[i];

}
Array.Sort(result);
Console.WriteLine("[{0}]", string.Join(", ", result));

