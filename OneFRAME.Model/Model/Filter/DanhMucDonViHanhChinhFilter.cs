using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneFRAME.Core.Model;
using OneFRAME.Model;

namespace OneFRAME.Model
{
    public class DanhMucDonViHanhChinhFilterCls : FilterCls
    {
        //public int? HieuLuc { get; set; }
    }
}

public class DanhMucDonViHanhChinhFilterParser
{
    public static DanhMucDonViHanhChinhFilterCls CreateInstance()
    {
        DanhMucDonViHanhChinhFilterCls ODanhMucDonViHanhChinhFilter = new DanhMucDonViHanhChinhFilterCls();
        return ODanhMucDonViHanhChinhFilter;
    }


    public static DanhMucDonViHanhChinhFilterCls ParseFromDataRow(DataRow dr)
    {
        DanhMucDonViHanhChinhFilterCls ODanhMucDonViHanhChinhFilter = new DanhMucDonViHanhChinhFilterCls();
        //ODanhMucDonViHanhChinhFilter.HieuLuc = CoreXmlUtility.GetInt(dr, "HieuLuc", true);
        ODanhMucDonViHanhChinhFilter.ActiveOnly = CoreXmlUtility.GetInt(dr, "ActiveOnly", true);
        ODanhMucDonViHanhChinhFilter.DepartmentId = CoreXmlUtility.GetString(dr, "DepartmentId", true);
        ODanhMucDonViHanhChinhFilter.ExcOwnerId = CoreXmlUtility.GetString(dr, "ExcOwnerId", true);
        ODanhMucDonViHanhChinhFilter.IncludeSharing = CoreXmlUtility.GetInt(dr, "IncludeSharing", true);
        ODanhMucDonViHanhChinhFilter.Keyword = CoreXmlUtility.GetString(dr, "Keyword", true);
        ODanhMucDonViHanhChinhFilter.OwnerId = CoreXmlUtility.GetString(dr, "OwnerId", true);
        ODanhMucDonViHanhChinhFilter.OwnerUserId = CoreXmlUtility.GetString(dr, "OwnerUserId", true);
        ODanhMucDonViHanhChinhFilter.PageIndex = CoreXmlUtility.GetInt(dr, "PageIndex", true);
        ODanhMucDonViHanhChinhFilter.PageSize = CoreXmlUtility.GetInt(dr, "PageSize", true);
        ODanhMucDonViHanhChinhFilter.RoleId = CoreXmlUtility.GetString(dr, "RoleId", true);
        ODanhMucDonViHanhChinhFilter.SortField = CoreXmlUtility.GetString(dr, "SortField", true);
        ODanhMucDonViHanhChinhFilter.SortType = CoreXmlUtility.GetString(dr, "SortType", true);
        ODanhMucDonViHanhChinhFilter.Status = CoreXmlUtility.GetInt(dr, "Status", true);
        return ODanhMucDonViHanhChinhFilter;
    }


    public static DanhMucDonViHanhChinhFilterCls ParseFromXml(string XmlData, string XmlDataSchema)
    {
        DataSet ds = CoreXmlUtility.GetDataSetFromXml(XmlData, XmlDataSchema);
        if (ds.Tables[0].Rows.Count == 0) return null;
        DanhMucDonViHanhChinhFilterCls ODanhMucDonViHanhChinhFilter = ParseFromDataRow(ds.Tables[0].Rows[0]);
        return ODanhMucDonViHanhChinhFilter;
    }



    public static XmlCls GetXml(DanhMucDonViHanhChinhFilterCls ODanhMucDonViHanhChinhFilter)
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
                    //ODanhMucDonViHanhChinhFilter.HieuLuc,
                    ODanhMucDonViHanhChinhFilter.ActiveOnly,
                    ODanhMucDonViHanhChinhFilter.DepartmentId,
                    ODanhMucDonViHanhChinhFilter.ExcOwnerId,
                    ODanhMucDonViHanhChinhFilter.IncludeSharing,
                    ODanhMucDonViHanhChinhFilter.Keyword,
                    ODanhMucDonViHanhChinhFilter.OwnerId,
                    ODanhMucDonViHanhChinhFilter.OwnerUserId,
                    ODanhMucDonViHanhChinhFilter.PageIndex,
                    ODanhMucDonViHanhChinhFilter.PageSize,
                    ODanhMucDonViHanhChinhFilter.RoleId,
                    ODanhMucDonViHanhChinhFilter.SortField,
                    ODanhMucDonViHanhChinhFilter.SortType,
                    ODanhMucDonViHanhChinhFilter.Status
                });
        XmlCls OXml = new XmlCls();
        OXml.XmlData = ds.GetXml();
        OXml.XmlDataSchema = ds.GetXmlSchema();
        return OXml;
    }
}
