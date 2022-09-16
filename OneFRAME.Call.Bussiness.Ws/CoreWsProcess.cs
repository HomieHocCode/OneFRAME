
using OneFRAME.Call.Bussiness.Template;
using OneFRAME.Core.Model;using OneFRAME.Model;
using OneFRAME.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneFRAME.Call.Bussiness.Ws
{
    public class CoreWsProcess : BussinessProcessTemplate
    {
        public override string Id
        {
            get
            {
                return "CoreSqlProcess";
            }
        }
        public override string ServiceName
        {
            get
            {
                return "WS SERVICE";
            }
        }


       
        public override IUnitProcess CreateUnitProcess()
        {
            return new UnitProcessBll();
        }
        
    }
}
 