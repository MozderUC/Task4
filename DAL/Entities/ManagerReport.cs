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

        public string ManagerFirstName { get; set; }
        public string ManagerLastName { get; set; }
        public string ClienFirstName { get; set; }
        public string ClientLastName { get; set; }

        public string ProductName { get; set; }
        public int ProductCost { get; set; }
    }
}
