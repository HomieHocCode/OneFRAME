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

    public class DanhMucICDChuongService : RemoteDataTypedTemplate
    {
        public static string StaticServiceId
        {
            get
            {
                return "DanhMucICDChuongService";
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
                return "Danh mục người dùng";
            }
        }
        public override AjaxOut Reading(RenderInfoCls ORenderInfo, int PageIndex, string Keyword)
        {
            AjaxOut RetAjaxOut = new AjaxOut();

            try
            {
                DanhMucICDChuongFilterCls
                    DanhMucICDChuongFilter = new DanhMucICDChuongFilterCls();
                DanhMucICDChuongFilter.Keyword = Keyword;
                DanhMucICDChuongFilter.PageIndex = PageIndex;
                DanhMucICDChuongFilter.Status = 1;

                int recordTotal = 0;
                DanhMucICDChuongCls[]
                    DanhMucICDChuongs = OneFRAME.Call.Bussiness.Utility.CallBussinessUtility.CreateBussinessProcess().CreateDanhMucICDChuongProcess().PageReading(ORenderInfo, DanhMucICDChuongFilter, ref recordTotal);

                if (DanhMucICDChuongs.Length != 0 && PageIndex == 0)
                {
                    var ODanhMucICDChuong = new DanhMucICDChuongCls();
                    var lstDanhMucICDChuong = DanhMucICDChuongs.ToList();
                    lstDanhMucICDChuong.Insert(0, ODanhMucICDChuong);
                    DanhMucICDChuongs = lstDanhMucICDChuong.ToArray();

                }
                //recordTotal = DanhMucICDChuongs.Length;
                Record ORecord = new Record();
                ORecord.total_count = (int)recordTotal;
                ORecord.incomplete_results = true;
                ORecord.items = new RecordItemCls[DanhMucICDChuongs.Length];
                for (int iIndex = 0; iIndex < DanhMucICDChuongs.Length; iIndex++)
                {
                    ORecord.items[iIndex] = new RecordItemCls();
                    if (!string.IsNullOrEmpty(DanhMucICDChuongs[iIndex].ID))
                    {
                        ORecord.items[iIndex] = new RecordItemCls();
                        ORecord.items[iIndex].id = DanhMucICDChuongs[iIndex].ID;
                        ORecord.items[iIndex].text = DanhMucICDChuongs[iIndex].Ten;

                        ORecord.items[iIndex].Code = DanhMucICDChuongs[iIndex].Ma;
                        ORecord.items[iIndex].Name = DanhMucICDChuongs[iIndex].Ten;
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
            var DanhMucICDChuong = OneFRAME.Call.Bussiness.Utility.CallBussinessUtility.CreateBussinessProcess().CreateDanhMucICDChuongProcess().CreateModel(ORenderInfo, Id);
            if (DanhMucICDChuong != null)
                return DanhMucICDChuong.Ten;
            else
                return "";
        }
    }
}
