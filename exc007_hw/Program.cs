// Напишите программу, 
// которая принимает на вход цифру, 
// обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.WriteLine("Input number of weekday");
int weekD = Convert.ToInt32(Console.ReadLine());

if (weekD == 6 || weekD == 7){
    Console.WriteLine("It's your day off!");
}
else if (weekD < 6 && weekD > 0){
    Console.WriteLine("Time to work");
}
else Console.WriteLine("This isn't a weekday");