/* Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие 
отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]   */

//узнаем длину массива от пользователя, переводим в число
int LengthArray(string message)
{
    int dimension = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out dimension))break;
        else Console.WriteLine("Ввели не корректное число, повторите ввод: ");
    }
    return Math.Abs(dimension);
}

//инициализируем массив
int[] InitArray(int dimension)
{
    int[] arr = new int[dimension];
    Random rnd = new Random();
    for (int i = 0; i < dimension; i++)
    {
        arr[i] = rnd.Next(-9,10);
    }
    return arr;
}

//печатаем массив                           можно не использовать метод PrintArray.  
void PrintArray(int[] arr)                // вместо 50 строки вставить еще раз 53 строку.
{                                         // команда string.Join(" ", array) выведет и
for (int i = 0; i < arr.Length; i++)      // первоначальный массив и перевернутый
{
Console.Write($"{arr[i]} ");
}
Console.WriteLine();
}

//замена знаков в элементах массива
void GetReplacement(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = - array[i];
    }
}

int dimension = LengthArray("Задайте колличество элементов в массиве: ");
int[] array = InitArray(dimension);
PrintArray(array);
GetReplacement(array);

Console.WriteLine(string.Join(" ", array));