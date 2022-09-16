using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneFRAME.Core.Model;using OneFRAME.Model;

namespace OneFRAME.Model
{
    public class DanhMucXaPhuongCls
    {
        public string   ID;
        public string   Ma;
        public string   Ten;
        public string   QuanHuyenID;
        public string   MoTa;
        public int     HieuLuc;
        public int      STT;
        public DateTime   NgayTao;
        public string   GhiChu;
        public string   NgayHieuLuc;
        public string   NgayHetHieuLuc;
        public string   ChaID;
        public string   MaBCBYT;
    }
}

public class DanhMucXaPhuongParser
{
    public static DanhMucXaPhuongCls CreateInstance()
    {
        DanhMucXaPhuongCls ODanhMucXaPhuong = new DanhMucXaPhuongCls();
        return ODanhMucXaPhuong;
    }


    public static DanhMucXaPhuongCls ParseFromDataRow(DataRow dr)
    {
        DanhMucXaPhuongCls ODanhMucXaPhuong = new DanhMucXaPhuongCls();
        ODanhMucXaPhuong.ID = CoreXmlUtility.GetString(dr, "ID", true);
        ODanhMucXaPhuong.Ma = CoreXmlUtility.GetString(dr, "Ma", true);
        ODanhMucXaPhuong.Ten = CoreXmlUtility.GetString(dr, "Ten", true);
        ODanhMucXaPhuong.MaBCBYT = CoreXmlUtility.GetString(dr, "MaBCBYT", true);
        ODanhMucXaPhuong.MoTa = CoreXmlUtility.GetString(dr, "MoTa", true);
        ODanhMucXaPhuong.STT = CoreXmlUtility.GetInt(dr, "STT", true);
        ODanhMucXaPhuong.HieuLuc = CoreXmlUtility.GetInt(dr, "HieuLuc", true);
        ODanhMucXaPhuong.NgayTao = CoreXmlUtility.GetDate(dr, "NgayTao", true);
        ODanhMucXaPhuong.NgayHieuLuc = CoreXmlUtility.GetString(dr, "NgayHieuLuc", true);
        ODanhMucXaPhuong.NgayHetHieuLuc = CoreXmlUtility.GetString(dr, "NgayHetHieuLuc", true);
        ODanhMucXaPhuong.GhiChu = CoreXmlUtility.GetString(dr, "GhiChu", true);
        ODanhMucXaPhuong.ChaID = CoreXmlUtility.GetString(dr, "ChaID", true);
        return ODanhMucXaPhuong;
    }

    public static DanhMucXaPhuongCls[] ParseFromDataTable(DataTable dtTable)
    {
        DanhMucXaPhuongCls[] DanhMucXaPhuongs = new DanhMucXaPhuongCls[dtTable.Rows.Count];
        for (int iIndex = 0; iIndex < dtTable.Rows.Count; iIndex++)
        {
            DanhMucXaPhuongs[iIndex] = ParseFromDataRow(dtTable.Rows[iIndex]);
        }
        return DanhMucXaPhuongs;
    }

