using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ProjectSpecilizationOOP_C_
{
    internal class clsPrintPatientsScreen
    {

        private static void _PrintPatients()
        {
            for (int i = 0; i <clsGlobal.Specializations.Count; i++)
            {
                if (clsGlobal.Specializations[i].Count == 0)
                    continue;

                int specializationSize = clsGlobal.Specializations[i].Count;
                Console.WriteLine($"There are {specializationSize} patients in specialization {i}");

                foreach (var patient in clsGlobal.Specializations[i])
                {
                    Console.WriteLine(patient);
                }
                Console.WriteLine("\n\n");
            }


        }

        public static void PrintPatients()
        {
            _PrintPatients();
        }
    }
}
