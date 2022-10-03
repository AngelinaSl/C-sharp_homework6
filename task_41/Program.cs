/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

void PrintArray(int[] myArray)
{
    int count = myArray.Length;
    int position = 0;
    Console.Write("[");
    while (position < count - 1)
    {
        Console.Write($"{myArray[position]}, ");
        position++;
    }
    Console.Write($"{myArray[position]}]");
}

Console.Write("Какое количество чисел Вы хотите ввести?:  ");
int i = Convert.ToInt32(Console.ReadLine());
if (i <= 0) Console.Write("Некорректный ввод данных. Попробуйте еще раз");
else
{
int[] array = new int[i];
for (i = 0; i < array.Length; i++)
{
    Console.Write("Введите число:   ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Вот все введенные вами числа: ");
PrintArray(array);

int count = 0;

for (i = 0; i < array.Length; i++)
{
    if ( array[i]> 0) count++;
}
Console.WriteLine ();
Console.WriteLine ($"В данной комбинации {count} чисел(-ла) больше 0.");
}