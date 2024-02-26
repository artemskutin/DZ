
// Напишите программу, которая будет принимать 
// на вход число и  возвращать сумму его цифр.


int SumOfDigits (int number)
{
    
    if (number == 0) return 0; 
    int result = number % 10 + SumOfDigits(number / 10);
    return result;
}

Console.WriteLine(SumOfDigits(82));




// Рекурсия - вызов метода внутри метода
// Факториал - произ-е чисел от 1 до N включительно 


int FindFactorial (int n)
{
    
    if (n == 1) return 1;
    
    return n * FindFactorial(n - 1);
}
Console.WriteLine(FindFactorial(4)); 










