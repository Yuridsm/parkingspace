using Test.Entities;
using Test.Enums;

namespace Test.ParkingSpaceStrategies
{
    public class CarParkingSpaceCalculateStrategy : IParkingSpaceCalculateStrategy
    {
        public int Execute(List<ParkingSpace> availableQuantity, ParkingSpaceStatus status)
        {
            var availableParkingSpaceToVan = availableQuantity
                    .Where(o => o.Type == ParkingSpaceType.VAN && o.Status == status)
                    .Count();
                
                var availableParkingSpaceToCar = availableQuantity
                    .Where(o => o.Type == ParkingSpaceType.CAR && o.Status == status)
                    .Count();

                return availableParkingSpaceToCar + availableParkingSpaceToVan;
        }
    }
}