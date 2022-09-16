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

    public class DanhMucDonViHanhChinhService : RemoteDataTypedTemplate
    {
        public static string StaticServiceId
        {
            get
            {
                return "DanhMucDonViHanhChinhService";
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
        //change OwnerUser --> DanhMucDonViHanhChinh
        public override AjaxOut Reading(RenderInfoCls ORenderInfo, int PageIndex, string Keyword)
        {
            AjaxOut RetAjaxOut = new AjaxOut();

            try
            {
                DanhMucDonViHanhChinhFilterCls
                    DanhMucDonViHanhChinhFilter = new DanhMucDonViHanhChinhFilterCls();
                DanhMucDonViHanhChinhFilter.Keyword = Keyword;
                DanhMucDonViHanhChinhFilter.PageIndex = PageIndex;
                DanhMucDonViHanhChinhFilter.Status = 1;

                long  recordTotal = 0; // from PageReading(ORenderInfo, DanhMucDonViHanhChinhFilter, ref recordTotal);
                DanhMucDonViHanhChinhCls[]
                    DanhMucDonViHanhChinhs = OneFRAME.Call.Bussiness.Utility.CallBussinessUtility.CreateBussinessProcess().CreateDanhMucDonViHanhChinhProcess().PageReading(ORenderInfo, DanhMucDonViHanhChinhFilter, ref recordTotal);

                if (DanhMucDonViHanhChinhs.Length != 0 && PageIndex == 0)
                {
                    var ODanhMucDonViHanhChinh = new DanhMucDonViHanhChinhCls();
                    var lstDanhMucDonViHanhChinh = DanhMucDonViHanhChinhs.ToList();
                    lstDanhMucDonViHanhChinh.Insert(0, ODanhMucDonViHanhChinh);
                    DanhMucDonViHanhChinhs = lstDanhMucDonViHanhChinh.ToArray();

                }
                //recordTotal = DanhMucDonViHanhChinhs.Length;
                Record ORecord = new Record();
                ORecord.total_count = (int)recordTotal;
                ORecord.incomplete_results = true;
                ORecord.items = new RecordItemCls[DanhMucDonViHanhChinhs.Length];
                for (int iIndex = 0; iIndex < DanhMucDonViHanhChinhs.Length; iIndex++)
                {
                    ORecord.items[iIndex] = new RecordItemCls();
                    if (!string.IsNullOrEmpty(DanhMucDonViHanhChinhs[iIndex].ID))
                    {
                        ORecord.items[iIndex] = new RecordItemCls();
                        ORecord.items[iIndex].id = DanhMucDonViHanhChinhs[iIndex].ID;
                        ORecord.items[iIndex].text = DanhMucDonViHanhChinhs[iIndex].Ten;

                        ORecord.items[iIndex].Code = DanhMucDonViHanhChinhs[iIndex].Ma;
                        ORecord.items[iIndex].Name = DanhMucDonViHanhChinhs[iIndex].Ten;
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
            var DanhMucDonViHanhChinh = OneFRAME.Call.Bussiness.Utility.CallBussinessUtility.CreateBussinessProcess().CreateDanhMucDonViHanhChinhProcess().CreateModel(ORenderInfo, Id);
            if (DanhMucDonViHanhChinh != null)
                return DanhMucDonViHanhChinh.Ten;
            else
                return "";
        }
    }
}
