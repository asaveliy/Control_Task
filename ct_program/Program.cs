
/// <summary>
/// Метод, который проверяет длинну (количество элементов) 
/// каждого отдельного элемента нашего исходного массива, 
/// сравнивая с 3.
/// </summary>
/// <param name="arrayInput"> Начальный массив </param>
void CheckLength(string[] arrayA, string[] arrayB)
{
    int count = 0;
    for (int i = 0; i < arrayA.Length; i++)
    {
    if(arrayA[i].Length <= 3)
        {
        arrayB[count] = arrayA[i];
        count++;
        }
    }
}



/// <summary>
/// Метод, который печатает новый массив.
/// </summary>
/// <param name="array"> Вводимый массив </param>
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}   ");
    }
    Console.WriteLine();
}



// ИНТЕГРИРОВАННЫЕ ПЕРЕМЕННЫЕ (для проверки)
string[] array = new string[4] {"123", ":-)", "-2", "computer science"}; 


// остальной код
string[] arrayNew = new string[array.Length];
CheckLength(array, arrayNew);
PrintArray(arrayNew);

