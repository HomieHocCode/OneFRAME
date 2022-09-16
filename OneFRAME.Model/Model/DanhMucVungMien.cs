using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneFRAME.Core.Model;using OneFRAME.Model;

namespace OneFRAME.Model
{
    public class DanhMucVungMienCls
    {
        public string ID;
        public string Ma;
        public string Ten;
        public string MoTa;
        public int HieuLuc;
        public int STT;
        public DateTime  NgayTao;
        public string GhiChu;
        public string NgayHieuLuc;
        public string NgayHetHieuLuc;
        public string ChaID;
       
    }
}

public class DanhMucVungMienParser
{
    public static DanhMucVungMienCls CreateInstance()
    {
        DanhMucVungMienCls ODanhMucVungMien = new DanhMucVungMienCls();
        return ODanhMucVungMien;
    }


    public static DanhMucVungMienCls ParseFromDataRow(DataRow dr)
    {
        DanhMucVungMienCls ODanhMucVungMien = new DanhMucVungMienCls();
        ODanhMucVungMien.ID = CoreXmlUtility.GetString(dr, "ID", true);
        ODanhMucVungMien.Ma = CoreXmlUtility.GetString(dr, "Ma", true);
        ODanhMucVungMien.Ten = CoreXmlUtility.GetString(dr, "Ten", true);
        ODanhMucVungMien.MoTa = CoreXmlUtility.GetString(dr, "MoTa", true);
        ODanhMucVungMien.HieuLuc = CoreXmlUtility.GetInt(dr, "HieuLuc", true);
        ODanhMucVungMien.STT = CoreXmlUtility.GetInt(dr, "STT", true);
        ODanhMucVungMien.NgayTao = CoreXmlUtility.GetDate(dr, "NgayTao", true);
        ODanhMucVungMien.GhiChu = CoreXmlUtility.GetString(dr, "GhiChu", true);
        ODanhMucVungMien.NgayHieuLuc = CoreXmlUtility.GetString(dr, "NgayHieuLuc", true);
        ODanhMucVungMien.NgayHetHieuLuc = CoreXmlUtility.GetString(dr, "NgayHetHieuLuc", true);
        ODanhMucVungMien.ChaID = CoreXmlUtility.GetString(dr, "ChaID", true);
         
        return ODanhMucVungMien;
    }

    public static DanhMucVungMienCls[] ParseFromDataTable(DataTable dtTable)
    {
        DanhMucVungMienCls[] DanhMucVungMiens = new DanhMucVungMienCls[dtTable.Rows.Count];
        for (int iIndex = 0; iIndex < dtTable.Rows.Count; iIndex++)
        {
            DanhMucVungMiens[iIndex] = ParseFromDataRow(dtTable.Rows[iIndex]);
        }
        return DanhMucVungMiens;
    }

    public static DanhMucVungMienCls[] ParseFromMultiXml(string XmlData, string XmlDataSchema)
    {
        DataSet ds = CoreXmlUtility.GetDataSetFromXml(XmlData, XmlDataSchema);
        DanhMucVungMienCls[] DanhMucVungMiens = ParseFromDataTable(ds.Tables[0]);
        return DanhMucVungMiens;
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

    public static DanhMucVungMienCls ParseFromXml(string XmlData, string XmlDataSchema)
    {
        DataSet ds = CoreXmlUtility.GetDataSetFromXml(XmlData, XmlDataSchema);
        if (ds.Tables[0].Rows.Count == 0) return null;
        DanhMucVungMienCls ODanhMucVungMien = ParseFromDataRow(ds.Tables[0].Rows[0]);
        return ODanhMucVungMien;
    }

    public static XmlCls GetXml(DanhMucVungMienCls[] DanhMucVungMiens)
    {
        DataSet ds = new DataSet();
        ds.Tables.Add("info");
        ds.Tables["info"].Columns.Add("ID");
        ds.Tables["info"].Columns.Add("Ma");
        ds.Tables["info"].Columns.Add("Ten");
        ds.Tables["info"].Columns.Add("NgayTao");
        ds.Tables["info"].Columns.Add("MoTa");
        ds.Tables["info"].Columns.Add("STT", typeof(int));
        ds.Tables["info"].Columns.Add("HieuLuc", typeof(bool));
        ds.Tables["info"].Columns.Add("GhiChu");
        ds.Tables["info"].Columns.Add("NgayHieuLuc");
        ds.Tables["info"].Columns.Add("NgayHetHieuLuc");
        ds.Tables["info"].Columns.Add("ChaID");
        ds.Tables["info"].Columns.Add("XaPhuongId");
        for (int iIndex = 0; iIndex < DanhMucVungMiens.Length; iIndex++)
        {
            ds.Tables["info"].Rows.Add(new object[]
            {
                DanhMucVungMiens[iIndex].ID,
                DanhMucVungMiens[iIndex].Ma,
                DanhMucVungMiens[iIndex].Ten,
                DanhMucVungMiens[iIndex].NgayTao,
                DanhMucVungMiens[iIndex].MoTa,
                DanhMucVungMiens[iIndex].STT,
                DanhMucVungMiens[iIndex].HieuLuc,
                DanhMucVungMiens[iIndex].GhiChu,
                DanhMucVungMiens[iIndex].NgayHieuLuc,
                DanhMucVungMiens[iIndex].NgayHetHieuLuc,
                DanhMucVungMiens[iIndex].ChaID,
                
            });
        }
        XmlCls OXml = new XmlCls();
        OXml.XmlData = ds.GetXml();
        OXml.XmlDataSchema = ds.GetXmlSchema();
        return OXml;
    }

    public static XmlCls GetXml(DanhMucVungMienCls ODanhMucVungMien)
    {
        DataSet ds = new DataSet();
        ds.Tables.Add("info");
        ds.Tables["info"].Columns.Add("ID");
        ds.Tables["info"].Columns.Add("Ma");
        ds.Tables["info"].Columns.Add("Ten");
        ds.Tables["info"].Columns.Add("NgayTao");
        ds.Tables["info"].Columns.Add("MoTa");
        ds.Tables["info"].Columns.Add("STT", typeof(int));
        ds.Tables["info"].Columns.Add("HieuLuc", typeof(bool));
        ds.Tables["info"].Columns.Add("GhiChu");
        ds.Tables["info"].Columns.Add("NgayHieuLuc");
        ds.Tables["info"].Columns.Add("NgayHetHieuLuc");
        ds.Tables["info"].Columns.Add("ChaID");
        ds.Tables["info"].Columns.Add("XaPhuongId");
        ds.Tables["info"].Rows.Add(new object[]
            {
                ODanhMucVungMien.ID,
                ODanhMucVungMien.Ma,
                ODanhMucVungMien.Ten,
                ODanhMucVungMien.NgayTao,
                ODanhMucVungMien.MoTa,
                ODanhMucVungMien.STT,
                ODanhMucVungMien.HieuLuc,
                ODanhMucVungMien.GhiChu,
                ODanhMucVungMien.NgayHieuLuc,
                ODanhMucVungMien.NgayHetHieuLuc,
                ODanhMucVungMien.ChaID,
                 
            });
        XmlCls OXml = new XmlCls();
        OXml.XmlData = ds.GetXml();
        OXml.XmlDataSchema = ds.GetXmlSchema();
        return OXml;
    }
}
