using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LsiTest.Infrastructure
{
    public interface IDatabaseQueryExecutor
    {
        Hashtable Execute(string query);
    }
}
