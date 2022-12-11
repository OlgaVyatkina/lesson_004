// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int A = inputNumberA();
int B = inputNumberB();
Console.WriteLine(Exponentiation(A, B));


int Exponentiation(int a, int b) //возводим число а в степень b
{
int result = a;
    for (int i = 1; i < b; i++)
    {
    result = result * a;
    } 
    return result;
   }

int inputNumberB()  // проверка на введенное число  и натуральность числа b
{
    int number;
 while (true)
    {
    Console.Write("Введите натуральное число B: ");
    string? text = Console.ReadLine();
        if ((int.TryParse(text, out number)) && (number > 0))
        {
            break;
        }
        Console.WriteLine("Число B некоректно. Попробуйте еще раз.");
    }
    return number;
}

int inputNumberA()  // проверка на введенное число 
{
    int number;
 while (true)
    {
    Console.Write("Введите число A: ");
    string? text = Console.ReadLine();
        if (int.TryParse(text, out number)) 
        {
            break;
        }
        Console.WriteLine("Число A некоректно. Попробуйте еще раз.");
    }
    return number;
}