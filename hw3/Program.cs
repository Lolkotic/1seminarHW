Console.WriteLine("Введите число и я определю чётное ли оно: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)  
{
    Console.WriteLine("да");
}
else 
{
    Console.WriteLine("нет");
}