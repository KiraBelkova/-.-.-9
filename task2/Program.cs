// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

System.Console.WriteLine("Введите значение M");
int m = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите значение N");
int n = Convert.ToInt32(System.Console.ReadLine());

 if(m > n)
        {
            int temp = m;
            m = n;
            n = temp;
        }

int NaturSum(int m, int n)
{
    if (m > n)
    
      return 0;
      else
      
        return m + NaturSum(m + 1 , n);

      }

int sum = NaturSum(m , n);
System.Console.WriteLine(sum);