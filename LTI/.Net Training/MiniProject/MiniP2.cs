using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniProject
{
    class Story1
    {
        public static void cyear()
        {
            Console.WriteLine("Enter the Year:");
            DateTime year = DateTime.ParseExact(Console.ReadLine(), "yyyy", null);
            //List<Complaint> yorder = CSVRead.Complaints.OrderBy(x => x.Daterec).ToList();
            List<Complaint> yorder = (from Complaint in CSVRead.Complaints where Complaint.Daterec.Year == year.Year select Complaint).ToList();
            Complaint complaint = new Complaint();
            for (int i = 0; i < 5; i++)
            {
                complaint.display(yorder[i]);

            }

        }
    }
    class Story2
    {
        public static void cbankname()
        {
            Console.WriteLine("Enter the Bank Name:");
            string bank = Console.ReadLine();
            //List<Complaint> yorder = CSVRead.Complaints.OrderBy(x => x.Daterec).ToList();
            List<Complaint> yorder = (from Complaint in CSVRead.Complaints where Complaint.Company==bank select Complaint).ToList();
            Complaint complaint = new Complaint();
            for (int i = 0; i < 5; i++)
            {
                complaint.display(yorder[i]);
            }
        }

    }
    class Story3
    {
        public static void cid()
        {
            Console.WriteLine("Enter the Complaint ID:");
            long cid = long.Parse(Console.ReadLine());
            ////List<Complaint> yorder = CSVRead.Complaints.OrderBy(x => x.Daterec).ToList();
            List<Complaint> yorder = (from Complaint in CSVRead.Complaints where Complaint.ComplaintID == cid select Complaint).ToList();
            Complaint complaint = new Complaint();
            complaint.display(yorder[0]);
        }

    }
    class Story4
    {
       
        public static void calcDays()
        {
           
            Complaint complaint = new Complaint();
            for (int i = 0; i < 5; i++)
            {
                complaint.display(CSVRead.Complaints[i]);
                Console.WriteLine("No.of Days to Close:"+(CSVRead.Complaints[i].Sent - CSVRead.Complaints[i].Daterec).TotalDays);

            }
        }
             

    }
    class MiniP2
    {
               
        public static void Main(string[] args)
        {
            
            //Story1.cyear();
            //Story2.cbankname();
            //Story3.cid();
            Story4.calcDays();
            



        }


    }
}
