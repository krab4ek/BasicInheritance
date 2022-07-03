using BasicInheritance;

Console.WriteLine($"****** Basic Inheritance ******\n");

Car myCar = new Car(80);
Console.WriteLine($"My car is going {myCar.Speed}");

myCar.Speed = 50;
Console.WriteLine($"My car is going {myCar.Speed}");


Console.ReadLine();