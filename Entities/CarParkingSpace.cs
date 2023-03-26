using Test.Enums;

namespace Test.Entities
{
    public class CarParkingSpace : ParkingSpace
    {
        public static CarParkingSpace Create(ParkingSpaceStatus status = ParkingSpaceStatus.FREE)
        {
            var car = new CarParkingSpace();
            car.Type = ParkingSpaceType.CAR;
            car.Status = status;
            return car;
        }
    }
}