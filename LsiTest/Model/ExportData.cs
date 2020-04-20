using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LsiTest.Model
{
    public class ExportData
    {
        public ExportData(Hashtable record)
        {
            int.TryParse(record["Id"].ToString(), out int id);
            Id = id;

            ExportName = record["ExportName"].ToString();

            DateTime.TryParse(record["ExportDate"].ToString(), out var dt);
            ExportDate = dt;

            UserFullName = record["UserFullName"].ToString();

            LocalName = record["Name"].ToString();

        }
       
        public int Id { get; set; }
        public string ExportName { get; set; }
        public DateTime ExportDate { get; set; }
        public string UserFullName { get; set; }
        public string LocalName { get; set; }

    }
}
