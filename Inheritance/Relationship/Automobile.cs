using System;

public class Automobile
{
    public Automobile(string make, string model, int year)
	{
        if (make == null)
            throw new ArgumentNullException("The make cannot be null.");
        else if (String.IsNullOrWhiteSpace(make))
            throw new ArgumentException("make cannot be an empty string or have space characters only.");
        Make = make;

        if (model == null)
            throw new ArgumentNullException("The model cannot be null.");
        else if (String.IsNullOrWhiteSpace(make))
            throw new ArgumentException("model cannot be an empty string or have space characters only.");
        Model = model;

        if (year < 1857 || year > DateTime.Now.Year + 2)
            throw new ArgumentException("The year is out of range.");
        Year = year;
	}

    public string Make { get; set; }

    public string Model { get; set; }

    public int Year { get; set; }

    public override string ToString()
    {
        return String.Format("{0} {1} {2}", Year, Make, Model);
    }
}

public class Example
{
    public static void Main()
    {
        var packard = new Automobile("Packard", "Custom Eight", 1948);
        var camry = new Automobile("Camry", "Toyota", 1988);
        Console.WriteLine(packard);
        Console.WriteLine(camry);
    }
}