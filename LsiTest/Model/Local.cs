using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LsiTest.Model
{
    public class Local
    {
        public Local(Hashtable record)
        {
            int.TryParse(record["Id"].ToString(), out int id);
            Id = id;
            Name = record["Name"].ToString();
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
