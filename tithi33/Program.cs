using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tithi33
{
    public class snearaself
    {
        public string firstName;
        public string lastName;
        public void Lover()
        {
            Console.WriteLine("Sneara likes " + " " + firstName + " " + lastName);
            Console.ReadLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            snearaself male = new snearaself();
            male.firstName = "Abul Ala";
            male.lastName = "Walid";
            male.Lover();
        }
    }
}
