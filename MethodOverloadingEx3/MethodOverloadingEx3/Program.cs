using MethodOverloadingEx3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingEx3
{
    //Immplement a Class MobileBIll with mobileNumber, numberOfCalls, callRate with methods to addMobileBill and displayMobileBill.
    //Implement another class MsebBill with meterNumber, numberOfUnits, ratePerUnit and methods to addMsebBIll and displayMsebBill.
    //Implement a Bill class with billNumber, billDate, customerName and methods to addBill and displayBill.
    //Overload display bill method for MobileBill and MsebBill.
    public class MobileBill
    {
        private string mobileNumber;
        private int numberOfCalls;
        private int callRate;

        public void addMobileBill(string mnumber, int nc, int cr)
        {
            this.mobileNumber = mnumber;
            this.numberOfCalls = nc;
            this.callRate = cr;
        }

        public void displayMobileBill()
        {
            Console.WriteLine("\tMobile Number : "+mobileNumber);
            Console.WriteLine("\tNumber of Calls : " + numberOfCalls);
            Console.WriteLine("\tCall Rate : " + callRate);
            Console.WriteLine("\tGenerated Mobile Bill is : " + (callRate*numberOfCalls) + " Rs");
        }
    }

    public class MsebBill
    {
        private int meterNumber;
        private int numberOfUnits;
        private int ratePerUnit;

        public void addMsebBill(int metern, int nu, int rpu)
        {
            this.meterNumber = metern;
            this.numberOfUnits = nu;
            this.ratePerUnit = rpu;
        }

        public void displayMsebBill()
        {
            Console.WriteLine("\tMeter Number : " + meterNumber);
            Console.WriteLine("\tNumber of Units : " + numberOfUnits);
            Console.WriteLine("\tRate Per Unit : " + ratePerUnit);
            Console.WriteLine("\tGenerated Mobile Bill is : " + (ratePerUnit * numberOfUnits) + " Rs");
        }
    }

    public class Bill
    {
        private int billNumber;
        private string billDate;
        private string customerName;

        public void addBill(int bn, string bdate, string cn)
        {
            this.billNumber = bn;
            this.billDate = bdate;
            this.customerName = cn;
        }

        public void displayBill()
        {
            Console.WriteLine("\n\tBill Number : "+billNumber);
            Console.WriteLine("\tBill Date : " + billDate);
            Console.WriteLine("\tCustomer Name : " + customerName);
        }

        public void displayBill(Bill b,MobileBill mb)
        {
            Console.WriteLine("\n\n******************** GENERATED MOBILE BILL ********************");
            b.displayBill();
            mb.displayMobileBill();
        }

        public void displayBill(Bill b,MsebBill msb)
        {
            Console.WriteLine("\n******************** GENERATED MSEB BILL ********************");
            b.displayBill();
            msb.displayMsebBill();
            Console.WriteLine("\n*************************************************************");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("################## ENTER BILL DETAILS ##################");
            Console.Write("Enter Bill Number : ");
            int bNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Bill Date : ");
            string bDate = Console.ReadLine();

            Console.Write("Enter Customer Name : ");
            string cName = Console.ReadLine();

            Console.WriteLine("\n################## ENTER MOBILE BILL DETAILS ##################");
            Console.Write("Enter Mobile Number : ");
            string mNumber = Console.ReadLine();
            Console.Write("Enter Number of Calls : ");
            int nOfCalls = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Call Rate : ");
            int cRate = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n################## ENTER MSEB BILL DETAILS ##################");
            Console.Write("Enter Meter Number : ");
            int meterNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number of Units : ");
            int nOfUnits = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Rate Per Units : ");
            int rPerUnit = Convert.ToInt32(Console.ReadLine());

            MobileBill mb = new MobileBill();
            mb.addMobileBill(mNumber,nOfCalls,cRate);

            MsebBill msb = new MsebBill();
            msb.addMsebBill(meterNo,nOfUnits,rPerUnit);

            Bill b = new Bill();
            b.addBill(bNumber,bDate,cName);

            b.displayBill(b, mb);
            b.displayBill(b, msb);

        }
    }
}

