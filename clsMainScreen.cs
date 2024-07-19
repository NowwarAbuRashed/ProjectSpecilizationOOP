using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clsMyLiprary;
namespace ProjectSpecilizationOOP_C_
{
    internal class clsMainScreen
    {
        enum eChoice { AddNewPatient = 1, PrintNewPatient = 2, GetNextPatients = 3, Exit = 4 };
       public  enum  eStatis { regular = 0, urgent = 1 };


        private static void _AddPatients()
        {
            clsAddPationtsScreen.AddPationts();
        }

        private static void _PrintPatients()
        {
            clsPrintPatientsScreen.PrintPatients();
        }
        private static void _GetNextPatients()
        {
            clsGetNextPatientsScreen.GetNextPatients();
        }

        private static void _PerfromMainMenueOption(eChoice Choice)
        {
            switch (Choice)
            {
                case eChoice.AddNewPatient:
                    _AddPatients();
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case eChoice.PrintNewPatient:
                    _PrintPatients();
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case eChoice.GetNextPatients:
                    _GetNextPatients();
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case eChoice.Exit:
                    Console.Clear();
                    break;

            }

        }

        static public void ShowMainMenue()
        {


            do
            {
                Console.WriteLine("Enter your choice");
                Console.WriteLine("1) Add new Patient");
                Console.WriteLine("2) Print New Pationt");
                Console.WriteLine("3) Get Next Pationt");
                Console.WriteLine("4) Exit");

                int Choice = clsInputValidate.ReadIntNumberBetween(1, 4);

                _PerfromMainMenueOption((eChoice)Choice);

                if((eChoice)Choice==eChoice.Exit)
                {
                    return;
                }

            } while (true);




        }


    }
}
