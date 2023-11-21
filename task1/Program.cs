// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

int reverseNaturalSeries(string text)
{
    System.Console.Write(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
} 
        
void PrintNumbers(int n)
{
    if(n == 0) return;
    System.Console.Write(n + " "); 
    PrintNumbers(n - 1);
    
}

int n = reverseNaturalSeries("Введите число больше 1: ");
PrintNumbers(n);