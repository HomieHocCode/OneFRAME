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

    public class DanhMucVungMienService : RemoteDataTypedTemplate
    {
        public static string StaticServiceId
        {
            get
            {
                return "DanhMucVungMienService";
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
        //change OwnerUser --> DanhMucVungMien
        public override AjaxOut Reading(RenderInfoCls ORenderInfo, int PageIndex, string Keyword)
        {
            AjaxOut RetAjaxOut = new AjaxOut();

            try
            {
                DanhMucVungMienFilterCls
                    DanhMucVungMienFilter = new DanhMucVungMienFilterCls();
                DanhMucVungMienFilter.Keyword = Keyword;
                DanhMucVungMienFilter.PageIndex = PageIndex;
                DanhMucVungMienFilter.Status = 1;

                int recordTotal = 0; // from PageReading(ORenderInfo, DanhMucVungMienFilter, ref recordTotal);
                DanhMucVungMienCls[]
                    DanhMucVungMiens = OneFRAME.Call.Bussiness.Utility.CallBussinessUtility.CreateBussinessProcess().CreateDanhMucVungMienProcess().PageReading(ORenderInfo, DanhMucVungMienFilter, ref recordTotal);

                if (DanhMucVungMiens.Length != 0 && PageIndex == 0)
                {
                    var ODanhMucVungMien = new DanhMucVungMienCls();
                    var lstDanhMucVungMien = DanhMucVungMiens.ToList();
                    lstDanhMucVungMien.Insert(0, ODanhMucVungMien);
                    DanhMucVungMiens = lstDanhMucVungMien.ToArray();

                }
                //recordTotal = DanhMucVungMiens.Length;
                Record ORecord = new Record();
                ORecord.total_count = (int)recordTotal;
                ORecord.incomplete_results = true;
                ORecord.items = new RecordItemCls[DanhMucVungMiens.Length];
                for (int iIndex = 0; iIndex < DanhMucVungMiens.Length; iIndex++)
                {
                    ORecord.items[iIndex] = new RecordItemCls();
                    if (!string.IsNullOrEmpty(DanhMucVungMiens[iIndex].ID))
                    {
                        ORecord.items[iIndex] = new RecordItemCls();
                        ORecord.items[iIndex].id = DanhMucVungMiens[iIndex].ID;
                        ORecord.items[iIndex].text = DanhMucVungMiens[iIndex].Ten;

                        ORecord.items[iIndex].Code = DanhMucVungMiens[iIndex].Ma;
                        ORecord.items[iIndex].Name = DanhMucVungMiens[iIndex].Ten;
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
            var DanhMucVungMien = OneFRAME.Call.Bussiness.Utility.CallBussinessUtility.CreateBussinessProcess().CreateDanhMucVungMienProcess().CreateModel(ORenderInfo, Id);
            if (DanhMucVungMien != null)
                return DanhMucVungMien.Ten;
            else
                return "";
        }
    }
}
