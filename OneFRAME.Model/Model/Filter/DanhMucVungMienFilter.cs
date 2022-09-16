using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneFRAME.Core.Model;using OneFRAME.Model;

namespace OneFRAME.Model
{
    public class DanhMucVungMienFilterCls : FilterCls
    {
        //public int? HieuLuc { get; set; }
    }
}

public class DanhMucVungMienFilterParser
{
    public static DanhMucVungMienFilterCls CreateInstance()
    {
        DanhMucVungMienFilterCls ODanhMucVungMienFilter = new DanhMucVungMienFilterCls();
        return ODanhMucVungMienFilter;
    }


    public static DanhMucVungMienFilterCls ParseFromDataRow(DataRow dr)
    {
        DanhMucVungMienFilterCls ODanhMucVungMienFilter = new DanhMucVungMienFilterCls();
        //ODanhMucVungMienFilter.HieuLuc = CoreXmlUtility.GetInt(dr, "HieuLuc", true);
        ODanhMucVungMienFilter.ActiveOnly = CoreXmlUtility.GetInt(dr, "ActiveOnly", true);
        ODanhMucVungMienFilter.DepartmentId = CoreXmlUtility.GetString(dr, "DepartmentId", true);
        ODanhMucVungMienFilter.ExcOwnerId = CoreXmlUtility.GetString(dr, "ExcOwnerId", true);
        ODanhMucVungMienFilter.IncludeSharing = CoreXmlUtility.GetInt(dr, "IncludeSharing", true);
        ODanhMucVungMienFilter.Keyword = CoreXmlUtility.GetString(dr, "Keyword", true);
        ODanhMucVungMienFilter.OwnerId = CoreXmlUtility.GetString(dr, "OwnerId", true);
        ODanhMucVungMienFilter.OwnerUserId = CoreXmlUtility.GetString(dr, "OwnerUserId", true);
        ODanhMucVungMienFilter.PageIndex = CoreXmlUtility.GetInt(dr, "PageIndex", true);
        ODanhMucVungMienFilter.PageSize = CoreXmlUtility.GetInt(dr, "PageSize", true);
        ODanhMucVungMienFilter.RoleId = CoreXmlUtility.GetString(dr, "RoleId", true);
        ODanhMucVungMienFilter.SortField = CoreXmlUtility.GetString(dr, "SortField", true);
        ODanhMucVungMienFilter.SortType = CoreXmlUtility.GetString(dr, "SortType", true);
        ODanhMucVungMienFilter.Status = CoreXmlUtility.GetInt(dr, "Status", true);
        return ODanhMucVungMienFilter;
    }


    public static DanhMucVungMienFilterCls ParseFromXml(string XmlData, string XmlDataSchema)
    {
        DataSet ds = CoreXmlUtility.GetDataSetFromXml(XmlData, XmlDataSchema);
        if (ds.Tables[0].Rows.Count == 0) return null;
        DanhMucVungMienFilterCls ODanhMucVungMienFilter = ParseFromDataRow(ds.Tables[0].Rows[0]);
        return ODanhMucVungMienFilter;
    }



    public static XmlCls GetXml(DanhMucVungMienFilterCls ODanhMucVungMienFilter)
    {
        DataSet ds = new DataSet();
        ds.Tables.Add("info");
        //ds.Tables["info"].Columns.Add("HieuLuc");
        ds.Tables["info"].Columns.Add("ActiveOnly");
        ds.Tables["info"].Columns.Add("DepartmentId");
        ds.Tables["info"].Columns.Add("ExcOwnerId");
        ds.Tables["info"].Columns.Add("IncludeSharing");
        ds.Tables["info"].Columns.Add("Keyword");
        ds.Tables["info"].Columns.Add("OwnerId");
        ds.Tables["info"].Columns.Add("OwnerUserId");
        ds.Tables["info"].Columns.Add("PageIndex");
        ds.Tables["info"].Columns.Add("PageSize");
        ds.Tables["info"].Columns.Add("RoleId");
        ds.Tables["info"].Columns.Add("SortField");
        ds.Tables["info"].Columns.Add("SortType");
        ds.Tables["info"].Columns.Add("Status");
        ds.Tables["info"].Rows.Add(new object[]
                {
                    //ODanhMucVungMienFilter.HieuLuc,
                    ODanhMucVungMienFilter.ActiveOnly,
                    ODanhMucVungMienFilter.DepartmentId,
                    ODanhMucVungMienFilter.ExcOwnerId,
                    ODanhMucVungMienFilter.IncludeSharing,
                    ODanhMucVungMienFilter.Keyword,
                    ODanhMucVungMienFilter.OwnerId,
                    ODanhMucVungMienFilter.OwnerUserId,
                    ODanhMucVungMienFilter.PageIndex,
                    ODanhMucVungMienFilter.PageSize,
                    ODanhMucVungMienFilter.RoleId,
                    ODanhMucVungMienFilter.SortField,
                    ODanhMucVungMienFilter.SortType,
                    ODanhMucVungMienFilter.Status
                });
        XmlCls OXml = new XmlCls();
        OXml.XmlData = ds.GetXml();
        OXml.XmlDataSchema = ds.GetXmlSchema();
        return OXml;
    }
}
