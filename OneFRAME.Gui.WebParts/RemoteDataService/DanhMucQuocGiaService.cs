using OneFRAME.Call.Bussiness.Utility;
using OneFRAME.Core.Model;
using OneFRAME.Model;
using OneFRAME.Bussiness.Utility;
using OneFRAME.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OneFRAME.WebParts
{

    public class DanhMucQuocGiaService : RemoteDataTypedTemplate
    {
        public static string StaticServiceId
        {
            get
            {
                return "DanhMucQuocGiaService";
            }
        }
        public override string ServiceId
        {
            get
            {
                return StaticServiceId;
            }
        }

        public override string ServiceName
        {
            get
            {
                return "Danh mục đơn vị hành chính"; //change 
            }
        }
        //change OwnerUser --> DanhMucQuocGia
        public override AjaxOut Reading(RenderInfoCls ORenderInfo, int PageIndex, string Keyword)
        {
            AjaxOut RetAjaxOut = new AjaxOut();

            try
            {
                DanhMucQuocGiaFilterCls
                    DanhMucQuocGiaFilter = new DanhMucQuocGiaFilterCls();
                DanhMucQuocGiaFilter.Keyword = Keyword;
                DanhMucQuocGiaFilter.PageIndex = PageIndex;
                DanhMucQuocGiaFilter.Status = 1;

                int  recordTotal = 0; // from PageReading(ORenderInfo, DanhMucQuocGiaFilter, ref recordTotal);
                DanhMucQuocGiaCls[]
                    DanhMucQuocGias = OneFRAME.Call.Bussiness.Utility.CallBussinessUtility.CreateBussinessProcess().CreateDanhMucQuocGiaProcess().PageReading(ORenderInfo, DanhMucQuocGiaFilter, ref recordTotal);

                if (DanhMucQuocGias.Length != 0 && PageIndex == 0)
                {
                    var ODanhMucQuocGia = new DanhMucQuocGiaCls();
                    var lstDanhMucQuocGia = DanhMucQuocGias.ToList();
                    lstDanhMucQuocGia.Insert(0, ODanhMucQuocGia);
                    DanhMucQuocGias = lstDanhMucQuocGia.ToArray();

                }
                //recordTotal = DanhMucQuocGias.Length;
                Record ORecord = new Record();
                ORecord.total_count = (int)recordTotal;
                ORecord.incomplete_results = true;
                ORecord.items = new RecordItemCls[DanhMucQuocGias.Length];
                for (int iIndex = 0; iIndex < DanhMucQuocGias.Length; iIndex++)
                {
                    ORecord.items[iIndex] = new RecordItemCls();
                    if (!string.IsNullOrEmpty(DanhMucQuocGias[iIndex].ID))
                    {
                        ORecord.items[iIndex] = new RecordItemCls();
                        ORecord.items[iIndex].id = DanhMucQuocGias[iIndex].ID;
                        ORecord.items[iIndex].text = DanhMucQuocGias[iIndex].Ten;

                        ORecord.items[iIndex].Code = DanhMucQuocGias[iIndex].Ma;
                        ORecord.items[iIndex].Name = DanhMucQuocGias[iIndex].Ten;
                    }
                    else
                    {
                        ORecord.items[iIndex].id = null;
                        ORecord.items[iIndex].Code = "Mã";
                        ORecord.items[iIndex].Name = "Tên";
                    }
                }
                string json = JsonConvert.SerializeObject(ORecord, Formatting.Indented);
                RetAjaxOut.HtmlContent = json;
            }
            catch (Exception ex)
            {
                RetAjaxOut.Error = true;
                RetAjaxOut.InfoMessage = string.IsNullOrEmpty(ex.Message) ? ex.ToString() : ex.Message;
            }
            return RetAjaxOut;
        }
        public override string LoadDisplayName(RenderInfoCls ORenderInfo, string Id)
        {
            var DanhMucQuocGia = OneFRAME.Call.Bussiness.Utility.CallBussinessUtility.CreateBussinessProcess().CreateDanhMucQuocGiaProcess().CreateModel(ORenderInfo, Id);
            if (DanhMucQuocGia != null)
                return DanhMucQuocGia.Ten;
            else
                return "";
        }
    }
}
