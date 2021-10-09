using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class Tires
    {
        private string m_ManufacturerName;
        private float m_MaxAirPressure;
        private float m_CurrentAirPressure;

        public Tires(string i_ManufacturerName, float i_MaxAirPressure, float i_CurrentAirPressure)
        {
            m_ManufacturerName = i_ManufacturerName;
            m_MaxAirPressure = i_MaxAirPressure;
            m_CurrentAirPressure = i_CurrentAirPressure;
        }

        public string ManufacturerName
        {
            get
            {
                return m_ManufacturerName;
            }
            set
            {
                m_ManufacturerName = value;
            }
        }

        public float MaxAirPressure
        {
            get
            {
                return m_MaxAirPressure;
            }
            set
            {
                m_MaxAirPressure = value;
            }
        }

        public float CurrentAirPressure
        {
            get
            {
                return m_CurrentAirPressure;
            }
            set
            {
                m_CurrentAirPressure = value;
            }
        }

        public void Inflatoin(float i_AirPressiroToAdd)
        {
            CurrentAirPressure += i_AirPressiroToAdd;
        }

        public override string ToString()
        {
            string TireInformationOutput;

            TireInformationOutput = string.Format(
            @"Tires
            Manufacturer: {0}
            Current air pressure: {1}
            Max air pressure: {2}",
            m_ManufacturerName,
            m_CurrentAirPressure,
            m_MaxAirPressure);

            return TireInformationOutput;
        }
    }
}