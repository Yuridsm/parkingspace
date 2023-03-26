using Test.Entities;
using Test.Enums;

namespace Test.ParkingSpaceStrategies
{
    public interface IParkingSpaceCalculateStrategy
    {
        int Execute(List<ParkingSpace> availableQuantity, ParkingSpaceStatus status);
    }
}