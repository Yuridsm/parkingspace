using Test.Entities;
using Test.Enums;

namespace Test.ParkingSpaceStrategies
{
    public class ParkingSpaceCalculateContext
    {
        private IParkingSpaceCalculateStrategy _parkingSpaceCalculateStrategy = default!;

        public void SetStrategy(IParkingSpaceCalculateStrategy parkingSpaceCalculateStrategy)
        {
            _parkingSpaceCalculateStrategy = parkingSpaceCalculateStrategy;
        }

        public int FreeParkingSpaceCalculate(List<ParkingSpace> availableQuantity)
        {
            return _parkingSpaceCalculateStrategy.Execute(availableQuantity, ParkingSpaceStatus.FREE);
        }

        public int FilledParkingSpaceCalculate(List<ParkingSpace> availableQuantity)
        {
            return _parkingSpaceCalculateStrategy.Execute(availableQuantity, ParkingSpaceStatus.FILLED);
        }
    }
}