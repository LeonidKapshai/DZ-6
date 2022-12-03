// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел:");
var array = FillArray(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine("Введите числа:");

Console.Write($"Чисел больше 0: {Sum(array)}");


int Sum(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        if (array[i]> 0)
            {
                sum++;
            }
        }
    return sum;
}



int[] FillArray(int length)
{
int[] array = new int[length];
for(int i = 0; i < length; i++)
{
array[i] = 0;
}
return array;
}