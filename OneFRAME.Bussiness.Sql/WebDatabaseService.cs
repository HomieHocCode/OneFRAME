using OneFRAME.Bussiness.Template;
using OneFRAME.Database.Service;
using OneFRAME.Database.Service.Sql;
using OneFRAME.Core.Model;using OneFRAME.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneFRAME.Bussiness.Sql
{
    public class WebDatabaseService
    {
        public static IDatabaseService CreateDBService(ActionSqlParamCls ActionSqlParam)
        {
            IDatabaseService Found = null;
            if (ActionSqlParam.DBService.Equals("MSSQL"))
            {
                Found = SqlDatabaseService.GetInstance();
            }
            if (ActionSqlParam.DBService.Equals("ORACLE"))
            {
                Found = new OracleDatabaseService();
            }
            if (Found == null) throw new Exception("NOT SUPPORT DBSERVICE");
            Found.ConnectionString = ActionSqlParam.ConnectionString;
            return Found;
        }
        public static IDatabaseService CreateDBService(string connectionstring)
        {
            IDatabaseService Found = SqlDatabaseService.GetInstance();
            Found.ConnectionString = connectionstring;
            return Found;
        }
    }
}
