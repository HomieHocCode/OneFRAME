﻿using OneFRAME.Bussiness.Utility;
using OneFRAME.Call.Bussiness.Utility;
using OneFRAME.Core.Model;
using OneFRAME.Model;
using OneFRAME.UploadUtility;
using OneFRAME.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneFRAME.WebParts
{
    public class DanhMucXaPhuong : WebPartTemplate
    {
        public override string WebPartId
        {
            get
            {
                return "DanhMucXaPhuong";
            }
        }

        public override string WebPartTitle
        {
            get
            {
                return "Danh Mục xã phường ";
            }
        }

        public override string Description
        {
            get
            {
                return "Danh mục xã phường ";
            }
        }

        public override void RegAjaxPro(SiteParam OSiteParam, System.Web.UI.Page Page)
        {
            AjaxPro.Utility.RegisterTypeForAjax(typeof(DanhMucXaPhuong), Page);
        }

        public override AjaxOut CheckPermission(RenderInfoCls ORenderInfo)
        {
            SiteParam OSiteParam = WebEnvironments.CreateSiteParam(ORenderInfo);
            string UserId = WebSessionUtility.GetCurrentLoginUser(OSiteParam).OwnerUserId;
            bool HasPermission = true;
            AjaxOut RetAjaxOut = new AjaxOut();
            RetAjaxOut.RetBoolean = HasPermission;
            return RetAjaxOut;
        }

        public override AjaxOut Draw(SiteParam OSiteParam, RenderInfoCls ORenderInfo)
        {
            AjaxOut RetAjaxOut = new AjaxOut();
            AjaxOut RetAjaxOutCheckPermission = CheckPermission(ORenderInfo);
            WebSession.CheckSessionTimeOut(ORenderInfo);

            if (RetAjaxOutCheckPermission.RetBoolean == false)
            {
                RetAjaxOut.HtmlContent = WebScreen.GetPanelInfo(OSiteParam, "Không có quyền truy cập tính năng này", false);
                return RetAjaxOut;
            }
            try
            {
                string SessionId = System.Guid.NewGuid().ToString();
                string UserId = WebSessionUtility.GetCurrentLoginUser(OSiteParam).OwnerUserId;
                string LoginName = WebSessionUtility.GetCurrentLoginUser(OSiteParam).LoginName;
                string filtemplate = WebConfig.GetWebHttpRoot() + "temp/ImportDanhMucXaPhuong.xlsx";
                RetAjaxOut.HtmlContent =
                #region HtmlContext
 WebEnvironments.ProcessHtml("<div id=\"divListForm\">\r\n" +
                    " <div class=\"ibox float-e-margins\"> \r\n" +
                    "     <div class=\"ibox-title\"> \r\n" +
                    "         <h5>" + WebLanguage.GetLanguage(OSiteParam, "DANH MỤC XÃ PHƯỜNG  ") + "</h5> \r\n" +
                    "     </div> \r\n" +
                    "     <div class=\"ibox-content\"> \r\n" +
                    "       <button type=\"button\" style=\"margin-bottom:14px;padding:0px; width:80px;height:32px\" class=\"btn btn-sm btn-primary\" onclick=\"location.href='" + filtemplate + "'\"><i class=\"fa fa-download\"></i> " + WebLanguage.GetLanguage(OSiteParam, "File Import") + "</button>\r\n" +
                    "       <button type=\"button\" style=\"margin-bottom:14px;padding:0px; width:80px;height:32px\" class=\"btn btn-sm btn-primary\" onclick=\"javascript:Import();\"> " + WebLanguage.GetLanguage(OSiteParam, "Import") + "</button>\r\n" +
                    "       <button type=\"button\" style=\"margin-bottom:14px;padding:0px; width:80px;height:32px\" class=\"btn btn-sm btn-primary pull-right\" onclick=\"javascript:ServerSideDrawAddForm();\"> " + WebLanguage.GetLanguage(OSiteParam, "Thêm") + "</button>\r\n" +
                    "         <div class=\"fileinput fileinput-new\" data-provides=\"fileinput\">\r\n" +
                    "            <span style=\"margin-bottom:14px;padding:5px; width:80px;height:32px\"  class=\"btn btn-default btn-file\" ><span class=\"fileinput-new\">Chọn File</span>\r\n" +
                    "            <span class=\"fileinput-exists\">Chọn lại</span><input type=\"file\" name=\"...\" id=\"fileUpload\"/></span>\r\n" +
                    "            <span class=\"fileinput-filename\"></span>\r\n" +
                    "            <a href=\"#\" class=\"close fileinput-exists\" data-dismiss=\"fileinput\" style=\"float: none\" id= \"aexit\" >×</a>\r\n" +
                    "         </div> \r\n" +
                    //"       <button type=\"button\" style=\"margin-bottom:14px;padding:0px; width:80px;height:32px\" class=\"btn btn-sm btn-primary\" onclick=\"javascript:CallExPortForm();\"> " + WebLanguage.GetLanguage(OSiteParam, "Export") + "</button>\r\n" +
                    //"       <button type=\"button\"  class=\"btn btn-sm btn-primary\" onclick=\"javascript:ServerSideDrawAddForm();\"> " + WebLanguage.GetLanguage(OSiteParam, "Thêm") + "</button>\r\n" +
                    "         <div id=\"divProcessing\" class=\"processing\"></div>\r\n" +
                    "               <div id=\"divDanhMucXaPhuongContent\">" + ServerSideDrawSearchResult(ORenderInfo, "", 0).HtmlContent + "</div>\r\n" +
                    "         </div> \r\n" +
                    "     </div> \r\n" +
                    " </div> \r\n" +
                    "</div>\r\n" +

                    "<div id=\"divActionForm\" style=\"display:none\"></div>\r\n" +

                    "<div id=\"divFormModal\" class=\"modal immodal\" style=\"overflow: hidden\"  role=\"dialog\" aria-labelledby=\"largeModal\" aria-hidden=\"true\" data-backdrop=\"static\">\r\n" +
                    "    <div class=\"modal-dialog\">\r\n" +
                    "       <div class=\"modal-content\">\r\n" +
                    "           <div class=\"panel-heading\">\r\n" +
                    "               <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-hidden=\"true\">&times;</button>\r\n" +
                    "               <h2 class=\"modal-title\" id=\"ModalTitle\"></h2>\r\n" +
                    "           </div> \r\n" +
                    "           <div class=\"modal-body\" id=\"divModalContent\"></div> \r\n" +
                    "        </div> \r\n" +
                    "    </div> \r\n" +
                    "</div> \r\n"
                    ) +
                #endregion

                #region MyRegion
 WebEnvironments.ProcessJavascript(
                    "<script language=\"javascript\">\r\n" +
                    "   var _currentPageIndex = 0;\r\n" +

                    "    $(document).ready(function() \r\n" +
                    "    {\r\n" +

                    "    });\r\n" +

                    "   function timkiem(event){\r\n" +
                    "    if(event.keyCode==13)\r\n" +
                    "       RealCallReading();\r\n" +
                    "   }\r\n" +

                    "   function checkCurrency(e){\r\n" +
                    "        if(event.which != 8 && isNaN(String.fromCharCode(e.which))){\r\n" +
                    "           event.preventDefault(); \r\n" +
                    "        }\r\n" +
                    "   }\r\n" +

                    // JS SELECT 2
                    "   function Select2()\r\n" +
                    "   {\r\n" +
                    "       CallInitSelect2('drpQuanHuyen', '" + WebEnvironments.GetRemoteProcessDataUrl(DanhMucQuanHuyenService.StaticServiceId) + "', 'Quận Huyện')\r\n" +
                    "   }\r\n" +

                    " function CallInitSelect2(Id, svUrl, place)\r\n" +
                    " {\r\n" +
                    "  $(\"#\"+Id).select2({ \r\n" +
                    //"        placeholder: 'Mã CSKCB',\r\n" +
                    "        allowClear: true,\r\n" +
                    "        ajax: { \r\n" +
                    "            id: function (e) { return e.id + \"|\" + e.text },  \r\n" +
                    "            url: svUrl,\r\n" +
                    "            dataType: 'json', \r\n" +
                    "            delay: 250, \r\n" +
                    "            type: 'POST',  \r\n" +
                    "            data: function (params) { \r\n" +
                    "                return { \r\n" +
                    "                    q: params.term,  \r\n" +
                    "                    page: params.page \r\n" +
                    "                }; \r\n" +
                    "            }, \r\n" +
                    "            processResults: function (data, params) { \r\n" +
                    "                params.page = params.page || 0; \r\n" +
                    "                return { \r\n" +
                    "                    results: data.items, \r\n" +
                    "                    pagination: { \r\n" +
                    "                        more: (params.page * 10) < data.total_count \r\n" +

                    "                    } \r\n" +
                    "                }; \r\n" +
                    "            }, \r\n" +
                    "            cache: true \r\n" +
                    "        }, \r\n" +
                    "        escapeMarkup: function (markup) { return markup; },  \r\n" +
                    "        minimumInputLength: 0, \r\n" +
                    "        templateResult: formatRepo,  \r\n" +
                    "        templateSelection: formatRepoSelection  \r\n" +
                    "    }); \r\n" +
                    " }\r\n" +
                    " CallInitSelect2();\r\n" +

                    "  function formatRepo(repo) { \r\n" +
                    "     var markup = ''; \r\n" +
                    "     if (repo.loading) return repo.text; \r\n" +
                    "     else if (repo.id == null) markup = '<table style=\"width: 100%;border-bottom: 1px solid black;\"><tr><td style=\"width:20%;padding:4px\"><h3>'+ repo.Code+'</h3></td> <td><h3>'+repo.Name+'</h3></td></tr></table>'; \r\n" +
"     else markup = '<table style=\"width: 100%;\"><tr><td style=\"color:maroon;font-weight:bold; width:20%;padding:4px\">'+ repo.Code+'</td> <td >'+repo.Name+'</td></tr></table>'; \r\n" +
                    "     return markup; \r\n" +
                    "  } \r\n" +

                    "  function formatRepoSelection(repo) { \r\n" +
                    "     if(repo.Code == undefined)\r\n" +
                    "        return repo.text; \r\n" +
                    "     else\r\n" +
                    "        return repo.text + '(' + repo.Code + ')'; \r\n" +
                    "   } \r\n" +
                    // JS SELECT 2


                    "   function NextPage(PageIndex)\r\n" +
                    "   {\r\n" +
                    "       _currentPageIndex = PageIndex;\r\n" +
                    "       RealCallReading();\r\n" +
                    "   }\r\n" +

                    "   function FilterSearch()\r\n" +
                    "   {\r\n" +
                    "       NextPage(0);\r\n" +
                    "   }\r\n" +

                    "   function RealCallReading()\r\n" +
                    "   {\r\n" +
                    "       RenderInfo=CreateRenderInfo();\r\n" +
                    "       Keyword = document.getElementById('txtKeyword').value;\r\n" +
                    //"       HieuLuc = document.getElementById('cbFilterHieuLuc').value;\r\n" +
                    "       AjaxOut = OneFRAME.WebParts.DanhMucXaPhuong.ServerSideDrawSearchResult(RenderInfo, Keyword, _currentPageIndex).value;\r\n" +
                    "       document.getElementById('divProcessing').innerHTML='';\r\n" +
                    "       document.getElementById('divDanhMucXaPhuongContent').innerHTML=AjaxOut.HtmlContent;\r\n" +
                    //"       $('.dataTables-autosort').footable();\r\n" +
                    "   }\r\n" +

                    "   function CloseModal()\r\n" +
                    "   {\r\n" +
                    "       $('#divFormModal').modal('hide');\r\n" +
                    "   }\r\n" +

                    "   function CallBack()\r\n" +
                    "   {\r\n" +
                    "       $('.confirm').focus(); " +
                    "   }\r\n" +
                    //---------------------------------------------------------------------------------------------------------------------------------------------
                    "   function ServerSideDrawAddForm()\r\n" +
                    "   {\r\n" +
                    "       RenderInfo=CreateRenderInfo();\r\n" +
                    "       AjaxOut = OneFRAME.WebParts.DanhMucXaPhuong.ServerSideDrawAddForm(RenderInfo).value;\r\n" +
                    "       if(AjaxOut.Error)\r\n" +
                    "       {\r\n" +
                    "           callGallAlert(AjaxOut.InfoMessage);\r\n" +
                    "           return;\r\n" +
                    "       }\r\n" +
                    "       document.getElementById('divModalContent').innerHTML=AjaxOut.HtmlContent;\r\n" +
                    "       document.getElementById('ModalTitle').innerHTML= '<span class=\"fa fa-pencil-square-o\">" + WebLanguage.GetLanguage(OSiteParam, "  Thêm mới") + "  </span>';\r\n" +
                    "       $('#divFormModal').modal('show');\r\n" +
                    "       document.getElementById('txtMa').focus();\r\n" +
                    "       Select2();" +
                    "   }\r\n" +

                    "   function ServerSideDrawUpdateForm(Id)\r\n" +
                    "   {\r\n" +
                    "       RenderInfo=CreateRenderInfo();\r\n" +
                    "       AjaxOut = OneFRAME.WebParts.DanhMucXaPhuong.ServerSideDrawUpdateForm(RenderInfo, Id).value;\r\n" +
                    "       if(AjaxOut.Error)\r\n" +
                    "       {\r\n" +
                    "           callGallAlert(AjaxOut.InfoMessage);\r\n" +
                    "           return;\r\n" +
                    "       }\r\n" +
                    "       document.getElementById('divModalContent').innerHTML=AjaxOut.HtmlContent;\r\n" +
                    "       document.getElementById('ModalTitle').innerHTML= '<span class=\"fa fa-pencil-square-o\">" + WebLanguage.GetLanguage(OSiteParam, "  Sửa thông tin") + "  </span>';\r\n" +
                    "       $('#divFormModal').modal('show');\r\n" +
                    "       document.getElementById('txtMa').focus();\r\n" +
                    "       Select2();" +
                    "   }\r\n" +

                    "   function ServerSideAdd()\r\n" +
                    "   {\r\n" +
                    "       RenderInfo=CreateRenderInfo();\r\n" +
                    "       var obj = new Object(); \r\n" +  //------------- ad obj 
                    "       obj.Ma = document.getElementById('txtMa').value.trim();\r\n" +
                    "       obj.Ten = document.getElementById('txtTen').value.trim();\r\n" +
                    "       obj.MaBCBYT  = document.getElementById('txtMaBCBYT').value.trim();\r\n" +
                    "       obj.QuanHuyenID = document.getElementById('txtQuanHuyenID').value.trim();\r\n" +
                    //"       obj.BanBe = $('#rdBanBe input:radio:checked').val();\r\n" +
                    "       obj.STT = document.getElementById('nbSTT').value.trim() || null; \r\n" +
                    "       obj.HieuLuc = $('#rdHieuLuc input:radio:checked').val();\r\n" +
                    "       obj.MoTa = document.getElementById('txtMoTa').value.trim();\r\n" +

                    "       AjaxOut = OneFRAME.WebParts.DanhMucXaPhuong.ServerSideAdd(RenderInfo,obj).value;\r\n" +
                    "       if(AjaxOut.Error)\r\n" +
                    "       {\r\n" +
                    "           callGallAlert(AjaxOut.InfoMessage);\r\n" +
                    "           return;\r\n" +
                    "       }\r\n" +
                    "       callSweetAlert(\"" + WebLanguage.GetLanguage(OSiteParam, "Thêm mới thành công!") + "\");\r\n" +
                    "       NextPage(_currentPageIndex);\r\n" +
                    "       CloseModal();\r\n" +
                    "       CallBack();\r\n" +

                    "   }\r\n" +

                     "   function ServerSideUpdate(Id)\r\n" +
                    "   {\r\n" +
                    "       RenderInfo=CreateRenderInfo();\r\n" +
                    "       var obj = new Object(); \r\n" + //-------------------------------

                    "       obj.Ma = document.getElementById('txtMa').value.trim();\r\n" +
                    "       obj.Ten = document.getElementById('txtTen').value.trim();\r\n" +
                    "       obj.MaBCBYT = document.getElementById('txtMaBCBYT').value.trim();\r\n" +
                    "       obj.QuanHuyenID = document.getElementById('txtQuanHuyenID').value.trim();\r\n" +
                    "       obj.STT = document.getElementById('nbSTT').value.trim() || null; \r\n" +
                    "       obj.HieuLuc = $('#rdHieuLuc input:radio:checked').val();\r\n" +
                    "       obj.MoTa = document.getElementById('txtMoTa').value.trim();\r\n" +

                    //"       obj.BanBe = $('#rdBanBe input:radio:checked').val();\r\n" +
                    //"       obj.NgayHieuLuc = document.getElementById('txtNgayHieuLuc').value.trim();\r\n" +
                    //"       obj.NgayHetHieuLuc = document.getElementById('txtNgayHetHieuLuc').value.trim();\r\n" +
                    // "       obj.GhiChu = document.getElementById('txtGhiChu').value.trim();\r\n" +


                    "       AjaxOut = OneFRAME.WebParts.DanhMucXaPhuong.ServerSideUpdate(RenderInfo, obj,Id).value;\r\n" +
                    "       if(AjaxOut.Error)\r\n" +
                    "       {\r\n" +
                    "           callGallAlert(AjaxOut.InfoMessage);\r\n" +
                    "           return;\r\n" +
                    "       }\r\n" +
                    "       callSweetAlert(\"" + WebLanguage.GetLanguage(OSiteParam, "Sửa thông tin thành công!") + "\");\r\n" +
                    "       NextPage(_currentPageIndex);\r\n" +
                    "       CloseModal();\r\n" +
                    "       CallBack();\r\n" +
                    "   }\r\n" +

                    "   function ServerSideDelete(DanhMucXaPhuongId)\r\n" +
                    "   {\r\n" +
                    "       RenderInfo=CreateRenderInfo();\r\n" +

                    "       swal({ \r\n" +
                    "               title: \"Thông báo\", \r\n" +
                    "               text: \"Đang thực hiện xóa danh mục\", \r\n" +
                    "               type: \"warning\", \r\n" +
                    "               showCancelButton: true, \r\n" +
                    "               confirmButtonColor: \"#DD6B55\", \r\n" +
                    "               confirmButtonText: \"Thực hiện xóa\", \r\n" +
                    "               cancelButtonText: \"Hủy bỏ\", \r\n" +
                    "               closeOnConfirm: false \r\n" +
                    "           }, function () { \r\n" +
                    "           AjaxOut = OneFRAME.WebParts.DanhMucXaPhuong.ServerSideDelete(RenderInfo, DanhMucXaPhuongId).value;\r\n" +
                    "           if(AjaxOut.Error)\r\n" +
                    "           {\r\n" +
                    "               callGallAlert(AjaxOut.InfoMessage);\r\n" +
                    "               return;\r\n" +
                    "           }\r\n" +
                    "       callSweetAlert(\"" + WebLanguage.GetLanguage(OSiteParam, "") + "Xóa thông tin thành công!\");\r\n" +
                    "             NextPage(_currentPageIndex);\r\n" +
                    "       }); \r\n" +
                    "   }\r\n" +

                #region Import
                    "   function Import()\r\n" +
                    "   {\r\n" +
                    "        RenderInfo=CreateRenderInfo();\r\n" +
                    "        fileUploadValue=document.getElementById('fileUpload').value;\r\n" +
                    "        if(fileUploadValue==''){\r\n" +
                    "            callSweetAlert('Chưa xác định tài liệu gắn kèm!');\r\n" +
                    "            return;\r\n" +
                    "        }\r\n" +
                    "       document.getElementById('divProcessing').innerHTML='Đang Import Danh mục';\r\n" +
                    "       swal({ \r\n" +
                    "               title: \"Thông báo\", \r\n" +
                    "               text: \"Đang thực hiện Import danh mục\", \r\n" +
                    "               type: \"warning\", \r\n" +
                    "               showCancelButton: true, \r\n" +
                    "               confirmButtonColor: \"#DD6B55\", \r\n" +
                    "               confirmButtonText: \"Thực hiện\", \r\n" +
                    "               cancelButtonText: \"Hủy bỏ\", \r\n" +
                    "               closeOnConfirm: false \r\n" +
                    "           }, function () { \r\n" +
                    "                  var fd = new FormData();\r\n" +
                    "               fd.append(\"fileUploadAvatar\", document.getElementById('fileUpload').files[0]);\r\n" +
                    "               var xhr = new XMLHttpRequest();\r\n" +
                    "               xhr.addEventListener(\"load\",uploaded, false);\r\n" +
                    "               xhr.open(\"POST\", \"" + WebConfig.GetImportHandler(OSiteParam, SessionId, UserId, LoginName, (int)ProcessImportHandlerUtility.eFileType.DM_XAPHUONG ) + "\");\r\n" +
                    "               xhr.send(fd);\r\n" +
                    "           }\r\n" +
                    "       ); \r\n" +
                    "   }\r\n" +
                    " function uploaded(evt) {\r\n" +
                    "       var parser = new DOMParser();\r\n" +
                    "       var xmlDoc = parser.parseFromString(evt.currentTarget.responseText,\"text/xml\"); \r\n" +
                    "       var mes = xmlDoc.getElementsByTagName(\"InfoMessage\")[0].childNodes[0].nodeValue;\r\n" +
                    "       callSweetAlert(mes);\r\n" +
                    "         Reload();\r\n" +

                    " }\r\n" +

                    "   function Reload()\r\n" +
                    "   {\r\n" +
                    "        var a = document.getElementById('aexit');\r\n" +
                    "        a.click();\r\n" +
                    "           NextPage(_currentPageIndex);\r\n" +
                    "   }\r\n" +
                #endregion

                    "</script>\r\n");
                #endregion
            }
            catch (Exception ex)
            {
                RetAjaxOut.Error = true;
                RetAjaxOut.HtmlContent = ex.Message.ToString();
                RetAjaxOut.InfoMessage = ex.Message.ToString();
            }
            return RetAjaxOut;
        }

        [AjaxPro.AjaxMethod(AjaxPro.HttpSessionStateRequirement.ReadWrite)]
        public static AjaxOut ServerSideDrawSearchResult(RenderInfoCls ORenderInfo, string Keyword, int CurrentPageIndex)
        {
            AjaxOut RetAjaxOut = new AjaxOut();
            try
            {
                SiteParam OSiteParam = WebEnvironments.CreateSiteParam(ORenderInfo);
                WebSession.CheckSessionTimeOut(ORenderInfo);

                DanhMucXaPhuongCls[] DanhMucXaPhuongs = CallBussinessUtility.CreateBussinessProcess().CreateDanhMucXaPhuongProcess().ReadingWithPaging(ORenderInfo, new DanhMucXaPhuongFilterCls()
                {
                    Keyword = Keyword,
                    //HieuLuc = !string.IsNullOrEmpty(HieuLuc) && HieuLuc != null ? int.Parse(HieuLuc) : (int)ONEMES3.DM.Model.Common.eSearch.SearchAll
                },
                    CurrentPageIndex, 18);
                var countDanhMucXaPhuong = CallBussinessUtility.CreateBussinessProcess().CreateDanhMucXaPhuongProcess().Count(ORenderInfo, new DanhMucXaPhuongFilterCls()
                {
                    Keyword = Keyword,
                    //HieuLuc = !string.IsNullOrEmpty(HieuLuc) && HieuLuc != null ? int.Parse(HieuLuc) : (int)ONEMES3.DM.Model.Common.eSearch.SearchAll
                }
                );

                ReturnPaging RetPaging = WebPaging.GetPaging((int)countDanhMucXaPhuong, CurrentPageIndex, 18, 10, "NextPage");

                var nextpage = string.Empty;
                if (countDanhMucXaPhuong > 18) nextpage = RetPaging.PagingText;

                string Html = "";
                if (DanhMucXaPhuongs.Length == 0)
                {
                    Html += "   <div class=\"search-result-info\"></div>\r\n" +
                        "         <div class=\"table-responsive\"> \r\n" +
                        "             <table class=\"table table-striped table-bordered table-hover\"> \r\n" +
                        "                 <thead> \r\n" +
                        "                 <tr> \r\n" +
                        //"                     <td></td> \r\n" +
                        "                     <th> " + WebLanguage.GetLanguage(OSiteParam, "Mã") + "</th> \r\n" +
                        "                     <th> " + WebLanguage.GetLanguage(OSiteParam, "Tên") + "</th> \r\n" +
                        "                     <th> " + WebLanguage.GetLanguage(OSiteParam, "Mã BYT") + "</th> \r\n" +
                        "                     <th> " + WebLanguage.GetLanguage(OSiteParam, "Mô Tả") + "</th> \r\n" +
                        "                     <th> " + WebLanguage.GetLanguage(OSiteParam, "Hiệu Lực") + "</th> \r\n" +
                        "                     <th> " + WebLanguage.GetLanguage(OSiteParam, "Ngày Tạo") + "</th> \r\n" +
                        "                     <th> " + WebLanguage.GetLanguage(OSiteParam, "Ngày Hiệu Lực") + "</th> \r\n" +
                        "                     <th> " + WebLanguage.GetLanguage(OSiteParam, "Ngày Hết Hiệu Lực") + "</th> \r\n" +
                        "                     <th> " + WebLanguage.GetLanguage(OSiteParam, "STT") + "</th> \r\n" +
                        //"                     <th> " + WebLanguage.GetLanguage(OSiteParam, "Bạn Bè") + "</th> \r\n" +
                        "                     <th> " + WebLanguage.GetLanguage(OSiteParam, "Ghi Chú ") + "</th> \r\n" +
                        "                     <th class = \"unsort\" style=\"min-width:50px\" >" + WebLanguage.GetLanguage(OSiteParam, "Tác vụ") + "</th> \r\n" +
                        //"                     <th><a title=\"Thêm mới bản ghi\" href=\"javascript:ServerSideDrawAddForm();\">Thêm</a></th> \r\n" +
                        "                 </tr> \r\n" +
                        "                 </thead> \r\n" +
                        "             </table> \r\n" +
                        "       </div>\r\n";
                }
                else
                {
                    Html += "   <div class=\"search-result-info\"></div>\r\n" +
                        "         <div class=\"table-responsive\"> \r\n" +
                        "             <table class=\"table table-striped table-bordered table-hover\"> \r\n" +
                        "                 <thead> \r\n" +
                        "                 <tr> \r\n" +
                        "                     <th> " + WebLanguage.GetLanguage(OSiteParam, "Mã") + "</th> \r\n" +
                        "                     <th> " + WebLanguage.GetLanguage(OSiteParam, "Tên") + "</th> \r\n" +
                        "                     <th> " + WebLanguage.GetLanguage(OSiteParam, "Mã BYT ") + "</th> \r\n" +
                        "                     <th> " + WebLanguage.GetLanguage(OSiteParam, "Mô Tả") + "</th> \r\n" +
                        "                     <th style=\"width:80px\"> " + WebLanguage.GetLanguage(OSiteParam, "Hiệu lực") + "</th> \r\n" +
                        "                     <th> " + WebLanguage.GetLanguage(OSiteParam, "Ngày Tạo") + "</th> \r\n" +
                        "                     <th> " + WebLanguage.GetLanguage(OSiteParam, "Ngày Hiệu Lực") + "</th> \r\n" +
                        "                     <th> " + WebLanguage.GetLanguage(OSiteParam, "Ngày Hết Hiệu Lực ") + "</th> \r\n" +
                        "                     <th style=\"width:20px\"> " + WebLanguage.GetLanguage(OSiteParam, "STT") + "</th> \r\n" +
                        //"                     <th style=\"width:80px\"> " + WebLanguage.GetLanguage(OSiteParam, "Bạn Bè ") + "</th> \r\n" +
                        "                     <th> " + WebLanguage.GetLanguage(OSiteParam, "Ghi Chú") + "</th> \r\n" +
                        "                     <th class = \"unsort\" style=\"width:65px\" >" + WebLanguage.GetLanguage(OSiteParam, "Tác vụ") + "</th> \r\n" +
                        //"                     <th class = \"unsort\"><a title=\"Thêm mới bản ghi\" href=\"javascript:ServerSideDrawAddForm();\">Thêm</a></th> \r\n" +
                        "                 </tr> \r\n" +
                        "                 </thead> \r\n" +
                        "                 <tbody> \r\n";
                    for (int iIndex = 0; iIndex < DanhMucXaPhuongs.Length; iIndex++)
                    {
                        Html += "               <tr> \r\n" +
                            "                     <td>" + DanhMucXaPhuongs[iIndex].Ma + "</td> \r\n" +
                            "                     <td>" + DanhMucXaPhuongs[iIndex].Ten + "</td> \r\n" +
                            "                     <td>" + DanhMucXaPhuongs[iIndex].MaBCBYT + "</td> \r\n" +
                            "                     <td>" + DanhMucXaPhuongs[iIndex].MoTa + "</td> \r\n" +
                            "                     <td title=\"" + DanhMucXaPhuongs[iIndex].HieuLuc + "\">" + (DanhMucXaPhuongs[iIndex].HieuLuc == (int)OneFRAME.Model.Common.eHieuLuc.Khong ? Helper.HieuLuc.Khong : Helper.HieuLuc.Co) + " </ td > \r\n" +
                            //"                     <td style=\"text-align: center;\">" + DanhMucXaPhuongs[iIndex].HieuLuc + "</td> \r\n" +
                            "                     <td>" + DanhMucXaPhuongs[iIndex].NgayTao + "</td> \r\n" +
                            "                     <td>" + DanhMucXaPhuongs[iIndex].NgayHieuLuc + "</td> \r\n" +
                            "                     <td>" + DanhMucXaPhuongs[iIndex].NgayHetHieuLuc + "</td> \r\n" +
                            "                     <td style=\"text-align: center;\">" + DanhMucXaPhuongs[iIndex].STT + "</td> \r\n" +
                            //"                     <td title=\"" + DanhMucXaPhuongs[iIndex].BanBe + "\">" + (DanhMucXaPhuongs[iIndex].BanBe == (int)OneFRAME.Model.Common.eBanBe.Co ? Helper.BanBe.Co : Helper.BanBe.Khong) + " </ td > \r\n" +
                            //"                     <td style=\"text-align: center;\">" + DanhMucXaPhuongs[iIndex].BanBe  + "</td> \r\n" +
                            "                     <td>" + DanhMucXaPhuongs[iIndex].GhiChu + "</td> \r\n" +
                            "                     <td class=\"td-center\"> &nbsp; <a title=\"Sửa\" onclick=\"ServerSideDrawUpdateForm('" + DanhMucXaPhuongs[iIndex].ID + "');\"><i class=\"" + WebScreen.GetEditGridIcon() + "\"></i></a> &nbsp; <a title=\"Xóa\" href=\"javascript:ServerSideDelete('" + DanhMucXaPhuongs[iIndex].ID + "');\"><i class=\"" + WebScreen.GetDeleteGridIcon() + "\"></i></a></td> \r\n" +
                            "                 </tr> \r\n";
                    }
                    Html += "               </tbody> \r\n" +
                        "             </table> \r\n" +
                        "          </div>\r\n" +
                        "                   <div class=\"\">\r\n" +
                        "                        <div class=\"col-md-3\" style=\"margin-top:20px;padding-left: 0px;\">\r\n" +
                        "                       <lable>" + WebLanguage.GetLanguage(OSiteParam, "Số bản ghi:") + " " + RetPaging.EndIndex + "" + "/ " + "" + countDanhMucXaPhuong + "</lable>\r\n" +
                        "                        </div>\r\n" +
                        "                       <div class=\"col-md-9\" style=\"margin-top:20px;\">\r\n" +
                        "                       " + nextpage + "" +
                        "                       </div>\r\n" +
                        //"                    </div>\r\n" +

                        "          </div>\r\n";
                }
                Html = WebEnvironments.ProcessHtml(Html);
                RetAjaxOut.HtmlContent = Html;
            }
            catch (Exception ex)
            {
                RetAjaxOut.Error = true;
                RetAjaxOut.InfoMessage = ex.Message.ToString();
                RetAjaxOut.HtmlContent = ex.Message.ToString();
            }
            return RetAjaxOut;
        }

        #region showpopup
        [AjaxPro.AjaxMethod(AjaxPro.HttpSessionStateRequirement.ReadWrite)]
        public static AjaxOut ServerSideDrawAddForm(RenderInfoCls ORenderInfo)
        {

            AjaxOut RetAjaxOut = new AjaxOut();
            try
            {
                SiteParam OSiteParam = WebEnvironments.CreateSiteParam(ORenderInfo);
                WebSession.CheckSessionTimeOut(ORenderInfo);

                string Html =
                    "<form id=\"sendmail\" data-async  method=\"post\"  role=\"form\" onSubmit=\"return false;\" class=\"contactForm\">\r\n" +

                        //"      <div style=\"max-height: calc(100vh - 210px); overflow-y:scroll; white-space: nowrap;\"> \r\n" +

                        "            <div class=\"col-xs-12 col-sm-12 col-md-12\"> \r\n" +
                        "                  <div class=\"form-group\">\r\n" +
                        "                       <label>" + WebLanguage.GetLanguage(OSiteParam, "Mã Xã/Phường ") + " <span style='color:red'>*</span></label>\r\n" +
                        "                       <input id=\"txtMa\" type=\"text\" placeholder=\"Mã Xã/Phường\" class=\"form-control\" required>\r\n" +
                        "                  </div>\r\n" +
                        "            </div>\r\n" +

                        "            <div class=\"col-xs-12 col-sm-12 col-md-12\">\r\n" +
                        "                  <div class=\"form-group\">\r\n" +
                        "                       <label>" + WebLanguage.GetLanguage(OSiteParam, "Tên Xã/hường ") + " <span style='color:red'>*</span></label>\r\n" +
                        "                       <input id=\"txtTen\" type=\"text\" placeholder=\"Tên\" class=\"form-control\" required>\r\n" +
                        "                  </div>\r\n" +
                        "            </div>\r\n" +

                        "            <div class=\"col-xs-12 col-sm-12 col-md-12\">\r\n" +
                        "                  <div class=\"form-group\">\r\n" +
                        "                       <label>" + WebLanguage.GetLanguage(OSiteParam, "Mã BYT") + "<span style='color:red'>*</span></label>\r\n" +
                        "                       <input id=\"txtMaBCBYT\" type=\"Text\" placeholder=\"Mã BYT\" class=\"form-control\" >\r\n" +
                        "                  </div>\r\n" +
                        "            </div>\r\n" +

                       "           <div class=\"col-xs-12 col-sm-12 col-md-12\">\r\n" +
                        "                <div class=\"form-group\">\r\n" +
                        "                     <label for=\"inputSubject\">" + WebLanguage.GetLanguage(OSiteParam, "Quận Huyện") + " <span style='color:red'>*</span></label>\r\n" +
                        "                     <div>" +
                        "                          <select id=\"drpQuanHuyen\" placeholder=\"click for selection\"style=\"width: 100%;\"  class=\"form-control select2\" required></select>\r\n" +
                        "                     </div>\r\n" +
                        "                </div>\r\n" +
                        "           </div>\r\n" +

                        "            <div class=\"col-xs-12 col-sm-12 col-md-12\">\r\n" +
                        "                  <div class=\"form-group\">\r\n" +
                        "                       <label>" + WebLanguage.GetLanguage(OSiteParam, "Số thứ tự") + " <span style='color:red'>*</span></label>\r\n" +
                        "                       <input id=\"nbSTT\" type=\"number\" onkeypress=\"checkCurrency(event);\" min=\"0\" max=\"999999999\"  class=\"form-control\" required>\r\n" +
                        "                  </div>\r\n" +
                        "            </div>\r\n" +


                        "            <div class=\"col-xs-12 col-sm-12 col-md-12\" id=\"rdHieuLuc\">\r\n" +
                        "                  <div class=\"form-group\"> " +
                        "                        <label>" + WebLanguage.GetLanguage(OSiteParam, "Trạng thái") + "</label>\r\n" +
                        "                        <div> \r\n" +
                        "                             <label class=\"radio-inline\"><input  id = \"optradioHl0\" type = \"radio\" name=\"optradioHl\" value=\"" + (int)OneFRAME.Model.Common.eHieuLuc.Co + "\" checked>" + OneFRAME.Model.Helper.HieuLuc.Co + "</label> " + // common file
                        "                             <label class=\"radio-inline\"><input  id = \"optradioHl1\" type = \"radio\" name=\"optradioHl\" value=\"" + (int)OneFRAME.Model.Common.eHieuLuc.Khong + "\">" + OneFRAME.Model.Helper.HieuLuc.Khong + "</label> " + //common file
                        "                        </div> " +
                        "                  </div> " +
                        "            </div>\r\n" +

                        //"            <div class=\"col-xs-12 col-sm-12 col-md-12 \" id=\"rdBanBe\">\r\n" +
                        //"                  <div class=\"form-group\"> " +
                        //"                        <label>" + WebLanguage.GetLanguage(OSiteParam, "Bạn Bè ") + "</label>\r\n" +
                        //"                        <div> \r\n" +
                        //"                             <label class=\"radio-inline\"><input  id = \"optradioBb0\" type = \"radio\" name=\"optradioBb\" value=\"" + (int)OneFRAME.Model.Common.eBanBe.Co + "\" checked>" + OneFRAME.Model.Helper.BanBe.Co + "</label> " + // common file
                        //"                             <label class=\"radio-inline\"><input  id = \"optradioBb1\" type = \"radio\" name=\"optradioBb\" value=\"" + (int)OneFRAME.Model.Common.eBanBe.Khong + "\">" + OneFRAME.Model.Helper.BanBe.Khong + "</label> " + //common file
                        //"                        </div> " +
                        //"                  </div> " +
                        //"            </div>\r\n" +



                        //"            <div class=\"col-xs-12 col-sm-12 col-md-12\">\r\n" +
                        //"                 <div class=\"form-group\">\r\n" +
                        //"                      <label>" + WebLanguage.GetLanguage(OSiteParam, " Ngày Hiệu Lực") + "</label>\r\n" +
                        //"                      <input id=\"txtNgayHieuLuc \" type=\"date\" placeholder=\"Ngày Hiệu Lực \" class=\"form-control\" >\r\n" +
                        //"                 </div>\r\n" +
                        //"            </div>\r\n" +

                        //"            <div class=\"col-xs-12 col-sm-12 col-md-12\">\r\n" +
                        //"                 <div class=\"form-group\">\r\n" +
                        //"                      <label>" + WebLanguage.GetLanguage(OSiteParam, " Ngày Hết Hiệu Lực") + "</label>\r\n" +
                        //"                      <input id=\"txtNgayHetHieuLuc\" type=\"date\" placeholder=\"Ngày Hết Hiệu Lực \" class=\"form-control\" >\r\n" +
                        //"                 </div>\r\n" +
                        //"            </div>\r\n" +



                        "            <div class=\"col-xs-12 col-sm-12 col-md-12\">\r\n" +
                        "                 <div class=\"form-group\">\r\n" +
                        "                      <label>" + WebLanguage.GetLanguage(OSiteParam, "Mô Tả:") + "</label>\r\n" +
                        "                      <textarea class=\"form-control\" id=\"txtMoTa\" rows=\"4\"></textarea>\r\n" +
                        "                 </div>\r\n" +
                        "            </div>\r\n" +

                        //"            <div class=\"col-xs-12 col-sm-12 col-md-12\">\r\n" +
                        //"                  <div class=\"form-group\">\r\n" +
                        //"                       <label>" + WebLanguage.GetLanguage(OSiteParam, "Ghi Chú ") + " </label>\r\n" +
                        //"                       <input id=\"txtGhiChu\" type=\"text\" onkeypress=\"checkCurrency(event);\" min=\"0\" max=\"999999999\"  class=\"form-control\" required>\r\n" +
                        //"                  </div>\r\n" +
                        //"            </div>\r\n" +



                        //"      </div>\r\n" +

                        "      <div class=\"form-group\" >\r\n" +

                        "           <div class=\"form-group\" style=\"margin-top: 10px; margin-left: 15px;\">\r\n" +
                        "               <button class=\"btn btn-sm btn-primary mr-5px\"  type=\"submit\" onclick=\"javascript:ServerSideAdd();\"><strong>" + WebLanguage.GetLanguage(OSiteParam, "Chấp nhận") + "</strong></button> \r\n" +
                        "               <button class=\"btn btn-sm btn-primary\" type=\"button\" onclick=\"javascript:CloseModal();\"><strong>" + WebLanguage.GetLanguage(OSiteParam, "Bỏ qua") + "</strong></button> \r\n" +
                        "               <div id='response'></div>\r\n" +
                        "          </div>\r\n" +

                        "      </div>\r\n" +

                        "</form>";

                Html = WebEnvironments.ProcessHtml(Html);
                RetAjaxOut.HtmlContent = Html;
            }
            catch (Exception ex)
            {
                RetAjaxOut.Error = true;
                RetAjaxOut.InfoMessage = ex.Message.ToString();
                RetAjaxOut.HtmlContent = ex.Message.ToString();
            }
            return RetAjaxOut;
        }

        [AjaxPro.AjaxMethod(AjaxPro.HttpSessionStateRequirement.ReadWrite)]
        public static AjaxOut ServerSideDrawUpdateForm(RenderInfoCls ORenderInfo, string Id) // form đưa ra thông tin 
        {
            AjaxOut RetAjaxOut = new AjaxOut();
            try
            {
                SiteParam OSiteParam = WebEnvironments.CreateSiteParam(ORenderInfo);
                WebSession.CheckSessionTimeOut(ORenderInfo);
                DanhMucXaPhuongCls ODanhMucXaPhuong = CallBussinessUtility.CreateBussinessProcess().CreateDanhMucXaPhuongProcess().CreateModel(ORenderInfo, Id);

                if (ODanhMucXaPhuong == null) throw new Exception(WebLanguage.GetLanguage(OSiteParam, "Đơn vị hành chính đã bị xóa hoặc không tìm thấy"));

                string Html =
                        "  <form id=\"sendmail\" data-async  method=\"post\" role=\"form\" onSubmit=\"return false;\" class=\"contactForm\">\r\n" +

                        //"        <div style=\"max-height: calc(100vh - 210px); overflow-y:scroll; white-space: nowrap;\">" +

                        "               <div class=\"col-xs-12 col-sm-12 col-md-12\">\r\n" +
                        "                    <div class=\"form-group\">\r\n" +
                        "                        <label for=\"inputTo\">" + WebLanguage.GetLanguage(OSiteParam, "Mã Xã Phường ") + " <span style='color:red'>*</span></label>\r\n" +
                        "                        <input id=\"txtMa\" type=\"text\" placeholder=\"Mã Xã Phường\" class=\"form-control\" value=\"" + ODanhMucXaPhuong.Ma + "\" required>\r\n" +
                        "                    </div>\r\n" +
                        "               </div>\r\n" +

                        "               <div class=\"col-xs-12 col-sm-12 col-md-12\">\r\n" +
                        "                   <div class=\"form-group\">\r\n" +
                        "                       <label for=\"inputSubject\">" + WebLanguage.GetLanguage(OSiteParam, "Tên Xã Phường  ") + " <span style='color:red'>*</span></label>\r\n" +
                        "                       <input id=\"txtTen\" type=\"text\" placeholder=\"Tên\" class=\"form-control\" value=\"" + ODanhMucXaPhuong.Ten + "\" required>\r\n" +
                        "                   </div>\r\n" +
                        "               </div>\r\n" +

                        "               <div class=\"col-xs-12 col-sm-12 col-md-12\">\r\n" +
                        "                   <div class=\"form-group\">\r\n" +
                        "                       <label for=\"inputSubject\">" + WebLanguage.GetLanguage(OSiteParam, "Mã BYT") + " </label>\r\n" +
                        "                       <input id=\"txtMaBCBYT\" type=\"text\" placeholder=\"Mã BYT\" class=\"form-control\" value=\"" + ODanhMucXaPhuong.MaBCBYT + "\" >\r\n" +
                        "                   </div>\r\n" +
                        "               </div>\r\n" +

                        "               <div class=\"col-xs-12 col-sm-12 col-md-12\">\r\n" +
                        "                   <div class=\"form-group\">\r\n" +
                        "                       <label for=\"inputSubject\">" + WebLanguage.GetLanguage(OSiteParam, "Quận Huyện ") + " </label>\r\n" +
                        "                       <input id=\"drpQuanHuyen\" type=\"text\" placeholder=\"Quận Huyện\" class=\"form-control\" value=\"" + ODanhMucXaPhuong.MaBCBYT + "\" >\r\n" +
                        "                   </div>\r\n" +
                        "               </div>\r\n" +


                        "               <div class=\"col-xs-12 col-sm-12 col-md-12\">\r\n" +
                        "                   <div class=\"form-group\">\r\n" +
                        "                       <label for=\"inputSubject\">" + WebLanguage.GetLanguage(OSiteParam, "Số thứ tự ") + "<span style='color:red'>*</span></label>\r\n" +
                        "                       <input id=\"nbSTT\" type=\"number\" min=\"0\" max=\"999999999\" onkeypress=\"checkCurrency(event);\" class=\"form-control\" value=\"" + ODanhMucXaPhuong.STT + "\" required>\r\n" +
                        "                   </div>\r\n" +
                        "               </div>\r\n" +


                        "               <div class=\"col-xs-12 col-sm-12 col-md-12\" id=\"rdHieuLuc\">\r\n" +
                        "                   <div class=\"form-group\"> " +
                        "                       <label for=\"inputSubject\">" + WebLanguage.GetLanguage(OSiteParam, "Trạng thái") + "</label>\r\n" +
                        "                       <div> \r\n" +
                        "                             <label class=\"radio-inline\"><input  id = \"optradioHl0\" type = \"radio\" name=\"optradioHl\" value=\"" + (int)OneFRAME.Model.Common.eHieuLuc.Co + "\" " + (ODanhMucXaPhuong.HieuLuc == (int)Common.eHieuLuc.Co ? "checked" : "") + "      >" + OneFRAME.Model.Helper.HieuLuc.Co + "</label> " + // common file  time 2
                        "                             <label class=\"radio-inline\"><input  id = \"optradioHl1\" type = \"radio\" name=\"optradioHl\" value=\"" + (int)OneFRAME.Model.Common.eHieuLuc.Khong + "\"" + (ODanhMucXaPhuong.HieuLuc == (int)Common.eHieuLuc.Khong ? "checked" : "") + ">" + OneFRAME.Model.Helper.HieuLuc.Khong + "</label> " + //common file
                        "                       </div> " +
                        "                   </div> " +
                        "               </div>\r\n" +
                        

                         "               <div class=\"col-xs-12 col-sm-12 col-md-12\">\r\n" +
                        "                   <div class=\"form-group\">\r\n" +
                        "                       <label for=\"inputBody\">" + WebLanguage.GetLanguage(OSiteParam, "Mô Tả") + ":</label>\r\n" +
                        "                       <textarea class=\"form-control\" id=\"txtMoTa\" rows=\"4\">" + ODanhMucXaPhuong.MoTa + "</textarea>\r\n" +
                        "                   </div>\r\n" +
                        "               </div>\r\n" +



                        

                        "      <div class=\"form-group\" >\r\n" +

                        "           <div class=\"form-group\" style=\"margin-top: 10px; margin-left: 15px;\">\r\n" +
                        "               <button class=\"btn btn-sm btn-primary mr-5px\" type=\"submit\" onclick=\"javascript:ServerSideUpdate('" + Id + "');\"><strong>" + WebLanguage.GetLanguage(OSiteParam, "Chấp nhận") + "</strong></button> \r\n" +
                        "               <button class=\"btn btn-sm btn-primary\" data-dismiss=\"modal\" type=\"button\" onclick=\"javascript:CloseModal();\"><strong>" + WebLanguage.GetLanguage(OSiteParam, "Bỏ qua") + "</strong></button>\r\n" +
                        "               <div id='response'></div>\r\n" +
                        "           </div>\r\n" +

                        "      </div>\r\n" +
                        "</form>";

                Html = WebEnvironments.ProcessHtml(Html);
                RetAjaxOut.HtmlContent = Html;
            }
            catch (Exception ex)
            {
                RetAjaxOut.Error = true;
                RetAjaxOut.InfoMessage = ex.Message.ToString();
                RetAjaxOut.HtmlContent = ex.Message.ToString();
            }
            return RetAjaxOut;
        }
        #endregion

        #region action
        [AjaxPro.AjaxMethod(AjaxPro.HttpSessionStateRequirement.ReadWrite)]
        public static AjaxOut ServerSideAdd(RenderInfoCls ORenderInfo, XaPhuong param) 
        {
            AjaxOut RetAjaxOut = new AjaxOut();
            try
            {
                SiteParam
                    OSiteParam = WebEnvironments.CreateSiteParam(ORenderInfo);
                WebSession.CheckSessionTimeOut(ORenderInfo);
                var ODMXaPhuongExist = CallBussinessUtility.CreateBussinessProcess().CreateDanhMucXaPhuongProcess().CreateModel(ORenderInfo, param.Ma);
                if (ODMXaPhuongExist != null)
                {
                    throw new Exception("Mã Hoặc ID  Đã Tồn Tại ");
                }//------- check mã thêm 
                int temp;
                DanhMucXaPhuongCls
                ODanhMucXaPhuong = new DanhMucXaPhuongCls();
                ODanhMucXaPhuong.Ma = param.Ma;
                ODanhMucXaPhuong.Ten = param.Ten;
                ODanhMucXaPhuong.NgayTao = DateTime.Now;
                ODanhMucXaPhuong.MaBCBYT = param.MaBCBYT;
                ODanhMucXaPhuong.STT = int.TryParse(param.STT, out temp) ? temp : 0;
                ODanhMucXaPhuong.HieuLuc = int.TryParse(param.HieuLuc, out temp) ? temp : 0;
                ODanhMucXaPhuong.MoTa = param.MoTa;
                ODanhMucXaPhuong.QuanHuyenID = param.QuanHuyenID;
                CallBussinessUtility.CreateBussinessProcess().CreateDanhMucXaPhuongProcess().Add(ORenderInfo, ODanhMucXaPhuong);
            }
            catch (Exception ex)
            {
                RetAjaxOut.Error = true;
                RetAjaxOut.InfoMessage = ex.Message.ToString();
                RetAjaxOut.HtmlContent = ex.Message.ToString();
            }
            return RetAjaxOut;
        }

        [AjaxPro.AjaxMethod(AjaxPro.HttpSessionStateRequirement.ReadWrite)]
        public static AjaxOut ServerSideUpdate(RenderInfoCls ORenderInfo, XaPhuong param, string Id)
        {
            AjaxOut RetAjaxOut = new AjaxOut();
            try
            {
                SiteParam OSiteParam = WebEnvironments.CreateSiteParam(ORenderInfo);
                WebSession.CheckSessionTimeOut(ORenderInfo);

                //CallBussinessUtility.CreateBussinessProcess().CreateDanhMucXaPhuongProcess().CheckTheCode(ORenderInfo, Id, Ma);
                int temp;
                DanhMucXaPhuongCls
                 ODanhMucXaPhuong = CallBussinessUtility.CreateBussinessProcess().CreateDanhMucXaPhuongProcess().CreateModel(ORenderInfo, Id);
                if (ODanhMucXaPhuong == null) throw new Exception("Đơn vị hành chính đã bị xóa hoặc không tìm thấy");
                if (ODanhMucXaPhuong.Ma != param.Ma)
                {
                    var ODMXaPhuongExist = CallBussinessUtility.CreateBussinessProcess().CreateDanhMucXaPhuongProcess().CreateModel(ORenderInfo, param.Ma);
                    if (ODMXaPhuongExist != null)
                    {
                        throw new Exception("Mã Xã Phường Đã Tồn Tại");
                    }
                }//---- check mã sửa
                ODanhMucXaPhuong.Ma = param.Ma;
                ODanhMucXaPhuong.Ten = param.Ten;
                ODanhMucXaPhuong.MaBCBYT = param.MaBCBYT;
                ODanhMucXaPhuong.NgayTao = DateTime.Now;
                ODanhMucXaPhuong.STT = int.TryParse(param.STT, out temp) ? temp : 0;
                ODanhMucXaPhuong.HieuLuc = int.TryParse(param.HieuLuc, out temp) ? temp : 0;
                ODanhMucXaPhuong.MoTa = param.MoTa;
                ODanhMucXaPhuong.QuanHuyenID = param.QuanHuyenID;
               
                CallBussinessUtility.CreateBussinessProcess().CreateDanhMucXaPhuongProcess().Save(ORenderInfo, Id, ODanhMucXaPhuong);

            }
            catch (Exception ex)
            {
                RetAjaxOut.Error = true;
                RetAjaxOut.InfoMessage = ex.Message.ToString();
                RetAjaxOut.HtmlContent = ex.Message.ToString();
            }
            return RetAjaxOut;
        }

        [AjaxPro.AjaxMethod(AjaxPro.HttpSessionStateRequirement.ReadWrite)]
        public static AjaxOut ServerSideDelete(RenderInfoCls ORenderInfo, string Id)
        {
            AjaxOut RetAjaxOut = new AjaxOut();
            try
            {
                SiteParam OSiteParam = WebEnvironments.CreateSiteParam(ORenderInfo);
                WebSession.CheckSessionTimeOut(ORenderInfo);
                //var dataBenhNhans = CallBussinessUtility.CreateBussinessProcess().CreateBenhNhanProcess().Reading(ORenderInfo, new BenhNhanFilterCls());
                //dataBenhNhans = dataBenhNhans.Where(o => o.DiaChiHanhChinhID != null).ToArray();
                //if (dataBenhNhans.Length > 0)
                //{
                //    dataBenhNhans = dataBenhNhans.Where(o => o.DiaChiHanhChinhID.ToUpper().Equals(Id.ToUpper())).ToArray();
                //    if (dataBenhNhans.Length > 0)
                //        throw new Exception("Cần xóa các bản ghi này ở DM_GIUONG trước khi thực hiện xóa bản ghi này!");
                //}
                CallBussinessUtility.CreateBussinessProcess().CreateDanhMucXaPhuongProcess().Delete(ORenderInfo, Id);
            }
            catch (Exception ex)
            {
                RetAjaxOut.Error = true;
                RetAjaxOut.InfoMessage = ex.Message.ToString();
                RetAjaxOut.HtmlContent = ex.Message.ToString();
            }
            return RetAjaxOut;
        }

        #endregion

        #region CustomActionControls
        public override string divFilter
        {
            get
            {
                return
                       "<div class=\"col-md-3\" style=\"padding-top: 6px; padding-bottom: 6px;\">\r\n" +
                       "    <input id=\"txtKeyword\" placeholder=\"Tìm kiếm\" onkeypress=\"timkiem(event);\" class=\"form-control\" >\r\n" +
                       "</div>\r\n" +

                       "<div class=\"col-md-3\" style=\"padding-top: 6px; padding-bottom: 6px;\">\r\n" +
                       "       <button type=\"button\" style=\"margin-top: 0px; height: 28px;background-color: #e26614;color:white;\" class=\"btn btn-sm btn-primary\" onclick=\"javascript:FilterSearch();\" onkeypress=\"timkiem(event);\"> Tìm kiếm </button>\r\n" +
                       "</div>\r\n";

            }
        }


        #endregion
    }

    public class XaPhuong
    {
        public string Ma;
        public string Ten;
        public string MaBCBYT;
        public string QuanHuyenID;
        public string STT;
        public string HieuLuc;
        public string MoTa;

    }
}



