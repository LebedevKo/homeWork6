// пользователь вводит с клавиатуры М чисел.
// посчитать, сколько чисел больше 0 ввел пользователь
/*
Console.Write("Введите количество чисел для массива:");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size]; 
int positiveCount = 0;
for (int i = 0; i < size; i++) 
{
    Console.Write($"Введите число {i + 1}: ");
    int digit = Convert.ToInt32(Console.ReadLine());
    numbers[i] = digit;
        if (numbers[i] > 0)
        {
            positiveCount ++;
        }
}

//Console.WriteLine("массив: " + String.Join(", ", numbers)); 

Console.WriteLine($"кол-во чисел больше 0 равно: {positiveCount}");

*/

Console.Write("Введите количество чисел для массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int positiveCount = 0;

for (int i = 0; i < size; i++) 
{
    Console.Write($"Введите число {i + 1}: ");
    int digit = Convert.ToInt32(Console.ReadLine());
        if (digit > 0)
        {
            positiveCount ++;
        }
}

Console.WriteLine($"кол-во чисел больше 0 равно: {positiveCount}");






