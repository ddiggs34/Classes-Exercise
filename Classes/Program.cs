namespace Classes;

public class Program
{
    static void Main(string[] args)
    {
        //Instance of a class - DONE

      Car dreamCar = new Car(); //made a new type and calling the constructor from custom class

        dreamCar.Make = "Nissan";
        dreamCar.Model = "GTR";
        dreamCar.Year = 2020;

        Console.WriteLine($"My dream car is a {dreamCar.Year} {dreamCar.Make} {dreamCar.Model}");




    }
}
