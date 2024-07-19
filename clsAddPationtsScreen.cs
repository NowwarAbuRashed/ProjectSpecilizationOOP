using clsMyLiprary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;
using static ProjectSpecilizationOOP_C_.clsMainScreen;

namespace ProjectSpecilizationOOP_C_
{
    internal class clsAddPationtsScreen
    {


        static private void _AddPationt(int specialization, string Name, int statis)
        {
            if((eStatis)statis== eStatis.regular)
            {
                clsGlobal.Specializations[specialization].AddLast(Name + " regular");
            }
            else
            {
                clsGlobal.Specializations[specialization].AddFirst(Name + " urgent");
            }


        }
        static private void _AddPationts()
        {
            Console.WriteLine("Enter specialization, name, statis: ");
            int specialization =clsInputValidate.ReadIntNumberBetween(1, 20);
            string Name = clsInputValidate.ReadString();
            int statis = clsInputValidate.ReadIntNumberBetween(0, 1);

            if (!clsInputValidate.IsNumberBetween(clsGlobal.Specializations[specialization].Count,0,4))
            {
                Console.WriteLine("\nSorry we can,t add mor patients for this specialization");
                return;
            }

            _AddPationt(specialization, Name, statis);

            Console.WriteLine("\nAdd Patient is sucsessfaly :-)");
        }


        static public void AddPationts()
        {


            _AddPationts();
        }

    }
}
