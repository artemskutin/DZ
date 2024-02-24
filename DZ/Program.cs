//Задача 2: Подсчет количества четных чисел в массиве


int[] numbers = new int[10];
Random random = new Random();
int evenCount = 0;

for (int i = 0; i < numbers.Length; i++)
{
numbers[i] = random.Next(100, 1000);
Console.Write(numbers[i] + " ");
if (numbers[i] % 2 == 0)
{
evenCount++;
}
Console.WriteLine($"\nКоличество четных чисел в массиве: {evenCount}");
}


//Задача 1: Бесконечный запрос чисел до ввода ‘q’ или числа с четной суммой цифр

while (true)
{
  Console.Write("Введите число или 'q' для выхода: ");
  string input = Console.ReadLine();
  if (input == "q")
  {
    break;
  }
  int number;
  if (int.TryParse(input, out number))
  {
    int sum = 0;
    while (number > 0)
    {
      sum += number % 10;
      number /= 10;
    }
    if (sum % 2 == 0)
    {
      Console.WriteLine("[STOP]");
      break;
    }
  }
  else
  {
    Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число или 'q'.");
  }
}









