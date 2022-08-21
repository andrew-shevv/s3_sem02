// Напишите программу, 
// которая принимает на вход число 
// и проверяет, кратно ли оно одновременно 7 и 23.

Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Is the number divisible by both 7 and 23?");
if (num % 23 == 0 && num % 7 == 0) {
    Console.WriteLine("yes");
}
else Console.WriteLine("no");