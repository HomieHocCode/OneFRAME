using OneFRAME.MediaService;
using OneFRAME.Model;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for MediaServiceProcess
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class MediaServiceProcess : System.Web.Services.WebService {

    public MediaServiceProcess () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }


    [WebMethod]
    public string CheckWs() {
        return "ok";
    }


    [WebMethod]
    public OneFRAME.Core.Model.AjaxOut UploadMedia(string SecurityCode, string Xml,string XmlSchema,byte[] Bytes)
    {
        return MediaServiceUtility.UploadMedia(SecurityCode, Xml, XmlSchema, Bytes);
    }

    [WebMethod]
    public OneFRAME.Core.Model.AjaxOut DownloadMedia(string SecurityCode, string Xml, string XmlSchema)
    {
        return MediaServiceUtility.DownloadMedia(SecurityCode,Xml, XmlSchema);
    }

    [WebMethod]
    public OneFRAME.Core.Model.AjaxOut GetMediaInfo(string SecurityCode, string Xml, string XmlSchema)
    {
        return MediaServiceUtility.GetMediaInfo(SecurityCode,Xml, XmlSchema);
    }
}
