using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerExtensionTask.Models
{
    internal class Car
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public int ProducedYear { get; set; }

        public override string ToString()
        {
            return $"Car {Name} has {Colour} colour  and was produced in {ProducedYear}";
        }
    }
}
