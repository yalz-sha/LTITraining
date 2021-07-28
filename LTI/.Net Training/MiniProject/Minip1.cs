using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using LumenWorks.Framework.IO.Csv;

namespace MiniProject
{
    class CSVRead
    {
        static List<Complaint> complaints= new List<Complaint>();


         public static List<Complaint> Complaints { get => complaints; set => complaints = value; }

        public static void read()
        {
            var csvTable = new DataTable();
            using (var csvReader = new CsvReader(new StreamReader(System.IO.File.OpenRead(@"E:\LTI\.Net Training\complaints.csv")), true))
            {
                csvTable.Load(csvReader);
            }
            for (int i = 0; i < csvTable.Rows.Count; i++)
            {
                Complaints.Add(new Complaint
                {
                    Daterec = DateTime.ParseExact(csvTable.Rows[i][0].ToString(),"MM/dd/yyyy",null),
                    Product = csvTable.Rows[i][1].ToString(),
                    Subproduct = csvTable.Rows[i][2].ToString(),
                    Issue = csvTable.Rows[i][3].ToString(),
                    Subissue = csvTable.Rows[i][4].ToString(),
                    Company = csvTable.Rows[i][5].ToString(),
                    State = csvTable.Rows[i][6].ToString(),
                    ZIP = csvTable.Rows[i][7].ToString(),
                    Subvia = csvTable.Rows[i][8].ToString(),
                    Sent = DateTime.ParseExact(csvTable.Rows[i][9].ToString(), "MM/dd/yyyy", null),
                    Response = csvTable.Rows[i][10].ToString(),
                    Timely = csvTable.Rows[i][11].ToString(),
                    Dispute = csvTable.Rows[i][12].ToString(),
                    ComplaintID = long.Parse(csvTable.Rows[i][13].ToString())
                });
                
            }

        }
        

    }

    class Complaint
    {

        DateTime daterec;
        string product;
        string subproduct;
        string issue;
        string subissue;
        string company;
        string state;
        string zIP;
        string subvia;
        DateTime sent;
        string response;
        string timely;
        string dispute;
        long complaintID;

        public Complaint()
        {

        }
        public Complaint(DateTime daterec, string product, string subproduct, string issue, string subissue, string company, string state, string zIP, string subvia, DateTime sent, string response, string timely, string dispute, long complaintID)
        {
            this.daterec = daterec;
            this.product = product;
            this.subproduct = subproduct;
            this.issue = issue;
            this.subissue = subissue;
            this.company = company;
            this.state = state;
            this.zIP = zIP;
            this.subvia = subvia;
            this.sent = sent;
            this.response = response;
            this.timely = timely;
            this.dispute = dispute;
            this.complaintID = complaintID;
        }

        public DateTime Daterec { get => daterec; set => daterec = value; }
        public string Product { get => product; set => product = value; }
        public string Subproduct { get => subproduct; set => subproduct = value; }
        public string Issue { get => issue; set => issue = value; }
        public string Subissue { get => subissue; set => subissue = value; }
        public string Company { get => company; set => company = value; }
        public string State { get => state; set => state = value; }
        public string ZIP { get => zIP; set => zIP = value; }
        public string Subvia { get => subvia; set => subvia = value; }
        public DateTime Sent { get => sent; set => sent = value; }
        public string Response { get => response; set => response = value; }
        public string Timely { get => timely; set => timely = value; }
        public string Dispute { get => dispute; set => dispute = value; }
        public long ComplaintID { get => complaintID; set => complaintID = value; }

        public virtual void  display(Complaint c)
        {
            Console.WriteLine("\nDate Received:" + c.Daterec.ToShortDateString());
            Console.WriteLine("Product:" + c.product);
            Console.WriteLine("Subproduct:" + c.subproduct);
            Console.WriteLine("Issue:" + c.issue);
            Console.WriteLine("Subissue:" + c.subissue);
            Console.WriteLine("Company:" + c.company);
            Console.WriteLine("Date Sent:" + c.sent.ToShortDateString());
            Console.WriteLine("Response:" + c.response);
            Console.WriteLine("Complaint ID:" + c.complaintID);



        }
    }

    class Minip1
    {
        public static void Main(string[] args)
        {
            CSVRead.read();
            Complaint complaint = new Complaint();
            for(int i=0;i<5;i++)
            {
                complaint.display(CSVRead.Complaints[i]);

            }

        }
    }
}     
    

