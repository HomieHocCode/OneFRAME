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

    public class DanhMucXaPhuongService : RemoteDataTypedTemplate
    {
        public static string StaticServiceId
        {
            get
            {
                return "DanhMucXaPhuongService";
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
        //change OwnerUser --> DanhMucXaPhuong
        public override AjaxOut Reading(RenderInfoCls ORenderInfo, int PageIndex, string Keyword)
        {
            AjaxOut RetAjaxOut = new AjaxOut();

            try
            {
                DanhMucXaPhuongFilterCls
                    DanhMucXaPhuongFilter = new DanhMucXaPhuongFilterCls();
                DanhMucXaPhuongFilter.Keyword = Keyword;
                DanhMucXaPhuongFilter.PageIndex = PageIndex;
                DanhMucXaPhuongFilter.Status = 1;

                long recordTotal = 0; // from PageReading(ORenderInfo, DanhMucXaPhuongFilter, ref recordTotal);
                DanhMucXaPhuongCls[]
                    DanhMucXaPhuongs = OneFRAME.Call.Bussiness.Utility.CallBussinessUtility.CreateBussinessProcess().CreateDanhMucXaPhuongProcess().PageReading(ORenderInfo, DanhMucXaPhuongFilter, ref recordTotal);

                if (DanhMucXaPhuongs.Length != 0 && PageIndex == 0)
                {
                    var ODanhMucXaPhuong = new DanhMucXaPhuongCls();
                    var lstDanhMucXaPhuong = DanhMucXaPhuongs.ToList();
                    lstDanhMucXaPhuong.Insert(0, ODanhMucXaPhuong);
                    DanhMucXaPhuongs = lstDanhMucXaPhuong.ToArray();

                }
                //recordTotal = DanhMucXaPhuongs.Length;
                Record ORecord = new Record();
                ORecord.total_count = (int)recordTotal;
                ORecord.incomplete_results = true;
                ORecord.items = new RecordItemCls[DanhMucXaPhuongs.Length];
                for (int iIndex = 0; iIndex < DanhMucXaPhuongs.Length; iIndex++)
                {
                    ORecord.items[iIndex] = new RecordItemCls();
                    if (!string.IsNullOrEmpty(DanhMucXaPhuongs[iIndex].ID))
                    {
                        ORecord.items[iIndex] = new RecordItemCls();
                        ORecord.items[iIndex].id = DanhMucXaPhuongs[iIndex].ID;
                        ORecord.items[iIndex].text = DanhMucXaPhuongs[iIndex].Ten;

                        ORecord.items[iIndex].Code = DanhMucXaPhuongs[iIndex].Ma;
                        ORecord.items[iIndex].Name = DanhMucXaPhuongs[iIndex].Ten;
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
            var DanhMucXaPhuong = OneFRAME.Call.Bussiness.Utility.CallBussinessUtility.CreateBussinessProcess().CreateDanhMucXaPhuongProcess().CreateModel(ORenderInfo, Id);
            if (DanhMucXaPhuong != null)
                return DanhMucXaPhuong.Ten;
            else
                return "";
        }
    }
}
