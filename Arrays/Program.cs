//Одномерный массив
int[] array = new int[] { 1, 2 };

Console.WriteLine("Вывод одномерного массива");

for (int i = 0; i < array.Length; i++)
    Console.Write(array[i] + "\t");



//Двумерный массив
int[,] multiDimensionalArray = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };

int height = multiDimensionalArray.GetLength(0);
int weight = multiDimensionalArray.GetLength(1);

Console.WriteLine("\nВывод двумерного массива");
for (int i = 0; i < height; i++)
{
    for (int j = 0; j < weight; j++)
        Console.Write(multiDimensionalArray[i, j] + "\t");
    Console.WriteLine();
}


//Зубчатый массив
int[][] jaggedArray = new int[2][] { [1, 3, 5, 7, 9], [2, 4, 6, 8] };

Console.WriteLine("\nВывод jagged-массива");
for (int i = 0; i < jaggedArray.Length; i++)
{
    Console.Write("{0}-й элемент: ", i);

    for (int j = 0; j < jaggedArray[i].Length; j++)
        Console.Write("{0}{1}", jaggedArray[i][j], j == (jaggedArray[i].Length - 1) ? "" : " ");
    
    Console.WriteLine();
}