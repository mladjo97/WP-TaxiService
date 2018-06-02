﻿using TaxiServiceWebAPI.Helpers;

namespace TaxiServiceWebAPI.Models
{
    public class Vehicle
    {
        public Driver CarDriver { get; set; }
        public int VehicleAge { get; set; }
        public string NumberOfRegistration { get; set; }
        public string TaxiNumber { get; set; }
        public VehicleTypes VehicleType { get; set; } = VehicleTypes.Passenger;

        public Vehicle() { }

    }
}