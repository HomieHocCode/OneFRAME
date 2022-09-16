using FlexCel.Report;
using OneFRAME.Bussiness.Utility;
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
    public class DanhMucQuanHuyen : WebPartTemplate
    {
        public override string WebPartId
        {
            get
            {
                return "DanhMucQuanHuyen";
            }
        }

        public override string WebPartTitle
        {
            get
            {
                return "Danh Mục Quận Huyện  ";
            }
        }

        public override string Description
        {
            get
            {
                return "Danh mục Quận Huyện ";
            }
        }

        public override void RegAjaxPro(SiteParam OSiteParam, System.Web.UI.Page Page)
        {
            AjaxPro.Utility.RegisterTypeForAjax(typeof(DanhMucQuanHuyen), Page);
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
                string filtemplate = WebConfig.GetWebHttpRoot() + "temp/ImportDanhMucQuanHuyen.xlsx";
                RetAjaxOut.HtmlContent =
                #region HtmlContext
 WebEnvironments.ProcessHtml("<div id=\"divListForm\">\r\n" +
                    " <div class=\"ibox float-e-margins\"> \r\n" +
                    "     <div class=\"ibox-title\"> \r\n" +
                    "         <h5>" + WebLanguage.GetLanguage(OSiteParam, "DANH MỤC QUẬN HUYỆN  ") + "</h5> \r\n" +
                    "     </div> \r\n" +
                    "     <div class=\"ibox-content\"> \r\n" +
                    "       <button type=\"button\" style=\"margin-bottom:14px;padding:0px; width:80px;height:32px\" class=\"btn btn-sm btn-primary\" onclick=\"location.href='" + filtemplate + "'\"><i class=\"fa fa-download\"></i> " + WebLanguage.GetLanguage(OSiteParam, "File Import") + "</button>\r\n" +
                    "       <button type=\"button\" style=\"margin-bottom:14px;padding:0px; width:80px;height:32px\" class=\"btn btn-sm btn-primary\" onclick=\"javascript:Import();\"> " + WebLanguage.GetLanguage(OSiteParam, "Import") + "</button>\r\n" +
                    "       <button type=\"button\" style=\"margin-bottom:14px;padding:0px; width:80px;height:32px\" class=\"btn btn-sm btn-primary\" onclick=\"javascript:CallExPortForm();\"> " + WebLanguage.GetLanguage(OSiteParam, "Export") + "</button>\r\n" +
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
                    "               <div id=\"divDanhMucQuanHuyenContent\">" + ServerSideDrawSearchResult(ORenderInfo, "", 0).HtmlContent + "</div>\r\n" +
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
                    "       $('#drpTinhThanh').select2({\r\n" +
                    "           placeholder: 'Quận Huyện  ',\r\n" +
                    "           allowClear: true\r\n" +
                    "       });\r\n" +
                    "    });\r\n" +
                    //----
                    "   function CallExPortForm()\r\n" +
                    "   {\r\n" +
                    "       RenderInfo=CreateRenderInfo();\r\n" +
                    "       AjaxOut  = OneFRAME.WebParts.DanhMucQuanHuyen.ServerSidePrint(CreateRenderInfo()).value;\r\n" +
                    "       if(AjaxOut.Error)\r\n" +
                    "       {\r\n" +
                    "           callSweetAlert(AjaxOut.InfoMessage);\r\n" +
                    "           return;\r\n" +
                    "       }\r\n" +
                    "       window.open(AjaxOut.RetUrl, 'Download');\r\n" +
                    "       callSweetAlert(\"" + WebLanguage.GetLanguage(OSiteParam, "Xuất thành công") + "!\");\r\n" +
                    "   }\r\n" +
                    //---
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
                    //"       CallInitSelect2('drpVung', '" + WebEnvironments.GetRemoteProcessDataUrl(DanhMucVungMienService.StaticServiceId) + "', 'Vùng Miền')\r\n" +
                    "       CallInitSelect2('drpTinhThanh', '" + WebEnvironments.GetRemoteProcessDataUrl(DanhMucTinhThanhService.StaticServiceId) + "', 'Tinh Thanh')\r\n" +
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
                    "       AjaxOut = OneFRAME.WebParts.DanhMucQuanHuyen.ServerSideDrawSearchResult(RenderInfo, Keyword, _currentPageIndex).value;\r\n" +
                    "       document.getElementById('divProcessing').innerHTML='';\r\n" +
                    "       document.getElementById('divDanhMucQuanHuyenContent').innerHTML=AjaxOut.HtmlContent;\r\n" +
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
                    "       AjaxOut = OneFRAME.WebParts.DanhMucQuanHuyen.ServerSideDrawAddForm(RenderInfo).value;\r\n" +
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
                    "       AjaxOut = OneFRAME.WebParts.DanhMucQuanHuyen.ServerSideDrawUpdateForm(RenderInfo, Id).value;\r\n" +
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
                    "       obj.MaBCBYT = document.getElementById('txtMaBCBYT').value.trim();\r\n" +
                    "       obj.Ten = document.getElementById('txtTen').value.trim();\r\n" +
                    "       obj.TinhThanhID= document.getElementById('drpTinhThanh').value.trim();\r\n" +
                    "       obj.HieuLuc = $('#rdHieuLuc input:radio:checked').val();\r\n" +
                    "       obj.STT = document.getElementById('nbSTT').value.trim() || null; \r\n" +
                    "       obj.MoTa = document.getElementById('txtMoTa').value.trim();\r\n" +

                    "       AjaxOut = OneFRAME.WebParts.DanhMucQuanHuyen.ServerSideAdd(RenderInfo,obj).value;\r\n" +
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
                    "       obj.TinhThanhID = document.getElementById('drpTinhThanh').value.trim();\r\n" +
                    "       obj.MoTa = document.getElementById('txtMoTa').value.trim();\r\n" +
                    "       obj.HieuLuc = $('#rdHieuLuc input:radio:checked').val();\r\n" +
                    "       obj.STT = document.getElementById('nbSTT').value.trim() || null; \r\n" +



                    "       AjaxOut = OneFRAME.WebParts.DanhMucQuanHuyen.ServerSideUpdate(RenderInfo, obj,Id).value;\r\n" +
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

                    "   function ServerSideDelete(DanhMucQuanHuyenId)\r\n" +
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
                    "           AjaxOut = OneFRAME.WebParts.DanhMucQuanHuyen.ServerSideDelete(RenderInfo, DanhMucQuanHuyenId).value;\r\n" +
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
                    "               xhr.open(\"POST\", \"" + WebConfig.GetImportHandler(OSiteParam, SessionId, UserId, LoginName, (int)ProcessImportHandlerUtility.eFileType.DM_QUANHUYEN) + "\");\r\n" +
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

                DanhMucQuanHuyenCls[] DanhMucQuanHuyens = CallBussinessUtility.CreateBussinessProcess().CreateDanhMucQuanHuyenProcess().ReadingWithPaging(ORenderInfo, new DanhMucQuanHuyenFilterCls()
                {
                    Keyword = Keyword,
                    //HieuLuc = !string.IsNullOrEmpty(HieuLuc) && HieuLuc != null ? int.Parse(HieuLuc) : (int)ONEMES3.DM.Model.Common.eSearch.SearchAll
                },
                    CurrentPageIndex, 18);
                var countDanhMucQuanHuyen = CallBussinessUtility.CreateBussinessProcess().CreateDanhMucQuanHuyenProcess().Count(ORenderInfo, new DanhMucQuanHuyenFilterCls()
                {
                    Keyword = Keyword,
                    //HieuLuc = !string.IsNullOrEmpty(HieuLuc) && HieuLuc != null ? int.Parse(HieuLuc) : (int)ONEMES3.DM.Model.Common.eSearch.SearchAll
                }
                );

                ReturnPaging RetPaging = WebPaging.GetPaging((int)countDanhMucQuanHuyen, CurrentPageIndex, 18, 10, "NextPage");

                var nextpage = string.Empty;
                if (countDanhMucQuanHuyen > 18) nextpage = RetPaging.PagingText;

                string Html = "";
                if (DanhMucQuanHuyens.Length == 0)
                {
                    Html += "   <div class=\"search-result-info\"></div>\r\n" +
                        "         <div class=\"table-responsive\"> \r\n" +
                        "             <table class=\"table table-striped table-bordered table-hover\"> \r\n" +
                        "                 <thead> \r\n" +
                        "                 <tr> \r\n" +
                        //"                     <td></td> \r\n" +
                        "                     <th> " + WebLanguage.GetLanguage(OSiteParam, "Mã Quận Huyện ") + "</th> \r\n" +
                        "                     <th> " + WebLanguage.GetLanguage(OSiteParam, "Tên Quận Huyện ") + "</th> \r\n" +
                        "                     <th> " + WebLanguage.GetLanguage(OSiteParam, "Mã BYT") + "</th> \r\n" +
                        "                     <th> " + WebLanguage.GetLanguage(OSiteParam, "Tỉnh Thành") + "</th> \r\n" +
                        //"                     <th> " + WebLanguage.GetLanguage(OSiteParam, "Vùng Miền") + "</th> \r\n" +
                        "                     <th> " + WebLanguage.GetLanguage(OSiteParam, "Mô Tả") + "</th> \r\n" +
                        "                     <th> " + WebLanguage.GetLanguage(OSiteParam, "Hiệu Lực") + "</th> \r\n" +
                        "                     <th> " + WebLanguage.GetLanguage(OSiteParam, "Ngày Tạo") + "</th> \r\n" +
                        "                     <th> " + WebLanguage.GetLanguage(OSiteParam, "Ngày Hiệu Lực") + "</th> \r\n" +
                        "                     <th> " + WebLanguage.GetLanguage(OSiteParam, "Ngày Hết Hiệu Lực") + "</th> \r\n" +
                        "                     <th> " + WebLanguage.GetLanguage(OSiteParam, "STT") + "</th> \r\n" +
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
                        "                     <th> " + WebLanguage.GetLanguage(OSiteParam, "Mã Quận Huyện ") + "</th> \r\n" +
                        "                     <th> " + WebLanguage.GetLanguage(OSiteParam, "Tên Quận Huyện ") + "</th> \r\n" +
                        "                     <th> " + WebLanguage.GetLanguage(OSiteParam, "Mã BYT ") + "</th> \r\n" +
                        "                     <th> " + WebLanguage.GetLanguage(OSiteParam, "Tỉnh Thành") + "</th> \r\n" +
                        //"                     <th> " + WebLanguage.GetLanguage(OSiteParam, "Vùng Miền ") + "</th> \r\n" +
                        "                     <th> " + WebLanguage.GetLanguage(OSiteParam, "Mô Tả") + "</th> \r\n" +
                        "                     <th style=\"width:80px\"> " + WebLanguage.GetLanguage(OSiteParam, "Hiệu lực") + "</th> \r\n" +
                        "                     <th> " + WebLanguage.GetLanguage(OSiteParam, "Ngày Tạo") + "</th> \r\n" +
                        "                     <th> " + WebLanguage.GetLanguage(OSiteParam, "Ngày Hiệu Lực") + "</th> \r\n" +
                        "                     <th> " + WebLanguage.GetLanguage(OSiteParam, "Ngày Hết Hiệu Lực ") + "</th> \r\n" +
                        "                     <th style=\"width:20px\"> " + WebLanguage.GetLanguage(OSiteParam, "STT") + "</th> \r\n" +
                        "                     <th> " + WebLanguage.GetLanguage(OSiteParam, "Ghi Chú") + "</th> \r\n" +
                        "                     <th class = \"unsort\" style=\"width:65px\" >" + WebLanguage.GetLanguage(OSiteParam, "Tác vụ") + "</th> \r\n" +
                        //"                     <th class = \"unsort\"><a title=\"Thêm mới bản ghi\" href=\"javascript:ServerSideDrawAddForm();\">Thêm</a></th> \r\n" +
                        "                 </tr> \r\n" +
                        "                 </thead> \r\n" +
                        "                 <tbody> \r\n";
                    for (int iIndex = 0; iIndex < DanhMucQuanHuyens.Length; iIndex++)
                    {
                        Html += "               <tr> \r\n" +
                            "                     <td>" + DanhMucQuanHuyens[iIndex].Ma + "</td> \r\n" +
                            "                     <td>" + DanhMucQuanHuyens[iIndex].Ten + "</td> \r\n" +
                            "                     <td>" + DanhMucQuanHuyens[iIndex].MaBCBYT + "</td> \r\n" +
                            "                     <td>" + DanhMucTinhThanh.GetTenDVHC(ORenderInfo, DanhMucQuanHuyens[iIndex].TinhThanhID, (int)Common.eDVHC.TinhThanh) + "</td> \r\n" +
                            //"                     <td>" + CallBussinessUtility.CreateBussinessProcess().CreateDanhMucTinhThanhProcess().CreateModel(ORenderInfo, DanhMucQuanHuyens[iIndex].TinhThanhID)?.Ten + "</td> \r\n" +
                            //"                     <td>" + GetTenDVHC(ORenderInfo, DanhMucQuanHuyens[iIndex].VungID, (int)Common.eDVHC.VungMien) + "</td> \r\n" +
                            "                     <td>" + DanhMucQuanHuyens[iIndex].MoTa + "</td> \r\n" +
                            "                     <td title=\"" + DanhMucQuanHuyens[iIndex].HieuLuc + "\">" + (DanhMucQuanHuyens[iIndex].HieuLuc == (int)OneFRAME.Model.Common.eHieuLuc.Khong ? Helper.HieuLuc.Khong : Helper.HieuLuc.Co) + " </ td > \r\n" +
                            //"                     <td style=\"text-align: center;\">" + DanhMucQuanHuyens[iIndex].HieuLuc + "</td> \r\n" +
                            "                     <td>" + DanhMucQuanHuyens[iIndex].NgayTao + "</td> \r\n" +
                            "                     <td>" + DanhMucQuanHuyens[iIndex].NgayHieuLuc + "</td> \r\n" +
                            "                     <td>" + DanhMucQuanHuyens[iIndex].NgayHetHieuLuc + "</td> \r\n" +
                            "                     <td style=\"text-align: center;\">" + DanhMucQuanHuyens[iIndex].STT + "</td> \r\n" +
                            // "                     <td title=\"" + DanhMucQuanHuyens[iIndex].BanBe + "\">" + (DanhMucQuanHuyens[iIndex].BanBe == (int)OneFRAME.Model.Common.eBanBe.Co ? Helper.BanBe.Co : Helper.BanBe.Khong) + " </ td > \r\n" +
                            //"                     <td style=\"text-align: center;\">" + DanhMucQuanHuyens[iIndex].BanBe  + "</td> \r\n" +
                            "                     <td>" + DanhMucQuanHuyens[iIndex].GhiChu + "</td> \r\n" +
                            "                     <td class=\"td-center\"> &nbsp; <a title=\"Sửa\" onclick=\"ServerSideDrawUpdateForm('" + DanhMucQuanHuyens[iIndex].ID + "');\"><i class=\"" + WebScreen.GetEditGridIcon() + "\"></i></a> &nbsp; <a title=\"Xóa\" href=\"javascript:ServerSideDelete('" + DanhMucQuanHuyens[iIndex].ID + "');\"><i class=\"" + WebScreen.GetDeleteGridIcon() + "\"></i></a></td> \r\n" +
                            "                 </tr> \r\n";
                    }
                    Html += "               </tbody> \r\n" +
                        "             </table> \r\n" +
                        "          </div>\r\n" +
                        "                   <div class=\"\">\r\n" +
                        "                        <div class=\"col-md-3\" style=\"margin-top:20px;padding-left: 0px;\">\r\n" +
                        "                       <lable>" + WebLanguage.GetLanguage(OSiteParam, "Số bản ghi:") + " " + RetPaging.EndIndex + "" + "/ " + "" + countDanhMucQuanHuyen + "</lable>\r\n" +
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

                       "      <div style=\"max-height: calc(100vh - 210px); overflow-y:scroll;overflow-x: hidden; white-space: nowrap;\"> \r\n" +
                        //max-height: calc(100vh - 210px); overflow-y:scroll; overflow-x: hidden; white-space: nowrap;
                        "            <div class=\"col-xs-12 col-sm-12 col-md-12\"> \r\n" +
                        "                  <div class=\"form-group\">\r\n" +
                        "                       <label>" + WebLanguage.GetLanguage(OSiteParam, "Mã Quận Huyện  ") + " <span style='color:red'>*</span></label>\r\n" +
                        "                       <input id=\"txtMa\" type=\"text\" placeholder=\"Mã Quận Huyện\" class=\"form-control\" required>\r\n" +
                        "                  </div>\r\n" +
                        "            </div>\r\n" +

                        "            <div class=\"col-xs-12 col-sm-12 col-md-12\">\r\n" +
                        "                  <div class=\"form-group\">\r\n" +
                        "                       <label>" + WebLanguage.GetLanguage(OSiteParam, "Tên Quận Huyện ") + " <span style='color:red'>*</span></label>\r\n" +
                        "                       <input id=\"txtTen\" type=\"text\" placeholder=\"Tên Quận Huyện\" class=\"form-control\" required>\r\n" +
                        "                  </div>\r\n" +
                        "            </div>\r\n" +

                        "            <div class=\"col-xs-12 col-sm-12 col-md-12\">\r\n" +
                        "                  <div class=\"form-group\">\r\n" +
                        "                       <label>" + WebLanguage.GetLanguage(OSiteParam, "Mã BYT") + "<span style='color:red'>*</span></label>\r\n" +
                        "                       <input id=\"txtMaBCBYT\" type=\"text\" placeholder=\"Mã BCBYT\" class=\"form-control\" >\r\n" +
                        "                  </div>\r\n" +
                        "            </div>\r\n" +

                        "           <div class=\"col-xs-12 col-sm-12 col-md-12\">\r\n" +
                        "                <div class=\"form-group\">\r\n" +
                        "                     <label for=\"inputSubject\">" + WebLanguage.GetLanguage(OSiteParam, "Tỉnh Thành") + " <span style='color:red'>*</span></label>\r\n" +
                        "                     <div>" +
                        "                          <select id=\"drpTinhThanh\" placeholder=\"click for selection\"style=\"width: 100%;\"  class=\"form-control select2\" required></select>\r\n" +
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


                        "            <div class=\"col-xs-12 col-sm-12 col-md-12\">\r\n" +
                        "                 <div class=\"form-group\">\r\n" +
                        "                      <label>" + WebLanguage.GetLanguage(OSiteParam, "Mô Tả:") + "</label>\r\n" +
                        "                      <textarea class=\"form-control\" id=\"txtMoTa\" rows=\"4\"></textarea>\r\n" +
                        "                 </div>\r\n" +
                        "            </div>\r\n" +



                        "      <div class=\"ol-xs-12 col-sm-12 col-md-12\" >\r\n" +

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
                DanhMucQuanHuyenCls ODanhMucQuanHuyen = CallBussinessUtility.CreateBussinessProcess().CreateDanhMucQuanHuyenProcess().CreateModel(ORenderInfo, Id);
                //--------
                DanhMucTinhThanhCls ODanhMucTinhThanh = null;
                if (!string.IsNullOrEmpty(ODanhMucQuanHuyen.TinhThanhID))
                    ODanhMucTinhThanh = CallBussinessUtility.CreateBussinessProcess().CreateDanhMucTinhThanhProcess().CreateModel(ORenderInfo, ODanhMucQuanHuyen.TinhThanhID);
                //var setTenQG = ODanhMucTinhThanh.Ten;
                // Dùng để sét giá trị hiện có cho combobox đơn vị hành chính
                var setValueTinhThanh = ODanhMucTinhThanh != null ? string.Format("<option value=\"{0}\">{1}({2})</option>", ODanhMucTinhThanh.ID, ODanhMucTinhThanh.Ten, ODanhMucTinhThanh.Ma) : string.Empty;
                //--
                if (ODanhMucQuanHuyen == null) throw new Exception(WebLanguage.GetLanguage(OSiteParam, "Đơn vị hành chính đã bị xóa hoặc không tìm thấy"));

                string Html =
                        "  <form id=\"sendmail\" data-async  method=\"post\" role=\"form\" onSubmit=\"return false;\" class=\"contactForm\">\r\n" +

                        "        <div style=\"max-height: calc(100vh - 210px); overflow-y:scroll;overflow-x: hidden; white-space: nowrap;\">" +

                        "               <div class=\"col-xs-12 col-sm-12 col-md-12\">\r\n" +
                        "                    <div class=\"form-group\">\r\n" +
                        "                        <label for=\"inputTo\">" + WebLanguage.GetLanguage(OSiteParam, "Mã Quận Huyện ") + " <span style='color:red'>*</span></label>\r\n" +
                        "                        <input id=\"txtMa\" type=\"text\" placeholder=\"Mã \" class=\"form-control\" value=\"" + ODanhMucQuanHuyen.Ma + "\" required>\r\n" +
                        "                    </div>\r\n" +
                        "               </div>\r\n" +

                        "               <div class=\"col-xs-12 col-sm-12 col-md-12\">\r\n" +
                        "                   <div class=\"form-group\">\r\n" +
                        "                       <label for=\"inputSubject\">" + WebLanguage.GetLanguage(OSiteParam, "Tên Quận Huyện ") + " <span style='color:red'>*</span></label>\r\n" +
                        "                       <input id=\"txtTen\" type=\"text\" placeholder=\"Tên\" class=\"form-control\" value=\"" + ODanhMucQuanHuyen.Ten + "\" required>\r\n" +
                        "                   </div>\r\n" +
                        "               </div>\r\n" +

                        "               <div class=\"col-xs-12 col-sm-12 col-md-12\">\r\n" +
                        "                   <div class=\"form-group\">\r\n" +
                        "                       <label for=\"inputSubject\">" + WebLanguage.GetLanguage(OSiteParam, "Mã BCBYT") + " </label>\r\n" +
                        "                       <input id=\"txtMaBCBYT\" type=\"text\" placeholder=\"Mã BCBYT\" class=\"form-control\" value=\"" + ODanhMucQuanHuyen.MaBCBYT + "\" >\r\n" +
                        "                   </div>\r\n" +
                        "               </div>\r\n" +

                        "           <div class=\"col-xs-12 col-sm-12 col-md-12\">\r\n" +
                        "                <div class=\"form-group\">\r\n" +
                        "                     <label for=\"inputSubject\">" + WebLanguage.GetLanguage(OSiteParam, "Tỉnh Thành ") + " <span style='color:red'>*</span></label>\r\n" +
                        "                     <div>" +
                        "                          <select id=\"drpTinhThanh\" style=\"width: 100%;\"  class=\"form-control select2\" required>" + setValueTinhThanh + "</select>\r\n" +
                        "                     </div>\r\n" +
                        "                </div>\r\n" +
                        "           </div>\r\n" +



                        "               <div class=\"col-xs-12 col-sm-12 col-md-12\">\r\n" +
                        "                   <div class=\"form-group\">\r\n" +
                        "                       <label for=\"inputSubject\">" + WebLanguage.GetLanguage(OSiteParam, "Số thứ tự") + "<span style='color:red'>*</span></label>\r\n" +
                        "                       <input id=\"nbSTT\" type=\"number\" min=\"0\" max=\"999999999\" onkeypress=\"checkCurrency(event);\" class=\"form-control\" value=\"" + ODanhMucQuanHuyen.STT + "\" required>\r\n" +
                        "                   </div>\r\n" +
                        "               </div>\r\n" +


                        "               <div class=\"col-xs-12 col-sm-12 col-md-12\" id=\"rdHieuLuc\">\r\n" +
                        "                   <div class=\"form-group\"> " +
                        "                       <label for=\"inputSubject\">" + WebLanguage.GetLanguage(OSiteParam, "Trạng thái") + "</label>\r\n" +
                        "                       <div> \r\n" +
                        "                             <label class=\"radio-inline\"><input  id = \"optradioHl0\" type = \"radio\" name=\"optradioHl\" value=\"" + (int)OneFRAME.Model.Common.eHieuLuc.Co + "\" " + (ODanhMucQuanHuyen.HieuLuc == (int)Common.eHieuLuc.Co ? "checked" : "") + "      >" + OneFRAME.Model.Helper.HieuLuc.Co + "</label> " + // common file  time 2
                        "                             <label class=\"radio-inline\"><input  id = \"optradioHl1\" type = \"radio\" name=\"optradioHl\" value=\"" + (int)OneFRAME.Model.Common.eHieuLuc.Khong + "\"" + (ODanhMucQuanHuyen.HieuLuc == (int)Common.eHieuLuc.Khong ? "checked" : "") + ">" + OneFRAME.Model.Helper.HieuLuc.Khong + "</label> " + //common file
                        "                       </div> " +
                        "                   </div> " +
                        "               </div>\r\n" +
                         

                        "               <div class=\"col-xs-12 col-sm-12 col-md-12\">\r\n" +
                        "                   <div class=\"form-group\">\r\n" +
                        "                       <label for=\"inputBody\">" + WebLanguage.GetLanguage(OSiteParam, "Mô Tả") + ":</label>\r\n" +
                        "                       <textarea class=\"form-control\" id=\"txtMoTa\" rows=\"4\">" + ODanhMucQuanHuyen.MoTa + "</textarea>\r\n" +
                        "                   </div>\r\n" +
                        "               </div>\r\n" +



                        "      <div class=\"col-xs-12 col-sm-12 col-md-12\" >\r\n" +

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
        public static AjaxOut ServerSideAdd(RenderInfoCls ORenderInfo, QuanHuyen param)
        {
            AjaxOut RetAjaxOut = new AjaxOut();
            try
            {
                SiteParam
                    OSiteParam = WebEnvironments.CreateSiteParam(ORenderInfo);
                WebSession.CheckSessionTimeOut(ORenderInfo);
                var ODMQuanHuyenExist = CallBussinessUtility.CreateBussinessProcess().CreateDanhMucQuanHuyenProcess().CreateModel(ORenderInfo, param.Ma);
                if (ODMQuanHuyenExist != null)
                {
                    throw new Exception("Mã Hoặc Đã Tồn Tại ");
                }//------- check mã thêm 
                DanhMucQuanHuyenCls
                ODanhMucQuanHuyen = new DanhMucQuanHuyenCls();
                ODanhMucQuanHuyen.ID = Guid.NewGuid().ToString();
                ODanhMucQuanHuyen.Ma = param.Ma;
                ODanhMucQuanHuyen.Ten = param.Ten;
                ODanhMucQuanHuyen.MoTa = param.MoTa;
                ODanhMucQuanHuyen.TinhThanhID = param.TinhThanhID;
                ODanhMucQuanHuyen.MaBCBYT = param.MaBCBYT;
                //int temp;
                ODanhMucQuanHuyen.HieuLuc = int.TryParse(param.HieuLuc, out int temp) ? temp : 0;
                ODanhMucQuanHuyen.NgayTao = DateTime.Now;
                ODanhMucQuanHuyen.NgayHieuLuc = param.NgayHieuLuc;
                ODanhMucQuanHuyen.NgayHetHieuLuc = param.NgayHetHieuLuc;
                ODanhMucQuanHuyen.STT = int.TryParse(param.STT, out temp) ? temp : 0;


                CallBussinessUtility.CreateBussinessProcess().CreateDanhMucQuanHuyenProcess().Add(ORenderInfo, ODanhMucQuanHuyen);
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
        public static AjaxOut ServerSideUpdate(RenderInfoCls ORenderInfo, QuanHuyen param, string Id)
        {
            AjaxOut RetAjaxOut = new AjaxOut();
            try
            {
                SiteParam OSiteParam = WebEnvironments.CreateSiteParam(ORenderInfo);
                WebSession.CheckSessionTimeOut(ORenderInfo);

                //CallBussinessUtility.CreateBussinessProcess().CreateDanhMucQuanHuyenProcess().CheckTheCode(ORenderInfo, Id, Ma);
                //int temp;
                DanhMucQuanHuyenCls
                 ODanhMucQuanHuyen = CallBussinessUtility.CreateBussinessProcess().CreateDanhMucQuanHuyenProcess().CreateModel(ORenderInfo, Id);
                if (ODanhMucQuanHuyen == null) throw new Exception("Đơn vị này đã bị xóa hoặc không tìm thấy");
                if (ODanhMucQuanHuyen.Ma != param.Ma)
                {
                    var ODMQuanHuyenExist = CallBussinessUtility.CreateBussinessProcess().CreateDanhMucQuanHuyenProcess().CreateModel(ORenderInfo, param.Ma);
                    if (ODMQuanHuyenExist != null)
                    {
                        throw new Exception("Mã Đã Tồn Tại");
                    }
                }//---- check mã sửa
                ODanhMucQuanHuyen.ID = Id;
                ODanhMucQuanHuyen.Ma = param.Ma;
                ODanhMucQuanHuyen.Ten = param.Ten;
                ODanhMucQuanHuyen.MoTa = param.MoTa;
                ODanhMucQuanHuyen.TinhThanhID = param.TinhThanhID;
                ODanhMucQuanHuyen.MaBCBYT = param.MaBCBYT;
                ODanhMucQuanHuyen.HieuLuc = int.TryParse(param.HieuLuc, out int temp) ? temp : 0;
                ODanhMucQuanHuyen.NgayTao = DateTime.Now;
                ODanhMucQuanHuyen.NgayHieuLuc = param.NgayHieuLuc;
                ODanhMucQuanHuyen.NgayHetHieuLuc = param.NgayHetHieuLuc;
                ODanhMucQuanHuyen.STT = int.TryParse(param.STT, out temp) ? temp : 0;

                ODanhMucQuanHuyen.GhiChu = param.GhiChu;
                CallBussinessUtility.CreateBussinessProcess().CreateDanhMucQuanHuyenProcess().Save(ORenderInfo, Id, ODanhMucQuanHuyen);

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
                CallBussinessUtility.CreateBussinessProcess().CreateDanhMucQuanHuyenProcess().Delete(ORenderInfo, Id);
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
        [AjaxPro.AjaxMethod(AjaxPro.HttpSessionStateRequirement.ReadWrite)]
        public static AjaxOut ServerSidePrint(RenderInfoCls ORenderInfo)
        {
            AjaxOut RetAjaxOut = new AjaxOut();
            try
            {
                FlexCelReport flexCelReport = new FlexCelReport();

                List<QuanHuyenView> Datas = new List<QuanHuyenView>();

                SiteParam
                      OSiteParam = WebEnvironments.CreateSiteParam(ORenderInfo);
                WebSession.CheckSessionTimeOut(ORenderInfo);

                DanhMucQuanHuyenFilterCls ODanhMucQuanHuyen = new DanhMucQuanHuyenFilterCls();



                DanhMucQuanHuyenCls[] ODanhMucQuanHuyens = CallBussinessUtility.CreateBussinessProcess().CreateDanhMucQuanHuyenProcess().Reading(ORenderInfo, ODanhMucQuanHuyen);

                for (int i = 0; i < ODanhMucQuanHuyens.Length; i++)
                {
                    #region data



                    #endregion
                    var view = new QuanHuyenView();
                    view.Ma = ODanhMucQuanHuyens[i].Ma;
                    view.Ten = ODanhMucQuanHuyens[i].Ten;
                    view.STT = ODanhMucQuanHuyens[i].STT.ToString();
                    string HieuLuc = ODanhMucQuanHuyens[i].HieuLuc.ToString();
                    if (ODanhMucQuanHuyens[i].HieuLuc == 1)
                    {
                        view.HieuLuc = Helper.HieuLuc.Co;
                    }
                    else
                    {
                        view.HieuLuc = Helper.HieuLuc.Khong;
                    }

                    view.HieuLuc = ODanhMucQuanHuyens[i].HieuLuc.ToString();
                    view.GhiChu = ODanhMucQuanHuyens[i].GhiChu;
                    Datas.Add(view);
                }
                flexCelReport.AddTable("DanhMucQuanHuyen", Datas);

                //flexCelReport.SetValue("NgayLap", DateTime.Now);

                string XmlFile = OSiteParam.PathRoot + "\\ReportTemplates\\DanhMucQuanHuyen.xlsx";

                string Id = "DanhMucQuanHuyen_" + DateTime.Now.ToString("yyyy_MM_dd") + ".xlsx";
                string LoginName = WebSessionUtility.GetCurrentLoginUser(OSiteParam).LoginName;
                string Directoryfile = WebConfig.ConvertPathRoot(OSiteParam, OSiteParam.TempPathRoot);
                string SaveFile = WebConfig.ConvertPathRoot(OSiteParam, Directoryfile + "\\" + Id);
                //FlexCelReport ExcelReport = null;
                if (!System.IO.Directory.Exists(Directoryfile))
                    System.IO.Directory.CreateDirectory(Directoryfile);
                //workbook.SaveToFile(SaveFile, ExcelVersion.Version2007);
                RetAjaxOut = new OneFRAME.ReportUtility.FlexcelReportUtility().ExportEx(ORenderInfo, LoginName, XmlFile, "DM_HANGDOI", flexCelReport, SaveFile);
            }
            catch (Exception ex)
            {
                RetAjaxOut.Error = true;
                RetAjaxOut.InfoMessage = ex.Message.ToString();
                RetAjaxOut.HtmlContent = ex.Message.ToString();
            }
            return RetAjaxOut;
        }

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

        public sealed class QuanHuyenView
        {
            public string Ma { get; set; }
            public string Ten { get; set; }
            public string HieuLuc { get; set; }
            public string GhiChu { get; set; }
            public string STT { get; set; }
        }


        #endregion
    }


    public class QuanHuyen
    {
        public string Ma;
        public string Ten;
        public string MaBCBYT;
        public string MoTa;
        public string TinhThanhID;
        public string VungID;
        public string HieuLuc;
        public DateTime NgayHieuLuc;
        public DateTime NgayHetHieuLuc;
        public string GhiChu;
        public string STT;
    }
}



