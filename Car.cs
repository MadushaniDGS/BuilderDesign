using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace designPatterns
{
    public class Car
    {
        private int id {  get; set; }
        private string brand { get; set; }
        private string color { get; set; }
        private string model { get; set; }

        Car(CarBuilder carBuilder)
        {
            this.id = carBuilder.id;
            this.brand = carBuilder.brand;
            this.color = carBuilder.color;
            this.model = carBuilder.model;
        }
        
        public void Display()
            {
                Console.WriteLine($"{id} {brand} {model}");
            }

        public class CarBuilder
        {
            public int id { get; set; }
            public string brand { get; set; }
            public string color { get; set; }
            public string model { get; set; }

            public CarBuilder Id(int id)
            {
                this.id = id;
                return this;
            }

            public CarBuilder Brand(String brand)
            {
                this.brand = brand;
                return this;
            }

            public CarBuilder Color(string color)
            {
                this.color = color;
                return this;
            }
            public CarBuilder Model(string model)
            {
                this.model = model;
                return this;
            }

            public Car Build() 
            {
                return new Car(this);
            }

        }

    }
}
