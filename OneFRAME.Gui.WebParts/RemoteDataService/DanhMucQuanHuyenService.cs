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

    public class DanhMucQuanHuyenService : RemoteDataTypedTemplate
    {
        public static string StaticServiceId
        {
            get
            {
                return "DanhMucQuanHuyenService";
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
        //change OwnerUser --> DanhMucQuanHuyen
        public override AjaxOut Reading(RenderInfoCls ORenderInfo, int PageIndex, string Keyword)
        {
            AjaxOut RetAjaxOut = new AjaxOut();

            try
            {
                DanhMucQuanHuyenFilterCls
                    DanhMucQuanHuyenFilter = new DanhMucQuanHuyenFilterCls();
                DanhMucQuanHuyenFilter.Keyword = Keyword;
                DanhMucQuanHuyenFilter.PageIndex = PageIndex;
                DanhMucQuanHuyenFilter.Status = 1;

                int  recordTotal = 0; // from PageReading(ORenderInfo, DanhMucQuanHuyenFilter, ref recordTotal);
                DanhMucQuanHuyenCls[]
                    DanhMucQuanHuyens = OneFRAME.Call.Bussiness.Utility.CallBussinessUtility.CreateBussinessProcess().CreateDanhMucQuanHuyenProcess().PageReading(ORenderInfo, DanhMucQuanHuyenFilter, ref recordTotal);

                if (DanhMucQuanHuyens.Length != 0 && PageIndex == 0)
                {
                    var ODanhMucQuanHuyen = new DanhMucQuanHuyenCls();
                    var lstDanhMucQuanHuyen = DanhMucQuanHuyens.ToList();
                    lstDanhMucQuanHuyen.Insert(0, ODanhMucQuanHuyen);
                    DanhMucQuanHuyens = lstDanhMucQuanHuyen.ToArray();

                }
                //recordTotal = DanhMucQuanHuyens.Length;
                Record ORecord = new Record();
                ORecord.total_count = (int)recordTotal;
                ORecord.incomplete_results = true;
                ORecord.items = new RecordItemCls[DanhMucQuanHuyens.Length];
                for (int iIndex = 0; iIndex < DanhMucQuanHuyens.Length; iIndex++)
                {
                    ORecord.items[iIndex] = new RecordItemCls();
                    if (!string.IsNullOrEmpty(DanhMucQuanHuyens[iIndex].ID))
                    {
                        ORecord.items[iIndex] = new RecordItemCls();
                        ORecord.items[iIndex].id = DanhMucQuanHuyens[iIndex].ID;
                        ORecord.items[iIndex].text = DanhMucQuanHuyens[iIndex].Ten;

                        ORecord.items[iIndex].Code = DanhMucQuanHuyens[iIndex].Ma;
                        ORecord.items[iIndex].Name = DanhMucQuanHuyens[iIndex].Ten;
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
            var DanhMucQuanHuyen = OneFRAME.Call.Bussiness.Utility.CallBussinessUtility.CreateBussinessProcess().CreateDanhMucQuanHuyenProcess().CreateModel(ORenderInfo, Id);
            if (DanhMucQuanHuyen != null)
                return DanhMucQuanHuyen.Ten;
            else
                return "";
        }
    }
}
