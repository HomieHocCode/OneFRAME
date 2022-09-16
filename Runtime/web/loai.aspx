<%@ Page Language="C#" AutoEventWireup="true" %>
<%@ Register src="UserControls/USite.ascx" tagname="USite" tagprefix="uc1" %>

<script runat="server">
    protected void Page_Load(object sender, EventArgs e)
    {
        //string Data=INSASS.JSONP.OrderUtility.GetData();

        OneFRAME.Core.Model.RenderInfoCls ORenderInfo = new OneFRAME.Core.Model.RenderInfoCls();
        string SiteId = USite1.SiteId;
        string SiteLang = USite1.SiteLang;
        string UserSessionId = OneFRAME.Utility.WebEnvironments.GetUseSessionId() + System.Guid.NewGuid().ToString().Substring(0, 8);
        string SiteAssetLevelId = USite1.SiteAssetLevelId;
        string AssetLevelCode = USite1.AssetLevelCode;

        ORenderInfo.SiteId = SiteId;
        ORenderInfo.UserSessionId = UserSessionId;
        ORenderInfo.SiteLanguage = SiteLang;
        ORenderInfo.SiteAssetLevelId = SiteAssetLevelId;
        ORenderInfo.AssetLevelCode = AssetLevelCode;


        string ServiceId = OneFRAME.Utility.WebEnvironments.Request("ServiceId");
        string Page = OneFRAME.Utility.WebEnvironments.Request("page");
        string Loai = OneFRAME.Utility.WebEnvironments.Request("Loai");
               
        if (string.IsNullOrEmpty(Page))
        {
            Page = "0";
        }
        int iPage = int.Parse(Page);
        string q = HttpUtility.HtmlDecode(OneFRAME.Utility.WebEnvironments.Request("q"));

        OneFRAME.Core.Model.AjaxOut
            RetAjaxOut = OneFRAME.Utility.RemoteDataUtility.Find(ServiceId).Reading(ORenderInfo, iPage, q, new object[] { Loai });
        
        Response.ClearHeaders();
        Response.ClearContent();
        Response.AddHeader("Content-type", "application/javascript");
        Response.BufferOutput = true;
        Response.Write(RetAjaxOut.HtmlContent);
    }
</script>
<uc1:USite ID="USite1" runat="server" />