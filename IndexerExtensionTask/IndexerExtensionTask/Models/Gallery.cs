using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerExtensionTask.Models
{
    internal class Gallery
    {
        public string Name { get; set; }
        public Car[] Cars;

        public Car this[int index]
        {
            get => Cars[index]; 
            set
            {
                if (index > Cars.Length - 1)
                {
                    Console.WriteLine($"Given index is out of array, expand array by one element and set your value there?(Yes/Y)");
                    string response = Console.ReadLine().ToLower();
                    if (response == "y" || response == "yes")
                    {
                        Array.Resize(ref Cars, Cars.Length + 1);
                        Cars[index] = value;
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

        public bool this[string carName]
        {
            get
            {
                foreach (Car car in Cars)
                {
                    if (car.Name == carName)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public Gallery()
        {
            Cars  = new Car[0];
        }
    }
}
