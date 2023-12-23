Console.WriteLine("Lets calculate the amount of gallons of paint needed for the ceiling of a room.");
Console.Write("What is the length of the room in FT? ");
double lengthOfRoom = Convert.ToDouble(Console.ReadLine());
Console.Write("What is the width of the room in FT? ");
double widthOfRoom = Convert.ToDouble(Console.ReadLine());
double squareFeetOfRoom = lengthOfRoom * widthOfRoom;
double gallonsOfPaint = Math.Ceiling(squareFeetOfRoom / 350);
// assuming a gallon covers 350 sq ft.
Console.WriteLine($"You will need to purchase {gallonsOfPaint} gallons of paint to cover {squareFeetOfRoom} square feet.");

