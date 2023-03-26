using Test.Entities;
using Test.Enums;

namespace Test.ParkingSpaceStrategies
{
    public class VanParkingSpaceCalculateStrategy : IParkingSpaceCalculateStrategy
    {
        public int Execute(List<ParkingSpace> availableQuantity, ParkingSpaceStatus status)
        {
            int conversionFactorFromCarToVan = 3;

                var availableParkingSpaceToVan = availableQuantity
                    .Where(o => o.Type == ParkingSpaceType.VAN && o.Status == ParkingSpaceStatus.FREE)
                    .Count();
                
                var availableParkingSpaceToCar = availableQuantity
                    .Where(o => o.Type == ParkingSpaceType.CAR && o.Status == ParkingSpaceStatus.FREE)
                    .Count();

                return availableParkingSpaceToVan + 
                       (availableParkingSpaceToCar / conversionFactorFromCarToVan);
        }
    }
}