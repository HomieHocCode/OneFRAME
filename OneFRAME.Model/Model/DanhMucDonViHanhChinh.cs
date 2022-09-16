using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneFRAME.Core.Model;
using OneFRAME.Model;

namespace OneFRAME.Model
{
    public class DanhMucDonViHanhChinhCls
    {
        public string ID;
        public string Ma;
        public string Ten;
        public string TenTat;
        public string MieuTa;
        public int STT;
        public bool HieuLuc;
        public string QuocGiaId;
        public string VungId;
        public string TinhThanhId;
        public string QuanHuyenId;
        public string XaPhuongId;
    }
}

public class DanhMucDonViHanhChinhParser
{
    public static DanhMucDonViHanhChinhCls CreateInstance()
    {
        DanhMucDonViHanhChinhCls ODanhMucDonViHanhChinh = new DanhMucDonViHanhChinhCls();
        return ODanhMucDonViHanhChinh;
    }


    public static DanhMucDonViHanhChinhCls ParseFromDataRow(DataRow dr)
    {
        DanhMucDonViHanhChinhCls ODanhMucDonViHanhChinh = new DanhMucDonViHanhChinhCls();
        ODanhMucDonViHanhChinh.ID = CoreXmlUtility.GetString(dr, "ID", true);
        ODanhMucDonViHanhChinh.Ma = CoreXmlUtility.GetString(dr, "Ma", true);
        ODanhMucDonViHanhChinh.Ten = CoreXmlUtility.GetString(dr, "Ten", true);
        ODanhMucDonViHanhChinh.TenTat = CoreXmlUtility.GetString(dr, "TenTat", true);
        ODanhMucDonViHanhChinh.MieuTa = CoreXmlUtility.GetString(dr, "MieuTa", true);
        ODanhMucDonViHanhChinh.STT = CoreXmlUtility.GetInt(dr, "STT", true);
        ODanhMucDonViHanhChinh.HieuLuc = CoreXmlUtility.GetBoolean(dr, "HieuLuc", true);
        ODanhMucDonViHanhChinh.QuocGiaId = CoreXmlUtility.GetString(dr, "QuocGiaId", true);
        ODanhMucDonViHanhChinh.VungId = CoreXmlUtility.GetString(dr, "VungId", true);
        ODanhMucDonViHanhChinh.TinhThanhId = CoreXmlUtility.GetString(dr, "TinhThanhId", true);
        ODanhMucDonViHanhChinh.QuanHuyenId = CoreXmlUtility.GetString(dr, "QuanHuyenId", true);
        ODanhMucDonViHanhChinh.XaPhuongId = CoreXmlUtility.GetString(dr, "XaPhuongId", true);
        return ODanhMucDonViHanhChinh;
    }

    public static DanhMucDonViHanhChinhCls[] ParseFromDataTable(DataTable dtTable)
    {
        DanhMucDonViHanhChinhCls[] DanhMucDonViHanhChinhs = new DanhMucDonViHanhChinhCls[dtTable.Rows.Count];
        for (int iIndex = 0; iIndex < dtTable.Rows.Count; iIndex++)
        {
            DanhMucDonViHanhChinhs[iIndex] = ParseFromDataRow(dtTable.Rows[iIndex]);
        }
        return DanhMucDonViHanhChinhs;
    }

    public static DanhMucDonViHanhChinhCls[] ParseFromMultiXml(string XmlData, string XmlDataSchema)
    {
        DataSet ds = CoreXmlUtility.GetDataSetFromXml(XmlData, XmlDataSchema);
        DanhMucDonViHanhChinhCls[] DanhMucDonViHanhChinhs = ParseFromDataTable(ds.Tables[0]);
        return DanhMucDonViHanhChinhs;
    }

    public static long CountFromDataTable(DataTable dtTable)
    {
        if (dtTable != null && dtTable.Rows.Count > 0)
        {
            return Int64.Parse(dtTable.Rows[0][0].ToString());
        }
        else
            return 0;
    }

    public static DanhMucDonViHanhChinhCls ParseFromXml(string XmlData, string XmlDataSchema)
    {
        DataSet ds = CoreXmlUtility.GetDataSetFromXml(XmlData, XmlDataSchema);
        if (ds.Tables[0].Rows.Count == 0) return null;
        DanhMucDonViHanhChinhCls ODanhMucDonViHanhChinh = ParseFromDataRow(ds.Tables[0].Rows[0]);
        return ODanhMucDonViHanhChinh;
    }

