using Car0610.CarAppCar;
using Car0610.CarAppCustomer;
using Car0610.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car0610.CarAppMain
{
    class Program
    {
        static void Main(string[] args)
        {
            RandData rand = new RandData();
            Customer[] cs = new Customer[10];
            
            for (int i = 0; i < cs.Length; i++)
            {
                cs[i] = new Customer(rand.getName(), rand.getTel(),
                    rand.getAddress(), rand.getModel(), rand.getColor(),
                    rand.getYear(), rand.getCompany());
                cs[i].printCustomerInfo();
                //Console.WriteLine(cs[i].ToString());
            }
        }
    }
}
