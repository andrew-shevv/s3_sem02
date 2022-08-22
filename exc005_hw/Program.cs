// Напишите программу, 
// которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Input three-digit number: ");
int num3dig = Convert.ToInt32(Console.ReadLine());

int digMid = num3dig / 10 % 10;
if (num3dig > 99 && num3dig < 1000){
    Console.WriteLine($"{digMid} - middle digit");
}
else Console.WriteLine("This isn't a three-digit number");