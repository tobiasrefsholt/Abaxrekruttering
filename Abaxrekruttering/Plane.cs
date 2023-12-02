namespace Abaxrekruttering;

public class Plane : Vehicle
{
    private int _wingSpan;
    private int _weightNoCargo;
    private int _maxCargoWeight;

    public Plane(string registration, int effect, VehicleType vehicleType, int wingSpan, int weightNoCargo,
        int maxCargoWeight) : base(registration, effect, vehicleType)
    {
        _wingSpan = wingSpan;
        _weightNoCargo = weightNoCargo;
        _maxCargoWeight = maxCargoWeight;
    }

    protected override void PrintInfo()
    {
        throw new NotImplementedException();
    }

    public void Drive()
    {
        throw new NotImplementedException();
    }
}