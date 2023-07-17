using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowingTest
{

    public class Patient
    {
        public string GetPatient()
        {
            return "Base Patient";
        }
    }

    public class GoldPatient:Patient
    {
        public string GetPatient()
        {
            return "Child Patient";
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Patient patient = new Patient();
            Console.WriteLine(patient.GetPatient());
        }
    }
}
