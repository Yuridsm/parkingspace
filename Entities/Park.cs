using Test.Enums;
using Test.Exceptions;
using Test.Gateway;
using Test.ParkingSpaceStrategies;

namespace Test.Entities
{
    public class Park : IEntity
    {
        private readonly IGateway _gateway;
        private List<ParkingSpace> _availableQuantity = new();
        private ParkingSpaceCalculateContext _parkingSpaceCalculateContext;

        public Guid Identifier { get; set; }

        public List<ParkingSpace> AvailableQuantity 
        { 
            get
            {
                if(_availableQuantity.Count() == 0)
                    _availableQuantity = _gateway.GetParkingSpace();

                return _availableQuantity;
            }
        }

        public Park(IGateway gateway)
        {
            _gateway = gateway;
            _parkingSpaceCalculateContext = new ParkingSpaceCalculateContext();
        }

        public int AvailableParkingSpace(ParkingSpaceType type)
        {
            // MOTORCYCLE
            if(type == ParkingSpaceType.MOTORCYCLE)
            {
                _parkingSpaceCalculateContext.SetStrategy(new MotorcycleParkingSpaceCalculateStrategy());
                return _parkingSpaceCalculateContext.FreeParkingSpaceCalculate(AvailableQuantity);
            }

            // CAR
            if(type == ParkingSpaceType.CAR)
            {
                _parkingSpaceCalculateContext.SetStrategy(new CarParkingSpaceCalculateStrategy());
                return _parkingSpaceCalculateContext.FreeParkingSpaceCalculate(AvailableQuantity);
            }

            // VAN
            if(type == ParkingSpaceType.VAN)
            {
                _parkingSpaceCalculateContext.SetStrategy(new VanParkingSpaceCalculateStrategy());
                return _parkingSpaceCalculateContext.FilledParkingSpaceCalculate(AvailableQuantity);
            }

            throw new ParkingSpaceTypeNotFoundException("Parking Space Type Not Found.");
        }
    }
}