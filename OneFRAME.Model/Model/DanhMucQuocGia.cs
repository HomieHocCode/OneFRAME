using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OneFRAME.Core.Model;using OneFRAME.Model;

namespace OneFRAME.Model
{
    public class DanhMucQuocGiaCls
    {
        public string ID;
        public string Ma;
        public string Ten;
        public DateTime NgayTao;
        public string MoTa;
        public int STT;
        public int HieuLuc;
        public string GhiChu;
        public string NgayHieuLuc;
        public string NgayHetHieuLuc;
        public string ChaID;
        public int BanBe;
    }
}

public class DanhMucQuocGiaParser
{
    public static DanhMucQuocGiaCls CreateInstance()
    {
        DanhMucQuocGiaCls ODanhMucQuocGia = new DanhMucQuocGiaCls();
        return ODanhMucQuocGia;
    }


    public static DanhMucQuocGiaCls ParseFromDataRow(DataRow dr)
    {
        DanhMucQuocGiaCls ODanhMucQuocGia = new DanhMucQuocGiaCls();
        ODanhMucQuocGia.ID = CoreXmlUtility.GetString(dr, "ID", true);
        ODanhMucQuocGia.Ma = CoreXmlUtility.GetString(dr, "Ma", true);
        ODanhMucQuocGia.Ten = CoreXmlUtility.GetString(dr, "Ten", true);
        ODanhMucQuocGia.MoTa = CoreXmlUtility.GetString(dr, "MoTa", true);
        ODanhMucQuocGia.HieuLuc = CoreXmlUtility.GetInt(dr, "HieuLuc", true);
        ODanhMucQuocGia.STT = CoreXmlUtility.GetInt(dr, "STT", true);
        ODanhMucQuocGia.NgayTao = CoreXmlUtility.GetDate(dr, "NgayTao", true);
        ODanhMucQuocGia.GhiChu = CoreXmlUtility.GetString(dr, "GhiChu", true);
        ODanhMucQuocGia.NgayHieuLuc = CoreXmlUtility.GetString(dr, "NgayHieuLuc", true);
        ODanhMucQuocGia.NgayHetHieuLuc = CoreXmlUtility.GetString(dr, "NgayHetHieuLuc", true);
        ODanhMucQuocGia.ChaID = CoreXmlUtility.GetString(dr, "ChaID", true);
        ODanhMucQuocGia.BanBe = CoreXmlUtility.GetInt(dr, "BanBe", true);
        return ODanhMucQuocGia;
    }

    public static DanhMucQuocGiaCls[] ParseFromDataTable(DataTable dtTable)
    {
        DanhMucQuocGiaCls[] DanhMucQuocGias = new DanhMucQuocGiaCls[dtTable.Rows.Count];
        for (int iIndex = 0; iIndex < dtTable.Rows.Count; iIndex++)
        {
            DanhMucQuocGias[iIndex] = ParseFromDataRow(dtTable.Rows[iIndex]);
        }
        return DanhMucQuocGias;
    }

    public static DanhMucQuocGiaCls[] ParseFromMultiXml(string XmlData, string XmlDataSchema)
    {
        DataSet ds = CoreXmlUtility.GetDataSetFromXml(XmlData, XmlDataSchema);
        DanhMucQuocGiaCls[] DanhMucQuocGias = ParseFromDataTable(ds.Tables[0]);
        return DanhMucQuocGias;
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

    public static DanhMucQuocGiaCls ParseFromXml(string XmlData, string XmlDataSchema)
    {
        DataSet ds = CoreXmlUtility.GetDataSetFromXml(XmlData, XmlDataSchema);
        if (ds.Tables[0].Rows.Count == 0) return null;
        DanhMucQuocGiaCls ODanhMucQuocGia = ParseFromDataRow(ds.Tables[0].Rows[0]);
        return ODanhMucQuocGia;
    }

    public static XmlCls GetXml(DanhMucQuocGiaCls[] DanhMucQuocGias)
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
        ds.Tables["info"].Columns.Add("BanBe");
        for (int iIndex = 0; iIndex < DanhMucQuocGias.Length; iIndex++)
        {
            ds.Tables["info"].Rows.Add(new object[]
            {
                DanhMucQuocGias[iIndex].ID,
                DanhMucQuocGias[iIndex].Ma,
                DanhMucQuocGias[iIndex].Ten,
                DanhMucQuocGias[iIndex].NgayTao,
                DanhMucQuocGias[iIndex].MoTa,
                DanhMucQuocGias[iIndex].STT,
                DanhMucQuocGias[iIndex].HieuLuc,
                DanhMucQuocGias[iIndex].GhiChu,
                DanhMucQuocGias[iIndex].NgayHieuLuc,
                DanhMucQuocGias[iIndex].NgayHetHieuLuc,
                DanhMucQuocGias[iIndex].ChaID,
                DanhMucQuocGias[iIndex].BanBe,
            });
        }
        XmlCls OXml = new XmlCls();
        OXml.XmlData = ds.GetXml();
        OXml.XmlDataSchema = ds.GetXmlSchema();
        return OXml;
    }

    public static XmlCls GetXml(DanhMucQuocGiaCls ODanhMucQuocGia)
    {
        DataSet ds = new DataSet();
        ds.Tables.Add("info");
        ds.Tables["info"].Columns.Add("ID");
        ds.Tables["info"].Columns.Add("Ma");
        ds.Tables["info"].Columns.Add("Ten");
        ds.Tables["info"].Columns.Add("MoTa");
        ds.Tables["info"].Columns.Add("HieuLuc", typeof(bool));
        ds.Tables["info"].Columns.Add("STT", typeof(int));
        ds.Tables["info"].Columns.Add("NgayTao");
        ds.Tables["info"].Columns.Add("GhiChu");
        ds.Tables["info"].Columns.Add("NgayHieuLuc");
        ds.Tables["info"].Columns.Add("NgayHetHieuLuc");
        ds.Tables["info"].Columns.Add("ChaID");
        ds.Tables["info"].Columns.Add("BanBe");
        ds.Tables["info"].Rows.Add(new object[]
            {
                ODanhMucQuocGia.ID,
                ODanhMucQuocGia.Ma,
                ODanhMucQuocGia.Ten,
                ODanhMucQuocGia.MoTa,
                ODanhMucQuocGia.HieuLuc,
                ODanhMucQuocGia.STT,
                ODanhMucQuocGia.NgayTao,
                ODanhMucQuocGia.GhiChu,
                ODanhMucQuocGia.NgayHieuLuc,
                ODanhMucQuocGia.NgayHetHieuLuc,
                ODanhMucQuocGia.ChaID,
                ODanhMucQuocGia.BanBe,
            });
        XmlCls OXml = new XmlCls();
        OXml.XmlData = ds.GetXml();
        OXml.XmlDataSchema = ds.GetXmlSchema();
        return OXml;
    }
}
