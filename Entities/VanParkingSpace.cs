using Test.Enums;

namespace Test.Entities
{
    public class VanParkingSpace : ParkingSpace
    {
        public static VanParkingSpace Create(ParkingSpaceStatus status = ParkingSpaceStatus.FREE)
        {
            var van = new VanParkingSpace();
            
            van.Type = ParkingSpaceType.VAN;
            van.Status = status;

            return van;
        }
    }
}