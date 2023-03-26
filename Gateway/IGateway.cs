using Test.Entities;

namespace Test.Gateway
{
    public interface IGateway
    {
        List<ParkingSpace> GetParkingSpace();
    }
}