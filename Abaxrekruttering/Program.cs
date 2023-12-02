using Abaxrekruttering;

var vehicleList = new VehicleList();
var car1 = new Car("NF123456", 147, VehicleType.LightVehicle, "grønn", 200, VelocityUnit.KilometersPerHour);
var car2 = new Car("NF654321", 150, VehicleType.LightVehicle, "blå", 195, VelocityUnit.KilometersPerHour);
var plane = new Plane("LN1234", 1000, VehicleType.JetPlane, 30, 10000, 2000);
var boat = new Boat("ABC123", 100, VehicleType.Jolle, 30, VelocityUnit.Knot, 500);

vehicleList.AddVehicle(car1);
vehicleList.AddVehicle(car2);
vehicleList.AddVehicle(plane);
vehicleList.AddVehicle(boat);

vehicleList.ShowAll();

var compareMessage = vehicleList.Compare(0, 1) ? "Bilene er like" : "Bilene er ikke like";
Console.WriteLine(compareMessage);