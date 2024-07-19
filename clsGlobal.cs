using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSpecilizationOOP_C_
{
    internal class clsGlobal
    {

        static public List<LinkedList<string>> Specializations = new List<LinkedList<string>>(new LinkedList<string>[21]);

        static clsGlobal()
        {
            for (int i = 0; i < Specializations.Count; i++)
            {
                Specializations[i] = new LinkedList<string>();
            }
        }
    }
}
