// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int A = inputNumber();
Console.WriteLine(Sum(A));


int inputNumber()  // проверка на введенное число
{
    int number;
 while (true)
    {
    Console.Write("Введите натуральное число A: ");
    string? text = Console.ReadLine();
        if ((int.TryParse(text, out number)) && (number > 0))
        {
            break;
        }
        Console.WriteLine("Число A некоректно. Попробуйте еще раз.");
    }
    return number;
}


int Sum(int number){
int numberlength = Convert.ToString(number).Length;
    int count = 0;
    int result = 0;

    for (int i = 0; i < numberlength; i++){
      count = number - number % 10;
      result = result + (number - count);
      number = number / 10;
    }
   return result;
  }



