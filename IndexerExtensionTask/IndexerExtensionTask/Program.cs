using IndexerExtensionTask.Models;

namespace IndexerExtensionTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 1
            Console.WriteLine("Enter  your  number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number);
            Console.WriteLine("Number is prime: "+number.IsPrime());
            Console.WriteLine("Number is power of two: "+number.IsPowOfTwo());
            //task 2
            Gallery galery = new Gallery();
            Car car = new Car()
            {
                Name = "Porche 911",
                Colour = "Yellow",
                ProducedYear = 1992
            };
            galery[0] = car;
            Console.WriteLine(galery[0]);
            Console.WriteLine(galery["Porche 911"]);
        }
    }
}
