﻿<%@ Page Language="C#" AutoEventWireup="true" %>
<%@ Register src="UserControls/USite.ascx" tagname="USite" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<script runat="server">
    protected void Page_Load(object sender, EventArgs e)
    {

        OneFRAME.Core.Model.RenderInfoCls ORenderInfo = new OneFRAME.Core.Model.RenderInfoCls();
        string SiteId = USite1.SiteId;

        
        string usid = Request["usid"];
        if (string.IsNullOrEmpty(usid))
        {
            usid = OneFRAME.Utility.WebEnvironments.GetUseSessionId()+System.Guid.NewGuid().ToString().Substring(0, 8);
        }
        string SiteLang = Request["lang"];
        if (string.IsNullOrEmpty(SiteLang))
        {
            SiteLang = USite1.SiteLang;
        }

        string UserSessionId = usid;
        string SiteAssetLevelId = USite1.SiteAssetLevelId;
        string AssetLevelCode = USite1.AssetLevelCode;


        ORenderInfo.SiteId = SiteId;
        ORenderInfo.UserSessionId = UserSessionId;
        ORenderInfo.SiteLanguage = SiteLang;
        ORenderInfo.SiteAssetLevelId = SiteAssetLevelId;
        ORenderInfo.AssetLevelCode = AssetLevelCode;


        try
        {
            OneFRAME.Utility.WebSession.CheckSessionTimeOut(ORenderInfo);
        }
        catch
        {
            Response.Redirect("login.aspx");
        }
        bool IsUserLogin = OneFRAME.Utility.WebSessionUtility.IsUserLogin(ORenderInfo);
        if (IsUserLogin == false)
        {
            Response.Redirect("login.aspx");
        }

        ORenderInfo.OwnerId = OneFRAME.Utility.WebEnvironments.GetOwnerId(ORenderInfo);
        ORenderInfo.OwnerUserId = OneFRAME.Utility.WebEnvironments.GetOwnerUserId(ORenderInfo);
        ORenderInfo.RoleId = OneFRAME.Utility.WebSessionUtility.GetStdRoleAutoId(ORenderInfo);
        ORenderInfo.WebPartId = Request["wpid"];
        ORenderInfo.OwnerCode = Request["scope"];

        OneFRAME.Core.Model.IWebScreenRender
            WebScreenRender = OneFRAME.Utility.WebScreenRenderUtility.GetDefaultWebScreenRender(ORenderInfo);

        placeHolderContent.Controls.Clear();
        WebScreenRender.RegisterAjaxPro(ORenderInfo,this);
        OneFRAME.Core.Model.AjaxOut OAjaxOut = WebScreenRender.DrawContentPage(ORenderInfo,this);
        placeHolderContent.Controls.Clear();

        OneFRAME.Core.Model.AjaxOut OAjaxOutCss = WebScreenRender.PlugInCss(ORenderInfo);
        OneFRAME.Core.Model.AjaxOut OAjaxOutJavascript = WebScreenRender.PlugJavascript(ORenderInfo);

        placeHolderContent.Controls.Add(new LiteralControl(OAjaxOutCss.HtmlContent));
        placeHolderContent.Controls.Add(new LiteralControl(OAjaxOut.HtmlContent));
        placeHolderContent.Controls.Add(new LiteralControl(OAjaxOutJavascript.HtmlContent));

    }
