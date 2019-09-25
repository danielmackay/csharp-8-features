using CommercialRegistration;
using ConsumerVehicleRegistration;
using LiveryRegistration;
using System;


namespace CSharp8Features.Demos
{
    public static class Patterns
    {
        private static int Version;

        public static void Demo1()
        {
            Demo(1);
        }

        public static void Demo2()
        {
            Demo(2);
        }

        public static void Demo(int version)
        {
            Version = version;

            var soloDriver = new Car();
            var twoRideShare = new Car { Passengers = 1 };
            var threeRideShare = new Car { Passengers = 2 };
            var fullVan = new Car { Passengers = 5 };
            var emptyTaxi = new Taxi();
            var singleFare = new Taxi { Fares = 1 };
            var doubleFare = new Taxi { Fares = 2 };
            var fullValPool = new Taxi { Fares = 5 };
            var lowOccupantBus = new Bus { Capacity = 90, Riders = 15 };
            var normalBus = new Bus { Capacity = 90, Riders = 75 };
            var fullBus = new Bus { Capacity = 90, Riders = 85 };
            var lightTruck = new DeliveryTruck { GrossWeightClass = 2500 };
            var truck = new DeliveryTruck { GrossWeightClass = 4000 };
            var heavyTruck = new DeliveryTruck { GrossWeightClass = 7500 };

            Console.WriteLine($"The toll for a {nameof(soloDriver)} is {CalculateToll(soloDriver)}");
            Console.WriteLine($"The toll for a {nameof(twoRideShare)} is {CalculateToll(twoRideShare)}");
            Console.WriteLine($"The toll for a {nameof(threeRideShare)} is {CalculateToll(threeRideShare)}");
            Console.WriteLine($"The toll for a {nameof(fullVan)} is {CalculateToll(fullVan)}");
            Console.WriteLine($"The toll for a {nameof(emptyTaxi)} is {CalculateToll(emptyTaxi)}");
            Console.WriteLine($"The toll for a {nameof(singleFare)} is {CalculateToll(singleFare)}");
            Console.WriteLine($"The toll for a {nameof(doubleFare)} is {CalculateToll(doubleFare)}");
            Console.WriteLine($"The toll for a {nameof(fullValPool)} is {CalculateToll(fullValPool)}");
            Console.WriteLine($"The toll for a {nameof(lowOccupantBus)} is {CalculateToll(lowOccupantBus)}");
            Console.WriteLine($"The toll for a {nameof(normalBus)} is {CalculateToll(normalBus)}");
            Console.WriteLine($"The toll for a {nameof(fullBus)} is {CalculateToll(fullBus)}");
            Console.WriteLine($"The toll for a {nameof(lightTruck)} is {CalculateToll(lightTruck)}");
            Console.WriteLine($"The toll for a {nameof(truck)} is {CalculateToll(truck)}");
            Console.WriteLine($"The toll for a {nameof(heavyTruck)} is {CalculateToll(heavyTruck)}");

            try
            {
                CalculateToll("This will fail");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Caught an argument exception when using the wrong type");
            }

            try
            {
                CalculateToll(null);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Caught an argument exception when using null");
            }
        }

        private static object CalculateToll(object? vehicle) => Version == 1 ? CalculateTollV1(vehicle) : CalculateTollV2(vehicle);

        private static object CalculateTollV1(object? vehicle) => vehicle switch
        {
            Car _ => 2.00m,
            Taxi _ => 3.50m,
            Bus _ => 5.00m,
            DeliveryTruck _ => 10.00m,
            { } => throw new ArgumentNullException($"Not a known vehicle type"),
            null => throw new ArgumentNullException(nameof(vehicle))
        };

        /// <summary>
        /// Cars with no passengers get a 0.50 surcharge
        /// Cars with two passengers get a 0.50 discount
        /// Cars with three or mor passengers get a $1.00 discount
        /// Buses that are more than 90% full get a $1.00 discount
        /// Use nested switches
        /// </summary>
        /// <param name="vehicle"></param>
        /// <returns></returns>
        private static object CalculateTollV2(object? vehicle) => vehicle switch
        {
            Car { Passengers: 0 } => 2.50m,
            Car { Passengers: 2 } => 1.50m,
            Car { Passengers: 3 } => 1.00m,
            Car _ => 2.00m,
            Taxi _ => 3.50m,
            Bus _ => 5.00m,
            DeliveryTruck _ => 10.00m,
            { } => throw new ArgumentNullException($"Not a known vehicle type"),
            null => throw new ArgumentNullException(nameof(vehicle))
        };
    }
}

namespace ConsumerVehicleRegistration
{
    public class Car
    {
        public int Passengers { get; set; }
    }
}

namespace CommercialRegistration
{
    public class DeliveryTruck
    {
        public int GrossWeightClass { get; set; }
    }
}

namespace LiveryRegistration
{
    public class Taxi
    {
        public int Fares { get; set; }
    }

    public class Bus
    {
        public int Capacity { get; set; }
        public int Riders { get; set; }
    }

}
