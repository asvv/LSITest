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
    public class ExportDataProvider : IExportDataProvider
    {

        IDatabaseQueryExecutor DbExecutor;
        public ExportDataProvider()
        {
            DbExecutor = new DatabaseQueryExecutor();
        }
 
        public List<ExportData> GetExportData(ReportFilterModel reportFilterModel)
        {
            var ret = new List<ExportData>();

            var fromStr = reportFilterModel.From.ToString("dd/MM/yyyy");
            var toStr = reportFilterModel.To.ToString("dd/MM/yyyy");

            var query = $@"set dateformat dmy
                           select ed.Id, ed.ExportName, ed.ExportDate, ed.UserFullName, l.Name from ExportData ed left join Locals l on ed.LocalId = l.Id 
                                where l.Id = {reportFilterModel.LocalId} and ed.ExportDate between '{fromStr}' and '{toStr}'";

            var res = DbExecutor.Execute(query);
            for(int i = 0; i < res.Count; i++)
            {
                var ht = res[i] as Hashtable;
                var toAdd = new ExportData(ht);
                ret.Add(toAdd);
            }
            return ret;

            
        }
    }
}
