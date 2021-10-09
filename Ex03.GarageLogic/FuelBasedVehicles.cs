using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class FuelBasedVehicles : Vehicle
    {
        protected eFuelType m_VehicleFuelType;
        protected float m_VehichleMaxTank;

        public enum eFuelType
        {
            Soler = 1,
            Octan95,
            Octan96,
            Octan98
        }

        public FuelBasedVehicles(eFuelType i_FuelType, int i_NumberOfTires, int i_MaxPrashore, float i_MaxEnergiSource)
            : base(i_NumberOfTires, i_MaxPrashore, i_MaxEnergiSource)
        {
            m_VehicleFuelType = i_FuelType;
            m_VehichleMaxTank = i_MaxEnergiSource;
        }

        public eFuelType VehicleFuelType
        {
            get
            {
                return m_VehicleFuelType;
            }
            set
            {
                m_VehicleFuelType = value;
            }
        }

        public void Refuel(float i_HowMuchFuelToAdd, eFuelType i_FuelType)
        {
            Console.WriteLine(m_CurrentEnergySource);
            if (m_VehicleFuelType != i_FuelType)
            {
                throw new ArgumentException();
            }
            else
            {
                if (i_HowMuchFuelToAdd + m_CurrentEnergySource > m_VehichleMaxTank)
                {
                    throw new ValueOutOfRangeException(0, m_VehichleMaxTank - m_CurrentEnergySource);
                }
                else
                {
                    m_CurrentEnergySource += i_HowMuchFuelToAdd;
                }
            }
        }

        public float CurrentFuel
        {
            get
            {
                return m_CurrentEnergySource;
            }
            set
            {
                m_CurrentEnergySource = value;
            }
        }

        public override string ToString()
        {
            string stringInformationFuelBaseVehicle;

            stringInformationFuelBaseVehicle = string.Format(
            @"this vehicle based on Fuel
            the current fuel is: [{0}/{1}]
            {2}",
            m_CurrentEnergySource,
            m_VehichleMaxTank,
            base.ToString());
            return stringInformationFuelBaseVehicle;
        }
    }
}