    public static DanhMucXaPhuongCls[] ParseFromMultiXml(string XmlData, string XmlDataSchema)
    {
        DataSet ds = CoreXmlUtility.GetDataSetFromXml(XmlData, XmlDataSchema);
        DanhMucXaPhuongCls[] DanhMucXaPhuongs = ParseFromDataTable(ds.Tables[0]);
        return DanhMucXaPhuongs;
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

    public static DanhMucXaPhuongCls ParseFromXml(string XmlData, string XmlDataSchema)
    {
        DataSet ds = CoreXmlUtility.GetDataSetFromXml(XmlData, XmlDataSchema);
        if (ds.Tables[0].Rows.Count == 0) return null;
        DanhMucXaPhuongCls ODanhMucXaPhuong = ParseFromDataRow(ds.Tables[0].Rows[0]);
        return ODanhMucXaPhuong;
    }

    public static XmlCls GetXml(DanhMucXaPhuongCls[] DanhMucXaPhuongs)
    {
        DataSet ds = new DataSet();
        ds.Tables.Add("info");
        ds.Tables["info"].Columns.Add("ID");
        ds.Tables["info"].Columns.Add("Ma");
        ds.Tables["info"].Columns.Add("Ten");
        ds.Tables["info"].Columns.Add("MaBCBYT");
        ds.Tables["info"].Columns.Add("MoTa");
        ds.Tables["info"].Columns.Add("STT", typeof(int));
        ds.Tables["info"].Columns.Add("HieuLuc", typeof(bool));
        ds.Tables["info"].Columns.Add("NgayTao");
        ds.Tables["info"].Columns.Add("NgayHieuLuc");
        ds.Tables["info"].Columns.Add("NgayHetHieuLuc");
        ds.Tables["info"].Columns.Add("GhiChu");
        ds.Tables["info"].Columns.Add("ChaID");
        for (int iIndex = 0; iIndex < DanhMucXaPhuongs.Length; iIndex++)
        {
            ds.Tables["info"].Rows.Add(new object[]
            {
                DanhMucXaPhuongs[iIndex].ID,
                DanhMucXaPhuongs[iIndex].Ma,
                DanhMucXaPhuongs[iIndex].Ten,
                DanhMucXaPhuongs[iIndex].MaBCBYT,
                DanhMucXaPhuongs[iIndex].MoTa,
                DanhMucXaPhuongs[iIndex].STT,
                DanhMucXaPhuongs[iIndex].HieuLuc,
                DanhMucXaPhuongs[iIndex].NgayTao,
                DanhMucXaPhuongs[iIndex].NgayHieuLuc,
                DanhMucXaPhuongs[iIndex].NgayHetHieuLuc,
                DanhMucXaPhuongs[iIndex].GhiChu,
                DanhMucXaPhuongs[iIndex].ChaID,
            });
        }
        XmlCls OXml = new XmlCls();
        OXml.XmlData = ds.GetXml();
        OXml.XmlDataSchema = ds.GetXmlSchema();
        return OXml;
    }

    public static XmlCls GetXml(DanhMucXaPhuongCls ODanhMucXaPhuong)
    {
        DataSet ds = new DataSet();
        ds.Tables.Add("info");
        ds.Tables["info"].Columns.Add("ID");
        ds.Tables["info"].Columns.Add("Ma");
        ds.Tables["info"].Columns.Add("Ten");
        ds.Tables["info"].Columns.Add("MaBCBYT");
        ds.Tables["info"].Columns.Add("MoTa");
        ds.Tables["info"].Columns.Add("STT", typeof(int));
        ds.Tables["info"].Columns.Add("HieuLuc", typeof(bool));
        ds.Tables["info"].Columns.Add("NgayTao");
        ds.Tables["info"].Columns.Add("NgayHieuLuc");
        ds.Tables["info"].Columns.Add("NgayHetHieuLuc");
        ds.Tables["info"].Columns.Add("GhiChu");
        ds.Tables["info"].Columns.Add("ChaID");
        ds.Tables["info"].Rows.Add(new object[]
            {
                ODanhMucXaPhuong.ID,
                ODanhMucXaPhuong.Ma,
                ODanhMucXaPhuong.Ten,
                ODanhMucXaPhuong.MaBCBYT,
                ODanhMucXaPhuong.MoTa,
                ODanhMucXaPhuong.STT,
                ODanhMucXaPhuong.HieuLuc,
                ODanhMucXaPhuong.NgayTao,
                ODanhMucXaPhuong.NgayHieuLuc,
                ODanhMucXaPhuong.NgayHetHieuLuc,
                ODanhMucXaPhuong.GhiChu,
                ODanhMucXaPhuong.ChaID,
            });
        XmlCls OXml = new XmlCls();
        OXml.XmlData = ds.GetXml();
        OXml.XmlDataSchema = ds.GetXmlSchema();
        return OXml;
    }
}
