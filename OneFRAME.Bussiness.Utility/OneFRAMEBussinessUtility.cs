using OneFRAME.Bussiness.Sql;
using OneFRAME.Bussiness.Template;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneFRAME.Bussiness.Utility
{
    public class OneFRAMEBussinessUtility
    {
        public static IBussinessProcess CreateBussinessProcess()
        {
            return new SqlBussinessProcess();
        }
    }
}
