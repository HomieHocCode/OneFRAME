using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneFRAME.Core.Model;

namespace OneFRAME.Model
{
    public class UnitCls
    {
        public string UnitId;
        public string UnitCode = "";
        public string UnitName="";
        public int Active;
        public int SortIndex;
    }

    public class UnitParser
    {
        public static UnitCls CreateInstance()
        {
            UnitCls OUnit = new UnitCls();
            return OUnit;
        }

        public static UnitCls ParseFromXml(string XmlData)
        {
            DataSet ds = CoreXmlUtility.GetDataSetFromXml(XmlData);
            UnitCls OUnit = ParseFromDataRow(ds.Tables[0].Rows[0]);
            return OUnit;
        }


        public static UnitCls ParseFromDataRow(DataRow dr)
        {
            UnitCls OUnit = new UnitCls();
            OUnit.UnitId = CoreXmlUtility.GetString(dr, "UnitId", true);
            OUnit.UnitCode = CoreXmlUtility.GetString(dr, "UnitCode", true);
            OUnit.UnitName = CoreXmlUtility.GetString(dr, "UnitName", true);
            OUnit.SortIndex = CoreXmlUtility.GetInt(dr, "SortIndex", true);
            OUnit.Active = CoreXmlUtility.GetInt(dr, "Active", true);
            
            return OUnit;
        }

        public static UnitCls[] ParseFromDataTable(DataTable dtTable)
        {
            UnitCls[] Units = new UnitCls[dtTable.Rows.Count];
            for (int iIndex = 0; iIndex < dtTable.Rows.Count; iIndex++)
            {
                Units[iIndex] = ParseFromDataRow(dtTable.Rows[iIndex]);
            }

            return Units;
        }
    }
}


