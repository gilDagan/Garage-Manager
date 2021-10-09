using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class Vehicle
    {
        protected string m_ModelName;
        protected string m_LicensingNumber;
        protected List<Tires> m_Tire;
        protected float m_EnergyPrecent;
        protected Factory.ePossibleVehicles m_VehicleType;
        protected int m_NumberOfTires;
        protected float m_MaxTireAirPressure;
        protected float m_MaxEnergySource;
        protected float m_CurrentEnergySource;

        public Vehicle(int i_NumberOfTires, int i_MaxTireAirPressure, float i_MaxEnergySource)
        {

            m_NumberOfTires = i_NumberOfTires;
            m_MaxEnergySource = i_MaxEnergySource;
            m_MaxTireAirPressure = i_MaxTireAirPressure;
            m_Tire = new List<Tires>(m_NumberOfTires);
        }

        public Factory.ePossibleVehicles VehicleType
        {
            get
            {
                return m_VehicleType;
            }
            set
            {
                m_VehicleType = value;
            }
        }

        public List<Tires> Tire
        {
            get
            {
                return m_Tire;
            }
            set
            {
                m_Tire = value;
            }

        }

        public float MaxEnergySource
        {
            get
            {
                return m_MaxEnergySource;
            }
            set
            {
                m_MaxEnergySource = value;
            }
        }

        public float CurrentEnergySource
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

        public void SetTireInfo(string i_ManufacturerName, float i_MaxAirPressure, float i_CurrentAirPressure)
        {
            if ((i_MaxAirPressure >= i_CurrentAirPressure) && (i_CurrentAirPressure >= 0))
            {
                for (int i = 0; i <= m_NumberOfTires; i++)
                {
                    Tires currentTire = new Tires(i_ManufacturerName, i_MaxAirPressure, i_CurrentAirPressure);
                    Tire.Add(currentTire);
                }
            }
            else
            {
                throw new ValueOutOfRangeException(0, i_MaxAirPressure);
            }
        }

        public float EnergyPrecent
        {
            get
            {
                return m_EnergyPrecent = (CurrentEnergySource / MaxEnergySource) * 100;
            }
        }

        public string ModelName
        {
            get
            {
                return m_ModelName;
            }
            set
            {
                m_ModelName = value;
            }
        }

        public string LicensingNumber
        {
            get
            {
                return m_LicensingNumber;
            }
            set
            {
                m_LicensingNumber = value;
            }
        }

        public float MaxTireAirPressure
        {
            get
            {
                return m_MaxTireAirPressure;
            }
        }

        public override string ToString()
        {
            string vehicleInformationOutput;

            vehicleInformationOutput = string.Format(
            @"Vehicle:
            --------------------------------
            License Number: {0}
            Model Name: {1}
            Energy Percentage Left: {2}%
            Number of tires: {3},
            {4}",
            LicensingNumber,
            ModelName,
            EnergyPrecent,
            m_NumberOfTires,
            Tire[0].ToString());

            return vehicleInformationOutput;
        }
    }
}