using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Abaxrekruttering;

public enum VelocityUnit
{
    [Display(Name = "m/s")]
    MetersPerSecond,
    
    [Display(Name = "km/h")]
    KilometersPerHour,
    
    [Display(Name = "Kn")]
    Knot
}