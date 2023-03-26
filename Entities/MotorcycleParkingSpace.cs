using Test.Enums;

namespace Test.Entities
{
    public class MotorcycleParkingSpace : ParkingSpace
    {
        public static MotorcycleParkingSpace Create()
        {
            var motorcycle = new MotorcycleParkingSpace();
            
            motorcycle.Type = ParkingSpaceType.MOTORCYCLE;
            motorcycle.Status = ParkingSpaceStatus.FREE;

            return motorcycle;
        }
    }
}