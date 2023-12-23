Console.Write("What is the length of the room in feet? ");
double lengthOfRoomInFeet = Convert.ToDouble(Console.ReadLine());

Console.Write("What is the width of the room in feet? ");
double widthOfRoomInFeet = Convert.ToDouble(Console.ReadLine());

double areaOfRoomInSquareFeet = lengthOfRoomInFeet * widthOfRoomInFeet;
double areaOfRoomInSquareMeters = areaOfRoomInSquareFeet * 0.09290304; //formula m2 = f2 × 0.09290304


Console.WriteLine($"You entered the dimensions of {lengthOfRoomInFeet} feet by {widthOfRoomInFeet} feet.");
Console.Write("The area is ");
Console.WriteLine($"{areaOfRoomInSquareFeet} square feet. ");
Console.WriteLine($"{areaOfRoomInSquareMeters} square meters. ");