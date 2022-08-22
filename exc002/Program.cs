// Напишите программу, 
// которая будет принимать на вход два числа 
// и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления.

Console.WriteLine ("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int mult = num1 % num2;
if (mult == 0){
    Console.WriteLine($"{num1} is a multiple of {num2}");
}
else {
    Console.WriteLine($"{num1} isn't a multiple of {num2}. The remainder of the division is {mult}");
}