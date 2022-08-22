// Напишите программу, 
// которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99){
    while (num > 999){
        num = num / 10;
    }
    Console.WriteLine($"{num % 10} - third digit");
}
else Console.WriteLine("This number doesn't have a third digit");