﻿using OneFRAME.Call.Bussiness.Utility;
using OneFRAME.Core.Model;using OneFRAME.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneFRAME.Gui
{
    public class DashboardModule3: DashboardModuleTemplate
    {
        public override string ServiceId
        {
            get
            {
                return "DashboardModule3";
            }
        }

        public override string ServiceName
        {
            get
            {
                return "Loại điều trị";
            }
        }
        public override bool CheckPermissionAllowShow(RenderInfoCls ORenderInfo, DashboardParamCls ODashboardParam)
        {
            return base.CheckPermissionAllowShow(ORenderInfo, ODashboardParam);
        }

        public override void RegisterAjaxPro(RenderInfoCls ORenderInfo)
        {
            if (ORenderInfo.WebPage != null)
            {
                AjaxPro.Utility.RegisterTypeForAjax(typeof(DashboardModule3), ORenderInfo.WebPage);
            }
        }

        public override AjaxOut Draw(RenderInfoCls ORenderInfo, DashboardParamCls ODashboardParam)
        {
            AjaxOut RetAjaxOut = new AjaxOut();
            try
            {
                string Html = "<div class=\"ibox-content\" style=\"border-style: none;\">\r\n" +
                            "    <table class=\"table table-stripped small\">\r\n" +
                            "        <tbody>\r\n";
                //foreach (var tb in DanhMucKhoaPhongParser.sDieuTri)
                //{
                //    long total = 0;
                //    long count = CallBussinessUtility.CreateBussinessProcess().CreateXetNghiemProcess().ThongKeSoLuongTheoLoaiDieuTri(ORenderInfo, tb.Key, ref total);
                //    Html += "        <tr>\r\n" +
                //            "            <td>\r\n" +
                //            "                <i class=\"fa fa-circle text-navy\">&nbsp;&nbsp;&nbsp;" + tb.Value + "</i>\r\n" +
                //            "            </td>\r\n" +
                //            "            <td><lable>" + count + " / " + total + "</lable></td>\r\n" +
                //            "        </tr>\r\n";
                //}
                Html += "        </tbody>\r\n" +
                        "    </table>\r\n" +
                        "</div>";

                RetAjaxOut.HtmlContent = Html;
            }
            catch (Exception ex)
            {
                RetAjaxOut.Error = true;
                RetAjaxOut.InfoMessage = ex.Message.ToString();
                RetAjaxOut.HtmlContent= ex.Message.ToString();
            }

            return RetAjaxOut;
        }
    }
}