</script>
<html xmlns="http://www.w3.org/1999/xhtml">
<!--[if IE 8]> <html lang="en" class="ie8"> <![endif]-->
<!--[if IE 9]> <html lang="en" class="ie9"> <![endif]-->
<!--[if !IE]><!--> <html lang="en"> <!--<![endif]-->
<!-- BEGIN HEAD -->
<head runat="server">
    <meta charset="utf-8" />
    <title>OneFRAME - ONENET</title>
    <link rel = "icon" href = "img/OneMES.png"  type = "image/x-icon">
	<%--<link rel="shortcut icon" href="favicon.ico" />--%>
     
    <meta content="width=device-width, initial-scale=1.0" name="viewport" />
	<meta content="" name="description" />
	<meta content="" name="author" />
	
    <link href="../../../../themes/css/bootstrap.min.css" rel="stylesheet">
    <link href="../../../../themes/font-awesome/css/font-awesome.css" rel="stylesheet">
    <link href="../../../../themes/css/plugins/iCheck/custom.css" rel="stylesheet">

    <link href="../../../../themes/css/animate.css" rel="stylesheet">
    <link href="../../../../themes/css/style.css" rel="stylesheet">

    <!-- Sweet Alert -->
    <link href="../../../../themes/css/plugins/sweetalert/sweetalert.css" rel="stylesheet">


    <link href="../../../../themes/css/plugins/chosen/chosen.css" rel="stylesheet">

    <link href="../../../../themes/css/plugins/colorpicker/bootstrap-colorpicker.min.css" rel="stylesheet">

    

    <link href="../../../../themes/css/plugins/switchery/switchery.css" rel="stylesheet">

    <link href="../../../../themes/css/plugins/jasny/jasny-bootstrap.min.css" rel="stylesheet">

    <link href="../../../../themes/css/plugins/nouslider/jquery.nouislider.css" rel="stylesheet">

    <link href="../../../../themes/css/plugins/datapicker/datepicker3.css" rel="stylesheet">
    <link href="../../../../themes/css/plugins/bootstrap-datetimepicker/bootstrap-datetimepicker.css" rel="stylesheet" />
    <link href="../../../../themes/css/plugins/ionRangeSlider/ion.rangeSlider.css" rel="stylesheet">
    <link href="../../../../themes/css/plugins/ionRangeSlider/ion.rangeSlider.skinFlat.css" rel="stylesheet">

    <link href="../../../../themes/css/plugins/awesome-bootstrap-checkbox/awesome-bootstrap-checkbox.css" rel="stylesheet">

    <link href="../../../../themes/css/plugins/clockpicker/clockpicker.css" rel="stylesheet">

    <link href="../../../../themes/css/plugins/daterangepicker/daterangepicker-bs3.css" rel="stylesheet">

    <link href="../../../../themes/css/plugins/select2/select2.min.css" rel="stylesheet">

    <link href="../../../../themes/css/plugins/touchspin/jquery.bootstrap-touchspin.min.css" rel="stylesheet">

    <link href="../../../../themes/css/plugins/fullcalendar/fullcalendar.css" rel="stylesheet">
    <link href="../../../../themes/css/plugins/fullcalendar/fullcalendar.print.css" rel='stylesheet' media='print'>

    <link href="../../../../themes/css/plugins/codemirror/ambiance.css" rel="stylesheet">
    <link href="../../../../themes/css/plugins/codemirror/codemirror.css" rel="stylesheet">

    <link href="../../../../themes/css/plugins/jsTree/style.min.css" rel="stylesheet">

    <link href="../../../../themes/css/plugins/summernote/summernote.css" rel="stylesheet">
    <link href="../../../../themes/css/plugins/summernote/summernote-bs3.css" rel="stylesheet">
    
    <link href="../../../../themes/css/plugins/toastr/toastr.min.css" rel="stylesheet">
	
    <link rel="stylesheet" href="/ProcessImage/dist/cropper.css">
    <!-- d3 and c3 charts -->
    <link href="../../../../themes/css/plugins/c3/c3.min.css" rel="stylesheet">
    

    <style>
        .form-control {
            
        }
      .cropit-preview, .cropit-preview-thumb {
        background-color: #f8f8f8;
        background-size: cover;
        border: 5px solid #ccc;
        border-radius: 3px;
        margin-top: 7px;
        width: 200px;
        min-height:115px;
      }

      .cropit-preview-image-container {
        cursor: move;
      }

      .cropit-preview-background {
        opacity: .2;
        cursor: auto;
      }

      .image-size-label {
        margin-top: 10px;
      }

      input, .export {
        /* Use relative position to prevent from being covered by image background */
        position: relative;
        z-index: 10;
        display: block;
      }

      button {
        margin-top: 0px;
            height: 28px;
      }

      .img-container{
          height:400px;
      }

      .bootstrap-touchspin .input-group-btn-vertical {
            position: relative;
            white-space: nowrap;
            width: 1%;
            vertical-align:top;
            padding-top: 0px !important;
        }

      .touchspin3 {
          margin-top:10px;
          height:38px;
      }

      .bootstrap-touchspin{
          padding:0px;
          margin-top:-10px;
      }

      .icon-service{
          margin-right:5px;
          cursor:pointer;
          height:20px;
      }

     .autocomplete-suggestions { -webkit-box-sizing: border-box; -moz-box-sizing: border-box; box-sizing: border-box; border: 1px solid #999; background: #FFF; cursor: default; overflow: auto; -webkit-box-shadow: 1px 4px 3px rgba(50, 50, 50, 0.64); -moz-box-shadow: 1px 4px 3px rgba(50, 50, 50, 0.64); box-shadow: 1px 4px 3px rgba(50, 50, 50, 0.64); }
     .autocomplete-suggestion { padding: 2px 5px; white-space: nowrap; overflow: hidden; }
     .autocomplete-no-suggestion { padding: 2px 5px;}
     .autocomplete-selected { background: #F0F0F0; }
     .autocomplete-suggestions strong { font-weight: bold; color: maroon; }
     .autocomplete-group { padding: 2px 5px; font-weight: bold; font-size: 16px; color: #000; display: block; border-bottom: 1px solid #000; }

        /*td{padding:4px !important; background-color:none !important}*/
        form-control{padding: 1px !important;}

    </style>

</head>

<body>
   <form runat="server">
      <uc1:USite ID="USite1" runat="server" />
    </form>
    
     <!-- Mainly scripts -->
    <script src="../../../../themes/js/jquery-2.1.1.js"></script>
    <script src="../../../../themes/js/bootstrap.min.js"></script>
    <script src="../../../../themes/js/freeze-table.js"></script>  
    <!-- Custom and plugin javascript -->
    <script src="../../../../themes/js/inspinia.js"></script>
    <%--<script src="../../../../themes/js/plugins/pace/pace.min.js"></script>--%>
    <script src="../../../../themes/js/plugins/slimscroll/jquery.slimscroll.min.js"></script>

     <script src="../../../../themes/js/pub-sub-client.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/microsoft-signalr/3.1.7/signalr.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/axios/dist/axios.min.js"></script>
    <!-- Chosen -->
    <script src="../../../../themes/js/plugins/chosen/chosen.jquery.js"></script>

   <!-- JSKnob -->
   <script src="../../../../themes/js/plugins/jsKnob/jquery.knob.js"></script>

   <!-- Input Mask-->
    <script src="../../../../themes/js/plugins/jasny/jasny-bootstrap.min.js"></script>

   <!-- Data picker -->
   <script src="../../../../themes/js/plugins/datapicker/bootstrap-datepicker.js"></script>

   <!-- NouSlider -->
   <script src="../../../../themes/js/plugins/nouslider/jquery.nouislider.min.js"></script>

   <!-- Switchery -->
   <script src="../../../../themes/js/plugins/switchery/switchery.js"></script>

    <!-- IonRangeSlider -->
    <script src="../../../../themes/js/plugins/ionRangeSlider/ion.rangeSlider.min.js"></script>

    <!-- iCheck -->
    <script src="../../../../themes/js/plugins/iCheck/icheck.min.js"></script>

    <!-- MENU -->
    <script src="../../../../themes/js/plugins/metisMenu/jquery.metisMenu.js"></script>

    <!-- Color picker -->
    <script src="../../../../themes/js/plugins/colorpicker/bootstrap-colorpicker.min.js"></script>

    <!-- Clock picker -->
    <script src="../../../../themes/js/plugins/clockpicker/clockpicker.js"></script>

    
    <!-- Date range use moment.js same as full calendar plugin -->
    <script src="../../../../themes/js/plugins/fullcalendar/moment.min.js"></script>

    <!-- Date range picker -->
    <script src="../../../../themes/js/plugins/daterangepicker/daterangepicker.js"></script>
    <script src="../../../../themes/js/plugins/bootstrap-datetimepicker/moment-with-locales.js"></script>
    <script src="../../../../themes/js/plugins/bootstrap-datetimepicker/bootstrap-datetimepicker.js"></script>
    <!-- Select2 -->
    <script src="../../../../themes/js/plugins/select2/select2.full.min.js"></script>

    <!-- TouchSpin -->
    <script src="../../../../themes/js/plugins/touchspin/jquery.bootstrap-touchspin.min.js"></script>

    <!-- Sweet alert -->
    <script src="../../../../themes/js/plugins/sweetalert/sweetalert.min.js"></script>

    <!-- JsTree -->
    <script src="../../../../themes/js/plugins/jsTree/jstree.min.js"></script>

    <!-- Full Calendar -->
    <script src="../../../../themes/js/plugins/fullcalendar/fullcalendar.min.js"></script>

     <!-- CodeMirror -->
    <script src="../../../../themes/js/plugins/codemirror/codemirror.js"></script>
    <script src="../../../../themes/js/plugins/codemirror/mode/javascript/javascript.js"></script>

    <script src="../../../../tinymce/tinymce.min.js"></script>
    <script src="../../../../themes/js/plugins/slimscroll/jquery.slimscroll.min.js"></script>

    <script src="../../../../themes/js/plugins/summernote/summernote.min.js"></script>




    
    <!-- GITTER -->
    <script src="../../../../themes/js/plugins/gritter/jquery.gritter.min.js"></script>

    <!-- Sparkline -->
    <script src="../../../../themes/js/plugins/sparkline/jquery.sparkline.min.js"></script>

    <!-- Sparkline demo data  -->
    <script src="../../../../themes/js/demo/sparkline-demo.js"></script>

    <!-- ChartJS-->
    <script src="../../../../themes/js/plugins/chartJs/Chart.min.js"></script>
    <!-- Toastr -->
    <script src="../../../../themes/js/plugins/toastr/toastr.min.js"></script>


     <!-- Diff march patch -->
    <script src="../../../../themes/js/plugins/diff_match_patch/javascript/diff_match_patch.js"></script>

    <!-- jQuery pretty text diff -->
    <script src="../../../../themes/js/plugins/preetyTextDiff/jquery.pretty-text-diff.min.js"></script>

    <!-- jQuery max length -->
    <script src="../../../../themes/js/plugins/bootstrap-maxlength/bootstrap-maxlength.min.js" type="text/javascript"></script>


    <script src="../../../../themes/js/plugins/jquery-cropit/jquery.cropit.js" type="text/javascript"></script>

                    
    <script type="text/javascript" src="../../../../themes/js/plugins/autocomplete/jquery.mockjax.js"></script>
    <script type="text/javascript" src="../../../../themes/js/plugins/autocomplete/jquery.autocomplete.js"></script>
    <script type="text/javascript" src="../../../../themes/js/plugins/autocomplete/countries.js"></script>
    <!-- Flot -->
    <script type="text/javascript" src="../../../../themes/js/plugins/flot/jquery.flot.js"></script>
    <script type="text/javascript" src="../../../../themes/js/plugins/flot/jquery.flot.pie.js"></script>
    <script type="text/javascript" src="../../../../themes/js/plugins/flot/jquery.flot.resize.js"></script>
    <script type="text/javascript" src="../../../../themes/js/plugins/flot/jquery.flot.spline.js"></script>
    <script type="text/javascript" src="../../../../themes/js/plugins/flot/jquery.flot.symbol.js"></script>
    <script type="text/javascript" src="../../../../themes/js/plugins/flot/jquery.flot.time.js"></script>
    <script type="text/javascript" src="../../../../themes/js/plugins/flot/jquery.flot.tooltip.min.js"></script>

    <!-- d3 and c3 charts -->
    <script type="text/javascript" src="../../../../themes/js/plugins/d3/d3.min.js"></script>
    <script type="text/javascript" src="../../../../themes/js/plugins/c3/c3.min.js"></script>
    <!-- hiqpdf -->
    <script type="text/javascript" src="../../../../themes/js/plugins/printThis/printThis.js"></script>

    <asp:PlaceHolder ID="placeHolderContent" runat="server"></asp:PlaceHolder>
    
    <%--<script>
        $(document).ready(function () {
            $('.i-checks').iCheck({
                checkboxClass: 'icheckbox_square-green',
                radioClass: 'iradio_square-green',
            });
        });
    </script>--%>
    
    <script src="/ProcessImage/assets/js/tether.min.js"></script>
    <script src="/ProcessImage/dist/cropper.js"></script>
    <script src="/ProcessImage/js/main.js"></script>

    <script type="text/javascript" src="../../../../themes/js/plugins/sticky/ResizeSensor.js"></script>
    <script type="text/javascript" src="../../../../themes/js/plugins/sticky/theia-sticky-sidebar.js"></script>
    <script type="text/javascript" src="../../../../themes/js/plugins/html2canvas/html2canvas.min.js"></script>
    <script type="text/javascript" src="../../../../themes/js/plugins/loadingOverlay/loadingoverlay.js"></script>
    <script type="text/javascript" src="../../../../themes/js/plugins/loadingOverlay/loadingoverlay.min.js"></script>
    <script>
        toastr.options = {
            "positionClass": "toast-bottom-left"
        }
	</script>
</body>
</html>
  
	