using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class ElectricMotorcycle : ElectricBasedVehicles
    {
        Motorcycle.eLicenseType m_LicenseType;
        int m_EngineCapacity;
        private const int k_NumberOfTirs = 2;
        private const float k_MaxEngine = 1.8f;
        private const int k_MaxPrashore = 30;

        public ElectricMotorcycle()
            : base(k_NumberOfTirs, k_MaxPrashore, k_MaxEngine)
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

        public int EngineCapacity
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
            string stringInformationElectricMotorcycle;

            stringInformationElectricMotorcycle = string.Format(
            @"This is electric Motorcycle
            License type: {0}
            Engine capacity: {1},
            {2}",
            m_LicenseType,
            m_EngineCapacity,
            base.ToString());

            return stringInformationElectricMotorcycle;
        }
    }
}