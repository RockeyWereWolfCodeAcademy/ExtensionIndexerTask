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
            set => Cars[index] = value;
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
            Cars  = new Car[1];
        }
    }
}
