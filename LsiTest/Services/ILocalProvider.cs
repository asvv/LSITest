using LsiTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LsiTest.Services
{
    public interface ILocalProvider
    {
        List<Local> GetLocals();
    }
}
