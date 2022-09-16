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

    public class OwnerUserService : RemoteDataTypedTemplate
    {
        public static string StaticServiceId
        {
            get
            {
                return "OwnerUserService";
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
                OwnerUserFilterCls
                    OwnerUserFilter = new OwnerUserFilterCls();
                OwnerUserFilter.Keyword = Keyword;
                OwnerUserFilter.PageIndex = PageIndex;
                OwnerUserFilter.Status = 1;

                long recordTotal = 0;
                OwnerUserCls[]
                    OwnerUsers = OneFRAME.Core.Call.Bussiness.Utility.CoreCallBussinessUtility.CreateBussinessProcess().CreateOwnerUserProcess().PageReading(ORenderInfo, OwnerUserFilter, ref recordTotal);

                if (OwnerUsers.Length != 0 && PageIndex == 0)
                {
                    var OOwnerUser = new OwnerUserCls();
                    var lstOwnerUser = OwnerUsers.ToList();
                    lstOwnerUser.Insert(0, OOwnerUser);
                    OwnerUsers = lstOwnerUser.ToArray();

                }
                //recordTotal = OwnerUsers.Length;
                Record ORecord = new Record();
                ORecord.total_count = (int)recordTotal;
                ORecord.incomplete_results = true;
                ORecord.items = new RecordItemCls[OwnerUsers.Length];
                for (int iIndex = 0; iIndex < OwnerUsers.Length; iIndex++)
                {
                    ORecord.items[iIndex] = new RecordItemCls();
                    if (!string.IsNullOrEmpty(OwnerUsers[iIndex].OwnerUserId))
                    {
                        ORecord.items[iIndex] = new RecordItemCls();
                        ORecord.items[iIndex].id = OwnerUsers[iIndex].OwnerUserId;
                        ORecord.items[iIndex].text = OwnerUsers[iIndex].FullName;

                        ORecord.items[iIndex].Code = OwnerUsers[iIndex].LoginName;
                        ORecord.items[iIndex].Name = OwnerUsers[iIndex].FullName;
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
            var OwnerUser = OneFRAME.Core.Call.Bussiness.Utility.CoreCallBussinessUtility.CreateBussinessProcess().CreateOwnerUserProcess().CreateModel(ORenderInfo, Id);
            if (OwnerUser != null)
                return OwnerUser.FullName;
            else
                return "";
        }
    }
}
