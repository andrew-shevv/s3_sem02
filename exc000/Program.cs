// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

int numR = new Random().Next(10,100);
Console.WriteLine("Randomly generated number: " + numR);

int dig1 = numR / 10;
int dig2 = numR % 10;

if (dig1 > dig2){
    Console.WriteLine(dig1 + " - highest digit");
}
else if (dig2 > dig1){
    Console.WriteLine(dig2 + " - highest digit");
}
else Console.WriteLine("The digits are equal");