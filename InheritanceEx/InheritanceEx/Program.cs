using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceEx
{
    class Bill {
        private int billNo;
        private string billDate;
        private string customerName;
    
        protected void addBill(int bn,string bd, string cn)
        {
            this.billNo = bn;
            this.billDate = bd;
            this.customerName = cn;
        }

        protected void displayBill()
        {
            Console.WriteLine("Bill Number : " + billNo);
            Console.WriteLine("Bill Date : " + billDate);
            Console.WriteLine("Customer Name : " + customerName);
        }
    }

    class MobileBill : Bill {
        private string mobileNumber;
        private int numberOfCalls;
        private int callRate;
        public void addMobileBill(int bn, string bd, string cn, string mn, int nc, int cr) {
            addBill(bn, bd, cn);
            this.mobileNumber = mn;
            this.numberOfCalls = nc;
            this.callRate = cr;
        }

        public void displayMobileBill()
        {
            Console.WriteLine("################# MOBILE BILL #################\n");
            displayBill();
            Console.WriteLine("Mobile Number : " + mobileNumber);
            Console.WriteLine("Number of Callls : " + numberOfCalls);
            Console.WriteLine("Call Rate : " + callRate);
            Console.WriteLine("\nGenerated Mobile Bill Amount is : " + (numberOfCalls * callRate));
        }
    }

    class MsebBill : Bill
    {
        private int meterNo;
        private int numberOfUnits;
        private int unitRate;


        public void addMsebBill(int bn, string bd, string cn, int metern, int numberofunits, int ur) {
            addBill(bn, bd, cn);
            this.meterNo = metern;
            this.numberOfUnits = numberofunits;
            this.unitRate = ur;
        }
        public void displayMsebBill()
        {
            Console.WriteLine("\n################# MSEB BILL #################\n");
            displayBill();
            Console.WriteLine("Meter Number : " + meterNo);
            Console.WriteLine("Number of Units : " + numberOfUnits);
            Console.WriteLine("Unit Rate : " + unitRate);
            Console.WriteLine("\nGenerated MSEB Bill Amount is : " + (numberOfUnits * unitRate));
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MobileBill mobBill = new MobileBill();
            mobBill.addMobileBill(1, "1/1/24", "Shivam", "9146721757", 10, 1);
            mobBill.displayMobileBill();

            MsebBill msBill = new MsebBill();
            msBill.addMsebBill(2, "2/1/24", "Yogesh", 2413, 14, 12);
            msBill.displayMsebBill();
        }
    }
}
