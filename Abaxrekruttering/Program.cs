using Abaxrekruttering;

var vehicleList = new VehicleList();
vehicleList.AddVehicle(new Car("NF123456", 147, VehicleType.LightVehicle, "grønn" ,200,VelocityUnit.KilometersPerHour));
vehicleList.AddVehicle(new Car("NF654321", 150, VehicleType.LightVehicle, "blå", 195, VelocityUnit.KilometersPerHour));

vehicleList.AddVehicle(new Plane("LN1234", 1000, VehicleType.JetPlane, 30, 10000, 2000));

vehicleList.AddVehicle(new Boat("ABC123", 100, VehicleType.Jolle, 30, VelocityUnit.Knot, 500));