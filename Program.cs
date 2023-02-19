// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

System.Console.WriteLine("Task 41");
Console.Write("Enter M numbers (use space as divider) ");
int[] massiv = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int NoZeroArray (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>0) count++;
    }
    return count;
}

System.Console.WriteLine($" {NoZeroArray(massiv)}");

// Задача 43: Напишите программу, которая найдёт точку пересечения 
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

System.Console.WriteLine("Task 43");
double numk1 = EnterNumber("Enter k1");
double numk2 = EnterNumber("Enter k2");
double numb1 = EnterNumber("Enter b1");
double numb2 = EnterNumber("Enter b2");


double EnterNumber(string number)
{
    Console.Write($"Enter {number}: ");
    double num = Convert.ToInt32(Console.ReadLine());
    return num;
}

double numX (double num1, double num2, double num3, double num4) //k1, k2, b1, b2
{
    double numX = (num4-num3)/(num1-num2);
    return numX;
}

double resultX = numX(numk1, numk2, numb1, numb2);

double numY (double num1, double num2, double num3)
{
    double numY = num1*num3+num2;
    return numY;
}

System.Console.WriteLine($" {resultX} {numY(numk1, numb1,  resultX)}");



// Задача 44:выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5
// --> 0 1 1 2 3
// Если N = 3
// --> 0 1 1
// Если N = 7
// --> 0 1 1 2 3 5 8


Console.WriteLine("Enter numbers");
int number = Convert.ToInt32(Console.ReadLine());

if(number>0)
{
    int numbers1 = 0;
    Console.Write(" " + numbers1);
    int numbers2 = 1;
    Console.Write(" " + numbers2);
    for (int i = 0; i < number-2; i++)
    {
        int result = numbers1+numbers2;
        Console.Write(" " + result);
        numbers1 = numbers2;
        numbers2= result;
    }
}

