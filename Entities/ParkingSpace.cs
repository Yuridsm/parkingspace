using Test.Enums;

namespace Test.Entities
{
    public abstract class ParkingSpace : IEntity
    {
        public Guid Identifier { get; } = Guid.NewGuid();
        public ParkingSpaceType Type { get; protected set; }
        public ParkingSpaceStatus Status { get; protected set; }
    }
}