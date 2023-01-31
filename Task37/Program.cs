/*   Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21   */


int[] InitArray(int dimension)
{
    int[] arr = new int[dimension];
    Random rnd = new Random();
    for (int i = 0; i < dimension; i++)
    {
        arr[i] = rnd.Next(0, 10);
    }
    return arr;
}

int [] MultiOfNumbers(int [] arr)
{
    bool chetniy = true;                        
    int [] newArr = null;                       //задаем пустой маасив, чтобы использовать newArr далее
    if(arr.Length % 2 == 0)                     // если длина массива четная, то новый массив будет длинной
        newArr = new int [arr.Length / 2];      // "половина"
    else
    {                                           // если длина массива не четная, то новый массив будет длиной
        newArr = new int [arr.Length / 2 + 1];  // "половина +1", тогда chetniy = false;
        chetniy = false;
    }
    for (int i = 0; i < newArr.Length; i++)     // работаем с длиной нового массива
    {
    if (!chetniy && i == newArr.Length - 1)     // если длина массива не четная и текущий индекс равен последнему,
        newArr[i] = arr[i];                     // то записываем элемент под этим индексоv в новый массив (не умножаем его)
    else                                        // иначе (если длина массива четная и/или текущий индекс не равен последнему), 
        newArr[i] = arr[i] * arr[arr.Length - i - 1];       // то каждый текущий элемент умножаем на последний. i вычитаем 
    }                                           //сразу здесь, а не в отдельной строке (arr.Length = arr.Length - i - 1)
    return newArr;                              // т.к. первый i = 0, на результат не повлияет, а потом начнем убирать отработанный i
}

int [] array = InitArray(4);                      // можно изменять на нечетную длину массива
Console.WriteLine(string.Join(", ", array));
int [] newArray = MultiOfNumbers(array);
Console.WriteLine(string.Join(", ", newArray));
