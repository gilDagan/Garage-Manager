using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class Factory
    {
        public enum ePossibleVehicles
        {
            ElectricBasedMotorcycle = 1,
            FuelBasedMotorcycle,
            ElectricBasedCar,
            FuelBaseCar,
            Truck
        }

        public static Vehicle NewVehicle(ePossibleVehicles i_VehicleType)
        {
            Vehicle newVehicle = null;

            switch (i_VehicleType)
            {
                case ePossibleVehicles.ElectricBasedCar:
                    newVehicle = new ElectricCar();
                    break;

                case ePossibleVehicles.FuelBaseCar:
                    newVehicle = new FuelBasedCar();
                    break;

                case ePossibleVehicles.FuelBasedMotorcycle:
                    newVehicle = new FuelBasedMotorcycle();
                    break;

                case ePossibleVehicles.ElectricBasedMotorcycle:
                    newVehicle = new ElectricMotorcycle();
                    break;

                case ePossibleVehicles.Truck:
                    newVehicle = new Truck();
                    break;
            }

            return newVehicle;
        }
    }
}