    public static XmlCls GetXml(DanhMucDonViHanhChinhCls[] DanhMucDonViHanhChinhs)
    {
        DataSet ds = new DataSet();
        ds.Tables.Add("info");
        ds.Tables["info"].Columns.Add("ID");
        ds.Tables["info"].Columns.Add("Ma");
        ds.Tables["info"].Columns.Add("Ten");
        ds.Tables["info"].Columns.Add("TenTat");
        ds.Tables["info"].Columns.Add("MieuTa");
        ds.Tables["info"].Columns.Add("STT", typeof(int));
        ds.Tables["info"].Columns.Add("HieuLuc", typeof(bool));
        ds.Tables["info"].Columns.Add("QuocGiaId");
        ds.Tables["info"].Columns.Add("VungId");
        ds.Tables["info"].Columns.Add("TinhThanhId");
        ds.Tables["info"].Columns.Add("QuanHuyenId");
        ds.Tables["info"].Columns.Add("XaPhuongId");
        for (int iIndex = 0; iIndex < DanhMucDonViHanhChinhs.Length; iIndex++)
        {
            ds.Tables["info"].Rows.Add(new object[]
            {
                DanhMucDonViHanhChinhs[iIndex].ID,
                DanhMucDonViHanhChinhs[iIndex].Ma,
                DanhMucDonViHanhChinhs[iIndex].Ten,
                DanhMucDonViHanhChinhs[iIndex].TenTat,
                DanhMucDonViHanhChinhs[iIndex].MieuTa,
                DanhMucDonViHanhChinhs[iIndex].STT,
                DanhMucDonViHanhChinhs[iIndex].HieuLuc,
                DanhMucDonViHanhChinhs[iIndex].QuocGiaId,
                DanhMucDonViHanhChinhs[iIndex].VungId,
                DanhMucDonViHanhChinhs[iIndex].TinhThanhId,
                DanhMucDonViHanhChinhs[iIndex].QuanHuyenId,
                DanhMucDonViHanhChinhs[iIndex].XaPhuongId,
            });
        }
        XmlCls OXml = new XmlCls();
        OXml.XmlData = ds.GetXml();
        OXml.XmlDataSchema = ds.GetXmlSchema();
        return OXml;
    }

    public static XmlCls GetXml(DanhMucDonViHanhChinhCls ODanhMucDonViHanhChinh)
    {
        DataSet ds = new DataSet();
        ds.Tables.Add("info");
        ds.Tables["info"].Columns.Add("ID");
        ds.Tables["info"].Columns.Add("Ma");
        ds.Tables["info"].Columns.Add("Ten");
        ds.Tables["info"].Columns.Add("TenTat");
        ds.Tables["info"].Columns.Add("MieuTa");
        ds.Tables["info"].Columns.Add("STT", typeof(int));
        ds.Tables["info"].Columns.Add("HieuLuc", typeof(bool));
        ds.Tables["info"].Columns.Add("QuocGiaId");
        ds.Tables["info"].Columns.Add("VungId");
        ds.Tables["info"].Columns.Add("TinhThanhId");
        ds.Tables["info"].Columns.Add("QuanHuyenId");
        ds.Tables["info"].Columns.Add("XaPhuongId");
        ds.Tables["info"].Rows.Add(new object[]
            {
                ODanhMucDonViHanhChinh.ID,
                ODanhMucDonViHanhChinh.Ma,
                ODanhMucDonViHanhChinh.Ten,
                ODanhMucDonViHanhChinh.TenTat,
                ODanhMucDonViHanhChinh.MieuTa,
                ODanhMucDonViHanhChinh.STT,
                ODanhMucDonViHanhChinh.HieuLuc,
                ODanhMucDonViHanhChinh.QuocGiaId,
                ODanhMucDonViHanhChinh.VungId,
                ODanhMucDonViHanhChinh.TinhThanhId,
                ODanhMucDonViHanhChinh.QuanHuyenId,
                ODanhMucDonViHanhChinh.XaPhuongId,
            });
        XmlCls OXml = new XmlCls();
        OXml.XmlData = ds.GetXml();
        OXml.XmlDataSchema = ds.GetXmlSchema();
        return OXml;
    }
}
