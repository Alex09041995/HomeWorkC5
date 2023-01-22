Console.WriteLine("Данная программа создаёт массив вещественных чисел из введённого размера для массива. И находит разницу между максимальным и минимальным элементом в данном массиве.");
Console.WriteLine("Введите необходимый размер для создания массива");

int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

FillArrayRandomNumbers(numbers);

Console.WriteLine("Создан следующий массив из вещественных чисел: ");

PrintArray(numbers);

int min = Int32.MaxValue;
int max = Int32.MinValue;

for (int x = 0; x < numbers.Length; x++)
{
    if (numbers[x] > max)
        {
            max = numbers[x];
        }
    if (numbers[x] < min)
        {
            min = numbers[x];
        }
}
Console.WriteLine($"В созданном массиве {numbers.Length} чисел. Максимальное значение элемента составляет: {max}, минимальное значение элемента составляет: {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {max - min}");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToInt32(new Random().Next(0, 99));
        }
}

void PrintArray(int[] numbers)
{
   Console.Write("[");
    for(int i = 0; i < numbers.Length; i++)
        {
        Console.Write(numbers[i] + ", ");
        }
    Console.Write("]");
    Console.WriteLine();
}