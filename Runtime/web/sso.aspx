﻿<%@ Page Language="C#" AutoEventWireup="true" %>
<%@ Register src="UserControls/USite.ascx" tagname="USite" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<script runat="server">
    protected void Page_Load(object sender, EventArgs e)
    {

        OneFRAME.Core.Model.RenderInfoCls
            ORenderInfo = new OneFRAME.Core.Model.RenderInfoCls();
        string SiteId = USite1.SiteId;
        string SiteLang = Request["lang"];
        if (string.IsNullOrEmpty(SiteLang))
        {
            SiteLang = USite1.SiteLang;
        }
         string usid = Request["usid"];
        if (string.IsNullOrEmpty(usid))
        {
            usid = OneFRAME.Utility.WebEnvironments.GetUseSessionId()+System.Guid.NewGuid().ToString().Substring(0, 8);
        }
        string UserSessionId = usid;

        string SiteAssetLevelId = USite1.SiteAssetLevelId;
        string AssetLevelCode = USite1.AssetLevelCode;


        ORenderInfo.SiteId = SiteId;
        ORenderInfo.UserSessionId = UserSessionId;
        ORenderInfo.SiteLanguage = SiteLang;
        ORenderInfo.SiteAssetLevelId = SiteAssetLevelId;
        ORenderInfo.AssetLevelCode = AssetLevelCode;

        string id = (string)Request["id"];
        OneFRAME.Core.Model.AjaxOut
            AjaxOutAutoLogin = OneFRAME.Core.Call.Bussiness.Utility.CoreCallBussinessUtility.AutoLogin(ORenderInfo, id);
        if(AjaxOutAutoLogin.Error)
        {
            Response.Write("<center><div style=\"width:600px;color:maroon;font-weight:bold;font-size:26px; margin-top:100px; padding:20px;background-color:lightyellow;border-radius:20px\">"+AjaxOutAutoLogin.HtmlContent+"</div><center>");
        }
        else
        {
            Response.Redirect(AjaxOutAutoLogin.RetUrl);
        }
    }
</script>
<html xmlns="http://www.w3.org/1999/xhtml">
<!--[if IE 8]> <html lang="en" class="ie8"> <![endif]-->
<!--[if IE 9]> <html lang="en" class="ie9"> <![endif]-->
<!--[if !IE]><!--> <html lang="en"> <!--<![endif]-->
<!-- BEGIN HEAD -->
<head runat="server">
    <meta charset="utf-8" />
    <title>TOUR247.VN</title>
     
    <meta content="width=device-width, initial-scale=1.0" name="viewport" />
	<meta content="" name="description" />
	<meta content="" name="author" />
	
   
</head>

<body>
   <form runat="server">
      <uc1:USite ID="USite1" runat="server" />
    </form>
   

</body>
</html>
  
	