using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneFRAME.Core.Model;using OneFRAME.Model;

namespace OneFRAME.Model
{
    public class DanhMucICDChuongFilterCls : FilterCls
    {
        //public int? HieuLuc { get; set; }
    }
}

public class DanhMucICDChuongFilterParser
{
    public static DanhMucICDChuongFilterCls CreateInstance
    {
        get
        {
            DanhMucICDChuongFilterCls ODanhMucICDChuongFilter = new DanhMucICDChuongFilterCls();
            return ODanhMucICDChuongFilter;
        }
    }

    public static DanhMucICDChuongFilterCls ParseFromDataRow(DataRow dr)
    {
        DanhMucICDChuongFilterCls ODanhMucICDChuongFilter = new DanhMucICDChuongFilterCls();
        //ODanhMucICDChuongFilter.HieuLuc = CoreXmlUtility.GetInt(dr, "HieuLuc", true);
        ODanhMucICDChuongFilter.ActiveOnly = CoreXmlUtility.GetInt(dr, "ActiveOnly", true);
        ODanhMucICDChuongFilter.DepartmentId = CoreXmlUtility.GetString(dr, "DepartmentId", true);
        ODanhMucICDChuongFilter.ExcOwnerId = CoreXmlUtility.GetString(dr, "ExcOwnerId", true);
        ODanhMucICDChuongFilter.IncludeSharing = CoreXmlUtility.GetInt(dr, "IncludeSharing", true);
        ODanhMucICDChuongFilter.Keyword = CoreXmlUtility.GetString(dr, "Keyword", true);
        ODanhMucICDChuongFilter.OwnerId = CoreXmlUtility.GetString(dr, "OwnerId", true);
        ODanhMucICDChuongFilter.OwnerUserId = CoreXmlUtility.GetString(dr, "OwnerUserId", true);
        ODanhMucICDChuongFilter.PageIndex = CoreXmlUtility.GetInt(dr, "PageIndex", true);
        ODanhMucICDChuongFilter.PageSize = CoreXmlUtility.GetInt(dr, "PageSize", true);
        ODanhMucICDChuongFilter.RoleId = CoreXmlUtility.GetString(dr, "RoleId", true);
        ODanhMucICDChuongFilter.SortField = CoreXmlUtility.GetString(dr, "SortField", true);
        ODanhMucICDChuongFilter.SortType = CoreXmlUtility.GetString(dr, "SortType", true);
        ODanhMucICDChuongFilter.Status = CoreXmlUtility.GetInt(dr, "Status", true);
        return ODanhMucICDChuongFilter;
    }

    public static XmlCls GetXml(DanhMucICDChuongFilterCls ODanhMucICDChuongFilter)
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
                    //ODanhMucICDChuongFilter.HieuLuc,
                    ODanhMucICDChuongFilter.ActiveOnly,
                    ODanhMucICDChuongFilter.DepartmentId,
                    ODanhMucICDChuongFilter.ExcOwnerId,
                    ODanhMucICDChuongFilter.IncludeSharing,
                    ODanhMucICDChuongFilter.Keyword,
                    ODanhMucICDChuongFilter.OwnerId,
                    ODanhMucICDChuongFilter.OwnerUserId,
                    ODanhMucICDChuongFilter.PageIndex,
                    ODanhMucICDChuongFilter.PageSize,
                    ODanhMucICDChuongFilter.RoleId,
                    ODanhMucICDChuongFilter.SortField,
                    ODanhMucICDChuongFilter.SortType,
                    ODanhMucICDChuongFilter.Status
                });
        XmlCls OXml = new XmlCls();
        OXml.XmlData = ds.GetXml();
        OXml.XmlDataSchema = ds.GetXmlSchema();
        return OXml;
    }
}
