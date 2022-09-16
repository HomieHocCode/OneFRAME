using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneFRAME.Core.Model;
using OneFRAME.Model;

namespace OneFRAME.Model
{
    public class DanhMucQuanHuyenCls
    {
        public string ID;
        public string Ma;
        public string Ten;
        public string TinhThanhID;
        public string MoTa;
        public int HieuLuc;
        public int STT;
        public DateTime NgayTao;
        public string GhiChu;
        public DateTime? NgayHieuLuc;
        public DateTime ?NgayHetHieuLuc;
        public string ChaID;
        public string MaBCBYT;
    }
}

public class DanhMucQuanHuyenParser
{
    public static DanhMucQuanHuyenCls CreateInstance()
    {
        DanhMucQuanHuyenCls ODanhMucQuanHuyen = new DanhMucQuanHuyenCls();
        return ODanhMucQuanHuyen;
    }


    public static DanhMucQuanHuyenCls ParseFromDataRow(DataRow dr)
    {
        DanhMucQuanHuyenCls ODanhMucQuanHuyen = new DanhMucQuanHuyenCls();
        ODanhMucQuanHuyen.ID = CoreXmlUtility.GetString(dr, "ID", true);
        ODanhMucQuanHuyen.Ma = CoreXmlUtility.GetString(dr, "Ma", true);
        ODanhMucQuanHuyen.Ten = CoreXmlUtility.GetString(dr, "Ten", true);
        ODanhMucQuanHuyen.MoTa = CoreXmlUtility.GetString(dr, "MoTa", true);
        ODanhMucQuanHuyen.TinhThanhID = CoreXmlUtility.GetString(dr, "TinhThanhID",true);
        ODanhMucQuanHuyen.HieuLuc = CoreXmlUtility.GetInt(dr, "HieuLuc", true);
        ODanhMucQuanHuyen.STT = CoreXmlUtility.GetInt(dr, "STT", true);
        ODanhMucQuanHuyen.NgayTao = CoreXmlUtility.GetDate(dr, "NgayTao", true);
        ODanhMucQuanHuyen.GhiChu = CoreXmlUtility.GetString(dr, "GhiChu", true);
        ODanhMucQuanHuyen.NgayHieuLuc = CoreXmlUtility.GetDateOrNull(dr, "TuNgay", true);
        ODanhMucQuanHuyen.NgayHetHieuLuc = CoreXmlUtility.GetDateOrNull(dr, "DenNgay", true);
        ODanhMucQuanHuyen.ChaID = CoreXmlUtility.GetString(dr, "ChaID", true);
        ODanhMucQuanHuyen.MaBCBYT = CoreXmlUtility.GetString(dr, "MaBCBYT", true);
        return ODanhMucQuanHuyen;
    }

    public static DanhMucQuanHuyenCls[] ParseFromDataTable(DataTable dtTable)
    {
        DanhMucQuanHuyenCls[] DanhMucQuanHuyens = new DanhMucQuanHuyenCls[dtTable.Rows.Count];
        for (int iIndex = 0; iIndex < dtTable.Rows.Count; iIndex++)
        {
            DanhMucQuanHuyens[iIndex] = ParseFromDataRow(dtTable.Rows[iIndex]);
        }
        return DanhMucQuanHuyens;
    }

