// Напишите программу, 
// которая принимает на вход два числа 
// и проверяет, является ли одно число квадратом другого.

Console.WriteLine("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Is one of the numbers the other number squared?");
if (num1 * num1 == num2 || num2 * num2 == num1){
    Console.WriteLine("yes");
}
else Console.WriteLine("no");