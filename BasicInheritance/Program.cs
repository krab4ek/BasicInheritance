using BasicInheritance;

Console.WriteLine($"****** Basic Inheritance ******\n");

Car myCar = new Car(80);
Console.WriteLine($"My car is going {myCar.Speed}");

myCar.Speed = 50;
Console.WriteLine($"My car is going {myCar.Speed}");

MiniVan myVan = new MiniVan();
myVan.Speed = 10;
Console.WriteLine($"My van is going {myVan.Speed}");

Console.ReadLine();