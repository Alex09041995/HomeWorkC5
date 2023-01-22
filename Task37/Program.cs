Console.WriteLine("Данная программа находит произведение пар чисел в одномерном массиве. Парой в данном массиве считается первый и последний элемент, второй и предпоследний и т.д.");

void FillArray(int[] array, int minValue, int maxValue)
{
    int length = array.Length;
    Random rnd = new Random();

    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue +1);
    }
}

void ProductPairsOfNumber(int[] array)
{
    int length = array.Length;

    for (int i = 0; i < length / 2; i++)
    {
        int product = (array[i] * array[length - i - 1]);
        var str = string.Join(" ,", product);
        Console.Write(product + ", ");
    }
    if (length % 2 != 0)
    {
        Console.Write(array[length / 2]);
    }
}

string PrintArray(int [] array)
{
    string outputSrt = String.Empty;
    outputSrt = string.Join(" ", array);

    return outputSrt;
}

int[] array = new int[7];

            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            array[3] = 4;
            array[4] = 5;
            array[5] = 6;
            array[6] = 7;

var str = string.Join(" ,", array);
Console.WriteLine("[{0}]", string.Join(", ", array));
ProductPairsOfNumber(array);