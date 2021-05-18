using System;

public class Car
{
    //property
    public int Miles { get; set; }
    // constractor with default
    public Car(int miles = 10)
    {
        this.Miles = miles;
    }
    //method
    public void GetMiles() 
    {
        Console.WriteLine(Miles);
    }
}