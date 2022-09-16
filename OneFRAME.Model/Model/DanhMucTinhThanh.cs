using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneFRAME.Core.Model;using OneFRAME.Model;

namespace OneFRAME.Model
{
    public class DanhMucTinhThanhCls
    {
        public string ID;
        public string Ma;
        public string Ten;
        public string QuocGiaID;
        public string VungID;
        public string MoTa;
        public int HieuLuc;
        public int STT;
        public DateTime NgayTao;
        public string GhiChu;
        public DateTime? NgayHieuLuc;
        public DateTime? NgayHetHieuLuc;
        public string ChaID;
        public string MaBCBYT;
    }
}

public class DanhMucTinhThanhParser
{
    public static DanhMucTinhThanhCls CreateInstance()
    {
        DanhMucTinhThanhCls ODanhMucTinhThanh = new DanhMucTinhThanhCls();
        return ODanhMucTinhThanh;
    }


    public static DanhMucTinhThanhCls ParseFromDataRow(DataRow dr)
    {
        DanhMucTinhThanhCls ODanhMucTinhThanh = new DanhMucTinhThanhCls();
        ODanhMucTinhThanh.ID = CoreXmlUtility.GetString(dr, "ID", true);
        ODanhMucTinhThanh.Ma = CoreXmlUtility.GetString(dr, "Ma", true);
        ODanhMucTinhThanh.Ten = CoreXmlUtility.GetString(dr, "Ten", true);
        ODanhMucTinhThanh.QuocGiaID = CoreXmlUtility.GetString(dr, "QuocGiaID",true);
        ODanhMucTinhThanh.VungID  = CoreXmlUtility.GetString(dr, "VungID", true);
        ODanhMucTinhThanh.MoTa = CoreXmlUtility.GetString(dr, "MoTa", true);
        ODanhMucTinhThanh.HieuLuc = CoreXmlUtility.GetInt(dr, "HieuLuc", true);
        ODanhMucTinhThanh.STT = CoreXmlUtility.GetInt(dr, "STT", true);
        ODanhMucTinhThanh.NgayTao = CoreXmlUtility.GetDate(dr, "NgayTao", true);
        ODanhMucTinhThanh.GhiChu = CoreXmlUtility.GetString(dr, "GhiChu", true);
        ODanhMucTinhThanh.NgayHieuLuc = CoreXmlUtility.GetDateOrNull(dr, "TuNgay", true);
        ODanhMucTinhThanh.NgayHetHieuLuc = CoreXmlUtility.GetDateOrNull(dr, "DenNgay", true);
        ODanhMucTinhThanh.ChaID = CoreXmlUtility.GetString(dr, "ChaID", true);
        ODanhMucTinhThanh.MaBCBYT = CoreXmlUtility.GetString(dr, "MaBCBYT", true);
        return ODanhMucTinhThanh;
    }

    public static DanhMucTinhThanhCls[] ParseFromDataTable(DataTable dtTable)
    {
        DanhMucTinhThanhCls[] DanhMucTinhThanhs = new DanhMucTinhThanhCls[dtTable.Rows.Count];
        for (int iIndex = 0; iIndex < dtTable.Rows.Count; iIndex++)
        {
            DanhMucTinhThanhs[iIndex] = ParseFromDataRow(dtTable.Rows[iIndex]);
        }
        return DanhMucTinhThanhs;
    }

