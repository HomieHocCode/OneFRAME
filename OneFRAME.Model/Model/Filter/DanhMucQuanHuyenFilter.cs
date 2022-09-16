using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneFRAME.Core.Model;using OneFRAME.Model;

namespace OneFRAME.Model
{
    public class DanhMucQuanHuyenFilterCls : FilterCls
    {
        //public int? HieuLuc { get; set; }
    }
}

public class DanhMucQuanHuyenFilterParser
{
    public static DanhMucQuanHuyenFilterCls CreateInstance()
    {
        DanhMucQuanHuyenFilterCls ODanhMucQuanHuyenFilter = new DanhMucQuanHuyenFilterCls();
        return ODanhMucQuanHuyenFilter;
    }


    public static DanhMucQuanHuyenFilterCls ParseFromDataRow(DataRow dr)
    {
        DanhMucQuanHuyenFilterCls ODanhMucQuanHuyenFilter = new DanhMucQuanHuyenFilterCls();
        //ODanhMucQuanHuyenFilter.HieuLuc = CoreXmlUtility.GetInt(dr, "HieuLuc", true);
        ODanhMucQuanHuyenFilter.ActiveOnly = CoreXmlUtility.GetInt(dr, "ActiveOnly", true);
        ODanhMucQuanHuyenFilter.DepartmentId = CoreXmlUtility.GetString(dr, "DepartmentId", true);
        ODanhMucQuanHuyenFilter.ExcOwnerId = CoreXmlUtility.GetString(dr, "ExcOwnerId", true);
        ODanhMucQuanHuyenFilter.IncludeSharing = CoreXmlUtility.GetInt(dr, "IncludeSharing", true);
        ODanhMucQuanHuyenFilter.Keyword = CoreXmlUtility.GetString(dr, "Keyword", true);
        ODanhMucQuanHuyenFilter.OwnerId = CoreXmlUtility.GetString(dr, "OwnerId", true);
        ODanhMucQuanHuyenFilter.OwnerUserId = CoreXmlUtility.GetString(dr, "OwnerUserId", true);
        ODanhMucQuanHuyenFilter.PageIndex = CoreXmlUtility.GetInt(dr, "PageIndex", true);
        ODanhMucQuanHuyenFilter.PageSize = CoreXmlUtility.GetInt(dr, "PageSize", true);
        ODanhMucQuanHuyenFilter.RoleId = CoreXmlUtility.GetString(dr, "RoleId", true);
        ODanhMucQuanHuyenFilter.SortField = CoreXmlUtility.GetString(dr, "SortField", true);
        ODanhMucQuanHuyenFilter.SortType = CoreXmlUtility.GetString(dr, "SortType", true);
        ODanhMucQuanHuyenFilter.Status = CoreXmlUtility.GetInt(dr, "Status", true);
        return ODanhMucQuanHuyenFilter;
    }


    public static DanhMucQuanHuyenFilterCls ParseFromXml(string XmlData, string XmlDataSchema)
    {
        DataSet ds = CoreXmlUtility.GetDataSetFromXml(XmlData, XmlDataSchema);
        if (ds.Tables[0].Rows.Count == 0) return null;
        DanhMucQuanHuyenFilterCls ODanhMucQuanHuyenFilter = ParseFromDataRow(ds.Tables[0].Rows[0]);
        return ODanhMucQuanHuyenFilter;
    }



    public static XmlCls GetXml(DanhMucQuanHuyenFilterCls ODanhMucQuanHuyenFilter)
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
                    //ODanhMucQuanHuyenFilter.HieuLuc,
                    ODanhMucQuanHuyenFilter.ActiveOnly,
                    ODanhMucQuanHuyenFilter.DepartmentId,
                    ODanhMucQuanHuyenFilter.ExcOwnerId,
                    ODanhMucQuanHuyenFilter.IncludeSharing,
                    ODanhMucQuanHuyenFilter.Keyword,
                    ODanhMucQuanHuyenFilter.OwnerId,
                    ODanhMucQuanHuyenFilter.OwnerUserId,
                    ODanhMucQuanHuyenFilter.PageIndex,
                    ODanhMucQuanHuyenFilter.PageSize,
                    ODanhMucQuanHuyenFilter.RoleId,
                    ODanhMucQuanHuyenFilter.SortField,
                    ODanhMucQuanHuyenFilter.SortType,
                    ODanhMucQuanHuyenFilter.Status
                });
        XmlCls OXml = new XmlCls();
        OXml.XmlData = ds.GetXml();
        OXml.XmlDataSchema = ds.GetXmlSchema();
        return OXml;
    }
}
