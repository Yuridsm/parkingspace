using Test.Enums;

namespace Test.Entities
{
    public class VanParkingSpace : ParkingSpace
    {
        public static VanParkingSpace Create()
        {
            var van = new VanParkingSpace();
            
            van.Type = ParkingSpaceType.VAN;
            van.Status = ParkingSpaceStatus.FREE;

            return van;
        }
    }
}