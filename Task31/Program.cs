/*  Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.*/

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

//печатаем массив
void PrintArray(int[] arr)
{
for (int i = 0; i < arr.Length; i++)
{
Console.Write($"{arr[i]} ");
}

Console.WriteLine();
}

//находим сумму положительных в массиве
int GetPositiveSum(int[] array)
{
int sum = 0;

for (int i = 0; i < array.Length; i++)
{
if(array[i] > 0)
sum += array[i];
}

return sum;
}
//находим сумму отрицательных в массиве
int GetNegativeSumm(int[] array)
{
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
if(array[i] < 0)
sum += array[i];
}
return sum;
}

(int, int) GetSummsFromArray(int[] array)   // кортеж, с ним метод может возвращать несколько типов и разные
{                                           // (int, string, double), при этом в return переменные указываются 
int posSum = 0;                             // в том же порядке
int negSum = 0;                             

for (int i = 0; i < array.Length; i++)
{
if(array[i] < 0)
negSum += array[i];
else
posSum += array[i];
}

return (posSum, negSum);
}


int[] array = InitArray(12);
PrintArray(array);
int posSum = GetPositiveSum(array);
int negSum = GetNegativeSumm(array);

(int pos, int neg) = GetSummsFromArray(array);

Console.WriteLine($"сумма положительных = {posSum}, отрицательных = {negSum}");
Console.WriteLine($"сумма положительных = {pos}, отрицательных = {neg}");