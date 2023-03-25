using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UserBasicInformation
{
    internal class Program
    {
        public enum Gender
        {
            Male,
            Female
        }
        static void Main(string[] args)
        {
            int year, month, day;
            char gender;

            Console.WriteLine("Enter your born year.");
            year = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter month.");
            month = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter day.");
            day = int.Parse(Console.ReadLine());

            Console.WriteLine("Select your gender (M/F).");
            gender = char.Parse(Console.ReadLine());

            DateTime userDateOfBirth = new DateTime(year, month, day);
            Console.WriteLine(userDateOfBirth.ToString("dd/MM/yyyy"));

            string checkGender;

            if (gender == 'M' || gender == 'm')
            {
                checkGender = Gender.Male.ToString();
                Console.WriteLine("You will be retired at 65 years old.");
            }
            else if (gender == 'F' || gender == 'f')
            {
                checkGender = Gender.Female.ToString();
                Console.WriteLine("You will be retired at 63 years old.");
            }
            else
            {
                checkGender = null;
            }
        }
    }
}
