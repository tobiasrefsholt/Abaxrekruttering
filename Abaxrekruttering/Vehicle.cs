namespace Abaxrekruttering;

public abstract class Vehicle
{
    protected string Registration;
    protected int Effect;
    protected VehicleType VehicleType;

    protected Vehicle(string registration, int effect, VehicleType vehicleType)
    {
        Registration = registration;
        Effect = effect;
        VehicleType = vehicleType;
    }

    protected abstract void PrintInfo();
}