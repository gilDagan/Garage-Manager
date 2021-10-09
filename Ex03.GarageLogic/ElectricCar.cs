using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class ElectricCar : ElectricBasedVehicles
    {
        Car.eColor m_color;
        Car.eNunDoors m_numDoors;
        private const int k_NumberOfTirs = 4;
        private const float k_MaxEngine = 3.2f;
        private const int k_MaxPressure = 32;

        public ElectricCar()
            : base(k_NumberOfTirs, k_MaxPressure, k_MaxEngine)
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
            string stringInformationElectricCar;

            stringInformationElectricCar = string.Format(
            @"This is electric car,
            color: {0}
            number of doors: {1}
            {2}",
            m_color,
            m_numDoors,
            base.ToString());

            return stringInformationElectricCar;
        }
    }
}