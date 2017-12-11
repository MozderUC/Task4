using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQtoCSV;

namespace Task4.DTO
{
    class ManagerReport
    {
        public DateTime ReportDate { get; set; }               
        public string ManagerLastName { get; set; }

        [CsvColumn(FieldIndex = 1)]
        public string ClienFirstName { get; set; }
        [CsvColumn(FieldIndex = 2)]
        public string ClientLastName { get; set; }
        [CsvColumn(FieldIndex = 3)]
        public string ProductName { get; set; }
        [CsvColumn(FieldIndex = 4)]
        public int ProductCost { get; set; }
    }
}
