/* Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения 
которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5   */

//инициализируем массив
int[] InitArray(int dimension)
{
    int[] arr = new int[dimension];
    Random rnd = new Random();
    for (int i = 0; i < dimension; i++)
        {
            arr[i] = rnd.Next(0, 1000);
        }
    return arr;
}

// поиск элементов из отрезка [10,99]
int NumberOfElements(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 10 && arr[i] < 100)
        {
            count++;                        //count = count + 1;
            
        }
    }
    return count;
}

int[] array = InitArray(123);
Console.WriteLine(string.Join(", ", array));
int count = NumberOfElements(array);
Console.WriteLine($"Колличество элементов массива из отрезка [10,99] = {count}");