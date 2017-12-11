using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class ManagerReport
    {
        public int Id { get; set; }

        public DateTime ReportDate { get; set; }
        public string ManagerLastName { get; set; }
        public string ClienFirstName { get; set; }
        public string ClientLastName { get; set; }

        public string ProductName { get; set; }
        public int ProductCost { get; set; }

        public ManagerReport()
        {
                
        }
        public ManagerReport(DateTime date, string manLastName, string clientFirstName, string clientLastName, string productName, int productCost )
        {
            this.ReportDate = date;
            this.ManagerLastName = manLastName;
            this.ClienFirstName = clientFirstName;
            this.ClientLastName = clientLastName;
            this.ProductName = productName;
            this.ProductCost = productCost;
        }
    }
}
