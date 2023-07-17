using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowingTest
{

    public class Patient
    {
        public virtual string GetPatient()
        {
            return "Base Patient";
        }
    }

    public class GoldPatient:Patient
    {
        public new string GetPatient()
        {
            return "Child Patient";
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Patient patient = new GoldPatient();
            Console.WriteLine(patient.GetPatient());//parent method get invoked
            GoldPatient goldP = new GoldPatient();
            Console.WriteLine(goldP.GetPatient());//child method gets invoked
            
        }
    }
}
