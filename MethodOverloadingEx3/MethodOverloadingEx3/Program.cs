using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingEx3
{
    class MobileBill
    {
        private int mobileNumber;
        private int numberOfCalls;
        private int callRate;
        public void addMobileBill(int mn,int noc, int cr)
        {
            this.mobileNumber = mn;
            this.numberOfCalls = noc;
            this.callRate = cr;
        }

        public void displayMoibleBill()
        {
            Console.WriteLine("Mobile Number : " + mobileNumber);
            Console.WriteLine("Number of Calls : " + numberOfCalls);
            Console.WriteLine("Call Rate : " + callRate);
            Console.WriteLine("Generated Mobile bill : " + (numberOfCalls * callRate) + " Rs");
        }
    }

    class MsebBill
    {
        private int meterNumber;
        private int numberOfUnits;
        private int ratePerUnit;
        public void addMsebBill(int metern, int nou, int rpu)
        {
            this.meterNumber = metern;
            this.numberOfUnits = nou;       
            this.ratePerUnit = rpu; 
        }

        public void displayMsebBill()
        {
            Console.WriteLine("Meter Number : " + meterNumber);
            Console.WriteLine("Number of Units : " + numberOfUnits);
            Console.WriteLine("Rate Per Units : " + ratePerUnit);
            Console.WriteLine("Generated Mseb bill : " + (numberOfUnits * ratePerUnit) + " Rs");
        }
    }

    class Bill
    {
        private int billNumber;
        private string billDate;
        private string customerName;
        public void addBill(int bn, string bd, string cn)
        {
            this.billNumber = bn;
            this.billDate = bd;
            this.customerName = cn;
        }

        public void displayBill()
        {
            Console.WriteLine("Bill Number : "+billNumber);
            Console.WriteLine("Bill Date : " + billDate);
            Console.WriteLine("Customer Name : " + customerName);
        }
        public void displayBill(Bill b, MobileBill mb)
        {
            Console.WriteLine("\n\n########## GENERATED MOBILE BILL ##########");
            b.displayBill();
            mb.displayMoibleBill();
        }

        public void displayBill(Bill b, MsebBill msb)
        {
            Console.WriteLine("\n########## GENERATED MSEB BILL ##########");
            b.displayBill();
            msb.displayMsebBill();
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("########## ENTER BILL DETAILS ##########");
            Console.Write("Enter Bill Number : ");
            int bNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Bill Date : ");
            string bDate = Console.ReadLine();

            Console.Write("Enter Customer Name : ");
            string cName = Console.ReadLine();

            Console.WriteLine("\n########## ENTER MOBILE BILL DETAILS ##########");
            Console.Write("Enter Mobile Number : ");
            int mNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number of Calls : ");
            int nOfCalls = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Call Rate : ");
            int cRate = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n########## ENTER MSEB BILL DETAILS ##########");
            Console.Write("Enter Meter Number : ");
            int meterN = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number of Units : ");
            int nOfUnits = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Rate Per Units : ");
            int rPerUnit = Convert.ToInt32(Console.ReadLine());

            Bill b = new Bill();
            b.addBill(bNumber, bDate, cName);

            MobileBill mb = new MobileBill();
            mb.addMobileBill(mNumber, nOfCalls, cRate);

            MsebBill msb = new MsebBill();
            msb.addMsebBill(meterN,nOfUnits,rPerUnit);

            b.displayBill(b,mb);
            b.displayBill(b,msb);


        }
    }
}
