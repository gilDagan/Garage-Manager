using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class FuelBasedCar : FuelBasedVehicles
    {
        Car.eColor m_color;
        Car.eNunDoors m_numDoors;
        private const eFuelType k_FuelType = eFuelType.Octan95;
        private const int k_NumberOfTirs = 4;
        private const float k_MaxTank = 45f;
        private const int k_MaxPrashore = 32;

        public FuelBasedCar()
            : base(k_FuelType, k_NumberOfTirs, k_MaxPrashore, k_MaxTank)
        {
        }

        public Car.eColor Color
        {
            get
            {
                return m_color;
            }
            set
            {
                m_color = value;
            }
        }

        public Car.eNunDoors NumberOfDoors
        {
            get
            {
                return m_numDoors;
            }
            set
            {
                m_numDoors = value;
            }
        }

        public override string ToString()
        {
            string stringInformationFuelCar;

            stringInformationFuelCar = string.Format(
            @"This is fuel base car,
            color: {0}
            number of doors: {1}
            Fuel type: {2}
             {3}", m_color, m_numDoors, k_FuelType, base.ToString());
            return stringInformationFuelCar;
        }
    }
}