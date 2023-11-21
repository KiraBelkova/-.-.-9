// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

System.Console.WriteLine("Введите значение M");
int m = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите значение N");
int n = Convert.ToInt32(System.Console.ReadLine());


int Ackermann  (int m, int n)
{
    if( m == 0)
    return n + 1;
    else if (m > 0 && n == 0)
    return Ackermann(m - 1, 1);
    else
    return Ackermann( m - 1, Ackermann(m, n -1) );
}

int res = Ackermann(m,n);
System.Console.WriteLine(res);
