using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneFRAME.Core.Model;using OneFRAME.Model;

namespace OneFRAME.Model
{
    public class DanhMucICDChuongCls
    {
        public string ID;
        public string Ma;
        public string Ten;
        public string MaBCBYT;
        public string MoTa;
        public int HieuLuc;
        public DateTime NgayTao;
        public DateTime NgayHieuLuc;
        public DateTime NgayHetHieuLuc;
        public int STT;
        public string GhiChu;
        public string TacVu;

        
    }
}

public class DanhMucICDChuongParser
{
    public static DanhMucICDChuongCls CreateInstance()
    {
        DanhMucICDChuongCls ODanhMucICDChuong = new DanhMucICDChuongCls();
        return ODanhMucICDChuong;
    }


    public static DanhMucICDChuongCls ParseFromDataRow(DataRow dr)
    {
        DanhMucICDChuongCls ODanhMucICDChuong = new DanhMucICDChuongCls();
        ODanhMucICDChuong.ID = CoreXmlUtility.GetString(dr, "ID", true);
        ODanhMucICDChuong.Ma = CoreXmlUtility.GetString(dr, "Ma", true);
        ODanhMucICDChuong.Ten = CoreXmlUtility.GetString(dr, "Ten", true);
        ODanhMucICDChuong.MaBCBYT = CoreXmlUtility.GetString(dr, "MaBCBYT", true);
        ODanhMucICDChuong.MoTa = CoreXmlUtility.GetString(dr, "MoTa", true);
        ODanhMucICDChuong.HieuLuc = CoreXmlUtility.GetInt(dr, "HieuLuc", true);
        ODanhMucICDChuong.NgayTao = CoreXmlUtility.GetDate(dr, "NgayTao", true);
        ODanhMucICDChuong.NgayHieuLuc = CoreXmlUtility.GetDate(dr, "NgayHieuLuc", true);
        ODanhMucICDChuong.NgayHetHieuLuc = CoreXmlUtility.GetDate(dr, "NgayHetHieuLuc", true);
        ODanhMucICDChuong.STT = CoreXmlUtility.GetInt(dr, "STT", true);
        ODanhMucICDChuong.GhiChu = CoreXmlUtility.GetString(dr, "GhiChu", true);
        ODanhMucICDChuong.TacVu = CoreXmlUtility.GetString(dr, "TacVu", true);
      
        return ODanhMucICDChuong;
    }

    public static DanhMucICDChuongCls[] ParseFromDataTable(DataTable dtTable)
    {
        DanhMucICDChuongCls[] DanhMucICDChuongs = new DanhMucICDChuongCls[dtTable.Rows.Count];
        for (int iIndex = 0; iIndex < dtTable.Rows.Count; iIndex++)
        {
            DanhMucICDChuongs[iIndex] = ParseFromDataRow(dtTable.Rows[iIndex]);
        }
        return DanhMucICDChuongs;
    }

    public static DanhMucICDChuongCls[] ParseFromMultiXml(string XmlData, string XmlDataSchema)
    {
        DataSet ds = CoreXmlUtility.GetDataSetFromXml(XmlData, XmlDataSchema);
        DanhMucICDChuongCls[] DanhMucICDChuongs = ParseFromDataTable(ds.Tables[0]);
        return DanhMucICDChuongs;
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

    public static DanhMucICDChuongCls ParseFromXml(string XmlData, string XmlDataSchema)
    {
        DataSet ds = CoreXmlUtility.GetDataSetFromXml(XmlData, XmlDataSchema);
        if (ds.Tables[0].Rows.Count == 0) return null;
        DanhMucICDChuongCls ODanhMucICDChuong = ParseFromDataRow(ds.Tables[0].Rows[0]);
        return ODanhMucICDChuong;
    }

    public static XmlCls GetXml(DanhMucICDChuongCls[] DanhMucICDChuongs)
    {
        DataSet ds = new DataSet();
        ds.Tables.Add("info");
        ds.Tables["info"].Columns.Add("Ma");
        ds.Tables["info"].Columns.Add("Ten");
        ds.Tables["info"].Columns.Add("MaBCBYT");
        ds.Tables["info"].Columns.Add("MoTa");
        ds.Tables["info"].Columns.Add("HieuLuc", typeof(bool));
        ds.Tables["info"].Columns.Add("NgayTao");
        ds.Tables["info"].Columns.Add("NgayHieuLuc");
        ds.Tables["info"].Columns.Add("NgayHetHieuLuc");
        ds.Tables["info"].Columns.Add("STT", typeof(int));
        ds.Tables["info"].Columns.Add("GhiChu");
        ds.Tables["info"].Columns.Add("TacVu");
        
        for (int iIndex = 0; iIndex < DanhMucICDChuongs.Length; iIndex++)
        {
            ds.Tables["info"].Rows.Add(new object[]
            {
                DanhMucICDChuongs[iIndex].ID,
                DanhMucICDChuongs[iIndex].Ma,
                DanhMucICDChuongs[iIndex].Ten,
                DanhMucICDChuongs[iIndex].MaBCBYT,
                DanhMucICDChuongs[iIndex].MoTa,
                DanhMucICDChuongs[iIndex].HieuLuc,
                DanhMucICDChuongs[iIndex].NgayTao,
                DanhMucICDChuongs[iIndex].NgayHieuLuc,
                DanhMucICDChuongs[iIndex].NgayHetHieuLuc,
                DanhMucICDChuongs[iIndex].STT,
                DanhMucICDChuongs[iIndex].GhiChu,
                DanhMucICDChuongs[iIndex].TacVu,
               
            });
        }
        XmlCls OXml = new XmlCls();
        OXml.XmlData = ds.GetXml();
        OXml.XmlDataSchema = ds.GetXmlSchema();
        return OXml;
    }

    public static XmlCls GetXml(DanhMucICDChuongCls ODanhMucICDChuong)
    {
        DataSet ds = new DataSet();
        ds.Tables.Add("info");
        ds.Tables["info"].Columns.Add("ID");
        ds.Tables["info"].Columns.Add("Ma");
        ds.Tables["info"].Columns.Add("Ten");
        ds.Tables["info"].Columns.Add("MaBCBYT");
        ds.Tables["info"].Columns.Add("MoTa");
        ds.Tables["info"].Columns.Add("HieuLuc", typeof(bool));
        ds.Tables["info"].Columns.Add("NgayTao");
        ds.Tables["info"].Columns.Add("NgayHieuLuc");
        ds.Tables["info"].Columns.Add("STT", typeof(int));
        ds.Tables["info"].Columns.Add("GhiChu");
        ds.Tables["info"].Columns.Add("TacVu");
       
        ds.Tables["info"].Rows.Add(new object[]
            {   ODanhMucICDChuong.ID,
                ODanhMucICDChuong.Ma,
                ODanhMucICDChuong.Ten,
                ODanhMucICDChuong.MaBCBYT,
                ODanhMucICDChuong.MoTa,
                ODanhMucICDChuong.HieuLuc,
                ODanhMucICDChuong.NgayTao,
                ODanhMucICDChuong.NgayHieuLuc,
                ODanhMucICDChuong.STT,
                ODanhMucICDChuong.GhiChu,
                ODanhMucICDChuong.TacVu,
               
            });
        XmlCls OXml = new XmlCls();
        OXml.XmlData = ds.GetXml();
        OXml.XmlDataSchema = ds.GetXmlSchema();
        return OXml;
    }
}
