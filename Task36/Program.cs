Console.WriteLine("Данная программа создаёт одномерный массив, заполненный случайными числами. И находит сумму элементов, стоящих на чётных позициях в данном массиве.");

int i = 0;
int[] array = new int[4];
var random = new Random();

    for(i = 0; i < array.Length; i++)
        array[i] = random.Next(-99, 99);

var str = string.Join(" ", array);

Console.WriteLine($"Создан следующий массив из 4 случайных двузначных чисел: [{string.Join(", ", array)}]");

Console.WriteLine("Сумма элементов, стоящих на чётных позициях составляет: {0}", array[1] + array[3]);
Console.ReadKey();