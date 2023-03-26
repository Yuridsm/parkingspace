using Test.Entities;
using Test.Enums;
using Test.Gateway;

namespace Test
{
    public class Program
    {
        public static void Main()
        {
            // Access External System such that API, Database etc.
            IGateway gateway = new ParkingSpaceGateway();

            var park = new Park(gateway);

            Console.WriteLine($"There are {park.AvailableParkingSpace(ParkingSpaceType.MOTORCYCLE)} parking space to {nameof(ParkingSpaceType.MOTORCYCLE)}");

            foreach(var item in park.AvailableQuantity)
            {
                Console.WriteLine($"{item.Identifier} - {item.Type} - {item.Status}");
            }
            Console.WriteLine();
            foreach(var item in park.AvailableQuantity)
            {
                Console.WriteLine($"{item.Identifier} - {item.Type} - {item.Status}");
            }
        }
    }
}