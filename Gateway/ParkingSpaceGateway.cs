using Test.Entities;
using Test.Enums;

namespace Test.Gateway
{
    public class ParkingSpaceGateway : IGateway
    {
        public List<ParkingSpace> GetParkingSpace()
        {
            var availableQuantity = new List<ParkingSpace>(10);
            
            availableQuantity.Add(CarParkingSpace.Create(ParkingSpaceStatus.FILLED));
            availableQuantity.Add(CarParkingSpace.Create(ParkingSpaceStatus.FILLED));
            availableQuantity.Add(CarParkingSpace.Create());
            availableQuantity.Add(CarParkingSpace.Create());

            availableQuantity.Add(MotorcycleParkingSpace.Create(ParkingSpaceStatus.FILLED));
            availableQuantity.Add(MotorcycleParkingSpace.Create());
            availableQuantity.Add(MotorcycleParkingSpace.Create());

            availableQuantity.Add(VanParkingSpace.Create());
            availableQuantity.Add(VanParkingSpace.Create());
            availableQuantity.Add(VanParkingSpace.Create());


            return availableQuantity;
        }
    }
}