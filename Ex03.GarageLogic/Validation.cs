using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class Validation
    {
        public static bool CheckName(string i_Name)
        {
            bool isValidName = true;

            if (i_Name.Length == 0)
            {
                Console.Write("You must enter a name, please enter again: ");
                isValidName = false;
            }
            else
            {
                foreach (char someChar in i_Name)
                {
                    if (!char.IsLetter(someChar) && someChar != ' ')
                    {
                        Console.Write("Name must contain only letters or spaces, please enter again: ");
                        isValidName = false;
                        break;
                    }
                }
            }

            return isValidName;
        }

        public static bool CheckOwnerPhoneNumber(string i_PhoneNumber)
        {
            bool isValidPhoneNumber = true;

            if (i_PhoneNumber.Length != 10)
            {
                Console.Write("Phone number contein 10 numbers, please enter again: ");
                isValidPhoneNumber = false;
            }
            else
            {
                foreach (char someChar in i_PhoneNumber)
                {
                    if (!char.IsDigit(someChar))
                    {
                        Console.Write("Phone number must contain only numbers, please enter again: ");
                        isValidPhoneNumber = false;
                        break;
                    }
                }
            }

            return isValidPhoneNumber;
        }

        public static bool CheckLicenseNumber(string i_LicenseNumber)
        {
            bool isValidLicenseNumber = true;

            if (i_LicenseNumber.Length != 7 && i_LicenseNumber.Length != 8)
            {
                Console.Write("You must enter a license number with 7 or 8 digits, please enter again: ");
                isValidLicenseNumber = false;
            }
            else
            {
                foreach (char someChar in i_LicenseNumber)
                {
                    if (!char.IsDigit(someChar))
                    {
                        Console.Write("License number must contain digits only, please enter again: ");
                        isValidLicenseNumber = false;
                        break;
                    }
                }
            }

            return isValidLicenseNumber;
        }

        public static int ReceiveEnumInput<T>()
        {
            int selectedOption = -1;
            bool isValidInput = false;
            string userSelection;

            while (!isValidInput)
            {
                userSelection = Console.ReadLine();
                if (int.TryParse(userSelection, out selectedOption))
                {
                    isValidInput = IsInEnumOptionRange<T>(selectedOption);
                }
                else
                {
                    throw new FormatException();
                }

                if (!isValidInput)
                {
                    Console.Write("Invalid input, please try again: ");
                }
            }

            return selectedOption;
        }


        public static bool IsInEnumOptionRange<T>(int i_Selection)
        {
            return Enum.IsDefined(typeof(T), i_Selection);
        }


        public static bool CheckEngineCapacity(int i_engineCapacity)
        {          
            if (i_engineCapacity < 0)
            {
               throw new ArgumentException("Engine Capacity number must contain positive number");
            }

            return true;
        }

        public static bool CheckCurrentEnergy(float i_CurrentEnergy, float i_MaxEnergy)
        {
            if (i_CurrentEnergy > i_MaxEnergy)
            {
                throw new ValueOutOfRangeException(0, i_MaxEnergy);       
            }

            return true;
        }

        public static bool CheckAnsDangerus(string i_AnsDangerus)
        {
            bool isValidInput = true;
            bool ansDangerus;

            try
            {
                ansDangerus = bool.Parse(i_AnsDangerus);

            }
            catch
            {
                Console.WriteLine("You didnt enter a invalid input, please enter again:");
                isValidInput = false;
            }

            return isValidInput;
        }

        public static bool CheckMaxTank(string i_MaxTank)
        {
            bool isValidInput = true;
            float ansDangerus;

            try
            {
                ansDangerus = float.Parse(i_MaxTank);
            }
            catch
            {
                Console.WriteLine("You didnt enter a invalid input, please enter again:");
                isValidInput = false;
            }

            return isValidInput;
        }
    }
}
