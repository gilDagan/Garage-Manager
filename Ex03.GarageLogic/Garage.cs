using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class Garage
    {
        private Dictionary<string, OwnerInformation> m_VehiclesInTheGarage;

        public Garage()
        {
            m_VehiclesInTheGarage = new Dictionary<string, OwnerInformation>();
        }

        public Dictionary<string, OwnerInformation> VehicleInTheGarage
        {
            get
            {
                return m_VehiclesInTheGarage;
            }
        }

        public string AddNewVehicle(string i_VehicleOwnerName, string i_VehicleOwnerPhone, Vehicle i_Vehicle)
        {
            StringBuilder inGarageMessage = new StringBuilder();

            if (VehicleInTheGarage.ContainsKey(i_Vehicle.LicensingNumber))
            {
                VehicleInTheGarage[i_Vehicle.LicensingNumber].VehicleStatus = OwnerInformation.eVehicleStatus.InRepaired;
                inGarageMessage.AppendFormat("Vehicle number {0} is already in the system", i_Vehicle.LicensingNumber);
            }
            else
            {
                OwnerInformation ownerInformationToInsert = new OwnerInformation(i_VehicleOwnerName, i_VehicleOwnerPhone, i_Vehicle);
                VehicleInTheGarage.Add(i_Vehicle.LicensingNumber, ownerInformationToInsert);
                inGarageMessage.AppendFormat("Vehicle number {0} was inserted into the garage", i_Vehicle.LicensingNumber);
            }

            return inGarageMessage.ToString();
        }

        public List<string> ListOfLicensingNumberOfTheVehicleInTheGarage()
        {
            List<string> vehicleListInTheGarage = new List<string>();

            foreach (KeyValuePair<string, OwnerInformation> vehicle in VehicleInTheGarage)
            {
                vehicleListInTheGarage.Add(vehicle.Key);
            }

            return vehicleListInTheGarage;
        }

        public List<string> ListOfLicensingNumberOfTheVehicleInTheGarageByStatus(OwnerInformation.eVehicleStatus i_Status)
        {
            List<String> vehicleListInTheGarage = new List<string>();

            foreach (KeyValuePair<string, OwnerInformation> vehicle in VehicleInTheGarage)
            {
                if (vehicle.Value.VehicleStatus == i_Status)
                {
                    vehicleListInTheGarage.Add(vehicle.Key);
                }
            }

            return vehicleListInTheGarage;
        }

        public bool IsInGarege(string  i_LicanseNumber)
        {
            bool isExist = false;

            foreach (KeyValuePair<string, OwnerInformation> vehicle in VehicleInTheGarage)
            {
                if (vehicle.Key == i_LicanseNumber)
                {
                    isExist = true;
                }
            }

            return isExist;
        }

        public void ChangeStatusVehicle(string i_licensingNumber, OwnerInformation.eVehicleStatus i_NewStatus)
        {
            if (i_NewStatus != VehicleInTheGarage[i_licensingNumber].VehicleStatus)
            {
                VehicleInTheGarage[i_licensingNumber].VehicleStatus = i_NewStatus;
            }
        }

        public void InflateTiresToMax(string i_licensingNumber)
        {
            foreach (Tires tire in VehicleInTheGarage[i_licensingNumber].Vehicle.Tire)
            {
                tire.Inflatoin(tire.MaxAirPressure - tire.CurrentAirPressure);
            }
        }

        public void RefuelAFuelBasedVehicle(string i_licensingNumber, FuelBasedVehicles.eFuelType i_FuelType, float i_AmountToFill)
        {
            (VehicleInTheGarage[i_licensingNumber].Vehicle as FuelBasedVehicles).Refuel(i_AmountToFill, i_FuelType);
        }

        public void ChargeAnElectricBasedVehicle(string i_licensingNumber, float i_NumberOfMinutesToCharge)
        {
            ElectricBasedVehicles vehicle = (VehicleInTheGarage[i_licensingNumber].Vehicle as ElectricBasedVehicles);
            vehicle.Recharge(i_NumberOfMinutesToCharge);
        }

        public string DisplayVehicleInformation(string i_licensingNumber)
        { 
            return (VehicleInTheGarage[i_licensingNumber]).ToString();
        }

        public class OwnerInformation
        {
            private string m_OwnerName;
            private string m_OwnerPhone;
            eVehicleStatus m_VehicleStatus;
            Vehicle m_Vehicle;

            public OwnerInformation(string i_VehicleOwnerName, string i_VehicleOwnerPhone, Vehicle i_Vehicle)
            {
                m_OwnerName = i_VehicleOwnerName;
                m_OwnerPhone = i_VehicleOwnerPhone;
                m_VehicleStatus = eVehicleStatus.InRepaired;
                m_Vehicle = i_Vehicle;
            }

            public string OwnerName
            {
                get
                {
                    return m_OwnerName;
                }
                set
                {
                    m_OwnerName = value;
                }
            }

            public string OwnerPhoneNumber
            {
                get
                {
                    return m_OwnerPhone;
                }
                set
                {
                    m_OwnerPhone = value;
                }
            }

            public eVehicleStatus VehicleStatus
            {
                get
                {
                    return m_VehicleStatus;
                }
                set
                {
                    m_VehicleStatus = value;
                }
            }

            public Vehicle Vehicle
            {
                get
                {
                    return m_Vehicle;
                }
            }

            public enum eVehicleStatus
            {
                InRepaired = 1,
                Repaired,
                Paid
            }

            public override string ToString()
            {
                string vehicleInformationOutput = string.Format(
                @"{0}
                Owner name: {1}
                Phone number: {2}
                Status: {3}
                ",
                Vehicle.ToString(),
                m_OwnerName,
                m_OwnerPhone,
                m_VehicleStatus);

                return vehicleInformationOutput;
            }
        }
    }
}
