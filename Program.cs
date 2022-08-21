/*
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] numbers = new int[4];

void FillArray(int[] array, int min, int max)
{
 for (int i = 0; i<array.Length; i++ )
 {
 array[i] = new Random().Next(min, max);
  }
}

void WritingAnArray(int[] array)
{
 for (int i = 0; i<array.Length; i++ )
 {
 Console.Write(array[i] + " ");
  }
 Console.WriteLine();
}

int QuantityPositive(int[] array)
{
 int quantity = 0;
 for (int i = 0; i<array.Length; i++ )
 {
 if (array[i] % 2 == 1)
    {
      quantity++;
    }
  }
  return quantity;
}

FillArray(numbers, 100, 1000);
WritingAnArray(numbers);
Console.WriteLine();

int quantity = QuantityPositive(numbers);
Console.WriteLine($"The number of even numbers in the array: {quantity}");
*/
/*
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Write($"Input the number of array elements: ");
int numberElements = Convert.ToInt32(Console.ReadLine()); 

int RandomNumbers(int elementNumber, int min, int max)
  {
  int[] randomNumbers = new int[elementNumber];
  int sumElements = 0;
  Console.Write("Array: ");

    for (int i = 0; i <randomNumbers.Length; i++)
    {
      randomNumbers[i] = new Random().Next(min, max);

      Console.Write(randomNumbers[i] + " ");

      if (i % 2 != 1)
      {
        sumElements = sumElements + randomNumbers[i];
      }
    }
  return sumElements;
  }

int randomNumbers = RandomNumbers(elementNumber, 1, 10);

Console.WriteLine($"The sum of the elements standing in odd positions: {randomNumbers}");
*/