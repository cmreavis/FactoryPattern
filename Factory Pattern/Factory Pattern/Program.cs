using Factory_Pattern;

Console.WriteLine("How many wheels are on your dream vehicle? My factory can only produce two, four, and six wheeled vehicles.\n" +
    "Any other number of wheels will result in a boring economy car.");
//receive user input
var numWheels = Convert.ToInt32(Console.ReadLine());

//calling getvehicle method
IVehicle vehicle = VehicleFactory.GetVehicle(numWheels);

//drive method for each vehicle type just prints what the 'factory' is building
vehicle.Drive();

Console.WriteLine();