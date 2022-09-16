using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneFRAME.Core.Model;using OneFRAME.Model;

namespace OneFRAME.Model
{
    public class DanhMucXaPhuongFilterCls : FilterCls
    {
        //public int? HieuLuc { get; set; }
    }
}

public class DanhMucXaPhuongFilterParser
{
    public static DanhMucXaPhuongFilterCls CreateInstance()
    {
        DanhMucXaPhuongFilterCls ODanhMucXaPhuongFilter = new DanhMucXaPhuongFilterCls();
        return ODanhMucXaPhuongFilter;
    }


    public static DanhMucXaPhuongFilterCls ParseFromDataRow(DataRow dr)
    {
        DanhMucXaPhuongFilterCls ODanhMucXaPhuongFilter = new DanhMucXaPhuongFilterCls();
        //ODanhMucXaPhuongFilter.HieuLuc = CoreXmlUtility.GetInt(dr, "HieuLuc", true);
        ODanhMucXaPhuongFilter.ActiveOnly = CoreXmlUtility.GetInt(dr, "ActiveOnly", true);
        ODanhMucXaPhuongFilter.DepartmentId = CoreXmlUtility.GetString(dr, "DepartmentId", true);
        ODanhMucXaPhuongFilter.ExcOwnerId = CoreXmlUtility.GetString(dr, "ExcOwnerId", true);
        ODanhMucXaPhuongFilter.IncludeSharing = CoreXmlUtility.GetInt(dr, "IncludeSharing", true);
        ODanhMucXaPhuongFilter.Keyword = CoreXmlUtility.GetString(dr, "Keyword", true);
        ODanhMucXaPhuongFilter.OwnerId = CoreXmlUtility.GetString(dr, "OwnerId", true);
        ODanhMucXaPhuongFilter.OwnerUserId = CoreXmlUtility.GetString(dr, "OwnerUserId", true);
        ODanhMucXaPhuongFilter.PageIndex = CoreXmlUtility.GetInt(dr, "PageIndex", true);
        ODanhMucXaPhuongFilter.PageSize = CoreXmlUtility.GetInt(dr, "PageSize", true);
        ODanhMucXaPhuongFilter.RoleId = CoreXmlUtility.GetString(dr, "RoleId", true);
        ODanhMucXaPhuongFilter.SortField = CoreXmlUtility.GetString(dr, "SortField", true);
        ODanhMucXaPhuongFilter.SortType = CoreXmlUtility.GetString(dr, "SortType", true);
        ODanhMucXaPhuongFilter.Status = CoreXmlUtility.GetInt(dr, "Status", true);
        return ODanhMucXaPhuongFilter;
    }


    public static DanhMucXaPhuongFilterCls ParseFromXml(string XmlData, string XmlDataSchema)
    {
        DataSet ds = CoreXmlUtility.GetDataSetFromXml(XmlData, XmlDataSchema);
        if (ds.Tables[0].Rows.Count == 0) return null;
        DanhMucXaPhuongFilterCls ODanhMucXaPhuongFilter = ParseFromDataRow(ds.Tables[0].Rows[0]);
        return ODanhMucXaPhuongFilter;
    }



    public static XmlCls GetXml(DanhMucXaPhuongFilterCls ODanhMucXaPhuongFilter)
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
                    //ODanhMucXaPhuongFilter.HieuLuc,
                    ODanhMucXaPhuongFilter.ActiveOnly,
                    ODanhMucXaPhuongFilter.DepartmentId,
                    ODanhMucXaPhuongFilter.ExcOwnerId,
                    ODanhMucXaPhuongFilter.IncludeSharing,
                    ODanhMucXaPhuongFilter.Keyword,
                    ODanhMucXaPhuongFilter.OwnerId,
                    ODanhMucXaPhuongFilter.OwnerUserId,
                    ODanhMucXaPhuongFilter.PageIndex,
                    ODanhMucXaPhuongFilter.PageSize,
                    ODanhMucXaPhuongFilter.RoleId,
                    ODanhMucXaPhuongFilter.SortField,
                    ODanhMucXaPhuongFilter.SortType,
                    ODanhMucXaPhuongFilter.Status
                });
        XmlCls OXml = new XmlCls();
        OXml.XmlData = ds.GetXml();
        OXml.XmlDataSchema = ds.GetXmlSchema();
        return OXml;
    }
}
