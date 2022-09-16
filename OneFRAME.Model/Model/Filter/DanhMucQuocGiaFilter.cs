using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneFRAME.Core.Model;using OneFRAME.Model;

namespace OneFRAME.Model
{
    public class DanhMucQuocGiaFilterCls : FilterCls
    {
        //public int? HieuLuc { get; set; }
    }
}

public class DanhMucQuocGiaFilterParser
{
    public static DanhMucQuocGiaFilterCls CreateInstance()
    {
        DanhMucQuocGiaFilterCls ODanhMucQuocGiaFilter = new DanhMucQuocGiaFilterCls();
        return ODanhMucQuocGiaFilter;
    }


    public static DanhMucQuocGiaFilterCls ParseFromDataRow(DataRow dr)
    {
        DanhMucQuocGiaFilterCls ODanhMucQuocGiaFilter = new DanhMucQuocGiaFilterCls();
        //ODanhMucQuocGiaFilter.HieuLuc = CoreXmlUtility.GetInt(dr, "HieuLuc", true);
        ODanhMucQuocGiaFilter.ActiveOnly = CoreXmlUtility.GetInt(dr, "ActiveOnly", true);
        ODanhMucQuocGiaFilter.DepartmentId = CoreXmlUtility.GetString(dr, "DepartmentId", true);
        ODanhMucQuocGiaFilter.ExcOwnerId = CoreXmlUtility.GetString(dr, "ExcOwnerId", true);
        ODanhMucQuocGiaFilter.IncludeSharing = CoreXmlUtility.GetInt(dr, "IncludeSharing", true);
        ODanhMucQuocGiaFilter.Keyword = CoreXmlUtility.GetString(dr, "Keyword", true);
        ODanhMucQuocGiaFilter.OwnerId = CoreXmlUtility.GetString(dr, "OwnerId", true);
        ODanhMucQuocGiaFilter.OwnerUserId = CoreXmlUtility.GetString(dr, "OwnerUserId", true);
        ODanhMucQuocGiaFilter.PageIndex = CoreXmlUtility.GetInt(dr, "PageIndex", true);
        ODanhMucQuocGiaFilter.PageSize = CoreXmlUtility.GetInt(dr, "PageSize", true);
        ODanhMucQuocGiaFilter.RoleId = CoreXmlUtility.GetString(dr, "RoleId", true);
        ODanhMucQuocGiaFilter.SortField = CoreXmlUtility.GetString(dr, "SortField", true);
        ODanhMucQuocGiaFilter.SortType = CoreXmlUtility.GetString(dr, "SortType", true);
        ODanhMucQuocGiaFilter.Status = CoreXmlUtility.GetInt(dr, "Status", true);
        return ODanhMucQuocGiaFilter;
    }


    public static DanhMucQuocGiaFilterCls ParseFromXml(string XmlData, string XmlDataSchema)
    {
        DataSet ds = CoreXmlUtility.GetDataSetFromXml(XmlData, XmlDataSchema);
        if (ds.Tables[0].Rows.Count == 0) return null;
        DanhMucQuocGiaFilterCls ODanhMucQuocGiaFilter = ParseFromDataRow(ds.Tables[0].Rows[0]);
        return ODanhMucQuocGiaFilter;
    }



    public static XmlCls GetXml(DanhMucQuocGiaFilterCls ODanhMucQuocGiaFilter)
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
                    //ODanhMucQuocGiaFilter.HieuLuc,
                    ODanhMucQuocGiaFilter.ActiveOnly,
                    ODanhMucQuocGiaFilter.DepartmentId,
                    ODanhMucQuocGiaFilter.ExcOwnerId,
                    ODanhMucQuocGiaFilter.IncludeSharing,
                    ODanhMucQuocGiaFilter.Keyword,
                    ODanhMucQuocGiaFilter.OwnerId,
                    ODanhMucQuocGiaFilter.OwnerUserId,
                    ODanhMucQuocGiaFilter.PageIndex,
                    ODanhMucQuocGiaFilter.PageSize,
                    ODanhMucQuocGiaFilter.RoleId,
                    ODanhMucQuocGiaFilter.SortField,
                    ODanhMucQuocGiaFilter.SortType,
                    ODanhMucQuocGiaFilter.Status
                });
        XmlCls OXml = new XmlCls();
        OXml.XmlData = ds.GetXml();
        OXml.XmlDataSchema = ds.GetXmlSchema();
        return OXml;
    }
}
