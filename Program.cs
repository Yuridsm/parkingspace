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

            Console.WriteLine($"There are {park.AvailableParkingSpace(ParkingSpaceType.VAN)} parking space to {nameof(ParkingSpaceType.VAN)}\n");

            foreach(var item in park.AvailableQuantity)
                Console.WriteLine($"{item.Identifier} - {item.Type} - {item.Status}");
        }
    }
}