using LsiTest.Infrastructure;
using LsiTest.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LsiTest.Services
{
    public class LocalProvider : ILocalProvider
    {
        IDatabaseQueryExecutor queryExecutor;
        public LocalProvider()
        {
            queryExecutor = new DatabaseQueryExecutor();
        }
        public List<Local> GetLocals()
        {
            var query = "select * from Locals";
            var res = queryExecutor.Execute(query);
            var ret = new List<Local>();

            for(int i = 0; i < res.Count; i++)
            {
                var record = res[i] as Hashtable;
                var toAdd = new Local(record);
                ret.Add(toAdd);
            }
            return ret;
        }
    }
}
