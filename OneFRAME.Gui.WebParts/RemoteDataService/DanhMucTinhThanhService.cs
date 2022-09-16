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

    public class DanhMucTinhThanhService : RemoteDataTypedTemplate
    {
        public static string StaticServiceId
        {
            get
            {
                return "DanhMucTinhThanhService";
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
        //change OwnerUser --> DanhMucTinhThanh
        public override AjaxOut Reading(RenderInfoCls ORenderInfo, int PageIndex, string Keyword)
        {
            AjaxOut RetAjaxOut = new AjaxOut();

            try
            {
                DanhMucTinhThanhFilterCls
                    DanhMucTinhThanhFilter = new DanhMucTinhThanhFilterCls();
                DanhMucTinhThanhFilter.Keyword = Keyword;
                DanhMucTinhThanhFilter.PageIndex = PageIndex;
                DanhMucTinhThanhFilter.Status = 1;

                int  recordTotal = 0; // from PageReading(ORenderInfo, DanhMucTinhThanhFilter, ref recordTotal);
                DanhMucTinhThanhCls[]
                    DanhMucTinhThanhs = OneFRAME.Call.Bussiness.Utility.CallBussinessUtility.CreateBussinessProcess().CreateDanhMucTinhThanhProcess().PageReading(ORenderInfo, DanhMucTinhThanhFilter, ref recordTotal);

                if (DanhMucTinhThanhs.Length != 0 && PageIndex == 0)
                {
                    var ODanhMucTinhThanh = new DanhMucTinhThanhCls();
                    var lstDanhMucTinhThanh = DanhMucTinhThanhs.ToList();
                    lstDanhMucTinhThanh.Insert(0, ODanhMucTinhThanh);
                    DanhMucTinhThanhs = lstDanhMucTinhThanh.ToArray();

                }
                //recordTotal = DanhMucTinhThanhs.Length;
                Record ORecord = new Record();
                ORecord.total_count = (int)recordTotal;
                ORecord.incomplete_results = true;
                ORecord.items = new RecordItemCls[DanhMucTinhThanhs.Length];
                for (int iIndex = 0; iIndex < DanhMucTinhThanhs.Length; iIndex++)
                {
                    ORecord.items[iIndex] = new RecordItemCls();
                    if (!string.IsNullOrEmpty(DanhMucTinhThanhs[iIndex].ID))
                    {
                        ORecord.items[iIndex] = new RecordItemCls();
                        ORecord.items[iIndex].id = DanhMucTinhThanhs[iIndex].ID;
                        ORecord.items[iIndex].text = DanhMucTinhThanhs[iIndex].Ten;

                        ORecord.items[iIndex].Code = DanhMucTinhThanhs[iIndex].Ma;
                        ORecord.items[iIndex].Name = DanhMucTinhThanhs[iIndex].Ten;
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
            var DanhMucTinhThanh = OneFRAME.Call.Bussiness.Utility.CallBussinessUtility.CreateBussinessProcess().CreateDanhMucTinhThanhProcess().CreateModel(ORenderInfo, Id);
            if (DanhMucTinhThanh != null)
                return DanhMucTinhThanh.Ten;
            else
                return "";
        }
    }
}
