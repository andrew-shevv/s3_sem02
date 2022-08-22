// Напишите программу, 
// которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа.

int num3dig = new Random().Next(100, 1000);
Console.WriteLine($"Randomly generated number: {num3dig}");

int dig1 = num3dig / 100;
int dig2 = num3dig % 10;
int num3digNoMid = dig1 * 10 + dig2;

Console.WriteLine(num3digNoMid);