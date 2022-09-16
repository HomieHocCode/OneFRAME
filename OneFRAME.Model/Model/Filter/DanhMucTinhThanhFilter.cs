using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneFRAME.Core.Model;using OneFRAME.Model;

namespace OneFRAME.Model
{
    public class DanhMucTinhThanhFilterCls : FilterCls
    {
        //public int? HieuLuc { get; set; }
    }
}

public class DanhMucTinhThanhFilterParser
{
    public static DanhMucTinhThanhFilterCls CreateInstance()
    {
        DanhMucTinhThanhFilterCls ODanhMucTinhThanhFilter = new DanhMucTinhThanhFilterCls();
        return ODanhMucTinhThanhFilter;
    }


    public static DanhMucTinhThanhFilterCls ParseFromDataRow(DataRow dr)
    {
        DanhMucTinhThanhFilterCls ODanhMucTinhThanhFilter = new DanhMucTinhThanhFilterCls();
        //ODanhMucTinhThanhFilter.HieuLuc = CoreXmlUtility.GetInt(dr, "HieuLuc", true);
        ODanhMucTinhThanhFilter.ActiveOnly = CoreXmlUtility.GetInt(dr, "ActiveOnly", true);
        ODanhMucTinhThanhFilter.DepartmentId = CoreXmlUtility.GetString(dr, "DepartmentId", true);
        ODanhMucTinhThanhFilter.ExcOwnerId = CoreXmlUtility.GetString(dr, "ExcOwnerId", true);
        ODanhMucTinhThanhFilter.IncludeSharing = CoreXmlUtility.GetInt(dr, "IncludeSharing", true);
        ODanhMucTinhThanhFilter.Keyword = CoreXmlUtility.GetString(dr, "Keyword", true);
        ODanhMucTinhThanhFilter.OwnerId = CoreXmlUtility.GetString(dr, "OwnerId", true);
        ODanhMucTinhThanhFilter.OwnerUserId = CoreXmlUtility.GetString(dr, "OwnerUserId", true);
        ODanhMucTinhThanhFilter.PageIndex = CoreXmlUtility.GetInt(dr, "PageIndex", true);
        ODanhMucTinhThanhFilter.PageSize = CoreXmlUtility.GetInt(dr, "PageSize", true);
        ODanhMucTinhThanhFilter.RoleId = CoreXmlUtility.GetString(dr, "RoleId", true);
        ODanhMucTinhThanhFilter.SortField = CoreXmlUtility.GetString(dr, "SortField", true);
        ODanhMucTinhThanhFilter.SortType = CoreXmlUtility.GetString(dr, "SortType", true);
        ODanhMucTinhThanhFilter.Status = CoreXmlUtility.GetInt(dr, "Status", true);
        return ODanhMucTinhThanhFilter;
    }


    public static DanhMucTinhThanhFilterCls ParseFromXml(string XmlData, string XmlDataSchema)
    {
        DataSet ds = CoreXmlUtility.GetDataSetFromXml(XmlData, XmlDataSchema);
        if (ds.Tables[0].Rows.Count == 0) return null;
        DanhMucTinhThanhFilterCls ODanhMucTinhThanhFilter = ParseFromDataRow(ds.Tables[0].Rows[0]);
        return ODanhMucTinhThanhFilter;
    }



    public static XmlCls GetXml(DanhMucTinhThanhFilterCls ODanhMucTinhThanhFilter)
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
                    //ODanhMucTinhThanhFilter.HieuLuc,
                    ODanhMucTinhThanhFilter.ActiveOnly,
                    ODanhMucTinhThanhFilter.DepartmentId,
                    ODanhMucTinhThanhFilter.ExcOwnerId,
                    ODanhMucTinhThanhFilter.IncludeSharing,
                    ODanhMucTinhThanhFilter.Keyword,
                    ODanhMucTinhThanhFilter.OwnerId,
                    ODanhMucTinhThanhFilter.OwnerUserId,
                    ODanhMucTinhThanhFilter.PageIndex,
                    ODanhMucTinhThanhFilter.PageSize,
                    ODanhMucTinhThanhFilter.RoleId,
                    ODanhMucTinhThanhFilter.SortField,
                    ODanhMucTinhThanhFilter.SortType,
                    ODanhMucTinhThanhFilter.Status
                });
        XmlCls OXml = new XmlCls();
        OXml.XmlData = ds.GetXml();
        OXml.XmlDataSchema = ds.GetXmlSchema();
        return OXml;
    }
}
