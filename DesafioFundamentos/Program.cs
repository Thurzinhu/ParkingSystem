using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal initialFee = 0;
decimal pricePerHour = 0;

Console.Write("Welcome to the parking lot system!\n" +
                  "Type the initial fee: ");
initialFee = Convert.ToDecimal(Console.ReadLine());

Console.Write("Type the price per hour: ");
pricePerHour = Convert.ToDecimal(Console.ReadLine());

ParkingLot parkingLot = new ParkingLot(initialFee, pricePerHour);

string option = string.Empty;
bool showMenu = true;

while (showMenu)
{
    Console.Clear();
    Console.WriteLine("Type option: ");
    Console.WriteLine("1 - Add new vehicle");
    Console.WriteLine("2 - Remove vehicle");
    Console.WriteLine("3 - Print vehicles");
    Console.WriteLine("4 - End program");

    switch (Console.ReadLine())
    {
        case "1":
            parkingLot.AddVehicle();
            break;

        case "2":
            parkingLot.RemoveVehicle();
            break;

        case "3":
            parkingLot.PrintVehicles();
            break;

        case "4":
            showMenu = false;
            break;

        default:
            Console.WriteLine("Invalid option");
            break;
    }

    Console.WriteLine("Press any key to continue");
    Console.ReadLine();
}