int number = new Random().Next(100, 1000);
Console.WriteLine($"Наше случайное число = {number}");
int numberA = number/100;
int numberC = number % 10;
Console.WriteLine(numberA*10 + numberC);
