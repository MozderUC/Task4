using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQtoCSV;

namespace Task4.CustomDataClass
{
    class ManagerReport
    {
        [CsvColumn(FieldIndex = 1)]
        public string ManagerFirstName { get; set; }
        [CsvColumn(FieldIndex = 2)]
        public string ManagerLastName { get; set; }
        [CsvColumn(FieldIndex = 3)]
        public string ClienFirstName { get; set; }
        [CsvColumn(FieldIndex = 4)]
        public string ClientLastName { get; set; }
        [CsvColumn(FieldIndex = 5)]
        public string ProductName { get; set; }
        [CsvColumn(FieldIndex = 6)]
        public int ProductCost { get; set; }
    }
}
