using Test.Enums;

namespace Test.Entities
{
    public class MotorcycleParkingSpace : ParkingSpace
    {
        public static MotorcycleParkingSpace Create(ParkingSpaceStatus status = ParkingSpaceStatus.FREE)
        {
            var motorcycle = new MotorcycleParkingSpace();
            
            motorcycle.Type = ParkingSpaceType.MOTORCYCLE;
            motorcycle.Status = status;

            return motorcycle;
        }
    }
}