namespace designPatterns
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Car car = new Car.CarBuilder().
              Id(12).Brand("Toyota").Color("red").Model("18/17").Build();
            car.Display();

            Car car1 = new Car.CarBuilder().
              Id(20).Brand("Honda").Build();
            car1.Display();


        }
    }
}