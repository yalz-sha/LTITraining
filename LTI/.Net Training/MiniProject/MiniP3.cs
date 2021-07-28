using MiniProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniProject
{
    class Story5
    {
        public static void respvalue()
        {
           
            ////List<Complaint> yorder = CSVRead.Complaints.OrderBy(x => x.Daterec).ToList();
            List<Complaint> yorder = (from Complaint in CSVRead.Complaints where Complaint.Response.Equals("Closed") || Complaint.Response.Equals("Closed with explanation") select Complaint).ToList();
            Console.WriteLine("Complaints with response closed/closed with explanation");
            Complaint complaint = new Complaint();
            for (int i = 0; i < 5; i++)
            {
                complaint.display(yorder[i]);
            }
        }
    }
    
    class MiniP3
    {
        public static void Main()
        {
            CSVRead.read();
            Story5.respvalue();
            

        }
    }
}