    public static DanhMucTinhThanhCls[] ParseFromMultiXml(string XmlData, string XmlDataSchema)
    {
        DataSet ds = CoreXmlUtility.GetDataSetFromXml(XmlData, XmlDataSchema);
        DanhMucTinhThanhCls[] DanhMucTinhThanhs = ParseFromDataTable(ds.Tables[0]);
        return DanhMucTinhThanhs;
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

    public static DanhMucTinhThanhCls ParseFromXml(string XmlData, string XmlDataSchema)
    {
        DataSet ds = CoreXmlUtility.GetDataSetFromXml(XmlData, XmlDataSchema);
        if (ds.Tables[0].Rows.Count == 0) return null;
        DanhMucTinhThanhCls ODanhMucTinhThanh = ParseFromDataRow(ds.Tables[0].Rows[0]);
        return ODanhMucTinhThanh;
    }

    public static XmlCls GetXml(DanhMucTinhThanhCls[] DanhMucTinhThanhs)
    {
        DataSet ds = new DataSet();
        ds.Tables.Add("info");
        ds.Tables["info"].Columns.Add("ID");
        ds.Tables["info"].Columns.Add("Ma");
        ds.Tables["info"].Columns.Add("Ten");
        ds.Tables["info"].Columns.Add("QuocGiaID");
        ds.Tables["info"].Columns.Add("VungID");
        ds.Tables["info"].Columns.Add("MoTa");
        ds.Tables["info"].Columns.Add("HieuLuc", typeof(int));
        ds.Tables["info"].Columns.Add("STT", typeof(int));
        ds.Tables["info"].Columns.Add("NgayTao");
        ds.Tables["info"].Columns.Add("GhiChu");
        ds.Tables["info"].Columns.Add("TuNgay");
        ds.Tables["info"].Columns.Add("DenNgay");
        ds.Tables["info"].Columns.Add("ChaID");
        ds.Tables["info"].Columns.Add("MaBCBYT");
        for (int iIndex = 0; iIndex < DanhMucTinhThanhs.Length; iIndex++)
        {
            ds.Tables["info"].Rows.Add(new object[]
            {
                DanhMucTinhThanhs[iIndex].ID,
                DanhMucTinhThanhs[iIndex].Ma,
                DanhMucTinhThanhs[iIndex].Ten,
                DanhMucTinhThanhs[iIndex].QuocGiaID,
                DanhMucTinhThanhs[iIndex].VungID,
                DanhMucTinhThanhs[iIndex].MoTa,
                DanhMucTinhThanhs[iIndex].HieuLuc,
                DanhMucTinhThanhs[iIndex].STT,
                DanhMucTinhThanhs[iIndex].NgayTao,
                DanhMucTinhThanhs[iIndex].GhiChu,
                DanhMucTinhThanhs[iIndex].NgayHieuLuc,
                DanhMucTinhThanhs[iIndex].NgayHetHieuLuc,
                DanhMucTinhThanhs[iIndex].ChaID,
                DanhMucTinhThanhs[iIndex].MaBCBYT,
            });
        }
        XmlCls OXml = new XmlCls();
        OXml.XmlData = ds.GetXml();
        OXml.XmlDataSchema = ds.GetXmlSchema();
        return OXml;
    }

    public static XmlCls GetXml(DanhMucTinhThanhCls ODanhMucTinhThanh)
    {
        DataSet ds = new DataSet();
        ds.Tables.Add("info");
        ds.Tables["info"].Columns.Add("ID");
        ds.Tables["info"].Columns.Add("Ma");
        ds.Tables["info"].Columns.Add("Ten");
        ds.Tables["info"].Columns.Add("QuocGiaID");
        ds.Tables["info"].Columns.Add("VungID");
        ds.Tables["info"].Columns.Add("MoTa");
        ds.Tables["info"].Columns.Add("STT", typeof(int));
        ds.Tables["info"].Columns.Add("HieuLuc", typeof(int));
        ds.Tables["info"].Columns.Add("NgayTao");
        ds.Tables["info"].Columns.Add("GhiChu");
        ds.Tables["info"].Columns.Add("NgayHieuLuc");
        ds.Tables["info"].Columns.Add("NgayHetHieuLuc");
        ds.Tables["info"].Columns.Add("ChaID");
        ds.Tables["info"].Columns.Add("MaBCBYT");
        ds.Tables["info"].Rows.Add(new object[]
            {
                ODanhMucTinhThanh.ID,
                ODanhMucTinhThanh.Ma,
                ODanhMucTinhThanh.Ten,
                ODanhMucTinhThanh.QuocGiaID,
                ODanhMucTinhThanh.VungID,
                ODanhMucTinhThanh.MoTa,
                ODanhMucTinhThanh.HieuLuc,
                ODanhMucTinhThanh.STT,
                ODanhMucTinhThanh.NgayTao,
                ODanhMucTinhThanh.GhiChu,
                ODanhMucTinhThanh.NgayHieuLuc,
                ODanhMucTinhThanh.NgayHetHieuLuc,
                ODanhMucTinhThanh.ChaID,
                ODanhMucTinhThanh.MaBCBYT,
            });
        XmlCls OXml = new XmlCls();
        OXml.XmlData = ds.GetXml();
        OXml.XmlDataSchema = ds.GetXmlSchema();
        return OXml;
    }
}
