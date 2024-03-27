namespace DesafioFundamentos.Models
{
    public class ParkingLot
    {
        private decimal InitialFee { get; set; }
        private decimal PricePerHour { get; set; }
        private List<string> Vehicles = new List<string>();

        public ParkingLot(decimal initialFee, decimal pricePerHour)
        {
            InitialFee = initialFee;
            PricePerHour = pricePerHour;
        }

        public void AddVehicle()
        {
            Console.Write("Type the vehicle plate: ");
            string plate = Console.ReadLine();

            Vehicles.Add(plate);

            Console.WriteLine($"\nVehicle: {plate} successfully added");
        }

        public void RemoveVehicle()
        {
            Console.Write("Type the plate of the vehicle to be removed: ");

            string plate = Console.ReadLine();

            if (Vehicles.Any(x => x.ToUpper() == plate.ToUpper()))
            {
                Console.Write("Type the number of hours the vehicle spent in the parkinglot: ");
                int hours;
                try
                {
                    hours = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Please type an integer");
                    return;
                }

                decimal total = InitialFee + (PricePerHour * hours); 
                Vehicles.Remove(plate);

                Console.WriteLine($"The vehicle {plate} was removed.\nTotal Price: {total:C}");
            }
            else
            {
                Console.WriteLine("Vehicle not parked");
            }
        }

        public void PrintVehicles()
        {
            if (Vehicles.Any())
            {
                Console.WriteLine("-----Vehicles-----");
                foreach (var plate in Vehicles)
                {
                    Console.WriteLine(plate);
                }
                Console.WriteLine("------------------");
            }
            else
            {
                Console.WriteLine("No vehicles");
            }
        }
    }
}
