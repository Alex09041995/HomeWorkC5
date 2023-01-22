Console.WriteLine("Данная программа автоматически задаёт массив из 4 случайных положительных трёхзначных чисел. И показывает количество чётных чисел в данном массиве.");

int i = 0;
int[] array = new int[4];
var random = new Random();

    for(i = 0; i < array.Length; i++)
        array[i] = random.Next(100, 999);

var str = string.Join(" ", array);

Console.WriteLine($"Создан следующий массив из 4 случайных положительных трёхзначных чисел: [{string.Join(", ", array)}]");

int even;
even = 0;
    for (i = 0; i < array.GetLength(0); i++)
        if (array[i] % 2 == 0)
        even++;

Console.WriteLine($"Количество чётных чисел в данном массиве: {even}");
Console.ReadKey();