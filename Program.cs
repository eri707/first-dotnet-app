using System;

namespace first_dotnet_app
{
    class Program
    {
        static void Main(string[] args)
        {
           //creating a instance(object) with parameter
           var car = new Car(30);
           //call method
           car.GetMiles();
           //also can use property here(but rare)
           car.Miles = 40;
           car.GetMiles();
        }
    }
}
