// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать
// на старте выполнения алгоритма.
// При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

string[] StringArray(string[] array1)
{
  string[] array2 = new string[array1.Length];
  int count = 0;
  for (int i = 0; i < array1.Length; i++)
  {
    if (array1[i].Length <= 3)
    {
      array2[count] = array1[i];
      count++;
    }
  }
  Array.Resize(ref array2, count);
  return array2;
}

string[] GetNumber(int size)
{
  string[] arr = new string[size];
  for (int i = 0; i < arr.Length; i++)
  {
    Console.Write($"{i + 1}: ");
    arr[i] = (Console.ReadLine());
  }
  return arr;
}

int EntNumber(string text)
{
  Console.WriteLine(text);
  return int.Parse(Console.ReadLine());
}

int number = EntNumber("Enter of number elements array: ");
string[] result = GetNumber(number);
Console.Write("[" + String.Join(", ", result) + "] -> ");
Console.WriteLine("[" + String.Join(", ", StringArray(result)) + "]");