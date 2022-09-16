using OneFRAME.Bussiness.Utility;
using OneFRAME.Call.Bussiness.Utility;
using OneFRAME.Core.Model;using OneFRAME.Model;
using OneFRAME.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneFRAME.WebParts
{
    public class Unit : WebPartTemplate
    {
        public override string WebPartId
        {
            get
            {
                return "Unit";
            }
        }

        public override string WebPartTitle
        {
            get
            {
                return "Danh mục đơn vị tính";
            }
        }

        public override string Description
        {
            get
            {
                return "Danh mục đơn vị tính";
            }
        }
        public override string divFilter
        {
            get
            {
                return "<div class=\"col-md-5\" style=\"padding-top:12px\"><select id=\"drpSelectTimKiem\" onchange=\"javascript:FilterSearch(this);\" style =\"width:100%;\"  data-placeholder=\"Tìm kiếm...\" class=\"form-control select2\" tabindex=\"1\"></select></div>\r\n";
            }
        }
        public override void RegAjaxPro(SiteParam OSiteParam, System.Web.UI.Page Page)
        {
            AjaxPro.Utility.RegisterTypeForAjax(typeof(Unit), Page);
        }

        public override AjaxOut CheckPermission(RenderInfoCls ORenderInfo)
        {
            SiteParam OSiteParam = WebEnvironments.CreateSiteParam(ORenderInfo);
            string UserId = WebSessionUtility.GetCurrentLoginUser(OSiteParam).OwnerUserId;
            bool HasPermission = true;// WebPermissionUtility.CheckPermission(OSiteParam, DictionaryPermission.StaticPermissionFunctionId, "Access", DictionaryPermission.StaticPermissionFunctionCode, DictionaryPermission.StaticPermissionFunctionId, UserId, false);
            AjaxOut RetAjaxOut = new AjaxOut();
            RetAjaxOut.RetBoolean = HasPermission;

            return RetAjaxOut;
        }

        public override AjaxOut Draw(SiteParam OSiteParam, RenderInfoCls ORenderInfo)
        {
            AjaxOut RetAjaxOut = new AjaxOut();
            try
            {
                AjaxOut RetAjaxOutCheckPermission = CheckPermission(ORenderInfo);
                if (RetAjaxOutCheckPermission.RetBoolean == false)
                {
                    RetAjaxOut.HtmlContent = WebScreen.GetPanelInfo(OSiteParam, WebLanguage.GetLanguage(OSiteParam, "Không có quyền truy cập tính năng này"), false);
                    return RetAjaxOut;
                }
                RetAjaxOut.HtmlContent =
                    WebEnvironments.ProcessJavascript(
                    "<script language=javascript>\r\n" +
                    "   var EditMode='view';\r\n"+
                    "   function ShowEditItemLine(UnitId)\r\n" +
                    "   {\r\n" +
                    "       RenderInfo=CreateRenderInfo();\r\n" +
                    "       if(EditMode!='view')return;\r\n"+
                    "       EditMode='edit';\r\n" +
                    "       $('.CssEditorItem').hide();\r\n"+
                    "       $('.CssDisplayItem').show();\r\n" +
                    "       document.getElementById('trNewRow').style.display='none';\r\n" +

                    "       document.getElementById('txtUnitCode'+UnitId).style.display='block';\r\n" +
                    "       document.getElementById('spanUnitCode'+UnitId).style.display='none';\r\n" +
                    
                    "       document.getElementById('txtUnitName'+UnitId).style.display='block';\r\n" +
                    //"       document.getElementById('spanUnitName'+UnitId).style.display='none';\r\n" +
                    
                    "       CallInitSelect2('txtUnitName'+UnitId);\r\n"+
                    "       document.getElementById('txtUnitCode'+UnitId).select();\r\n"+
                    "       document.getElementById('txtUnitCode'+UnitId).focus();\r\n" +
                    "   }\r\n" +

                    "   function CallAddForm()\r\n" +
                    "   {\r\n" +
                    "       RenderInfo=CreateRenderInfo();\r\n" +
                    "       if(EditMode!='view')return;\r\n" +
                    "       EditMode='add';\r\n"+
                    "       $('.CssEditorItem').hide();\r\n" +
                    "       $('.CssDisplayItem').show();\r\n" +
                    "       $('.CssEditButtonItem').hide();\r\n" +
                    "       document.getElementById('trNewRow').style.display='table-row';\r\n" +
                    "       document.getElementById('txtUnitCode').value='';\r\n"+
                    "       document.getElementById('txtUnitName').value='';\r\n" +
                    "       document.getElementById('txtUnitCode').focus();\r\n"+
                    //"       $('#myTable').append('<tr><td></td><td>Code</td><td>Name</td><td>Active</td><td></td><td></td></tr>');\r\n" +

                    //"       AjaxOut = OneFRAME.WebParts.Unit.ServerSideDrawAddForm(RenderInfo).value;\r\n" +
                    //"       document.getElementById('divActionForm').innerHTML=AjaxOut.HtmlContent;\r\n" +
                    //"       document.getElementById('divActionForm').style.display='block';\r\n" +
                    //"       document.getElementById('divListForm').style.display='none';\r\n" +
                    //"       document.getElementById('txtUnitCode').focus();\r\n" +
                    "   }\r\n" +

                    "   function CallSaveItem(UnitId)\r\n" +
                    "   {\r\n" +
                    "       RenderInfo=CreateRenderInfo();\r\n" +


                    "       UnitCode = document.getElementById('txtUnitCode'+UnitId).value;\r\n" +
                    "       UnitName = document.getElementById('txtUnitName'+UnitId).value;\r\n" +
                    "       SortIndex = '1';\r\n"+
                    "       Active = 1;\r\n"+
                    "       AjaxOut = OneFRAME.WebParts.Unit.ServerSideUpdate(RenderInfo, UnitId, UnitCode, UnitName, SortIndex, Active).value;\r\n" +
                    "       if(AjaxOut.Error)\r\n" +
                    "       {\r\n" +
                    "           callSweetAlert(AjaxOut.InfoMessage);\r\n" +
                    "           return;\r\n" +
                    "       }\r\n" +


                    "       $('.CssEditorItem').hide();\r\n" +
                    "       $('.CssDisplayItem').show();\r\n" +
                    "       document.getElementById('spanUnitCode'+UnitId).innerHTML=UnitCode;\r\n" +
                    "       document.getElementById('spanUnitName'+UnitId).innerHTML=UnitName;\r\n" +

                    "       EditMode='view';\r\n" +
                    "   }\r\n" +


                    "   function CallUpdateForm(UnitId)\r\n" +
                    "   {\r\n" +
                    "       RenderInfo=CreateRenderInfo();\r\n" +
                    "       AjaxOut = OneFRAME.WebParts.Unit.ServerSideDrawUpdateForm(RenderInfo, UnitId).value;\r\n" +
                    "       document.getElementById('divActionForm').innerHTML=AjaxOut.HtmlContent;\r\n" +
                    "       document.getElementById('divActionForm').style.display='block';\r\n" +
                    "       document.getElementById('divListForm').style.display='none';\r\n" +
                    "       document.getElementById('txtUnitCode').focus();\r\n" +
                    "   }\r\n" +

                    "   function CallBack()\r\n" +
                    "   {\r\n" +
                    "       document.getElementById('divActionForm').innerHTML='';\r\n" +
                    "       document.getElementById('divActionForm').style.display='none';\r\n" +
                    "       document.getElementById('divListForm').style.display='block';\r\n" +
                    "   }\r\n" +

                    "   function CallActionAdd()\r\n" +
                    "   {\r\n" +
                    "       RenderInfo=CreateRenderInfo();\r\n" +
                    "       UnitCode = document.getElementById('txtUnitCode').value;\r\n" +
                    "       UnitName = document.getElementById('txtUnitName').value;\r\n" +
                    "       SortIndex = document.getElementById('txtSortIndex').value;\r\n" +
                    "       Active = parseInt(document.getElementById('drpSelectActive').value,10);\r\n" +
                    "       AjaxOut = OneFRAME.WebParts.Unit.ServerSideAdd(RenderInfo, UnitCode, UnitName, SortIndex, Active).value;\r\n" +
                    "       if(AjaxOut.Error)\r\n" +
                    "       {\r\n" +
                    "           callSweetAlert(AjaxOut.InfoMessage);\r\n" +
                    "           return;\r\n" +
                    "       }\r\n" +
                    "       CallReading();\r\n" +
                    "       document.getElementById('txtUnitCode').value='';\r\n" +
                    "       document.getElementById('txtUnitName').value='';\r\n" +
                    "       document.getElementById('txtUnitCode').focus();\r\n" +
                    "       document.getElementById('txtSortIndex').value=parseInt(SortIndex,10)+1;\r\n" +
                    "   }\r\n" +


                    "   function CallActionUpdate(UnitId)\r\n" +
                    "   {\r\n" +
                    "       RenderInfo=CreateRenderInfo();\r\n" +
                    "       UnitCode = document.getElementById('txtUnitCode').value;\r\n" +
                    "       UnitName = document.getElementById('txtUnitName').value;\r\n" +
                    "       SortIndex = document.getElementById('txtSortIndex').value;\r\n" +
                    "       Active = parseInt(document.getElementById('drpSelectActive').value,10);\r\n" +
                    "       AjaxOut = OneFRAME.WebParts.Unit.ServerSideUpdate(RenderInfo, UnitId, UnitCode, UnitName, SortIndex, Active).value;\r\n" +
                    "       if(AjaxOut.Error)\r\n" +
                    "       {\r\n" +
                    "           callSweetAlert(AjaxOut.InfoMessage);\r\n" +
                    "           return;\r\n" +
                    "       }\r\n" +
                    "       CallReading();\r\n" +
                    "       CallBack();\r\n" +
                    "   }\r\n" +

                    "   function CallActionDelete(UnitId)\r\n" +
                    "   {\r\n" +
                    "       RenderInfo=CreateRenderInfo();\r\n" +

                    "       swal({ \r\n" +
                    "               title: \"" + WebLanguage.GetLanguageConfirmDelete(OSiteParam) + "\", \r\n" +
                    "               text: \"" + WebLanguage.GetLanguage(OSiteParam, "Đang thực hiện xóa đơn vị tính này ra khỏi hệ thống") + "!\", \r\n" +
                    "               type: \"warning\", \r\n" +
                    "               showCancelButton: true, \r\n" +
                    "               confirmButtonColor: \"#DD6B55\", \r\n" +
                    "               confirmButtonText: \"" + WebLanguage.GetLanguage(OSiteParam, "Thực hiện xóa") + "\", \r\n" +
                    "               cancelButtonText: \"" + WebLanguage.GetLanguage(OSiteParam, "Hủy bỏ") + "\", \r\n" +
                    "               closeOnConfirm: false \r\n" +
                    "           }, function () { \r\n" +


                    "           AjaxOut = OneFRAME.WebParts.Unit.ServerSideDelete(RenderInfo, UnitId).value;\r\n" +
                    "           if(AjaxOut.Error)\r\n" +
                    "           {\r\n" +
                    "               callSweetAlert(AjaxOut.InfoMessage);\r\n" +
                    "               return;\r\n" +
                    "           }\r\n" +
                    "           CallReading();\r\n" +

                    "           swal(\"" + WebLanguage.GetLanguage(OSiteParam, "Đã xóa") + "!\", \"" + WebLanguage.GetLanguage(OSiteParam, "đơn vị tính đã được xóa thành công!") + ".\", \"success\"); \r\n" +
                    "       }); \r\n" +

                    "   }\r\n" +


                    "   function CallReading()\r\n" +
                    "   {\r\n" +
                    "       CurrentPageIndex=0;\r\n"+
                    "       document.getElementById('divProcessing').innerHTML='" + WebLanguage.GetLanguageProcessing(OSiteParam) + "';\r\n" +
                    "       setTimeout('RealCallReading()',10);\r\n" +
                    "   }\r\n" +

                    "   CurrentPageIndex=0;\r\n"+

                    "   function NextPage(PageIndex)\r\n" +
                    "   {\r\n" +
                    "       CurrentPageIndex=PageIndex;\r\n"+
                    "       setTimeout('RealCallReading()',10);\r\n"+
                    "   }\r\n" +

                    "   function RealCallReading()\r\n" +
                    "   {\r\n" +
                    "       RenderInfo=CreateRenderInfo();\r\n" +
                    "       Keyword = document.getElementById('txtKeyword').value;\r\n" +
                    "       OneFRAME.WebParts.Unit.ServerSideDrawSearchResult(RenderInfo, Keyword, CurrentPageIndex, CallBackReading);\r\n" +
                    "   }\r\n" +

                    "   function CallBackReading(res)\r\n" +
                    "   {\r\n" +
                    "       AjaxOut = res.value;\r\n" +
                    "       document.getElementById('divProcessing').innerHTML='';\r\n" +
                    "       document.getElementById('divUnitContent').innerHTML=AjaxOut.HtmlContent;\r\n" +
                    "   }\r\n" +


                    " function formatRepo(repo) { \r\n"+
                    "    if (repo.loading) return repo.text; \r\n"+
                    "    var markup = '<table style=\"width:100%\"><tr><td style=\"width:50px\"><img src=\"https://cdn2.iconfinder.com/data/icons/medical-icons-110/512/medical_icon_5-128.png\" style=\"height:48px\"/></td> <td style=\"width:100px;padding:4px;color:maroon;font-weight:bold\">'+ repo.UnitCode+'</td> <td style=\"padding:4px\">'+repo.UnitName+'</td></tr></table>'; \r\n" +
                    "    return markup; \r\n"+
                    "} \r\n"+

                    " function formatRepoSelection(repo) { \r\n"+
                    "    return repo.text || repo.text; \r\n"+
                    " } \r\n" +

                    " function CallInitSelect2(Id)\r\n"+
                    " {\r\n"+
                    "  $(\"#\"+Id).select2({ \r\n" +
                    "        ajax: { \r\n"+
                    "            id: function (e) { return e.id + \"|\" + e.text },  \r\n"+
                    "            url: \"" + WebEnvironments.GetRemoteProcessDataUrl(OwnerUserService.StaticServiceId) + "\", \r\n" +
                    "            dataType: 'json', \r\n"+
                    "            delay: 250, \r\n"+
                    "            type: 'POST',  \r\n"+
                    "            data: function (params) { \r\n"+
                    "                return { \r\n"+
                    "                    q: params.term,  \r\n"+
                    "                    page: params.page \r\n"+
                    "                }; \r\n"+
                    "            }, \r\n"+
                    "            processResults: function (data, params) { \r\n"+
                    "                params.page = params.page || 1; \r\n"+
                    "                return { \r\n"+
                    "                    results: data.items, \r\n"+
                    "                    pagination: { \r\n"+
                    "                        more: (params.page * 30) < data.total_count \r\n"+
                            
                    "                    } \r\n"+
                    "                }; \r\n"+
                    "            }, \r\n"+
                    "            cache: true \r\n"+
                    "        }, \r\n"+
                    "        escapeMarkup: function (markup) { return markup; },  \r\n"+
                    "        minimumInputLength: 0, \r\n"+
            
                    "        templateResult: formatRepo,  \r\n"+
                    "        templateSelection: formatRepoSelection  \r\n"+
                    "    }); \r\n" +
                    " }\r\n"+

                    " CallInitSelect2();\r\n"+
                    "</script>\r\n") +
                    WebEnvironments.ProcessHtml(
                        "<div id=\"divListForm\">\r\n" +
                        " <div class=\"ibox float-e-margins\"> \r\n" +
                        "     <div class=\"ibox-title\"> \r\n" +
                        "         <h5>" + WebLanguage.GetLanguage(OSiteParam, "Danh mục đơn vị tính") + " </h5> \r\n" +
                        "     </div> \r\n" +
                        "     <div class=\"ibox-content\"> \r\n" +
                        "         <div class=\"row\"> \r\n" +
                        "             <div class=\"col-sm-12\"> \r\n" +
                        "                 <div style=\"margin-bottom:5px\">" + WebLanguage.GetLanguage(OSiteParam, "Từ khóa lọc") + "</div>\r\n" +
                        "                 <div><input onkeypress=\"if(event.keyCode==13){CallReading();}\"  id=\"txtKeyword\" type=\"textbox\" placeholder=\"" + WebLanguage.GetLanguage(OSiteParam, "Điền từ khóa tìm kiếm") + "\" class=\"input-sm form-control\"></div>\r\n" +
                        "                 <div>\r\n" +
                        "                       <button onclick=\"javascript:CallReading();\" type=\"button\" class=\"btn btn-sm btn-primary mr-5px\"> " + WebLanguage.GetLanguage(OSiteParam, "Lọc") + "</button>\r\n" +
                        "                       <button type=\"button\" class=\"btn btn-sm btn-primary\" onclick=\"javascript:CallAddForm();\"> " + WebLanguage.GetLanguage(OSiteParam, "Thêm") + "</button>\r\n" +
                        "                 </div> \r\n" +
                        "             </div> \r\n" +
                        "         </div> \r\n" +
                        "         <div id=\"divProcessing\" class=\"processing\"></div>\r\n" +
                        "               <div id=\"divUnitContent\">" + ServerSideDrawSearchResult(ORenderInfo, "", 0).HtmlContent + "</div>\r\n" +
                        "         </div> \r\n" +
                        "     </div> \r\n" +
                        " </div> \r\n" +

                        "</div>\r\n" +
                        "<div id=\"divActionForm\" style=\"display:none\"></div>\r\n"
                        );


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
        public static AjaxOut ServerSideDrawSearchResult(
            RenderInfoCls ORenderInfo, 
            string Keyword,
            int CurrentPageIndex)
        {
            AjaxOut RetAjaxOut = new AjaxOut();
            try
            {
                SiteParam
                    OSiteParam = WebEnvironments.CreateSiteParam(ORenderInfo);
                WebSession.CheckSessionTimeOut(ORenderInfo);

                UnitFilterCls
                    OUnitFilter = new UnitFilterCls();
                OUnitFilter.Keyword = Keyword;
                OUnitFilter.PageSize=1;
                OUnitFilter.PageIndex=CurrentPageIndex;

                string OwnerCode = WebSessionUtility.GetCurrentLoginUser(OSiteParam).OwnerCode;
                UnitCls[] 
                    Units = CallBussinessUtility.CreateBussinessProcess().CreateUnitProcess().Reading(ORenderInfo, OUnitFilter);
                
                string Html = "";
                if (Units.Length == 0)
                {
                    Html += WebScreen.GetPanelInfo(OSiteParam, "Không có dữ liệu theo điều kiện lọc", true);
                }
                else
                {
                    ReturnPaging
                        OReturnPaging = WebPaging.GetPaging(Units.Length, CurrentPageIndex, 25, 10, "NextPage");
                    Html +=
                        "   <div class=\"search-result-info\">" + WebLanguage.GetLanguage(OSiteParam, "Tìm thấy") + " (" + Units.Length.ToString("#,##0") + ") " + WebLanguage.GetLanguage(OSiteParam, "dữ liệu theo điều kiện lọc") + "</div>\r\n" +
                        "         <div class=\"table-responsive\"> \r\n" +
                        OReturnPaging.PagingText+
                        "             <table class=\"table table-striped\" id=\"myTable\"> \r\n" +
                        "                 <thead> \r\n" +
                        "                 <tr> \r\n" +
                        "                     <th class=\"th-func-20\"></th> \r\n" +
                        "                     <th style=\"width:120px\">" + WebLanguage.GetLanguage(OSiteParam, "Mã") + " </th> \r\n" +
                        "                     <th>" + WebLanguage.GetLanguage(OSiteParam, "Tên đơn vị tính") + " </th> \r\n" +
                        "                     <th>" + WebLanguage.GetLanguage(OSiteParam, "Trạng thái") + " </th> \r\n" +
                        "                     <th class=\"th-func-20\"></th> \r\n" +
                        "                     <th class=\"th-func-20\"></th> \r\n" +
                        "                 </tr> \r\n" +
                        "                 </thead> \r\n" +
                        "                 <tbody> \r\n" +

                        "                 <tr id=\"trNewRow\" style=\"display:none\"> \r\n" +
                        "                     <td class=\"td-right\">6</td> \r\n" +
                        "                     <td style=\"color:maroon;font-size:12;font-weight:bold\"><input class=\"form-control\" id=\"txtUnitCode\"></td> \r\n" +
                        "                     <td style=\"color:maroon;font-size:12;font-weight:bold\"><input class=\"form-control\" id=\"txtUnitName\"></td> \r\n" +
                        "                     <td style=\"color:maroon;font-size:12;font-weight:bold\">xxx</td> \r\n" +
                        "                     <td class=\"td-center\">xx</td> \r\n" +
                        "                     <td class=\"td-center\">xx</td> \r\n" +
                        "                 </tr> \r\n";
                    for (int iIndex = OReturnPaging.StartIndex; iIndex < OReturnPaging.EndIndex; iIndex++)
                    {
                        string 
                            Select2Text=
                                "<select style=\"display:none\" multiple id=\"txtUnitName" + Units[iIndex].UnitId + "\" class=\"form-control select2 CssEditorItem\">/select>\r\n";
                        Html +=
                            "                 <tr> \r\n" +
                            "                     <td class=\"td-right\">" + (iIndex + 1).ToString("#,##0") + "</td> \r\n" +
                            "                     <td style=\"color:maroon;font-size:12;font-weight:bold\"><input value=\"" + Units[iIndex].UnitCode+ "\" id=\"txtUnitCode" + Units[iIndex].UnitId + "\" class=\"form-control CssEditorItem\" style=\"display:none\"><span class=\"CssDisplayItem\" style=\"cursor:pointer\" onclick=\"javascript:ShowEditItemLine('" + Units[iIndex].UnitId + "');\" id=\"spanUnitCode" + Units[iIndex].UnitId + "\">" + Units[iIndex].UnitCode + "</span></td> \r\n" +
                            "                     <td style=\"color:maroon;font-size:12;font-weight:bold\">"+Select2Text+"<span class=\"CssDisplayItem\" style=\"cursor:pointer\" onclick=\"javascript:ShowEditItemLine('" + Units[iIndex].UnitId + "');\" id=\"spanUnitName" + Units[iIndex].UnitId + "\">" + Units[iIndex].UnitName + "</span></td> \r\n" +
                            "                     <td>" + (Units[iIndex].Active == 1 ? WebLanguage.GetLanguage(OSiteParam, "Sử dụng") : WebLanguage.GetLanguage(OSiteParam, "Ngưng sử dụng")) + "</td> \r\n" +
                            "                     <td class=\"td-center\"><a class=\"CssEditButtonItem\" title=\"" + WebLanguage.GetLanguage(OSiteParam, "Sửa đơn vị tính") + "\" href=\"javascript:CallSaveItem('" + Units[iIndex].UnitId + "');\"><i class=\"" + WebScreen.GetEditGridIcon() + "\"></i></a></td> \r\n" +
                            "                     <td class=\"td-center\"><a class=\"CssEditButtonItem\" title=\"" + WebLanguage.GetLanguage(OSiteParam, "Xóa đơn vị tính") + "\" href=\"javascript:CallActionDelete('" + Units[iIndex].UnitId + "');\"><i class=\"" + WebScreen.GetDeleteGridIcon() + "\"></i></a></td> \r\n" +
                            "                 </tr> \r\n";
                    }
                    Html +=
                        "                 </tbody> \r\n" +
                        "             </table> \r\n" +
                        OReturnPaging.PagingText +
                        "       </div>\r\n" +
                        "   <script>\r\n" +
                        
                        "   </script>\r\n";
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



        [AjaxPro.AjaxMethod(AjaxPro.HttpSessionStateRequirement.ReadWrite)]
        public static AjaxOut ServerSideDrawAddForm(RenderInfoCls ORenderInfo)
        {
            AjaxOut RetAjaxOut = new AjaxOut();
            try
            {
                SiteParam
                    OSiteParam = WebEnvironments.CreateSiteParam(ORenderInfo);
                WebSession.CheckSessionTimeOut(ORenderInfo);
                string SelectActiveText =
                    "<select id=\"drpSelectActive\" class=\"form-control\">\r\n" +
                    "   <option value=\"0\">" + WebLanguage.GetLanguage(OSiteParam, "Không sử dụng") + "</option>\r\n" +
                    "   <option selected  value=\"1\">" + WebLanguage.GetLanguage(OSiteParam, "Có sử dụng") + "</option>\r\n" +
                    "</select>\r\n";
                string Html =
                       " <div class=\"ibox-content\"> \r\n" +
                       "     <div class=\"row\"> \r\n" +
                       "         <div class=\"col-sm-12\"><h3 class=\"m-t-none m-b\">" + WebLanguage.GetLanguage(OSiteParam, "Thêm mới") + "</h3> \r\n" +
                       "             <div> \r\n" +
                       "                 <div class=\"form-group\"><label>" + WebLanguage.GetLanguage(OSiteParam, "Mã đơn vị tính") + "</label> <input id=\"txtUnitCode\" type=\"textbox\" placeholder=\"" + WebLanguage.GetLanguage(OSiteParam, "Mã đơn vị tính") + "\" class=\"form-control\"></div> \r\n" +
                       "                 <div class=\"form-group\"><label>" + WebLanguage.GetLanguage(OSiteParam, "Tên đơn vị tính") + "</label> <input id=\"txtUnitName\" type=\"textbox\" placeholder=\"" + WebLanguage.GetLanguage(OSiteParam, "Nhập tên đơn vị tính") + "\" class=\"form-control\"></div> \r\n" +
                       "                 <div class=\"form-group\"><label>" + WebLanguage.GetLanguage(OSiteParam, "Thứ tự sắp xếp") + "</label> <input id=\"txtSortIndex\" type=\"textbox\" placeholder=\"" + WebLanguage.GetLanguage(OSiteParam, "Thứ tự sắp xếp") + "\" class=\"form-control\"></div> \r\n" +
                       "                 <div class=\"form-group\"><label>" + WebLanguage.GetLanguage(OSiteParam, "Trạng thái") + "</label> " + SelectActiveText + "</div> \r\n" +
                       "                 <div> \r\n" +
                       "                     <button class=\"btn btn-sm btn-primary m-t-n-xs mr-5px\" type=\"button\" onclick=\"javascript:CallActionAdd();\"><strong>" + WebLanguage.GetLanguage(OSiteParam, "Chấp nhận") + "</strong></button> \r\n" +
                       "                     <button class=\"btn btn-sm btn-primary m-t-n-xs\" type=\"button\" onclick=\"javascript:CallBack();\"><strong>" + WebLanguage.GetLanguage(OSiteParam, "Bỏ qua") + "</strong></button> \r\n" +
                       "                 </div> \r\n" +
                       "             </div> \r\n" +
                       "         </div> \r\n" +
                       "     </div> \r\n" +
                       " </div> \r\n";

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
        public static AjaxOut ServerSideDrawUpdateForm(RenderInfoCls ORenderInfo, string UnitId)
        {
            AjaxOut RetAjaxOut = new AjaxOut();
            try
            {
                SiteParam
                    OSiteParam = WebEnvironments.CreateSiteParam(ORenderInfo);
                WebSession.CheckSessionTimeOut(ORenderInfo);


                UnitCls
                    OUnit = CallBussinessUtility.CreateBussinessProcess().CreateUnitProcess().CreateModel(ORenderInfo, UnitId);
                if (OUnit == null)
                {
                    throw new Exception(WebLanguage.GetLanguage(OSiteParam, "đơn vị tính đã bị xóa hoặc không tìm thấy"));
                }
                string SelectActiveText =
                 "<select id=\"drpSelectActive\" class=\"form-control\">\r\n" +
                 "   <option value=\"0\">" + WebLanguage.GetLanguage(OSiteParam, "Không sử dụng") + "</option>\r\n" +
                 "   <option value=\"1\">" + WebLanguage.GetLanguage(OSiteParam, "Có sử dụng") + "</option>\r\n" +
                 "</select>\r\n";

                if (OUnit.Active == 1)
                {
                    SelectActiveText =
                 "<select id=\"drpSelectActive\" class=\"form-control\">\r\n" +
                 "   <option value=\"0\">" + WebLanguage.GetLanguage(OSiteParam, "Không sử dụng") + "</option>\r\n" +
                 "   <option selected value=\"1\">" + WebLanguage.GetLanguage(OSiteParam, "Có sử dụng") + "</option>\r\n" +
                 "</select>\r\n";
                }
                string Html =
                       " <div class=\"ibox-content\"> \r\n" +
                       "     <div class=\"row\"> \r\n" +
                       "         <div class=\"col-sm-12\"><h3 class=\"m-t-none m-b\">" + WebLanguage.GetLanguage(OSiteParam, "Sửa chữa") + "</h3> \r\n" +
                       "             <div> \r\n" +
                       "                 <div class=\"form-group\"><label>" + WebLanguage.GetLanguage(OSiteParam, "Mã loại hình") + "</label> <input id=\"txtUnitCode\" value=\"" + OUnit.UnitCode + "\" type=\"textbox\" placeholder=\"" + WebLanguage.GetLanguage(OSiteParam, "Mã") + "\" class=\"form-control\"></div> \r\n" +
                       "                 <div class=\"form-group\"><label>" + WebLanguage.GetLanguage(OSiteParam, "Tên đơn vị tính") + "</label> <input id=\"txtUnitName\" value=\"" + OUnit.UnitName + "\" type=\"textbox\" placeholder=\"" + WebLanguage.GetLanguage(OSiteParam, "Nhập tên đơn vị tính") + "\" class=\"form-control\"></div> \r\n" +
                       "                 <div class=\"form-group\"><label>" + WebLanguage.GetLanguage(OSiteParam, "Thứ tự sắp xếp") + "</label> <input id=\"txtSortIndex\" value=\"" + OUnit.SortIndex + "\" type=\"textbox\" placeholder=\"" + WebLanguage.GetLanguage(OSiteParam, "Thứ tự sắp xếp") + "\" class=\"form-control\"></div> \r\n" +
                       "                 <div class=\"form-group\"><label>" + WebLanguage.GetLanguage(OSiteParam, "Trạng thái") + "</label> " + SelectActiveText + "</div> \r\n" +
                       "                 <div> \r\n" +
                       "                     <button class=\"btn btn-sm btn-primary m-t-n-xs mr-5px\" type=\"button\" onclick=\"javascript:CallActionUpdate('" + UnitId + "');\"><strong>" + WebLanguage.GetLanguage(OSiteParam, "Chấp nhận") + "</strong></button> \r\n" +
                       "                     <button class=\"btn btn-sm btn-primary m-t-n-xs\" type=\"button\" onclick=\"javascript:CallBack();\"><strong>" + WebLanguage.GetLanguage(OSiteParam, "Bỏ qua") + "</strong></button> \r\n" +
                       "                 </div> \r\n" +
                       "             </div> \r\n" +
                       "         </div> \r\n" +
                       "     </div> \r\n" +
                       " </div> \r\n";

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
        public static AjaxOut ServerSideAdd(
            RenderInfoCls ORenderInfo,
            string UnitCode,
            string UnitName,
            string SortIndex,
            int Active)
        {
            AjaxOut RetAjaxOut = new AjaxOut();
            try
            {
                SiteParam
                    OSiteParam = WebEnvironments.CreateSiteParam(ORenderInfo);
                WebSession.CheckSessionTimeOut(ORenderInfo);

                if (string.IsNullOrEmpty(UnitName)) throw new Exception(WebLanguage.GetLanguage(OSiteParam, "Tên đơn vị tính không hợp lệ"));
                if (FunctionUtility.checkInteger(SortIndex) == false) throw new Exception(WebLanguage.GetLanguage(OSiteParam, "Thứ tự nhập không hợp lệ"));



                UnitCls
                    OUnit = new UnitCls();
                OUnit.UnitId = System.Guid.NewGuid().ToString();
                OUnit.UnitCode = UnitCode;
                OUnit.UnitName = UnitName;
                OUnit.SortIndex = int.Parse(SortIndex);
                OUnit.Active = Active;

                CallBussinessUtility.CreateBussinessProcess().CreateUnitProcess().Add(ORenderInfo, OUnit);
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
        public static AjaxOut ServerSideUpdate(
            RenderInfoCls ORenderInfo,
            string UnitId,
            string UnitCode,
            string UnitName,
            string SortIndex,
            int Active)
        {
            AjaxOut RetAjaxOut = new AjaxOut();
            try
            {
                    SiteParam
                    OSiteParam = WebEnvironments.CreateSiteParam(ORenderInfo);
                WebSession.CheckSessionTimeOut(ORenderInfo);



                if (string.IsNullOrEmpty(UnitName)) throw new Exception(WebLanguage.GetLanguage(OSiteParam, "Tên đơn vị tính không hợp lệ"));
                if (FunctionUtility.checkInteger(SortIndex) == false) throw new Exception(WebLanguage.GetLanguage(OSiteParam, "Thứ tự nhập không hợp lệ"));


                UnitCls
                    OUnit = CallBussinessUtility.CreateBussinessProcess().CreateUnitProcess().CreateModel(ORenderInfo, UnitId);
                OUnit.UnitCode = UnitCode;
                OUnit.UnitName = UnitName;
                OUnit.SortIndex = int.Parse(SortIndex);
                OUnit.Active = Active;
                CallBussinessUtility.CreateBussinessProcess().CreateUnitProcess().Save(ORenderInfo, UnitId, OUnit);
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
        public static AjaxOut ServerSideDelete(
            RenderInfoCls ORenderInfo,
            string UnitId)
        {
            AjaxOut RetAjaxOut = new AjaxOut();
            try
            {
                SiteParam
                    OSiteParam = WebEnvironments.CreateSiteParam(ORenderInfo);
                WebSession.CheckSessionTimeOut(ORenderInfo);

                CallBussinessUtility.CreateBussinessProcess().CreateUnitProcess().Delete(ORenderInfo, UnitId);
            }
            catch (Exception ex)
            {
                RetAjaxOut.Error = true;
                RetAjaxOut.InfoMessage = ex.Message.ToString();
                RetAjaxOut.HtmlContent = ex.Message.ToString();
            }
            return RetAjaxOut;
        }


    }
}
