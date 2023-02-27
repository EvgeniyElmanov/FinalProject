// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать
// на старте выполнения алгоритма.
// При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

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