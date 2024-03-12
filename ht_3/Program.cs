// Задайте произвольный массив. 
//Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.



void PrintNumbers(int[] numbers, int i)
{
    if (i < 0)
    {
        return;
    }
    Console.Write(numbers[i] + " ");

    PrintNumbers(numbers, i-1);

}
int[] numbers = {1, 3, 5, 7, 9};

PrintNumbers(numbers, numbers.Length - 1);

