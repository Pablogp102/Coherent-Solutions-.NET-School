using System;

using Task_2._1.Classes;

public class Program
{
    public static void Main()
    {
        Point3D point1 = new Point3D(0, 0, 0, 10);
        Point3D point2 = new Point3D(3, 4, 5, -5); 

       
        Console.WriteLine($"Point1  X: {point1.X}, Y: {point1.Y}, Z: {point1.Z}, Mass: {point1.Mass}");
        Console.WriteLine($"Point1 is zero: {point1.IsZero()}");

       
        Console.WriteLine($"Point2  X: {point2.X}, Y: {point2.Y}, Z: {point2.Z}, Mass: {point2.Mass}");
        Console.WriteLine($"Point2 is zero: {point2.IsZero()}");

        
        double distance = point1.DistanceToAnotherPoint(point2);
        Console.WriteLine($"Distance between point1 and point2: {distance}");

        
        point1.X = 1;
        point1.Y = 2;
        point1.Z = 3;
        point1.Mass = -2; 

        Console.WriteLine($"Updated Point1  X: {point1.X}, Y: {point1.Y}, Z: {point1.Z}, Mass: {point1.Mass}");
    }
}
