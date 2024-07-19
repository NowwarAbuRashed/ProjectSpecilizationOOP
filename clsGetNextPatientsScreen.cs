using clsMyLiprary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSpecilizationOOP_C_
{
    internal class clsGetNextPatientsScreen
    {



        private static void _GetNextPatients()
        {

            Console.WriteLine("Enter specialization: ");
            int specialization = clsInputValidate.ReadIntNumberBetween(1, 20, "Enter specialization : ");
            Console.WriteLine(specialization);

            if (clsGlobal.Specializations[specialization].Count==0)
            {
                Console.WriteLine("No Patients at the moment. Have rest, Dr");
            }
            else
            {
                Console.WriteLine($"{clsGlobal.Specializations[specialization].First.Value}  go with the Dr");

                clsGlobal.Specializations[specialization].RemoveFirst();

            }



        }

        public static void GetNextPatients()
        {
            _GetNextPatients();
        }
    }
}