    public static DanhMucQuanHuyenCls[] ParseFromMultiXml(string XmlData, string XmlDataSchema)
    {
        DataSet ds = CoreXmlUtility.GetDataSetFromXml(XmlData, XmlDataSchema);
        DanhMucQuanHuyenCls[] DanhMucQuanHuyens = ParseFromDataTable(ds.Tables[0]);
        return DanhMucQuanHuyens;
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

    public static DanhMucQuanHuyenCls ParseFromXml(string XmlData, string XmlDataSchema)
    {
        DataSet ds = CoreXmlUtility.GetDataSetFromXml(XmlData, XmlDataSchema);
        if (ds.Tables[0].Rows.Count == 0) return null;
        DanhMucQuanHuyenCls ODanhMucQuanHuyen = ParseFromDataRow(ds.Tables[0].Rows[0]);
        return ODanhMucQuanHuyen;
    }

    public static XmlCls GetXml(DanhMucQuanHuyenCls[] DanhMucQuanHuyens)
    {
        DataSet ds = new DataSet();
        ds.Tables.Add("info");
        ds.Tables["info"].Columns.Add("ID");
        ds.Tables["info"].Columns.Add("Ma");
        ds.Tables["info"].Columns.Add("Ten");
        ds.Tables["info"].Columns.Add("TinhThanhID");
        ds.Tables["info"].Columns.Add("MoTa");
        ds.Tables["info"].Columns.Add("HieuLuc", typeof(int));
        ds.Tables["info"].Columns.Add("STT", typeof(int));
        ds.Tables["info"].Columns.Add("NgayTao");
        ds.Tables["info"].Columns.Add("GhiChu");
        ds.Tables["info"].Columns.Add("TuNgay");
        ds.Tables["info"].Columns.Add("DenNgay");
        ds.Tables["info"].Columns.Add("ChaID");
        ds.Tables["info"].Columns.Add("MaBCBYT");
        for (int iIndex = 0; iIndex < DanhMucQuanHuyens.Length; iIndex++)
        {
            ds.Tables["info"].Rows.Add(new object[]
            {
                DanhMucQuanHuyens[iIndex].ID,
                DanhMucQuanHuyens[iIndex].Ma,
                DanhMucQuanHuyens[iIndex].Ten,
                DanhMucQuanHuyens[iIndex].TinhThanhID,
                DanhMucQuanHuyens[iIndex].MoTa,
                DanhMucQuanHuyens[iIndex].HieuLuc,
                DanhMucQuanHuyens[iIndex].STT,
                DanhMucQuanHuyens[iIndex].NgayTao,
                DanhMucQuanHuyens[iIndex].GhiChu,
                DanhMucQuanHuyens[iIndex].NgayHieuLuc,
                DanhMucQuanHuyens[iIndex].NgayHetHieuLuc,
                DanhMucQuanHuyens[iIndex].ChaID,
                DanhMucQuanHuyens[iIndex].MaBCBYT,
            });
        }
        XmlCls OXml = new XmlCls();
        OXml.XmlData = ds.GetXml();
        OXml.XmlDataSchema = ds.GetXmlSchema();
        return OXml;
    }

    public static XmlCls GetXml(DanhMucQuanHuyenCls ODanhMucQuanHuyen)
    {
        DataSet ds = new DataSet();
        ds.Tables.Add("info");
        ds.Tables["info"].Columns.Add("ID");
        ds.Tables["info"].Columns.Add("Ma");
        ds.Tables["info"].Columns.Add("Ten");
        ds.Tables["info"].Columns.Add("TinhThanhID");
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
                ODanhMucQuanHuyen.ID,
                ODanhMucQuanHuyen.Ma,
                ODanhMucQuanHuyen.Ten,
                ODanhMucQuanHuyen.TinhThanhID,
                ODanhMucQuanHuyen.MoTa,
                ODanhMucQuanHuyen.HieuLuc,
                ODanhMucQuanHuyen.STT,
                ODanhMucQuanHuyen.NgayTao,
                ODanhMucQuanHuyen.GhiChu,
                ODanhMucQuanHuyen.NgayHieuLuc,
                ODanhMucQuanHuyen.NgayHetHieuLuc,
                ODanhMucQuanHuyen.ChaID,
                ODanhMucQuanHuyen.MaBCBYT,
            });
        XmlCls OXml = new XmlCls();
        OXml.XmlData = ds.GetXml();
        OXml.XmlDataSchema = ds.GetXmlSchema();
        return OXml;
    }
}
