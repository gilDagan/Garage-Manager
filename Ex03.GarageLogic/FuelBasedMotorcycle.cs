using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class FuelBasedMotorcycle : FuelBasedVehicles
    {
        Motorcycle.eLicenseType m_LicenseType;
        int m_EngineCapacity;
        private const eFuelType k_FuelType = eFuelType.Octan98;
        private const int k_NumberOfTirs = 2;
        private const float k_MaxTank = 6f;
        private const int k_MaxPressure = 30;

        public FuelBasedMotorcycle()
            : base(k_FuelType, k_NumberOfTirs, k_MaxPressure, k_MaxTank)
        {
        }

        public Motorcycle.eLicenseType LicenseType
        {
            get
            {
                return m_LicenseType;
            }
            set
            {
                m_LicenseType = value;
            }
        }

        public int Enginecapacity
        {
            get
            {
                return m_EngineCapacity;
            }
            set
            {
                m_EngineCapacity = value;
            }
        }

        public override string ToString()
        {
            string stringInformationFuelBasedMotorcycle;

            stringInformationFuelBasedMotorcycle = string.Format(
            @"This is fuel based motorcycle,
            License type: {0}
            Engine capacity: {1}
            Fuel type = {2}
            {3}", 
            m_LicenseType,
            m_EngineCapacity,
            k_FuelType,
            base.ToString());

            return stringInformationFuelBasedMotorcycle;
        }
    }
}