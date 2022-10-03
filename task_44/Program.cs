/*
*Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

void PrintArray(int[] myArray)
{
    int count = myArray.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{myArray[position]} ");
        position++;
    }
    
}

Console.Write("Введите число N:  ");
int i = Convert.ToInt32(Console.ReadLine());
if (i <= 0) Console.Write("Некорректный ввод данных. Попробуйте еще раз");
else
{
int[] array = new int[i];
array[0] = 0;
array[1] = 1;
for (i = 2; i < array.Length; i++)
{
    array[i] = array[i-1] + array[i-2];
}
Console.Write($"Если N = {i} -> ");
PrintArray(array);
}