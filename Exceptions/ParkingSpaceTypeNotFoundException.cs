namespace Test.Exceptions
{
    public class ParkingSpaceTypeNotFoundException : Exception
    {
        public ParkingSpaceTypeNotFoundException()
        {
            
        }

        public ParkingSpaceTypeNotFoundException(string message)
        : base(message)
        {
            
        }

        public ParkingSpaceTypeNotFoundException(string message, Exception inner)
        : base(message, inner)
        {
            
        }
    }
}