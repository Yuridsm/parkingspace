using Test.Entities;
using Test.Enums;

namespace Test.ParkingSpaceStrategies
{
    public class MotorcycleParkingSpaceCalculateStrategy : IParkingSpaceCalculateStrategy
    {
        public int Execute(List<ParkingSpace> availableQuantity, ParkingSpaceStatus status)
        {
            var availableParkingSpaceToVan = availableQuantity
                    .Where(o => o.Type == ParkingSpaceType.VAN && o.Status == status)
                    .Count();
                
                var availableParkingSpaceToCar = availableQuantity
                    .Where(o => o.Type == ParkingSpaceType.CAR && o.Status == status)
                    .Count();

                var availableParkingSpaceToMotorcycle = availableQuantity
                    .Where(o => o.Type == ParkingSpaceType.MOTORCYCLE && o.Status == status)
                    .Count();

                return availableParkingSpaceToCar + 
                       availableParkingSpaceToMotorcycle +
                       availableParkingSpaceToVan;
        }
    }
}