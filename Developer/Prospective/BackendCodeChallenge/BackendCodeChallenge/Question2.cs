namespace BackendCodeChallenge;

 using RobotService;
 using PartsService;
 using CarService;

public class Question2
{
    private RobotService _robotService;
    private PartsService _partsService;
    private CarService _carService;

    /// Enum representing the types of robotic and automotive objects
    /// that can be built using this class.
    enum Types
    {
        RoboticDog,
        RoboticCat,
        RoboticDrone,
        RoboticCar,
        Toyota,
        Ford,
        Opel,
        Honda
    }

    public Question2(RobotService robotService, PartsService partsService)
    {
        _robotService = new RobotService();
        _partsService = new PartsService();
        _carService = new CarService();
    }

    public Robot BuildRobot(Enum RobotType)
    {
        if (IsValidType(RobotType))
        {
            var parts = GetPartsFor(RobotType);
            return _robotService.BuildRobot(parts);
        }
        else
            return null;
    }

    public Car BuildCar(Enum CarType)
    {
        if (IsValidType(CarType))
        {
            var parts = GetPartsFor(CarType);
            return _carService.BuildCar(parts);
        }
        else
            return null;
    }

    private List<Parts> GetPartsFor(Enum Type)
    {
        /*
         since methods GetCarPartsFor(Enum CarType) and GetCarPartsFor(Enum CarType) call _partsService.GetParts(Type)
         it would be best to merge them
        */
        return _partsService.GetParts(Type);
    }

    private bool IsValidType(Enum Type)
    {
        // check if the value of Type is one of the allowed robot types
        return Enum.IsDefined(typeof(Types), Type);
    }
}

