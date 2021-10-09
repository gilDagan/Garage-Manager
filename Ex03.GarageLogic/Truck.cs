using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class Truck : FuelBasedVehicles
    {
        private bool m_IsContainDangerouSsubstance;
        private float m_MaxCarryingWeight;
        private const eFuelType k_FuelType = eFuelType.Soler;
        private const int k_NumberOfTires = 16;
        private const float k_MaxTank = 120f;
        private const int k_MaxPrashore = 26;

        public Truck()
            : base(k_FuelType, k_NumberOfTires, k_MaxPrashore, k_MaxTank)
        {
        }

        public bool IsContainDangerousSubstances
        {
            get
            {
                return m_IsContainDangerouSsubstance;
            }
            set
            {
                m_IsContainDangerouSsubstance = value;
            }
        }

        public float MaxCarryingWeight
        {
            get
            {
                return m_MaxCarryingWeight;
            }
            set
            {
                m_MaxCarryingWeight = value;
            }
        }

        public override string ToString()
        {
            string stringInformationTruck;

            stringInformationTruck = string.Format(
            @"This is Truck,
            Fuel type: {0}
            Is contain dangerou substance: {1}
            Max carrying weight: {2},
            {3}",
            k_FuelType,
            m_IsContainDangerouSsubstance,
            m_MaxCarryingWeight,
            base.ToString());

            return stringInformationTruck;
        }
    }
}