// написать прграмму, к-я перевернет одномерный массив
// (последний эл-т будет на первом, а первый на последнем и т.д.)


// int[] GetArray(int length)
// {
//     int[] array = new int[length];
//     for (int i = 0; i < length; i++)
//     {
//         array[i] = new Random().Next(-10, 11);
//     }
//     return array;
// }
// void Reverse(int[] array)   // метод, к-й изменяет массив. перемещает ячейки между собой местами
// {
//     for (int i = 0; i < array.Length/2; i++)
//     {
//         int tmp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = tmp;
//     }
// }
// Console.WriteLine("Введите длинну массива ");
// int length = Convert.ToInt32(Console.ReadLine());
// int[] array = GetArray(length);
// Console.WriteLine(String.Join(", ", array));
// Reverse(array);
// Console.WriteLine(String.Join(", ", array));

// написать программау, к-я при нимает на вход три числа и проверяет 
// может ли существовать такой треугольник с такими длинной строки

// Console.WriteLine("Введите число ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число ");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число ");
// int c = Convert.ToInt32(Console.ReadLine());

// if (a + b < c || a + c < b ||  b + c < a)
// {
//     Console.WriteLine("нет ");
// }
// else
// {
//     Console.WriteLine("да ");
//}
// через массив

// Console.WriteLine("Введите число массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
/*
int size = 3;
int[] array = new int[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите длинну стороны {i +1} ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
if (array[0] + array[1] < array[2] || array[0] + array[2] < array[1] ||  array[1] + array[2] < array[0])
{
    Console.WriteLine("нет, такого треугольника нет ");
}
else
{
    Console.WriteLine("да, такой треугольник есть ");
}
*/



//написать программу,к-я будет преобразовывать десятичное число в двоичное.

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// string stroka = "";
// while (number > 0)
// {
//     stroka = number % 2 + stroka;
//     number = number / 2;
// }
// Console.WriteLine(stroka); // можно строку конвертировать в массив, а потом его реверсироать


// не используя рекурсию вывести первые N чисел Фибоначчи. первые два числа Фибоначчи: 0 и 1.

// Console.WriteLine("Введите число: ");
// int feb = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[feb];

// array[0] = 0;
// array[1] = 1;
// for (int i = 2; i < feb; i++)
// {
//     array[i] = array[i-2] + array [i - 1];
// }
// Console.WriteLine(String.Join(" ", array));



//написать программу, к-я будет создавать копию заданного массива с помощью поэлементного копирования

// Console.WriteLine("Введите длинну массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];
// Random myRandom = new Random();
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = myRandom.Next(1, 10);
// }
// Console.WriteLine(String.Join(" ", array));

// int[] array2 = new int[size];
// for (int i = 0; i < size; i++)
// {
//     array2[i] = array[i]; // (length - 1 - i) вместо i для решения первой задачи
// }
// Console.WriteLine(String.Join(" ", array));
